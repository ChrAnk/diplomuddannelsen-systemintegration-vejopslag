namespace VejregisterOpslag.Models
{
    public class Notatvej                               // Recordtype 005
    {
        public String? Recordtype { get; set; }
        public String? Kommunekode { get; set; }        // Position 3, length 4
        public String? Vejkode { get; set; }            // Position 7, length 4
        public String? Notatnummer { get; set; }        // Position 11, length 2
        public String? Notatlinje { get; set; }         // Position 13, length 40
        public String? Ajourført { get; set; }          // Position 53, length 12
        public String? Startdato { get; set; }          // Position 65, length 12 (ÅÅÅÅMMDDTTMM)
    }
}
