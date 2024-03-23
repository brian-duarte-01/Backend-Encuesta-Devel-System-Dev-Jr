using System;
using System.Collections.Generic;

namespace Backend_Encuesta_Devel_System.Models;

public partial class Encuestador
{
    public int IdEncuestador { get; set; }

    public string? EPrimerNombre { get; set; }

    public string? ESegundoNombre { get; set; }

    public string? EPrimerApellido { get; set; }

    public string? ESegundoApellido { get; set; }

    public int? ETelefono { get; set; }

    public string? Correo { get; set; }
}
