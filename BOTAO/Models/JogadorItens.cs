using System.ComponentModel.DataAnnotations.Schema;

namespace BOTAO.Models {
    public class JogadorItens {

        public int Id { get; set; }

        /// <summary>
        /// FK para o Jogador
        /// </summary>
        [ForeignKey(nameof(Jogador))]
        public int JogadorFK { get; set; }
        public Jogador Jogador { get; set; }

        /// <summary>
        /// FK para os Itens do Jogador
        /// </summary>
        [ForeignKey(nameof(Itens))]
        public int ItensFK { get; set; }
        public Itens Itens { get; set; }
    }
}
