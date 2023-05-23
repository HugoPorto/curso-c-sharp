using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get { return "Opcional: " + nome; }
            set { nome = value; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set
            {
                if (value >= 0)
                    preco = value;
                else
                    throw new ArgumentException("O preço deve ser um valor positivo.");
            }
        }

        public double PrecoComDesconto => Preco - (desconto * Preco);

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            // op1.PrecoComDesconto = 3000;

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco); // Exibe o preço do opcional 'op1'

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco); // Exibe o preço do opcional 'op2'
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
