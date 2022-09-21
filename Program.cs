//inizializzazione banca
Banca banca = new Banca("Mega Banca Mondiale");
Clienti primoCliente = new Clienti("Mario", "Rossi");
Clienti secondoCliente = new Clienti("Giovanni", "Verdi");
Console.WriteLine(banca.Nome);
//aggiunta due clienti
banca.AddCliente(primoCliente);
primoCliente.Stipendio = 30000;
banca.AddCliente(secondoCliente);

//test modifica cliente
banca.EditCliente(secondoCliente, "Gianluca", "Gianfranchi", 22000);


//test ricerca cliente : nome e cognome
List<Clienti> risultatoRicerca = banca.SearchCliente("Gianluca", "Gianfranchi");
if (risultatoRicerca.Count == 0)
{
    Console.WriteLine("Spiacente, non risulta nessun cliente con quel nome e cognome nel database");
}
else {
    foreach (Clienti el in risultatoRicerca) {
        Console.WriteLine(el.Nome + " " + el.Cognome);
        Console.WriteLine(el.CodiceFiscale);
    }
}
//test nuovo prestito
Prestiti nuovoPrestito = new Prestiti(secondoCliente,12000,1000);
banca.NewPrestito(nuovoPrestito);
//test ricerche prestiti partendo da codice fiscale //
//funziona , ritorna il 12k partendo dal cf del secondoUtente

List<Prestiti> risultatiPrestiti =  banca.SearchPrestitiByCodiceFiscale("GNLCGNFRNCH");
if (risultatiPrestiti.Count == 0)
{
    Console.WriteLine("Spiacente, non risulta nessun prestito con quel codice fiscale");
}
else
{
    foreach (Prestiti elm in risultatiPrestiti)
    {
        Console.WriteLine(elm.Ammontare);  
    }
}