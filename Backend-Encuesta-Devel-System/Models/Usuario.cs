using System;
using System.Collections.Generic;

namespace Backend_Encuesta_Devel_System.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? UNick { get; set; }

    public string? UPassword { get; set; }
}
