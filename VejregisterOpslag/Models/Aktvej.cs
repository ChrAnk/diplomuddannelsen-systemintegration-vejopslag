namespace VejregisterOpslag
{
    public class Aktvej                                 // Recordtype 001
    {
        public String? Recordtype { get; set; }
        public String? Kommunekode { get; set; }        // Position 3, length 4
        public String? Vejkode { get; set; }            // Position 7, length 4
        public String? Ajourført { get; set; }          // Position 11, length 12
        public String? TilKommunekode { get; set; }     // Position 23, length 4
        public String? TilVejkode { get; set; }         // Position 27, length 4
        public String? FraKommunekode { get; set; }     // Position 31, length 4
        public String? FraVejkode { get; set; }         // Position 35, length 4
        public String? Startdato { get; set; }          // Position 39, length 12 (ÅÅÅÅMMDDTTMM)
        public String? Addresseringsnavn { get; set; }  // Position 51, length 20
        public String? Vejnavn { get; set; }            // Position 71, length 40
    }
}
