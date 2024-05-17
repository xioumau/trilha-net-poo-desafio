using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("789456", "Modelo DIO", "558874899", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone("369852", "Modelo Infinite", "123456789", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Chrome");
