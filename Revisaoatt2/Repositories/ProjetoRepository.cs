using Revisaoatt2.Models;

namespace Revisaoatt2.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private static List<Projeto> ObterProjetos = new List<Projeto>();

        private static List<Visita> RegistrarVisitas = new List<Visita>();

        public void CadastrarProjeto(Projeto projeto)
        {
            ObterProjetos.Add(projeto);
        }

        public void RegistrarVisita(Visita visita)
        {
            RegistrarVisitas.Add(visita);
        }

        public List<Projeto> ObterTodos()
        {
            return ObterProjetos;
        }

        public Projeto ObterPorNumero(int numero)
        {
            return ObterProjetos.FirstOrDefault(p => p.NumeroDoProjeto == numero);
        }

        public List<Visita> ObterVisitasPorProjeto(int numero)
        {
            return RegistrarVisitas
                .Where(v => v.Projeto == numero)
                .ToList();
        }
    }
}

