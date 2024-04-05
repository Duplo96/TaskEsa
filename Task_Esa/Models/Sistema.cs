using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Esa.Models;

[Table("Sistema")]
public partial class Sistema
{
    public int SistemaId { get; set; }

    public string Nome { get; set; } = null!;

    public string? Codice { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<OggettoCeleste> OggettoCelesteRifs { get; set; } = new List<OggettoCeleste>();

    public IEnumerable<Oggetto_Sistema> ElencoOggSis { get; set; } = new List<Oggetto_Sistema>();
}
