namespace Task_Esa.Services
{
    public interface IService<T>
    {
        IEnumerable<T> PrendiliTutti();
    }
}
