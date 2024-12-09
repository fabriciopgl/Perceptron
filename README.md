
# **Treinamento Supervisionado do Perceptron de Rosenblatt** 🧮
Este repositório contém a implementação de um **Perceptron de Rosenblatt** em C#, desenvolvido como parte de um projeto prático para a disciplina de **Inteligência Artificial Aplicada**. O objetivo principal foi treinar o Perceptron para classificar entradas com base em um número de Registro Único (RU), utilizando aprendizado supervisionado. O código foi implementado manualmente, sem o uso de bibliotecas externas para aprendizado de máquina, promovendo uma compreensão aprofundada do algoritmo.

---

## **Conteúdo do Repositório** 📁

- `Program.cs`: Arquivo principal que coordena o treinamento do Perceptron.
- `Perceptron.cs`: Implementação da classe que encapsula a lógica do modelo, incluindo previsão, treinamento e exportação de resultados.
- `README.md`: Este arquivo, contendo informações sobre o projeto, sua execução e detalhes do funcionamento.

---

## **Objetivo** 📌

O projeto visa:
- Implementar o **Perceptron de Rosenblatt** do zero em C#, aplicando aprendizado supervisionado para treinar o modelo.
- Classificar corretamente entradas numéricas com base no número do RU fornecido.
- Exportar os resultados de treinamento para um arquivo Excel (.xlsx), incluindo o histórico dos pesos e as classificações.

---

## **Características do Perceptron** 🧠

O Perceptron de Rosenblatt ajusta seus pesos a cada época com base nos erros de classificação. As características principais do modelo implementado incluem:

- O modelo utiliza sete entradas, correspondentes aos 7 dígitos do RU.
- A taxa de aprendizado foi definida como **0.00001**, garantindo atualizações graduais nos pesos para estabilidade do modelo.
- Os pesos foram inicializados com o valor **1.0** e o bias como **-1.0**.

O treinamento segue a fórmula clássica de atualização de pesos:

```math
peso[i] = peso[i] + taxa de aprendizado * erro * entrada[i]
bias = bias + taxa de aprendizado * erro
```

```math
bias = bias + taxa de aprendizado * erro
```

---

## **Como executar** 💽

### **Pré-requisitos**

- .NET SDK instalado (versão 6.0 ou superior).
- Biblioteca **ClosedXML** instalada para exportação do Excel:
```bash
dotnet add package ClosedXML
```
Passos para execução:

Clone este repositório:
```bash
git clone https://github.com/seu-usuario/perceptron-rosenblatt.git
```

Navegue para o diretório do projeto:

```bash
cd perceptron-rosenblatt
```

Compile e execute o programa:
```bash
dotnet run
```

Após a execução, um arquivo .xlsx será gerado na pasta do projeto com os resultados do treinamento.

# **Funcionamento** 🛠️
O programa realiza o treinamento do Perceptron com um conjunto de dados gerado aleatoriamente. 

Durante o treinamento:

- O modelo ajusta seus pesos a cada época, baseado no erro entre a saída gerada e a saída ideal.
- O progresso dos pesos é armazenado para posterior análise.
- O treinamento para quando todos os erros forem corrigidos ou o número máximo de épocas for atingido.

Ao final da execução, o programa exporta os dados de treinamento (entradas, classificações e histórico de pesos) para uma planilha Excel.

## **Aprendizado** 💡
Este projeto proporcionou uma experiência prática na implementação de redes neurais simples, reforçando conceitos como:

- A importância dos parâmetros de aprendizado, como a taxa de aprendizado.
- O impacto da aleatoriedade nos dados de entrada no número de épocas para convergência.
- A relação entre teoria e prática na construção de modelos de inteligência artificial.
Além disso, a exportação dos resultados para Excel permitiu uma análise visual detalhada do progresso do modelo ao longo do treinamento.

# **Licença** 💼
Este projeto está licenciado sob a MIT License.

# **Contato** 📲
Se tiver dúvidas ou sugestões, sinta-se à vontade para entrar em contato:

**Autor**: Fabrício Pagliarini
**E-mail**: fabriciopgl87@gmail.com
