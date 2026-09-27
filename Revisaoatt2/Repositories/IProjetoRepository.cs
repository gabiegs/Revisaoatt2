using Revisaoatt2.Models;

namespace Revisaoatt2.Repositories
{
    public interface IProjetoRepository
    {
        public void CadastrarProjeto(Projeto projeto);
        public void RegistrarVisita(Visita visita);
        public List<Projeto> ObterTodos();
        public Projeto ObterPorNumero(int numero);
        List<Visita> ObterVisitasPorProjeto(int numero);
    }
}
