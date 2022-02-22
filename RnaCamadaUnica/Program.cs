// See https://aka.ms/new-console-template for more information
using RnaCamadaUnica;
//base de treinamento
Entrada e1 = new Entrada(0.3, 0.7, 1);
Entrada e2 = new Entrada(-0.6, 0.3, 0);
Entrada e3 = new Entrada(-0.1, -0.8, 0);
Entrada e4 = new Entrada(0.1, -0.45, 1);
List<Entrada> baseTreinamento = new List<Entrada>();
baseTreinamento.Add(e1);
baseTreinamento.Add(e2);	
baseTreinamento.Add(e3);
baseTreinamento.Add(e4);
//declarar o neuronio
Perceptron p1 = new Perceptron(0.5);
p1.Treinamento(baseTreinamento);

int resultado = p1.Teste(0.3, 0.7);
resultado = p1.Teste(-0.6, 0.3);

Console.ReadLine();


