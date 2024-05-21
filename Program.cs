using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("988887777", "M1", "1111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("999998877", "Iphone 20", "123", 218);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");