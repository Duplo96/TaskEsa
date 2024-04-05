
using Task_Esa.Models;
using Task_Esa.Services;

namespace Task_Esa.Repos
{
    public class OggettoCelesteRepo : IRepo<OggettoCeleste>
    {
        //private static OggettoCelesteService? instance;

        //public static OggettoCelesteService getInstance()
        //{
        //    if (instance == null)
        //        instance = new OggettoCelesteService();
        //    return instance;

        //}
        //private OggettoCelesteRepo() { }

        private readonly EsaContext _context;
        public OggettoCelesteRepo(EsaContext context)
        {
            _context= context;
        }


        public bool Create(OggettoCeleste entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OggettoCeleste? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OggettoCeleste> GetAll()
        {
            return _context.OggettiCelesti.ToList();
        }

        public bool Update(OggettoCeleste entity)
        {
            throw new NotImplementedException();
        }
    }
}
