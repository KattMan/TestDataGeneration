using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerationService.Repositories
{
    public interface IAddressRepository
    {
        List<string> GetAdjectives();
        List<string> GetNouns();
        List<string> GetStreetTypes();
        List<string> GetSubTypes();
        List<string> GetZipCodeInfo();
    }
}
