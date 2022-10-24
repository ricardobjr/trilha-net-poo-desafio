using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone i1 = new Iphone(numero: "(12)98888-7777", modelo: "iPhone 13 Pro Max", imei: "111111-22-333333-4", memoria: 64);
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Teste iPhone:");
i1.Informacoes();
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Telegram");


Smartphone n1 = new Nokia(numero: "(22)97777-6666", modelo: "C01 Plus", imei: "222222-33-444444-5", memoria: 32);
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Teste Nokia:");
n1.Informacoes();
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");