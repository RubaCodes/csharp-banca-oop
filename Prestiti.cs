
public class Prestiti {
    public int Id { set; get; }
    public Clienti cliente;
    public int Ammontare { set; get; }
    public decimal Rata { set; get; }
    public DateOnly dataInizio {get; set;}
    public DateOnly dataFine { get; set; }

    private static int contatorePrestiti = 1;

    //data fine
    public Prestiti(Clienti cliente, int ammontare) {
        Id = contatorePrestiti++;
        this.cliente = cliente;
        Ammontare = ammontare;
        //calcolo rata su un anno;
        Rata = Math.Round((decimal) ammontare / 12 ,2);
        //data di inizio e fine seetata di dafault ad un anno per sempliocita
        dataInizio = DateOnly.FromDateTime(DateTime.Now);
        dataFine = DateOnly.FromDateTime(DateTime.Now).AddYears(1);
    }
    public void GetPrestitoInfo()
    {
        Console.WriteLine("---- riassunto prestito----");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Ammontare: {Ammontare}");
        Console.WriteLine($"Codice Fiscale titolare: {cliente.CodiceFiscale}");
        Console.WriteLine($"Data di Inizio: {dataInizio}");
        Console.WriteLine($"Data di Fine: {dataFine}");
    }
}