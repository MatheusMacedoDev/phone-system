namespace PhoneSystem 
{
	public class Celular 
	{
		private string cor;
		private string modelo;
		private float tamanho;
		private bool ligado;
		
		public Celular(string cor, string modelo, float tamanho, bool ligado) 
		{
			this.cor = cor;
			this.modelo = modelo;
			this.tamanho = tamanho;
			this.ligado = ligado;
		}
		
		public void ligar() 
		{
			ligado = true;
		}
		
		public void desligar() 
		{
			ligado = false;
		}
		
		public void fazerLigacao() 
		{
			if (ligado)
				Console.WriteLine($"Ligação feita!");
			else
				Console.WriteLine($"O celular não pode realizar ações estando desligado.");
				
		}
		
		public void enviarMensagem() 
		{
			if (ligado)
				Console.WriteLine($"Mensagem enviada!");
			else
				Console.WriteLine($"O celular não pode realizar ações estando desligado.");
		}
	}
}