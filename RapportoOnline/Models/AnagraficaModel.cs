namespace RapportoOnline.Models
{
    public class AnagraficaModel : ErrorModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public bool? Servizio { get; set; }

        public bool? Pioniere { get; set; }

        public decimal? Ore {  get; set; }

        public bool? Studi {  get; set; }

        public int? St {  get; set; }

    }
}
