using Task_Esa.Models;

namespace Task_Esa.DTO
{
    public class OggettoCelesteDTO
    {
   

        public string Nom { get; set; } = null!;

        public string? Cod { get; set; }

        public DateOnly Dat { get; set; }

        public string Sco { get; set; } = null!;

        public string Tip { get; set; } = null!;

        public decimal Dis { get; set; }

        public decimal Ang { get; set; }

        public decimal Dist { get; set; }
        public virtual ICollection<Sistema>? SistemaRifs { get; set; } = new List<Sistema>();





    }
}
