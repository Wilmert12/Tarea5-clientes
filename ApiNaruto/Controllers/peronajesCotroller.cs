using ApiNaruto.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ApiNaruto.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonajesController : ControllerBase
{
    private readonly string _connectionString;

    public PersonajesController(IConfiguration config)
    {
        _connectionString = config.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Falta la cadena de conexión 'DefaultConnection'.");
    }

    [HttpGet]
    public async Task<IActionResult> GetPersonajes()
    {
        using var connection = new SqlConnection(_connectionString);

        const string sql = "SELECT Id, Nombre, Clan, Aldea, TipoChakra FROM Personajes";
        var personajes = await connection.QueryAsync<Personaje>(sql);

        return Ok(personajes);
    }

    [HttpPost]
    public async Task<IActionResult> GuardarPersonaje([FromBody] Personaje personaje)
    {
        using var connection = new SqlConnection(_connectionString);

        const string sql = @"INSERT INTO Personajes (Nombre, Clan, Aldea, TipoChakra)
                             VALUES (@Nombre, @Clan, @Aldea, @TipoChakra)";
        var filas = await connection.ExecuteAsync(sql, personaje);

        return filas > 0
            ? Ok("Personaje guardado exitosamente")
            : BadRequest("No se pudo guardar el registro");
    }
}