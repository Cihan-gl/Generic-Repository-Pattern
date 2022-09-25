using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using RepositoryPattern.Model;

namespace RepositoryPattern.Services
{
    public class PersonelRepository : GenericRepository<Personel>, IPersonelRepository
    {
        public PersonelRepository(RepoCihanDBContext context, ILogger logger) : base(context, logger)
        {

        }


        public override async Task<IEnumerable<Personel>> GetirHepsi()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Hatalar : ", typeof(PersonelRepository));
                return new List<Personel>();
            }
        }


    }
}
