

public class Banca {
    public string Nome { get;}
    //lista clienti
    List<Clienti> clienti;
    //lista prestiti
    List<Prestiti> prestiti;


    //METODI CLIENTI
    public Banca(string nome) {
        Nome = nome;
        clienti = new List<Clienti>();
        prestiti = new List<Prestiti>();    
    }
    //aggiungere cliente
    public void AddCliente(Clienti cliente) {
        clienti.Add(cliente);
    }
    //modifica cliente
    public void EditCliente(Clienti cliente, string newNome, string NewCognome, int newStipendio) {
        //se esiste il cliente
        cliente.Nome = newNome;
        cliente.Cognome = NewCognome;
        cliente.Stipendio = newStipendio;
        cliente.CodiceFiscale = cliente.GeneraCodiceFiscale();
    }
    //ricerca cliente : per nome e cognome
    public List<Clienti> SearchCliente(string nome, string cognome) {
        List<Clienti> risultatoRicerca = new List<Clienti>();
        //ritorna lista di clienti con quel nome e cognome
        foreach (Clienti cliente in clienti)
        {
            if (cliente.Nome.ToLower()+cliente.Cognome.ToLower() == nome.ToLower()+cognome.ToLower()) {
                risultatoRicerca.Add(cliente);
            }
        }
        return risultatoRicerca;
    }

    //Metodi prestiti
    public void NewPrestito(Prestiti prestito) {
        prestiti.Add(prestito);
    }
    public List<Prestiti> SearchPrestitiByCodiceFiscale(string codiceFiscale) {
        List<Prestiti> risultati = new List<Prestiti>();
        foreach (Prestiti el in prestiti) {
            if (el.cliente.CodiceFiscale == codiceFiscale) {
                risultati.Add(el);
            }
        }
        return risultati;
    }
}
