using System.ComponentModel.DataAnnotations;

public class Movie
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Director { get; set; }

    [Required]
    public string? Genre { get; set; }

    [Required]
    public int Year { get; set; }

    [DataType(DataType.MultilineText)]
    public string? Description { get; set; }

    public string? Poster { get; set; }
}