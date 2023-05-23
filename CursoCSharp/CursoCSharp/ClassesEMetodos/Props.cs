using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome; // Retorna "Opcional: " concatenado com o valor da variável 'nome'
            }
            set
            {
                nome = value; // Atribui o valor passado ao parâmetro 'value' à variável 'nome'
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; } // Propriedade autoimplementada que representa o preço do opcional

        // Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); // Calcula e retorna o preço com desconto utilizando uma expressão lambda
        }

        public CarroOpcional()
        {
            // Construtor padrão vazio
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome; // Atribui o valor do parâmetro 'nome' à propriedade 'Nome'
            Preco = preco; // Atribui o valor do parâmetro 'preco' à propriedade 'Preco'
        }
    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto); // Exibe o preço com desconto do opcional 'op1' (3149.91)

            // op1.PrecoComDesconto = 3000; // Atribuição inválida, pois 'PrecoComDesconto' é somente leitura

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica"; // Atribui o valor à propriedade 'Nome' do opcional 'op2'
            op2.Preco = 2349.9; // Atribui o valor à propriedade 'Preco' do opcional 'op2'

            Console.WriteLine(op2.Nome); // Exibe o nome do opcional 'op2' (Opcional: Direção Elétrica)
            Console.WriteLine(op2.Preco); // Exibe o preço do opcional 'op2' (2349.9)
            Console.WriteLine(op2.PrecoComDesconto); // Exibe o preço com desconto do opcional 'op2' (2114.91)
        }
    }
}
