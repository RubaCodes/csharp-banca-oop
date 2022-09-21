

public class Banca {
    public string Nome { get;}
    //lista clienti
    List<Clienti> clienti;
    //lista prestiti
    List<Prestiti> prestiti;

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
    }
    //ricerca cliente
    public Clienti SearchCliente(Clienti cliente) {

        return cliente;
    }
}
