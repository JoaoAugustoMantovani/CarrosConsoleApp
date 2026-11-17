public class Carro
{
    public string Fabricante;
    public string Modelo;
    public int AnoFabricacao;
    public int AnoModelo;
    public double ValorVenda;
    public Motor MotorDoCarro;

    public Carro(string fabricante, string modelo, int anoFabricacao, int anoModelo, double valorVenda, Motor motor)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        AnoFabricacao = anoFabricacao;
        AnoModelo = anoModelo;
        ValorVenda = valorVenda;
        MotorDoCarro = motor;
    }

    public double CalcularIPVA()
    {
        int anoAtual = DateTime.Now.Year;
        int idadeVeiculo = anoAtual - AnoFabricacao;

        if (AnoFabricacao <= 0 || AnoFabricacao > anoAtual)
        {
            Console.WriteLine("Ano de fabricação inválido.");
            return 0;
        }

        if (AnoModelo != AnoFabricacao && AnoModelo != AnoFabricacao + 1)
        {
            Console.WriteLine("Ano do modelo inválido.");
            return 0;
        }

        if (ValorVenda < 0)
        {
            Console.WriteLine("Valor de venda inválido.");
            return 0;
        }

        if (idadeVeiculo >= 20)
        {
            Console.WriteLine("Veículo isento de IPVA.");
            return 0;
        }

        double valorIPVA = ValorVenda * 0.04;

        return valorIPVA;
    }

    public override string ToString()
    {
        return $"Fabricante: {Fabricante}\n" +
               $"Modelo: {Modelo}\n" +
               $"Ano de Fabricação: {AnoFabricacao}\n" +
               $"Ano do Modelo: {AnoModelo}\n" +
               $"Valor de Venda: {ValorVenda}\n" +
               $"Combustível: {MotorDoCarro.Combustivel}\n" +
               $"Cilindrada: {MotorDoCarro.Cilindrada}\n" +
               $"Potência: {MotorDoCarro.Potencia} HP";
    }
}