using System.Text.Json.Serialization;

namespace Task_Esa.Models
{
    public class Oggetto_Sistema
    {

        [JsonIgnore]

        public Sistema sis { get; set; } = null!;
        public OggettoCeleste ogg { get; set; } = null!;

        [JsonIgnore]
        public int OggettoCelesteRIF { get; set; }
        public int SistemaRIF { get; set; }

    }
}
