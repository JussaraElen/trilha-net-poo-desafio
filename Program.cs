using System.ComponentModel;
using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone


// Criando uma instância da classe Nokia
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "84823544", modelo: "tijolão", imei: "2006", memoria: 01);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n");

// Criando uma instância da classe iPhone
Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "13381453", modelo: "IPhone 11", imei: "2020", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Snake");
    
