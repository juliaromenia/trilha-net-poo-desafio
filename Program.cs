using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        Console.WriteLine("Qual celular deseja cadastrar? (Nokia ou Iphone?)");
        string escolha = Console.ReadLine();

        if (escolha.ToLower() == "nokia")
        {
            Console.WriteLine("Celular Nokia");
            Console.WriteLine("Informe o número do celular: ");
            string numeroNokia = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular: ");
            string modeloNokia = Console.ReadLine();

            Console.WriteLine("Informe o IMEI do celular: ");
            string imeiNokia = Console.ReadLine();

            Console.WriteLine("Informe qual a memoria do celular: ");
            int memoriaNokia = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Smartphone nokia = new Nokia(numeroNokia, modeloNokia, imeiNokia, memoriaNokia);
            nokia.Dados();
            Console.WriteLine("Testando funcionalidades:");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Facebook");
        }
        else if (escolha.ToLower() == "iphone")
        {
            Console.WriteLine("Celular Iphone");
            Console.WriteLine("Informe o número do celular: ");
            string numeroIphone = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular: ");
            string modeloIPhone = Console.ReadLine();

            Console.WriteLine("Informe o IMEI do celular: ");
            string imeiIphone = Console.ReadLine();

            Console.WriteLine("Informe qual a memoria do celular: ");
            int memoriaIphone = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Smartphone iphone = new Iphone(numeroIphone, modeloIPhone, imeiIphone, memoriaIphone);
            iphone.Dados();
            Console.WriteLine("Testando funcionalidades:");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
        else
        {
            Console.WriteLine("Opção inválida. Por favor, escolha entre Nokia ou iPhone.");
        }
    }
}