using System;
using System.Collections.Generic;

namespace Database_Manager.Models;

public partial class Zwierzetum
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Typ { get; set; } = null!;

    public string SposobOdzywiania { get; set; } = null!;

    public virtual Gady? Gady { get; set; }

    public virtual Plazy? Plazy { get; set; }

    public virtual Ptaki? Ptaki { get; set; }

    public virtual Ryby? Ryby { get; set; }

    public virtual Ssaki? Ssaki { get; set; }
}
