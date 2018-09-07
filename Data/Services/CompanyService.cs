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
                    ID = 1,
                    CompanyName = "Waab",
                    isActive = false
                },
                new Company() {
                    ID = 2,
                    CompanyName = "Cedward",
                    isActive = false
                },
                new Company() {
                    ID = 3,
                    CompanyName = "Metroz",
                    isActive = true
                },
                new Company() {
                    ID = 4,
                    CompanyName = "Petigems",
                    isActive = true
                },
                new Company() {
                    ID = 5,
                    CompanyName = "Sustenza",
                    isActive = false
                },
                new Company() {
                    ID = 6,
                    CompanyName = "Emtrac",
                    isActive = true
                },
                new Company() {
                    ID = 7,
                    CompanyName = "Newcube",
                    isActive = false
                },
                new Company() {
                    ID = 8,
                    CompanyName = "Balooba",
                    isActive = false
                },
                new Company() {
                    ID = 9,
                    CompanyName = "Extragen",
                    isActive = true
                },
                new Company() {
                    ID = 10,
                    CompanyName = "Fortean",
                    isActive = false
                },
                new Company() {
                    ID = 11,
                    CompanyName = "Paragonia",
                    isActive = false
                },
                new Company() {
                    ID = 12,
                    CompanyName = "Aquazure",
                    isActive = true
                },
                new Company() {
                    ID = 13,
                    CompanyName = "Zeam",
                    isActive = true
                },
                new Company() {
                    ID = 14,
                    CompanyName = "Ronbert",
                    isActive = false
                },
                new Company() {
                    ID = 15,
                    CompanyName = "Kidgrease",
                    isActive = false
                },
                new Company() {
                    ID = 16,
                    CompanyName = "Lyrichord",
                    isActive = true
                },
                new Company() {
                    ID = 17,
                    CompanyName = "Telequiet",
                    isActive = true
                },
                new Company() {
                    ID = 18,
                    CompanyName = "Terrasys",
                    isActive = false
                },
                new Company() {
                    ID = 19,
                    CompanyName = "Hawkster",
                    isActive = false
                },
                new Company() {
                    ID = 20,
                    CompanyName = "Flotonic",
                    isActive = true
                },
                new Company() {
                    ID = 21,
                    CompanyName = "Poochies",
                    isActive = true
                },
                new Company() {
                    ID = 22,
                    CompanyName = "Radiantix",
                    isActive = false
                },
                new Company() {
                    ID = 23,
                    CompanyName = "Zanilla",
                    isActive = false
                },
                new Company() {
                    ID = 24,
                    CompanyName = "Applidec",
                    isActive = false
                },
                new Company() {
                    ID = 25,
                    CompanyName = "Polaria",
                    isActive = false
                },
                new Company() {
                    ID = 26,
                    CompanyName = "Recritube",
                    isActive = false
                },
                new Company() {
                    ID = 27,
                    CompanyName = "Myopium",
                    isActive = false
                },
                new Company() {
                    ID = 28,
                    CompanyName = "Klugger",
                    isActive = true
                },
                new Company() {
                    ID = 29,
                    CompanyName = "Motovate",
                    isActive = false
                },
                new Company() {
                    ID = 30,
                    CompanyName = "Bluplanet",
                    isActive = true
                },
                new Company() {
                    ID = 31,
                    CompanyName = "Kog",
                    isActive = true
                },
                new Company() {
                    ID = 32,
                    CompanyName = "Panzent",
                    isActive = true
                },
                new Company() {
                    ID = 33,
                    CompanyName = "Buzzness",
                    isActive = false
                },
                new Company() {
                    ID = 34,
                    CompanyName = "Ceprene",
                    isActive = false
                },
                new Company() {
                    ID = 35,
                    CompanyName = "Hydrocom",
                    isActive = false
                },
                new Company() {
                    ID = 36,
                    CompanyName = "Kiggle",
                    isActive = true
                },
                new Company() {
                    ID = 37,
                    CompanyName = "Geekular",
                    isActive = false
                },
                new Company() {
                    ID = 38,
                    CompanyName = "Insuresys",
                    isActive = false
                },
                new Company() {
                    ID = 39,
                    CompanyName = "Nebulean",
                    isActive = false
                },
                new Company() {
                    ID = 40,
                    CompanyName = "Musanpoly",
                    isActive = false
                },
                new Company() {
                    ID = 41,
                    CompanyName = "Hopeli",
                    isActive = false
                },
                new Company() {
                    ID = 42,
                    CompanyName = "Opticall",
                    isActive = false
                },
                new Company() {
                    ID = 43,
                    CompanyName = "Keeg",
                    isActive = false
                },
                new Company() {
                    ID = 44,
                    CompanyName = "Xerex",
                    isActive = true
                },
                new Company() {
                    ID = 45,
                    CompanyName = "Tropoli",
                    isActive = false
                },
                new Company() {
                    ID = 46,
                    CompanyName = "Franscene",
                    isActive = false
                },
                new Company() {
                    ID = 47,
                    CompanyName = "Pharmex",
                    isActive = true
                },
                new Company() {
                    ID = 48,
                    CompanyName = "Edecine",
                    isActive = true
                },
                new Company() {
                    ID = 49,
                    CompanyName = "Moreganic",
                    isActive = false
                },
                new Company() {
                    ID = 50,
                    CompanyName = "Flumbo",
                    isActive = false
                },
                new Company() {
                    ID = 51,
                    CompanyName = "Zolar",
                    isActive = true
                },
                new Company() {
                    ID = 52,
                    CompanyName = "Caxt",
                    isActive = true
                },
                new Company() {
                    ID = 53,
                    CompanyName = "Kozgene",
                    isActive = false
                },
                new Company() {
                    ID = 54,
                    CompanyName = "Collaire",
                    isActive = true
                },
                new Company() {
                    ID = 55,
                    CompanyName = "Vortexaco",
                    isActive = false
                },
                new Company() {
                    ID = 56,
                    CompanyName = "Surelogic",
                    isActive = true
                },
                new Company() {
                    ID = 57,
                    CompanyName = "Jamnation",
                    isActive = false
                },
                new Company() {
                    ID = 58,
                    CompanyName = "Signidyne",
                    isActive = true
                },
                new Company() {
                    ID = 59,
                    CompanyName = "Konnect",
                    isActive = false
                },
                new Company() {
                    ID = 60,
                    CompanyName = "Calcula",
                    isActive = true
                },
                new Company() {
                    ID = 61,
                    CompanyName = "Earwax",
                    isActive = true
                },
                new Company() {
                    ID = 62,
                    CompanyName = "Frenex",
                    isActive = false
                },
                new Company() {
                    ID = 63,
                    CompanyName = "Isologica",
                    isActive = true
                },
                new Company() {
                    ID = 64,
                    CompanyName = "Evidends",
                    isActive = false
                },
                new Company() {
                    ID = 65,
                    CompanyName = "Inrt",
                    isActive = false
                },
                new Company() {
                    ID = 66,
                    CompanyName = "Hotcakes",
                    isActive = true
                },
                new Company() {
                    ID = 67,
                    CompanyName = "Genmy",
                    isActive = true
                },
                new Company() {
                    ID = 68,
                    CompanyName = "Sunclipse",
                    isActive = true
                },
                new Company() {
                    ID = 69,
                    CompanyName = "Scenty",
                    isActive = true
                },
                new Company() {
                    ID = 70,
                    CompanyName = "Omatom",
                    isActive = true
                }

            };
        }

        public Company GetCompanyById(int id)
        {
            return GetCompanyByIdAsync(id).Result;
        }

        public Task<Company> GetCompanyByIdAsync(int id)
        {
            return Task.FromResult(_companies.Single(xx => Equals(xx.ID, id)));
        }

        public Task<IEnumerable<Company>> GetCompanysAsync()
        {
            return Task.FromResult(_companies.AsEnumerable());
        }


    }

    public interface ICompanyService
    {
        Company GetCompanyById(int id);
        Task<Company> GetCompanyByIdAsync(int id);
        Task<IEnumerable<Company>> GetCompanysAsync();
    }
}
