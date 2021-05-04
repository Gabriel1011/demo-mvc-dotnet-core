using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo_mvc.Models
{
  public class Filme
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Título é obrigatório")]
    [StringLength(60, MinimumLength = 3, ErrorMessage = "O titulo precisa ter entre 3 ou 60 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
    [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
    [Display(Name = "Data de Lançamento")]
    public DateTime? DataLancamento { get; set; }

    [StringLength(30, ErrorMessage = "O genero deve ter um máximo de 30 caracteres"), Required(ErrorMessage = "O campo genero é requerido")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\u00c0-\u00ff""'\w-]*$", ErrorMessage = "Genero em formato inválido")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "Preencha o campo valor")]
    [Range(1,1000, ErrorMessage = "Valor deve estar entre 1 à 1000")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal? Valor { get; set; }

    [Required(ErrorMessage = "Preencher a Avaliação")]
    [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somento números")]
    [Display(Name = "Avaliação")]
    public int? Avaliacao { get; set; }
  }
}