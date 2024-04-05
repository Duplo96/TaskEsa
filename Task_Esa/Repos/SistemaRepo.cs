
using Task_Esa.Models;
using Task_Esa.Services;

namespace Task_Esa.Repos
{
    public class SistemaRepo : IRepo<Sistema>
    {


        private readonly EsaContext _context;
        public SistemaRepo(EsaContext context)
        {
            _context = context;
        }
        public bool Create(Sistema entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Sistema? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sistema> GetAll()
        {
            return _context.Sistemi.ToList();
        }

        public bool Update(Sistema entity)
        {
            throw new NotImplementedException();
        }
    }
}
