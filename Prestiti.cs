
public class Prestiti {
    public int Id { set; get; }
    public Clienti cliente;
    public int Ammontare { set; get; }
    public int Rata { set; get; }
    public DateOnly dataInizio {get; set;}
    public DateOnly dataFine { get; set; }

    private static int contatorePrestiti = 1;

    //data fine
    public Prestiti(Clienti cliente, int ammontare, int rata) {
        Id = contatorePrestiti++;
        this.cliente = cliente;
        Ammontare = ammontare;
        Rata = rata;
        //data di inizio e fine seetata di dafault ad un anno per sempliocita
        dataInizio = new DateOnly();
        dataFine = new DateOnly().AddYears(1);
    }
}