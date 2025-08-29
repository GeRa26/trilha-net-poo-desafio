using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone xs = new Iphone("123456789", "iPhone Xs", "123456789012345", 64);
xs.Ligar();
xs.InstalarAplicativo("Instagram");

Smartphone nokialumia = new Nokia("987654321", "Nokia 7.2", "987654321098765", 128);
nokialumia.ReceberLigacao();
nokialumia.InstalarAplicativo("WhatsApp");