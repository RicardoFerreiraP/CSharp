using Aula1705_Camadas.Controllers;
using Aula1705_Camadas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Views
{
    class AtividadesView
    {
        public void ExibirMenu()
        {
            int opcao = 9;
            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("=          Escolha uma opção:          =");
                Console.WriteLine("=         1 - Criar Atividade          =");
                Console.WriteLine("=         2 - Listar Atividade         =");
                Console.WriteLine("=         3 - Buscar Atividade         =");
                Console.WriteLine("=         4 - Editar Atividade         =");
                Console.WriteLine("=         5 - Excluir Atividade        =");
                Console.WriteLine("=         9 - Sair                     =");
                Console.WriteLine("========================================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CriarAtividade();
                        break;

                    case 2:
                        ListarAtividades();
                        break;

                    case 3:
                        BuscarAtividade();
                        break;

                    case 4:
                        EditarAtividade();
                        break;

                    case 5:
                        ExcluirAtividade();
                        break;

                    default:
                        break;
                }
            }

            while (opcao != 9);

        }

        public void CriarAtividade()
        {
            Atividade atividade = ObterDadosAtividade();

            AtividadesController atividadeCtrl = new AtividadesController();
            atividadeCtrl.Salvar(atividade);
        }

        private static Atividade ObterDadosAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();
            atividade.Ativo = true;
            return atividade;
        }

        private void ListarAtividades()
        {
            AtividadesController atividadeController = new AtividadesController();
            foreach (Atividade atividade in atividadeController.Listar())
            {
                ExibirDetalhesAtividade(atividade);
            }
            Console.WriteLine("Fim da lista");
            Console.ReadKey();
        }

        private static void ExibirDetalhesAtividade(Atividade atividade)
        {
            Console.WriteLine("Listando atividades cadastradas");
            Console.WriteLine("---");
            Console.WriteLine("ID: " + atividade.AtividadeID);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
        }

        private void BuscarAtividade()
        {
            AtividadesController atividadeController = new AtividadesController();
            Console.WriteLine("Digite o ID da atividade: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = atividadeController.BuscarPorID(id);

            if (atividade != null)
            {
                ExibirDetalhesAtividade(atividade);

            }
            else
            {
                Console.WriteLine("Atividade não encontrada!");
            }
            Console.ReadKey();
        }

        private void EditarAtividade()
        {
            ListarAtividades();
            Console.Write("Digite o ID da atividade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObterDadosAtividade();

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Editar(id, atividadeAtualizada);
        }

        private void ExcluirAtividade()
        {
            ListarAtividades();
            Console.WriteLine("Digite o ID da atividade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Excluir(id);
        }

    }
}
