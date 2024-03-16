namespace VejregisterOpslag.Models
{
    public class VejegenskaberQueryParameters
    {
        private string? _kommunekode;
        private string? _vejkode;
        public string? Kommunekode { 
            get {  return _kommunekode; }
            set {  _kommunekode = value?.PadLeft(4, '0'); }
        }
        public string? Vejkode
        {
            get { return _vejkode; }
            set { _vejkode = value?.PadLeft(4, '0'); }
        }
    }
}
