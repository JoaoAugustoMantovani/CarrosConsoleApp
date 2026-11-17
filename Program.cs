Carro carro = CadastrarCarro();

ExibirCarro(carro);

Carro CadastrarCarro()
{
    Console.WriteLine("Informe o fabricante:");
    string fabricante = Console.ReadLine();

    Console.WriteLine("Informe o modelo:");
    string modelo = Console.ReadLine();

    Console.WriteLine("Informe o ano de fabricação:");
    int anoFabricacao = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o ano do modelo:");
    int anoModelo = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o valor de venda:");
    double valorVenda = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o combustível:");
    string combustivel = Console.ReadLine();

    Console.WriteLine("Informe a cilindrada:");
    double cilindrada = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a potência (HP):");
    int potencia = int.Parse(Console.ReadLine());

    Motor motor = new Motor(combustivel, cilindrada, potencia);
    Carro carro = new Carro(fabricante, modelo, anoFabricacao, anoModelo, valorVenda, motor);

    return carro;
}

void ExibirCarro(Carro carro)
{
    Console.WriteLine(carro.ToString());
    Console.WriteLine($"IPVA estimado: R$ {carro.CalcularIPVA():F2}");
}