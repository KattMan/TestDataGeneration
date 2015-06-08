using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerationService.Repositories
{
    public interface INameRepository
    {
        List<string> GetMaleNames();
        List<string> GetFemaleNames();
        List<string> GetSurnames();
        List<string> GetMaleTitles();
        List<string> GetFemaleTitles();
        List<string> GetTitles();
        List<string> GetSuffixes();
    }
}
