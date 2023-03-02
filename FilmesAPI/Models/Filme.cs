using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required(ErrorMessage ="O Título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required]
    [Range(70,600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }

    [Required(ErrorMessage ="O Diretor é obrigatório")]
    public string Diretor { get; set; }

    [Required(ErrorMessage = "O Gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O Tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
}
