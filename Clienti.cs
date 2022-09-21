
public class Clienti {
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Stipendio { get; set; }
    public string CodiceFiscale { get; set; }

    public Clienti(string nome, string cognome) {
        Nome = nome;
        Cognome = cognome;
        CodiceFiscale = GeneraCodiceFiscale();
    }

    public string GeneraCodiceFiscale()
    {
        //codice fiscale seplificato, solo consonanti
        string codiceFiscale ="";
        for (int i = 0; i < Nome.Length; i++) {
            if (Nome[i] != 'a' && Nome[i] != 'e' && Nome[i] != 'i' && Nome[i] != 'o' && Nome[i] != 'u') {
                codiceFiscale += Nome[i];
            }
        }
        for (int i = 0; i < Cognome.Length; i++)
        {
            if (Cognome[i] != 'a' && Cognome[i] != 'e' && Cognome[i] != 'i' && Cognome[i] != 'o' && Cognome[i] != 'u')
            {
                codiceFiscale += Cognome[i];
            }
        }
        return codiceFiscale.ToUpper();
    }
}