//inizializzazione banca
Banca banca = new Banca("Mega Banca Mondiale");
Clienti primoCliente = new Clienti("Mario", "Rossi");
Clienti secondoCliente = new Clienti("Giovanni", "Verdi");
Console.WriteLine(banca.Nome);
//aggiunta due clienti
banca.AddCliente(primoCliente);
banca.AddCliente(secondoCliente);


//test ricerca cliente : nome e cognome
List<Clienti> risultatoRicerca = banca.SearchCliente("Giovanni", "Verdi");
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

