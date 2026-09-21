using System.ComponentModel.DataAnnotations;

namespace ApiNaruto.Models;

public class Personaje
{
    public int Id { get; set; }

    [Required] public string Nombre { get; set; } = string.Empty;
    [Required] public string Clan { get; set; } = string.Empty;
    [Required] public string Aldea { get; set; } = string.Empty;
    [Required] public string TipoChakra { get; set; } = string.Empty;
}