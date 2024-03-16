namespace VejregisterOpslag.Models
{
    public class Divdist                                // Recordtype 007
    {
        public String? Recordtype { get; set; }
        public String? Kommunekode { get; set; }        // Position 3, length 4
        public String? Vejkode { get; set; }            // Position 7, length 4
        public String? HusnummerFra { get; set; }       // Position 11, length 4
        public String? HusnummerTil { get; set; }       // Position 15, length 4
        public String? LigeUlige { get; set; }          // Position 19, length 1
        public String? Ajourført { get; set; }          // Position 20, length 12
        public String? Distriktstype { get; set; }      // Position 32, length 2
        public String? Distriktskode { get; set; }      // Position 34, length 4
        public String? Distriktsnavn { get; set; }      // Position 38, length 30
    }
}
