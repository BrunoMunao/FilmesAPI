using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {

        [Required(ErrorMessage = "O titúlo é obrigatório!")]
        [StringLength(255, ErrorMessage = "O tamanho do título não pode exceder 255 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O ano é obrigatório!")]
        [StringLength(4, ErrorMessage = "O tamanho do ano não pode exceder 255 caracteres.")]
        public string Ano { get; set; }

        [Required(ErrorMessage = "O diretor é obrigatório!")]
        [StringLength(255, ErrorMessage = "O tamanho do nomde do diretor não pode exceder 255 caracteres.")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório!")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duração é obrigatória!")]
        [Range(70, 600, ErrorMessage = "O filme tem que ter tempo entre 70 e 600 minutos.")]
        public int Duracao { get; set; }
    }
}
