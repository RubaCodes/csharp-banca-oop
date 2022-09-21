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

