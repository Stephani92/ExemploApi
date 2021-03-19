namespace ExemploEntity_API
{
	public class Cliente
	{
		public Cliente(string id, string nome, string cpf, double salario)
		{
			ID = id;
			Nome = nome;
			Cpf = cpf;
			Salario = salario;
		}

		public string ID { get; set; }
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public double Salario { get; set; }
	}
}
