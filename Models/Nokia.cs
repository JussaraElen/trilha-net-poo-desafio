namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Sobrescrevendo o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int
        memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string Snake)
        {
            Console.WriteLine($"Instalando o aplicativo {Snake} no {Modelo}, número: {Numero} e IMEI {IMEI}.");
        }
    }
}