namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        private string _modelo;
        private string _imei;
        private int _memoria;

        public string Numero
        {
            get => _numero;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O número deve ser preenchido");
                }

                _numero = value;
            }
        }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string Modelo
        {
            get => _modelo.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Modelo deve ser preenchido");
                }

                _modelo = value;

            }
        }

        private string Imei 
        {
            get => _imei.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O imei deve ser preenchido");
                }

                _imei = value;
            }
        }

        private int Memoria 
        {
            get => _memoria; 

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A memoria não pode ser menor que zero");
                }

                _memoria = value;
            }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            
            Modelo = modelo;

            Imei = imei;

            Memoria = memoria;
        }

        public void Dados()
        {
            Console.WriteLine($"Dados do celular: \nNúmero: {Numero}, Modelo: {Modelo}, Imei: {Imei}, Memoria: {Memoria}GB");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação....");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}