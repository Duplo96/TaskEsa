using Task_Esa.Models;

namespace Task_Esa.DTO
{
    public class SistemaDTO
    {


        public string Nom { get; set; } = null!;

        public string? Cod { get; set; }

        public string Tip { get; set; } = null!;

        public virtual ICollection<OggettoCeleste> OggettoCelesteRifs { get; set; } = new List<OggettoCeleste>();
    }
}
