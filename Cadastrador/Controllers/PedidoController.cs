using Compartilhado;
using Compartilhado.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cadastrador.Controllers;

[Route("api/[controller]")]
public class PedidoController : ControllerBase
{
    [HttpPost]
    public async Task PostAsync([FromBody] Pedido pedido)
    {
        pedido.Id = Guid.NewGuid().ToString();
        pedido.DataDeCriacao = DateTime.UtcNow;

        await pedido.SalvarAsync<Pedido>();

        Console.WriteLine($"Pedido cadastrado com sucesso! Id: {pedido.Id}");
    }
}
