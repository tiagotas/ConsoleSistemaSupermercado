using System;

namespace ConsoleSistemaSupermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Mostrar um menu de opções para o usuário escolher:
             * 1) Ver a lista de Produtos na Compra
             * 2) Adicionar um item na Compra
             * 3) Sair do Sistema.
             */
            
            bool voltar_menu_inicial = false;

            int opcao_menu;

            do
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("        PagEtec - PDV para Supermercados      ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("Selecione uma Opção para Continuar:");
                Console.WriteLine("1 => Ver a lista de Produtos na Compra");
                Console.WriteLine("2 => Adicionar um Produto Compra");
                Console.WriteLine("3 => Sair do Sistema");

                /**
                 * Fazendo a validação da entrada do menu.
                 */ 
                bool digitacao_valida_opcao_menu = false;
                do
                {
                    digitacao_valida_opcao_menu = int.TryParse(Console.ReadLine(), out opcao_menu);

                    if(opcao_menu < 1 || opcao_menu > 3 || digitacao_valida_opcao_menu == false)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção inválida, redigite uma opção:");
                        Console.BackgroundColor = ConsoleColor.Black;

                        digitacao_valida_opcao_menu = false;
                    }
                } while (!digitacao_valida_opcao_menu);

                
                /**
                 *  Definindo para onde o usuário vai.
                 */ 
                switch (opcao_menu)
                {
                    case 1:
                        Console.WriteLine("vai mostrar a lista de itens na compra.");
                        break;

                    case 2:
                        Console.WriteLine("Vai pedir os dados do produto a ser posto na lista.");
                        break;

                    case 3:
                        Console.WriteLine("Vai sair do sistema.");
                        break;
                }


                /**
                 * Perguntando se o usuário quer voltar o menu inicial.
                 */ 
                Console.WriteLine("Deseja voltar ao menu inicial? S/n");
                voltar_menu_inicial = (Console.ReadLine().ToUpper() == "S") ? true : false;

            } while (voltar_menu_inicial);

            Console.WriteLine("Fim do Programa.");
            Console.ReadKey();
        }
    }
}