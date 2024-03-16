namespace VejregisterOpslag.Models
{
    public class Kirkedist                              // Recordtype 009
    {
        public String? Recordtype { get; set; }
        public String? Kommunekode { get; set; }        // Position 3, length 4
        public String? Vejkode { get; set; }            // Position 7, length 4
        public String? HusnummerFra { get; set; }       // Position 11, length 4
        public String? HusnummerTil { get; set; }       // Position 15, length 4
        public String? LigeUlige { get; set; }          // Position 19, length 1
        public String? Ajourført { get; set; }          // Position 20, length 12
        public String? Kirkekode { get; set; }          // Position 32, length 2
        public String? Distriktstekst { get; set; }     // Position 34, length 30
    }
}
