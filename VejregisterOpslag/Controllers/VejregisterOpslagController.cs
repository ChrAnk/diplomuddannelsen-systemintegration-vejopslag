using Microsoft.AspNetCore.Mvc;
using VejregisterOpslag.Models;
using System.Collections;

namespace VejregisterOpslag.Controllers
{
    [Route("VejregisterOpslag")]
    [ApiController]
    public class VejregisterOpslagController : ControllerBase
    {
        [HttpGet]
        [Route("FindEgenskaber")]
        public async Task<ActionResult> GetVejegenskaber([FromQuery] VejegenskaberQueryParameters queryParameters)
        {
            if (queryParameters.Kommunekode == null || queryParameters.Vejkode == null)
            {
                return BadRequest("Angiv både kommunekode og vejkode");
            }

            var filePath = @"C:\Vejregister.txt";

            ArrayList result = [];

            string[] lines = System.IO.File.ReadAllLines(filePath);

            var i = 0;
            string? kommunekode;
            string? vejkode;

            do
            {
                try
                {
                    kommunekode = lines[i].Substring(3, 4);
                    vejkode = lines[i].Substring(7, 4);
                }
                catch {
                    kommunekode = "";
                    vejkode = "";
                    continue;
                }

                if (kommunekode == queryParameters.Kommunekode && vejkode == queryParameters.Vejkode)
                {
                    var recordType = lines[i].Substring(0, 3);

                    switch (recordType)
                    {
                        case "001":
                            result.Add(new Aktvej
                            {
                                Recordtype = "001 Aktvej",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                Ajourført = lines[i].Substring(11, 12),
                                TilKommunekode = lines[i].Substring(23, 4),
                                TilVejkode = lines[i].Substring(27, 4),
                                FraKommunekode = lines[i].Substring(31, 4),
                                FraVejkode = lines[i].Substring(35, 4),
                                Startdato = lines[i].Substring(39, 12),
                                Addresseringsnavn = lines[i].Substring(51, 20).Trim(),
                                Vejnavn = lines[i].Substring(71).Trim()
                            });
                            break;

                        case "002":
                            result.Add(new Bolig
                            {
                                Recordtype = "002 Bolig",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                Husnummer = lines[i].Substring(11, 4),
                                Etage = lines[i].Substring(15, 2),
                                SideDør = lines[i].Substring(17, 4),
                                Ajourført = lines[i].Substring(21, 12),
                                Startdato = lines[i].Substring(34, 12),
                                Lokalitet = lines[i].Substring(58, 34).Trim()
                            });
                            break;

                        case "003":
                            result.Add(new Bynavn
                            {
                                Recordtype = "003 Bynavn",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Bynvn = lines[i].Substring(32, 34).Trim()
                            });
                            break;

                        case "004":
                            result.Add(new Postdist
                            {
                                Recordtype = "004 Postdistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Postnummer = lines[i].Substring(32, 4),
                                Postdistrikt = lines[i].Substring(36, 20).Trim()
                            });
                            break;

                        case "005":
                            result.Add(new Notatvej
                            {
                                Recordtype = "005 Notat",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                Notatnummer = lines[i].Substring(11, 2),
                                Notatlinje = lines[i].Substring(13, 40).Trim(),
                                Ajourført = lines[i].Substring(53, 12),
                                Startdato = lines[i].Substring(65, 12)
                            });
                            break;

                        case "006":
                            result.Add(new Byfornydist
                            {
                                Recordtype = "006 Byfornyelsesdistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Byfornyelseskode = lines[i].Substring(32, 6),
                                Byfornyelsestekst = lines[i].Substring(38, 30).Trim()
                            });
                            break;

                        case "007":
                            result.Add(new Divdist
                            {
                                Recordtype = "007 Diversedistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Distriktstype = lines[i].Substring(32, 2),
                                Distriktskode = lines[i].Substring(34, 4),
                                Distriktsnavn = lines[i].Substring(38, 30).Trim()
                            });
                            break;

                        case "008":
                            result.Add(new Evakuerdist
                            {
                                Recordtype = "008 Evakueringsdistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Evakueringskode = lines[i].Substring(32, 1),
                                Evakueringsnavn = lines[i].Substring(33, 30).Trim()
                            });
                            break;

                        case "009":
                            result.Add(new Kirkedist
                            {
                                Recordtype = "009 Kirkedistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Kirkekode = lines[i].Substring(32, 2),
                                Distriktstekst = lines[i].Substring(34, 30).Trim()
                            });
                            break;

                        case "010":
                            result.Add(new Skoledist
                            {
                                Recordtype = "010 Skoledistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Skolekode = lines[i].Substring(32, 4),
                                Distriktstekst = lines[i].Substring(36, 30).Trim()
                            });
                            break;
                            break;

                        case "011":
                            result.Add(new Befolkdist
                            {
                                Recordtype = "011 Befolkningsdistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Befolkningskode = lines[i].Substring(32, 4),
                                Distriktstekst = lines[i].Substring(36, 30).Trim()
                            });
                            break;

                        case "012":
                            result.Add(new Socialdist
                            {
                                Recordtype = "011 Socialdistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Socialkode = lines[i].Substring(32, 2),
                                Distriktstekst = lines[i].Substring(34, 30).Trim()
                            });
                            break;

                        case "013":
                            result.Add(new Sognedist
                            {
                                Recordtype = "013 Sognedistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Myndighedskode = lines[i].Substring(32, 4),
                                Myndighedsnavn = lines[i].Substring(36, 20).Trim()
                            });
                            break;

                        case "014":
                            result.Add(new Valgdist
                            {
                                Recordtype = "014 Valgdistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Valgkode = lines[i].Substring(32, 2),
                                Distriktstekst = lines[i].Substring(34, 30).Trim()
                            });
                            break;

                        case "015":
                            result.Add(new Varmedist
                            {
                                Recordtype = "015 Varmedistrikt",
                                Kommunekode = lines[i].Substring(3, 4),
                                Vejkode = lines[i].Substring(7, 4),
                                HusnummerFra = lines[i].Substring(11, 4),
                                HusnummerTil = lines[i].Substring(15, 4),
                                LigeUlige = lines[i].Substring(19, 1),
                                Ajourført = lines[i].Substring(20, 12),
                                Varmekode = lines[i].Substring(32, 4),
                                Distriktstekst = lines[i].Substring(36, 30).Trim()
                            });
                            break;

                        default:
                            break;
                    }
                }

                i++;
            }
            while (i < lines.Count() && (result.Count == 0 || (kommunekode == queryParameters.Kommunekode && vejkode == queryParameters.Vejkode)));

            if (result.Count > 0)
            {
                return Ok(result.ToArray());
            }

            return BadRequest("Ingen veje fundet");
        }

        [HttpGet]
        [Route("FindVeje")]
        public async Task<ActionResult> GetVeje([FromQuery] VejopslagQueryParameters queryParameters)
        {
            if (queryParameters.Startbogstaver == null)
            {
                return BadRequest("Angiv startbogstaver");
            }

            var filePath = @"C:\Vejregister.txt";

            ArrayList result = [];

            string[] lines = System.IO.File.ReadAllLines(filePath);

            string? recordType;
            string? vejnavn;

            foreach( var line in lines)
            {
                recordType = line.Substring(0, 3);

                if (recordType != "001") { continue; }

                vejnavn = line.Substring(71).Trim();

                if (!vejnavn.StartsWith(queryParameters.Startbogstaver, StringComparison.OrdinalIgnoreCase)) { continue; }

                result.Add(new Vejresultat
                {
                    Kommunekode = line.Substring(3, 4),
                    Vejkode = line.Substring(7, 4),
                    Vejnavn = line.Substring(71).Trim()
                });
            }

            if (result.Count > 0)
            {
                return Ok(result.ToArray());
            }

            return BadRequest("Ingen veje matcher kriterierne");
        }
    }
}
