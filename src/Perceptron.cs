using ClosedXML.Excel;

namespace Perceptron;

public class Perceptron(int inputSize, double learningRate = 0.00001)
{
    private double _bias = -1.0;
    private readonly double _learningRate = learningRate;
    private readonly List<List<double>> _weightsHistory = [];
    private readonly double[] _weights = Enumerable.Repeat(1.0, inputSize).ToArray();

    private static int ActivationFunction(double input) =>
        input >= 0 ? 1 : -1;

    public int Predict(double[] inputs)
    {
        double sum = _bias;

        for (int i = 0; i < _weights.Length; i++)
            sum += _weights[i] * inputs[i];

        return ActivationFunction(sum);
    }

    public void Train(double[][] trainingData, int[] labels, int epochs)
    {
        for (int epoch = 0; epoch < epochs; epoch++)
        {
            int errors = 0;
            for (int i = 0; i < trainingData.Length; i++)
            {
                double[] inputs = trainingData[i];
                int label = labels[i];
                int prediction = Predict(inputs);

                int error = label - prediction;
                if (error != 0) errors++;

                // Atualiza os pesos e bias
                for (int j = 0; j < _weights.Length; j++)
                    _weights[j] += _learningRate * error * inputs[j];
  
                _bias += _learningRate * error;
            }

            _weightsHistory.Add(new List<double>(_weights));
            Console.WriteLine($"Época {epoch + 1}, Erros: {errors}");

            // Imprime os pesos após cada época para verificar o ajuste
            Console.WriteLine($"Pesos após época {epoch + 1}: {string.Join(", ", _weights)}");

            // Se todos os erros foram corrigidos, podemos parar
            if (errors == 0) break;
        }
    }

    public void ExportToExcel(string filePath, double[][] trainingData, int[] labels)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Treinamento Perceptron");

        worksheet.Cell(1, 1).Value = "Entrada";
        worksheet.Cell(1, 2).Value = "Classificação Ideal";
        worksheet.Cell(1, 3).Value = "Classificação Gerada";
        worksheet.Cell(1, 4).Value = "Pesos";

        for (int i = 0; i < trainingData.Length; i++)
        {
            string inputs = string.Join("", trainingData[i]);
            int predicted = Predict(trainingData[i]);

            worksheet.Cell(i + 2, 1).Value = inputs;
            worksheet.Cell(i + 2, 2).Value = labels[i];
            worksheet.Cell(i + 2, 3).Value = predicted;
            worksheet.Cell(i + 2, 4).Value = string.Join(", ", _weightsHistory[i]);
        }

        workbook.SaveAs(filePath);
    }
}
