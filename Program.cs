using DesafioPOO.Models;

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone("(11)93333-1111", "Iphone 5", "111111", 64);
iphone.InstalarAplicativo("Whatsapp");
iphone.ReceberLigacao();


Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia("(11)91111-2222", "Tijolão", "222222", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");