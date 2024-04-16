using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MvcMovie.Models;

public class Player
{
    public int Id { get; set; }
    public string PlayerName { get; set; }
    public string Role { get; set; }
    public string? Weapon { get; set; }
}