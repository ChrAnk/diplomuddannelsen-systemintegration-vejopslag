namespace VejregisterOpslag.Models
{
    public class Byfornydist                            // Recordtype 006
    {
        public String? Recordtype { get; set; }
        public String? Kommunekode { get; set; }        // Position 3, length 4
        public String? Vejkode { get; set; }            // Position 7, length 4
        public String? HusnummerFra { get; set; }       // Position 11, length 4
        public String? HusnummerTil { get; set; }       // Position 15, length 4
        public String? LigeUlige { get; set; }          // Position 19, length 1
        public String? Ajourført { get; set; }          // Position 20, length 12
        public String? Byfornyelseskode { get; set; }   // Position 32, length 6
        public String? Byfornyelsestekst { get; set; }  // Position 38, length 30
    }
}
