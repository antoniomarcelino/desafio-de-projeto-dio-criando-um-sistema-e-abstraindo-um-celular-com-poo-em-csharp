using DesafioPOO.Models;

Console.WriteLine("Testando NOKIA");
Nokia nokia  = new Nokia("981982023", "NOKIA2023", "1111", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram foi instalado.");

Console.WriteLine("");

Console.WriteLine("Testando IPHONE");
Iphone iphone = new Iphone("998812023", "IPHONE2023", "1234", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine("");