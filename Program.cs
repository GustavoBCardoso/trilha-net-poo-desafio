using DesafioPOO.Models;

Nokia smartphone1 = new(numero: "112233445", modelo: "Nokia 5600", imei: "N976431K", memoria: 64);
Iphone smartphone2 = new(numero: "998877665", modelo: "Iphone 12", imei: "I134679E", memoria: 128);

Console.WriteLine("Nokia:");
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
smartphone1.Ligar();
smartphone2.ReceberLigacao();