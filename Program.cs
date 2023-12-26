using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Celular Nokia: ");
Smartphone nokia = new Nokia(numero: "99222-2222", modelo: "Nokia4", imei: "010101", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Celular Iphone: ");
Smartphone iphone = new Iphone(numero: "98111-1111", modelo: "Iphone11", imei: "101010", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");