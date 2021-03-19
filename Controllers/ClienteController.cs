using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntity_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ClienteController : ControllerBase
	{

		private List<Cliente> dados = new List<Cliente>();
		

		private readonly ILogger<ClienteController> _logger;

		public ClienteController(ILogger<ClienteController> logger)
		{
			_logger = logger;
			dados.Add(new Cliente("1", "Maria Sousa", "258.851.854-74", 2500.77));
			dados.Add(new Cliente("2", "Jose Santos", "358.800.700-01", 1851.88));
			dados.Add(new Cliente("3", "Miguel Castro Silva", "269.855.888-51", 3854.21));
			dados.Add(new Cliente("4", "Amanda Gasper Libero", "258.587.854-55", 8755.00));
			dados.Add(new Cliente("5", "Thais Alcantara Machado", "211.855.854-99", 1250.01));
		}

		[HttpGet]
		public IEnumerable<Cliente> Get()
		{
			return dados.OrderBy(x=> x.Nome);
		}

		[HttpGet("Id/{id}")]
		public Cliente GetPorId(string id)
		{
			return dados.Where(x => x.ID == id).FirstOrDefault();
		}
		[HttpGet("Cpf/{cpf}")]
		public Cliente GetPorCpf(string cpf)
		{
			var x =  dados.Where(x => x.Cpf == cpf).FirstOrDefault();
			x.Salario = x.Salario * 0.3;
			return x;
		}
	}
}
