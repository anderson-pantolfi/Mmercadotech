using mercado_tech.classes;

namespace mercado_tech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n============================================================\n\n");
            Console.WriteLine("Seja Bem vindo ao Sistema de Gereciamento Mercado Tech");
            Console.WriteLine("\n\n============================================================\n");

            while (true)
            {
                Console.WriteLine("\nEscolha uma das Opçoes para continuar: ");
                Console.WriteLine("0 - Sair do sistema");
                Console.WriteLine("1 - Cadastrar um novo Vendedor");
                Console.WriteLine("2 - Cadastrar um novo Cliente");
                Console.WriteLine("3 - Excluir um Usuario");
                Console.WriteLine("4 - Listar um Usuario Especifico");
                Console.WriteLine("5 - Listar todos os Vendedores");
                Console.WriteLine("6 - Listar todos os Clientes");
                Console.WriteLine("7 - Listar todos os Usuarios");

                Console.Write("\nObpção: ");

                string EntradaUserOpcao = Console.ReadLine();

                if (int.TryParse(EntradaUserOpcao, out int opcao))
                {

                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("\nEncerrando o sistema... Até logo!");
                            Console.WriteLine("Obrigado por Utilizar O mercado Tech\n\n");
                            return;
                        case 1:
                            UserManager.CreateVendedor();
                            break;
                        case 2:
                            UserManager.CreateCliente();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            UserManager.ExibirTodosOsVendedores();
                            break;
                        case 6:
                            UserManager.ExibirTodosOsClientes();
                            break;
                        case 7:
                            UserManager.ExibirTodosOsPerfies();
                            break;
                        
                    }
                }
                else
                {
                    Console.WriteLine("Voce nao digitou numero.");
                    continue;
                }
            }
        }
    }
}
