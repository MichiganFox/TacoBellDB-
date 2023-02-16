using System;
using System.Collections.Generic;

namespace CreatingASQLDBTacoBellDB.Models;

public partial class Taco
{
    public Taco(string name, float cost, bool softshell, bool dorito)
    {
        Name = name;
        Cost = cost;
        SoftShell = softshell;
        Dorito = dorito;
    }

    //public Taco(string name, int cost, bool softshell, bool dorito)
    //{
    //    Name = name;
    //    Cost = cost;
    //    SoftShell = softshell;
    //    Dorito = dorito;
    //}

    public int Id { get; set; }

    public string? Name { get; set; }

    public float? Cost { get; set; }

    public bool? SoftShell { get; set; }

    public bool? Dorito { get; set; }
}
