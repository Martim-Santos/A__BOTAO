namespace BOTAO.Models {
    public class Grupo {

        public int Id { get; set; }

        /// <summary>
        /// nome do Grupo
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// nome do criador
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// nome do criador
        /// </summary>
        public List<Array> membros { get; set; } = List.Empty;



    }
}
