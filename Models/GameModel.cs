using System.ComponentModel.DataAnnotations;

namespace GameLibraryAPI.Models;

public record GameModel
{
    [Key]
    public int Id { get; init; }
    
    public string Title { get; init; }
    public string Genre { get; init; }
    public decimal Price { get; init; }
    public DateOnly ReleaseDate { get; init; }
}