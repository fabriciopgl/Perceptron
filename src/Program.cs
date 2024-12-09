namespace Perceptron;

public class Program
{
    static void Main(string[] args)
    {
        const double RU = 4110920.0;

        // Gera 1000 amostras de entradas aleatórias e define classificações ideais
        Random random = new();
        double[][] trainingData = new double[1000][];
        int[] labels = new int[1000];

        for (int i = 0; i < trainingData.Length; i++)
        {
            trainingData[i] = Enumerable.Range(0, 7).Select(_ => random.Next(1, 10)).Select(Convert.ToDouble).ToArray();

            // Classificação ideal baseada na soma das entradas comparada ao RU
            double value = double.Parse(string.Join("", trainingData[i]));
            labels[i] = value >= RU ? 1 : -1;
        }

        // Adiciona amostras "próximas" ao RU para garantir que sejam testadas
        trainingData[0] = [4, 1, 1, 0, 9, 2, 0]; // Igual ao RU
        labels[0] = 1;

        trainingData[1] = [4, 1, 1, 0, 9, 1, 9]; // Próximo ao RU
        labels[1] = -1;

        // Cria e treina o Perceptron
        Perceptron perceptron = new(7);
        perceptron.Train(trainingData, labels, 200000);

        // Exporta resultados para Excel
        string filePath = $"4110920_treinamento_{DateTime.UtcNow:yyyyMMdd_HHmmss}.xlsx";
        perceptron.ExportToExcel(filePath, trainingData, labels);

        Console.WriteLine($"Treinamento concluído! Resultados salvos em {filePath}");
    }
}

