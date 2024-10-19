//Projeto destinado ao aprendizado em C#
//Objetivo - Calculadora em C#
public class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Digite o Primeiro valor: ");
        //Comando para imputar o valor após o usuario digitar
        string valor1 = Console.ReadLine();
        //Comando para Transformar um valor String em Int.
        //Todo valor lido pelo ReadLine é feito em String.
        int val1 = int.Parse(valor1);
        Console.WriteLine("Digite um Segundo Valor: ");
        string valor2 = Console.ReadLine();
        int val2 = int.Parse(valor2);

        Console.WriteLine("Escolha o algoritmo que deseja ser feito");
        Console.WriteLine("[1] Soma");
        Console.WriteLine("[2] Subtração");
        Console.WriteLine("[3] Multiplicação");
        Console.WriteLine("[4] Divisão");
        string decisao = Console.ReadLine();
        int algoritmo = int.Parse(decisao);

        switch (algoritmo)
        {
            case 1 :
                int Soma = val1 + val2;
                Console.WriteLine("O Valor é: " + Soma);
                break;
            case 2 :
                int Subtração = val1 - val2;
                Console.WriteLine("O Valor é: " + Subtração);
                break;
            case 3 :
                int Multiplicação = val1 * val2;
                Console.WriteLine("O Valor é: " + Multiplicação);
                break;
            case 4 :
                int Divisao = val1 / val2;
                Console.WriteLine("O Valor é: " + Divisao);
                break;
            default:
                Console.WriteLine("Valor não reconhecido");
                break;
        }
    }
}

