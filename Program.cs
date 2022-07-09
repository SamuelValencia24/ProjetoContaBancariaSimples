float num,A,B;
int OPCAO;

Console.WriteLine("Bem vindo a sua Calculadora: ");
Console.WriteLine("Digite o primeiro valor: ");
A = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o Segundo Valor: ");
B = float.Parse(Console.ReadLine());

Console.WriteLine("Opção 1........Adição");
Console.WriteLine("Opção 2......Subtração");
Console.WriteLine("Opção 3.....Multiplicação");
Console.WriteLine("Opção 4....Divisão");
Console.WriteLine("Escolha de Uma das Opções: ");
OPCAO = int.Parse(Console.ReadLine());

    if (OPCAO == 1)
    {
        num = A + B;
        Console.WriteLine("Resultado: " + num);
    }
    if (OPCAO == 2)
    {
        num = A - B;
        Console.WriteLine("Resultado: " + num);
    }
    if (OPCAO == 3)
    {
        num = A * B;
        Console.WriteLine("Resultado: " + num);
    }
    if (OPCAO == 4)
    {
        num = A / B;
        Console.WriteLine("Resultado: " + num);
    }
    else if (OPCAO == 0 && OPCAO == 5)
    {
        Console.WriteLine("Condição Inválida");
    }

