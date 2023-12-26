namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação de 'Desconhecido'...");
            Console.WriteLine("Deseja atender? ( 1 - sim | 2 - não) ");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.WriteLine("'Sete dias...'\nTututu");
            }
            else
            {
                Console.WriteLine("Tututu");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}