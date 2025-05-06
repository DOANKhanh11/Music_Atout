using System;
using System.Collections.Generic;

namespace MusicAtoutV1_Doan_Khanh.Models;

public partial class Ville
{
    public int IdVille { get; set; }

    public string? NomVille { get; set; }

    public int? Departement { get; set; }

    public virtual ICollection<Batiment> Batiments { get; set; } = new List<Batiment>();
}
