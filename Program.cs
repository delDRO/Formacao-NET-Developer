using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345");
Iphone iphone = new Iphone("987654321", "iPhone 13", "2987654321098765");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");
