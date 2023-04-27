using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;
using System.Reflection.PortableExecutable;

namespace Esercizio_LastDay.Models
{
	public static class Manager
	{
		public static List<Utente> UtentiAutorizzati = new List<Utente>
		{
			new Utente ("MicheleMeloni", "Utente1"),
			new Utente ("MarcoRossi", "Utente2"),
			new Utente ("CarloBianchi", "Utente3")

		};
		public static List<Cellulare> ProdottiDisponibili = new List<Cellulare>();


		public static bool Login(string nomeUtente, string pass)
		{
			var UtenteInLista = false;
			foreach (var item in UtentiAutorizzati)
			{
				if (item.Username == nomeUtente && item.Password == pass)
				{
					UtenteInLista = true;
				}
			}
			return UtenteInLista;
		}

		public static List<Cellulare> GetPhones()
		{
			//chiamata get http
			HttpClient client = new HttpClient();
				var website = new HttpRequestMessage(HttpMethod.Get,"https://gist.githubusercontent.com/hanse/4458506/raw/a702c19d07bd7693ee75efef18502c421b565949/phones.json");
			var response = client.Send(website);

			using (var read = new StreamReader(response.Content.ReadAsStream()))
			{
				var cellulare = read.ReadToEnd();
				ProdottiDisponibili = JsonConvert.DeserializeObject<List<Cellulare>>(cellulare);
				return ProdottiDisponibili;
			}
		}


	}
}

