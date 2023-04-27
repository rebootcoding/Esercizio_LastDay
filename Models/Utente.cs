namespace Esercizio_LastDay.Models
{
	public class Utente
	{
		public string Username { get; set; }
		public string Password { get; set; }

		public Utente(string Utente, string Pass)
		{
			Username = Utente;
			Password = Pass;
		}
	}
}
