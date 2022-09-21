

public class Banca {
    public string Nome { get; set; }
    //lista clienti
    List<Clienti> clienti;
    //lista prestiti
    List<Prestiti> prestiti;

    public Banca(string nome) {
        Nome = nome;
        clienti = new List<Clienti>();
        prestiti = new List<Prestiti>();    
    }
}
