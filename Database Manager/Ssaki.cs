using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Database_Manager;

public partial class Ssaki
{

    public int ZwierzeId { get; set; }

    public string Nazwa { get; set; } = null!;

    public string SposobOdzywiania { get; set; } = null!;

    public virtual Zwierzetum Zwierze { get; set; } = null!;
}
