namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Sobrescrevendo o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int
        memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string Instagram)
        {
            Console.WriteLine($"Instando o aplicativo {Instagram} no modelo {Modelo}, número {Numero} e Imei {IMEI}");
        }
    }
}