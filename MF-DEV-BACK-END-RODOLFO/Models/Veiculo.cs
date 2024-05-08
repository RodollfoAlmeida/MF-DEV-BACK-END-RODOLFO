using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MF_DEV_BACK_END_RODOLFO.Models

{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome do Veiculo!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a Placa do veiculo!")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação do Veiculo!")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Ano do modelo do Veiculo!")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
