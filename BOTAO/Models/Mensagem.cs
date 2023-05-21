using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BOTAO.Models {
    public class Mensagem {
        public Mensagem() {
            // inicializar a lista de itens do jogador
            ListaJogador = new HashSet<Jogador>();
        }

        /// <summary>
        /// Conteudo da mensagem
        /// </summary>
        public string frase { get; set; }

        /// <summary>
        /// data de envio da mensagem
        /// </summary>
        public DateTime data { get; set; }



        [ForeignKey(nameof(Jogador))]
        public int JogadorFK { get; set; }
        public Jogador Jogador { get; set; }

        [ForeignKey(nameof(Grupo))]
        public int GrupoFK { get; set; }
        public Grupo Grupo { get; set; }

        /// <summary>
        /// Lista dos Itens associados ao Jogador
        /// </summary>
        public ICollection<Jogador> ListaJogador { get; set; }
    }
}
