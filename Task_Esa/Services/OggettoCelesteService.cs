using Task_Esa.Models;
using Task_Esa.Repos;

namespace Task_Esa.Services
{
    public class OggettoCelesteService:IService<OggettoCeleste>
    {
        private readonly OggettoCelesteRepo _repository;

        public OggettoCelesteService(OggettoCelesteRepo repository)
        {
            _repository = repository;
        }


        public IEnumerable<OggettoCeleste> PrendiliTutti()
        {
            return _repository.GetAll();
        }




    }
}
