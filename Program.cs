using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "nokia zd3", imei: "ln1111133", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n\n\nSmartphone Iphone");
Smartphone iphone = new Iphone(numero: "999008", modelo: "Iphone 11", imei: "ip22211", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");