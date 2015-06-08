using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerationService.Services
{
    public interface IAddressGenerator
    {
        string GenerateCity();
        string GenerateState();
        string GenerateCounty();
        string GenerateZipcode();
        string GenerateCombinedZipInfo();
        string GenerateStreetNumber();
        string GenerateStreetName();
        string GenerateSubType();
        string GenerateSubNumber();
    }
}
