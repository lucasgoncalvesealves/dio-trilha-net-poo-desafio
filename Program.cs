using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Angry Birds Friends");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Angry Birds 2");
