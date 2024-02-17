namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(String.Format("O aplicativo {0} está sendo instalado no seu dispositivo Android...", nomeApp));
        }
    }
}