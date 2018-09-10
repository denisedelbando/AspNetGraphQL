using Data.Schema;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Services
{
    public class CompanyService : ICompanyService
    {
        IList<Company> _companies;
        public CompanyService()
        {
            _companies = new List<Company>() {
                new Company() {
                    id = 1,
                    CompanyName = "Waab",
                    IsActive =  false
                },
                new Company() {
                    id = 2,
                    CompanyName = "Cedward",
                    IsActive =  false
                },
                new Company() {
                    id = 3,
                    CompanyName = "Metroz",
                    IsActive =  true
                },
                new Company() {
                    id = 4,
                    CompanyName = "Petigems",
                    IsActive =  true
                },
                new Company() {
                    id = 5,
                    CompanyName = "Sustenza",
                    IsActive =  false
                },
                new Company() {
                    id = 6,
                    CompanyName = "Emtrac",
                    IsActive =  true
                },
                new Company() {
                    id = 7,
                    CompanyName = "Newcube",
                    IsActive =  false
                },
                new Company() {
                    id = 8,
                    CompanyName = "Balooba",
                    IsActive =  false
                },
                new Company() {
                    id = 9,
                    CompanyName = "Extragen",
                    IsActive =  true
                },
                new Company() {
                    id = 10,
                    CompanyName = "Fortean",
                    IsActive =  false
                },
                new Company() {
                    id = 11,
                    CompanyName = "Paragonia",
                    IsActive =  false
                },
                new Company() {
                    id = 12,
                    CompanyName = "Aquazure",
                    IsActive =  true
                },
                new Company() {
                    id = 13,
                    CompanyName = "Zeam",
                    IsActive =  true
                },
                new Company() {
                    id = 14,
                    CompanyName = "Ronbert",
                    IsActive =  false
                },
                new Company() {
                    id = 15,
                    CompanyName = "Kidgrease",
                    IsActive =  false
                },
                new Company() {
                    id = 16,
                    CompanyName = "Lyrichord",
                    IsActive =  true
                },
                new Company() {
                    id = 17,
                    CompanyName = "Telequiet",
                    IsActive =  true
                },
                new Company() {
                    id = 18,
                    CompanyName = "Terrasys",
                    IsActive =  false
                },
                new Company() {
                    id = 19,
                    CompanyName = "Hawkster",
                    IsActive =  false
                },
                new Company() {
                    id = 20,
                    CompanyName = "Flotonic",
                    IsActive =  true
                },
                new Company() {
                    id = 21,
                    CompanyName = "Poochies",
                    IsActive =  true
                },
                new Company() {
                    id = 22,
                    CompanyName = "Radiantix",
                    IsActive =  false
                },
                new Company() {
                    id = 23,
                    CompanyName = "Zanilla",
                    IsActive =  false
                },
                new Company() {
                    id = 24,
                    CompanyName = "Applidec",
                    IsActive =  false
                },
                new Company() {
                    id = 25,
                    CompanyName = "Polaria",
                    IsActive =  false
                },
                new Company() {
                    id = 26,
                    CompanyName = "Recritube",
                    IsActive =  false
                },
                new Company() {
                    id = 27,
                    CompanyName = "Myopium",
                    IsActive =  false
                },
                new Company() {
                    id = 28,
                    CompanyName = "Klugger",
                    IsActive =  true
                },
                new Company() {
                    id = 29,
                    CompanyName = "Motovate",
                    IsActive =  false
                },
                new Company() {
                    id = 30,
                    CompanyName = "Bluplanet",
                    IsActive =  true
                },
                new Company() {
                    id = 31,
                    CompanyName = "Kog",
                    IsActive =  true
                },
                new Company() {
                    id = 32,
                    CompanyName = "Panzent",
                    IsActive =  true
                },
                new Company() {
                    id = 33,
                    CompanyName = "Buzzness",
                    IsActive =  false
                },
                new Company() {
                    id = 34,
                    CompanyName = "Ceprene",
                    IsActive =  false
                },
                new Company() {
                    id = 35,
                    CompanyName = "Hydrocom",
                    IsActive =  false
                },
                new Company() {
                    id = 36,
                    CompanyName = "Kiggle",
                    IsActive =  true
                },
                new Company() {
                    id = 37,
                    CompanyName = "Geekular",
                    IsActive =  false
                },
                new Company() {
                    id = 38,
                    CompanyName = "Insuresys",
                    IsActive =  false
                },
                new Company() {
                    id = 39,
                    CompanyName = "Nebulean",
                    IsActive =  false
                },
                new Company() {
                    id = 40,
                    CompanyName = "Musanpoly",
                    IsActive =  false
                },
                new Company() {
                    id = 41,
                    CompanyName = "Hopeli",
                    IsActive =  false
                },
                new Company() {
                    id = 42,
                    CompanyName = "Opticall",
                    IsActive =  false
                },
                new Company() {
                    id = 43,
                    CompanyName = "Keeg",
                    IsActive =  false
                },
                new Company() {
                    id = 44,
                    CompanyName = "Xerex",
                    IsActive =  true
                },
                new Company() {
                    id = 45,
                    CompanyName = "Tropoli",
                    IsActive =  false
                },
                new Company() {
                    id = 46,
                    CompanyName = "Franscene",
                    IsActive =  false
                },
                new Company() {
                    id = 47,
                    CompanyName = "Pharmex",
                    IsActive =  true
                },
                new Company() {
                    id = 48,
                    CompanyName = "Edecine",
                    IsActive =  true
                },
                new Company() {
                    id = 49,
                    CompanyName = "Moreganic",
                    IsActive =  false
                },
                new Company() {
                    id = 50,
                    CompanyName = "Flumbo",
                    IsActive =  false
                },
                new Company() {
                    id = 51,
                    CompanyName = "Zolar",
                    IsActive =  true
                },
                new Company() {
                    id = 52,
                    CompanyName = "Caxt",
                    IsActive =  true
                },
                new Company() {
                    id = 53,
                    CompanyName = "Kozgene",
                    IsActive =  false
                },
                new Company() {
                    id = 54,
                    CompanyName = "Collaire",
                    IsActive =  true
                },
                new Company() {
                    id = 55,
                    CompanyName = "Vortexaco",
                    IsActive =  false
                },
                new Company() {
                    id = 56,
                    CompanyName = "Surelogic",
                    IsActive =  true
                },
                new Company() {
                    id = 57,
                    CompanyName = "Jamnation",
                    IsActive =  false
                },
                new Company() {
                    id = 58,
                    CompanyName = "Signidyne",
                    IsActive =  true
                },
                new Company() {
                    id = 59,
                    CompanyName = "Konnect",
                    IsActive =  false
                },
                new Company() {
                    id = 60,
                    CompanyName = "Calcula",
                    IsActive =  true
                },
                new Company() {
                    id = 61,
                    CompanyName = "Earwax",
                    IsActive =  true
                },
                new Company() {
                    id = 62,
                    CompanyName = "Frenex",
                    IsActive =  false
                },
                new Company() {
                    id = 63,
                    CompanyName = "Isologica",
                    IsActive =  true
                },
                new Company() {
                    id = 64,
                    CompanyName = "Evidends",
                    IsActive =  false
                },
                new Company() {
                    id = 65,
                    CompanyName = "Inrt",
                    IsActive =  false
                },
                new Company() {
                    id = 66,
                    CompanyName = "Hotcakes",
                    IsActive =  true
                },
                new Company() {
                    id = 67,
                    CompanyName = "Genmy",
                    IsActive =  true
                },
                new Company() {
                    id = 68,
                    CompanyName = "Sunclipse",
                    IsActive =  true
                },
                new Company() {
                    id = 69,
                    CompanyName = "Scenty",
                    IsActive =  true
                },
                new Company() {
                    id = 70,
                    CompanyName = "Omatom",
                    IsActive =  true
                }

            };
        }

        public Company GetCompanyById(int id)
        {
            return GetCompanyByIdAsync(id).Result;
        }

        public Task<Company> GetCompanyByIdAsync(int id)
        {
            return Task.FromResult(_companies.Single(xx => Equals(xx.id, id)));
        }

        public Task<PageInfo<Company>> GetCompanysAsync(int page, int size, string q = "")
        {
            IEnumerable<Company> filtered;
            if (!string.IsNullOrEmpty(q)) {
                filtered = _companies.Where(xx => xx.CompanyName.ToUpper().Contains(q.ToUpper()));
            }
            else{
                filtered = _companies;
            }
            PageInfo<Company> comp = new PageInfo<Company>(filtered, page, size);
            comp.Chars = filtered.Select(xx => xx.CompanyName.ToUpper().Remove(1)).OrderBy(xx => xx).Distinct(); 
            return Task.FromResult(comp);
        }


    }

    public interface ICompanyService
    {
        Company GetCompanyById(int id);
        Task<Company> GetCompanyByIdAsync(int id);
        Task<PageInfo<Company>> GetCompanysAsync(int page, int size, string q = "");
    }
}
