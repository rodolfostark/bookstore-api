using System.ComponentModel.DataAnnotations;

namespace BookstoreAPI.Data.Dtos.Book;

public class ReadBookDto
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo título é obrigatório")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "O campo autor é obrigatório")]
    public string Author { get; set; } = string.Empty;
    [StringLength(30, ErrorMessage = "O campo gênero não pode passar de 30 caracteres")]
    public string Genre { get; set; } = string.Empty;
    [Required(ErrorMessage = "O campo preço é obrigatório")]
    public double Price { get; set; }
    [Range(1, 600, ErrorMessage = "A quantirade em estoque deve ter no mínimo 1 e no máximo 600 livros")]
    public int InventoryQuantity { get; set; }

}
