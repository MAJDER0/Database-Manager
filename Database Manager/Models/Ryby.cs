using System;
using System.Collections.Generic;

namespace Database_Manager.Models;

public partial class Ryby
{
    public int ZwierzeId { get; set; }

    public string Nazwa { get; set; } = null!;

    public string SposobOdzywiania { get; set; } = null!;

    public virtual Zwierzetum Zwierze { get; set; } = null!;
}
