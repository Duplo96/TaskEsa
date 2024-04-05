using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Esa.Models;
[Table("Oggetto_Celeste")]
public partial class OggettoCeleste
{
    public int OggettoCelesteId { get; set; }

    public string Nome { get; set; } = null!;

    public string? Codice { get; set; }

    public DateOnly DataScoperta { get; set; }

    public string Scopritore { get; set; } = null!;

    public string Tipologia { get; set; } = null!;

    public decimal DistanzaTerra { get; set; }

    public decimal AngoloPolare { get; set; }

    public decimal DistanzaRadiale { get; set; }

    public virtual ICollection<Sistema>? SistemaRifs { get; set; } = new List<Sistema>();

    public IEnumerable<Oggetto_Sistema> ElencoOggSis { get; set; } = new List<Oggetto_Sistema>();
}
