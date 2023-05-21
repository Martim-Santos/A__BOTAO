using BOTAO.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOTAO.Controllers {
    [ApiController]
    [Route("api")]
    public class BotaoControler : ControllerBase {

        private static List<Itens> _Itens = new List<Itens>
        {
            new Itens { Name = "+1", Description="click vale mais 1", custo=10, Id=1},
            new Itens { Name = "x2", Description="click duplo", custo=50, Id=2},
            new Itens { Name = "x5", Description="multi clicks", custo=5000, Id=3},
            new Itens { Name = "+69", Description="nice", custo=690, Id=4},
            new Itens { Name = "x100", Description="muitos clicks", custo=100001, Id=5},
            new Itens { Name = "cartola", Description="bem refinado", custo=500, Id=6},
        };

        [HttpGet]
        public ActionResult Index() {
            Jogador jogador = new Jogador {
                UserName = "Unknown",
                Password = "blank",
                Email = "email@mail.com",
                click = 1,
                score = 0,
                Id = 1
            };
            return Ok(jogador);
        }

        [HttpGet("{id}")]
        public IActionResult GetItemId(int id) {
            var Item = _Itens.FirstOrDefault(I => I.Id == id);

            if (Item == null) {
                return NotFound();
            }

            return Ok(Item);
        }
    }
}
