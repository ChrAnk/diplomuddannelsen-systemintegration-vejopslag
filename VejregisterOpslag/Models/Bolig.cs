namespace VejregisterOpslag.Models
{
    public class Bolig                                  // Recordtype 002
    {
        public String? Recordtype { get; set; }
        public String? Kommunekode { get; set; }        // Position 3, length 4
        public String? Vejkode { get; set; }            // Position 7, length 4
        public String? Husnummer { get; set; }          // Position 11, length 4
        public String? Etage { get; set; }              // Position 15, length 2
        public String? SideDør { get; set; }            // Position 17, length 4
        public String? Ajourført { get; set; }          // Position 21, length 12
        public String? Startdato { get; set; }          // Position 34, length 12 (ÅÅÅÅMMDDTTMM)
        public String? Lokalitet { get; set; }          // Position 58, length 34{
    }
}
