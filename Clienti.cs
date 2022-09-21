
public class Clienti {
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Stipendio { get; set; }
    public string CodiceFiscale { get; set; }

    public Clienti(string nome, string cognome) {
        Nome = nome;
        Cognome = cognome;  
    }

    //private string GeneraCodiceFiscale() {
    //    string codiceFiscale;
        
    //}
}