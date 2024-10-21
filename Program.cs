using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123456",modelo: "Modelo 1",imei: "22121212",memoria: 52);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"654321",modelo: "Modelo 2",imei: "44441212",memoria: 60);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");