using System.ComponentModel.DataAnnotations;

namespace ApiNaruto.Blazor.Models;

public class Personaje
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El clan es obligatorio")]
    public string Clan { get; set; } = string.Empty;

    [Required(ErrorMessage = "La aldea es obligatoria")]
    public string Aldea { get; set; } = string.Empty;

    [Required(ErrorMessage = "El tipo de chakra es obligatorio")]
    public string TipoChakra { get; set; } = string.Empty;
}