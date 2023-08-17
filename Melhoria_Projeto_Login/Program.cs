using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melhoria_Projeto_Login
{
    internal class Program
    {
        //Um programa que pode ser usado para cadastrar múltiplos usuários
        //Opção para digitar S para sair ou C para cadastrar
        //Solicitar:
        //Nome Completo
        //Gênero, sendo M Masculino e F Feminino    
        //Data de nascimento no formato dd/MM/aaaa
        //Nome da Rua 
        //Número da Casa

        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Pressione C para cadastrar um usuário ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    Console.WriteLine("Informe o nome de usuário: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Pressione M para Masculino e F para Feminino ou O para outros: ");
                    char genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("Digite a data de nascimento no formato dd/mm/aaaa: ");
                    DateTime dataDeNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o nome da sua rua: ");
                    string NomeDaRua = Console.ReadLine();
                    Console.WriteLine("Digite o número da casa: ");
                    UInt32 numeroDaCasa = Convert.ToUInt32(Console.ReadLine());
                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Encerrando o programa.");
                }
                else
                {
                    Console.WriteLine("Opcão desconhecida!");
                }
            } while (opcao != "s");
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
