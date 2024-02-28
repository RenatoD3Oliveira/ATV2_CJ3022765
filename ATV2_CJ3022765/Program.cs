float salario;
Console.WriteLine("Digite seu salario atual");

//Leitura do salário
salario = float.Parse(Console.ReadLine());
//conta pra 25% ;-;
salario = salario + (25.0f / 100.0f) * salario;

Console.WriteLine("O novo salário e de R$ {0}", salario);

//Ctrl + K + C
//Ctrl + K + U


Console.WriteLine("digite um valor");
float n1 = float.Parse(Console.ReadLine());
float triplo = (n1 * 3) + 1;
float dobro = (n1 * 2) - 1;
Console.WriteLine("o seu resultado foi de " + (triplo + dobro));


double investimento = 1000;
double m1 = investimento - (investimento * 0.034);
double m2 = m1 + (investimento * 0.028);
double m3 = m2 + (investimento * 0.14);
double m4 = m3 - (investimento * 0.085);

Console.WriteLine("O resultado do investimento foi de:");
Console.WriteLine("o primeiro mes foi de:" +  m1);
Console.WriteLine("o segundo mes foi de:" + m2);
Console.WriteLine("o terceiro mes foi de:" + m3);
Console.WriteLine("o quarto e ultimo mes foi de:" + m4);