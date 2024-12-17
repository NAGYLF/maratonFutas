﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication4.Models;

public partial class Futok
{
    public int Fid { get; set; }

    public string Fnev { get; set; } = null!;

    public int Szulev { get; set; }

    public int Szulho { get; set; }

    public int Csapat { get; set; }

    public bool Ffi { get; set; }

    [JsonIgnore]
    public virtual ICollection<Eredmenyek> Eredmenyeks { get; set; } = new List<Eredmenyek>();
}
