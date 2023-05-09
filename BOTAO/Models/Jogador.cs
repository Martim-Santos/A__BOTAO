﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOTAO.Models
{
    public class Jogador{

        /// <summary>
        /// Descrição dos jogadores
        /// </summary>
        public Jogador() {
            // inicializar a lista de animais do criador
            ListaItens = new HashSet<Itens>();
        }
        public int Id { get; set; }
        /// <summary>
        /// Nome do jogador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchismento obrigratório.")]
        [StringLength(20)]
        public string UserName { get; set; }

        /// <summary>
        /// email do jogador
        /// </summary>
        [EmailAddress]
        [Required(ErrorMessage = "O {0} é de preenchismento obrigratório.")]
        [StringLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// password do jogador
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchismento obrigratório.")]
        [StringLength(20, MinimumLength = 8,
                      ErrorMessage = "A {0} tem de ter no mínimo {2} characteres")]
        public string Password { get; set; }


        /// <summary>
        /// score do criador
        /// </summary>
        public int score { get; set; }


        /*+++++++++++++++++++++++++++++++++++++++++++
         * relacionamentos associados ao Jogador
         */

        /// <summary>
        /// FK para o Grupo do Jogador
        /// </summary>
        [ForeignKey(nameof(Grupo))]
        public int GrupoFK { get; set; }
        public Grupo Grupo { get; set; }

        /// <summary>
        /// Lista dos Itens associados ao Jogador
        /// </summary>
        public ICollection<Itens> ListaItens { get; set; }

        

    }
}