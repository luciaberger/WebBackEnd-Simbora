using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBackEnd_Simbora.Models
{
	[Table("Eventos")]
	public class Eventos
	{
		[Key]
		public int Id { get; set; }
		
		[Required(ErrorMessage = "Obrigatório informar o nome!")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "Obrigatório informar a Data!")]
		public int Data { get; set; }
		[Required(ErrorMessage = "Obrigatório informar o Horário!")]
		public int Horario { get; set; }
		[Required(ErrorMessage = "Obrigatório informar o local!")]
		public string Local { get; set; }
		public string MaisInformacoes { get; set; }

	}
}
