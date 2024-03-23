using System;
using System.Collections.Generic;

namespace Backend_Encuesta_Devel_System.Models;

public partial class Encuestum
{
    public int IdEncuesta { get; set; }

    public string? ENombreEncuesta { get; set; }

    public string? EDescripcion { get; set; }

    public string? ETituloPregunta1 { get; set; }

    public string? EDescripPregunta1 { get; set; }

    public string? ERespuesta1 { get; set; }

    public string? ETituloPregunta2 { get; set; }

    public string? EDescripPregunta2 { get; set; }

    public string? ERespuesta2 { get; set; }

    public string? ETituloPregunta3 { get; set; }

    public string? EDescripPregunta3 { get; set; }

    public string? ERespuesta3 { get; set; }

    public string? ETituloPregunta4 { get; set; }

    public string? EDescripPregunta4 { get; set; }

    public string? ERespuesta4 { get; set; }

    public string? ETituloPregunta5 { get; set; }

    public string? EDescripPregunta5 { get; set; }

    public string? ERespuesta5 { get; set; }

    public string? EUsuario { get; set; }

    public string? EEncuestador { get; set; }

    public string? EFecha { get; set; }
}
