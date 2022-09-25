using System.Linq.Expressions;

namespace RepositoryPattern.Services
{
    public interface IGenericRepository<T> where T : class
    {
        //GetirHepsi,GetirByID,Ekle,Sil,Güncelle,GetirFiftreli

        Task<IEnumerable<T>> GetirHepsi();
        Task<T> GetirById(Guid id);
        Task<bool> Ekle(T entity);
        Task<bool> Sil(Guid id);
        Task<bool> Güncelle(T entity);
        Task<IEnumerable<T>> GetirFiltreli(Expression<Func<T, bool>> predicate);


    }
}
