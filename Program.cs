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

Console.WriteLine("----Test Log info singolo utente----");
primoCliente.GetUserInfo();
Console.WriteLine();
secondoCliente.GetUserInfo();
//test ricerca cliente : nome e cognome
Console.WriteLine( '\n' +"----Test ricerca singolo utente per nome e cognome----");
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
Prestiti prestitoUno = new Prestiti(secondoCliente,12000);
Prestiti prestitoDue = new Prestiti(secondoCliente, 10000);
//log per check sul calcolo rata
Console.WriteLine();
Console.WriteLine("----Test log costo prestiti----");
prestitoDue.GetPrestitoInfo();
prestitoUno.GetPrestitoInfo();





banca.NewPrestito(prestitoUno);
banca.NewPrestito(prestitoDue);

//test ricerche prestiti partendo da codice fiscale //
//funziona , ritorna il 12k partendo dal cf del secondoUtente
Console.WriteLine("----Test lista prestiti singolo utente----");
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

Console.WriteLine();

//test somma prestiti
Console.WriteLine("----Test somma prestiti singolo utente----");
Console.WriteLine(banca.GetTotalePrestiti("GNLCGNFRNCH"));