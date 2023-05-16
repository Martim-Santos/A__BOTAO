using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BOTAO.Models {
    public class Mensagem {
        public string frase { get; set; }



        [ForeignKey(nameof(Jogador))]
        public int JogadorFK { get; set; }
        public Jogador Jogador { get; set; }

        [ForeignKey(nameof(Grupo))]
        public int GrupoFK { get; set; }
        public Grupo Grupo { get; set; }
    }
}
