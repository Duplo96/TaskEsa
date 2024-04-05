using Task_Esa.Models;
using Task_Esa.Repos;

namespace Task_Esa.Services
{
    public class SistemaService : IService<Sistema>
    {
        private readonly SistemaRepo _repository;

        public SistemaService(SistemaRepo repository)
        {
            _repository = repository;
        }
        public IEnumerable<Sistema> PrendiliTutti()
        {

            return _repository.GetAll();
        }

       
    }
}
