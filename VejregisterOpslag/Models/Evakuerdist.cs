namespace VejregisterOpslag.Models
{
    public class Evakuerdist                            // Recordtype 008
    {
        public String? Recordtype { get; set; }
        public String? Kommunekode { get; set; }        // Position 3, length 4
        public String? Vejkode { get; set; }            // Position 7, length 4
        public String? HusnummerFra { get; set; }       // Position 11, length 4
        public String? HusnummerTil { get; set; }       // Position 15, length 4
        public String? LigeUlige { get; set; }          // Position 19, length 1
        public String? Ajourført { get; set; }          // Position 20, length 12
        public String? Evakueringskode { get; set; }    // Position 32, length 1
        public String? Evakueringsnavn { get; set; }     // Position 33, length 30
    }
}
