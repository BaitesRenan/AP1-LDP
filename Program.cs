using System;

class Program
{
    static void Main()
    {
        string nome;
        double altura, peso, imc;
        int idade;

        do
        {
            Console.WriteLine("Digite o nome da pessoa:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a altura (em metros):");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso (em quilogramas):");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade:");
            idade = int.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            string categoriaIMC = GetCategoriaIMC(imc);
            string faixaEtaria = GetFaixaEtaria(idade);

            Console.WriteLine($"{nome} tem {idade} anos, altura de {altura:F2} metros, peso de {peso:F2} kg.");
            Console.WriteLine($"Seu IMC é {imc:F2}, o que indica que está na categoria de {categoriaIMC}.");
            Console.WriteLine($"A faixa etária de {nome} é {faixaEtaria}.\n");

            Console.WriteLine("Deseja calcular o IMC de outra pessoa? (S/N)");
        } while (Console.ReadLine().ToUpper() == "S");
    }

    static string GetCategoriaIMC(double imc)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else if (imc < 24.9)
        {
            return "Peso normal";
        }
        else if (imc < 29.9)
        {
            return "Sobrepeso";
        }
        else if (imc < 34.9)
        {
            return "Obesidade grau 1";
        }
        else if (imc < 39.9)
        {
            return "Obesidade grau 2";
        }
        else
        {
            return "Obesidade grau 3";
        }
    }

    static string GetFaixaEtaria(int idade)
    {
        if (idade < 18)
        {
            return "Menor de idade";
        }
        else if (idade >= 18 && idade <= 64)
        {
            return "Adulto";
        }
        else
        {
            return "Idoso";
        }
    }
}
