namespace Esercizio_LastDay.Models
{
	//crea app per vendere cellulari
	//X crea login 
	//X 3 coppie user e password
	//con authentication filter vedere se è autenticato o meno
	//X visualizzare elenco (lato client o MVC) e mostrare elenco in pagina web
	//X pulsante COMPRA 
	//quando comprare "HAI COMPRATO : ....." -> redirect a view in cui c'è solo pulsante log out (gestito con Javascript)
	//all'onclick richiama web - api che fa logout (senza view vorrelata)
	//compra modello e in automatico dopo che compri fa il log out
	//sistema il css in modo che sia fruibile
	//File Json -> https://gist.githubusercontent.com/hanse/4458506/raw/a702c19d07bd7693ee75efef18502c421b565949/phones.json
	public class Cellulare
	{
		public string Vendor { get; set; }
		public string Model { get; set; }
	}
}
