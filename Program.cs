using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone("12345", "IPhone 13", "7410852963", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("CapCut");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("6789", "G11", "7410852963", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tiktok");
