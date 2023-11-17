using CrudEmpresa.Dominio.Entidades;
using System.Linq.Expressions;

namespace CrudEmpresa.Infra.Data.Repositorios
{
    public interface IRepositorioBase<T> where T : EntidadeBase, new()
    {
        Task Inserir(T entity);
        Task Excluir(T entity);
        Task<T> ObterPorId(int id);
        Task<List<T>> Burcar(Expression<Func<T, bool>> filter);
        Task<List<T>> Listar();
        Task Atualizar(T entity);
    }
}