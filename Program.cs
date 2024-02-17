using DesafioPOO.Models;

Nokia nokia = new Nokia("1198765432", "3220", "122333444455555", 1024);
Iphone iphone = new Iphone("9912345678", "Fortin", "988777666655555", 512);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Uber");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Ifood");
