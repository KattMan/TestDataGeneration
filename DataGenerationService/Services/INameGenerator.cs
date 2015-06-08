using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerationService.Services
{
    public interface INameGenerator
    {
        string GenerateFemaleName();
        string GenerateFemaleTitle();
        string GenerateMaleName();
        string GenerateMaleTitle();
        string GenerateSurname();
        string GenerateSuffix();
        string GenerateFullName(Gender gender);
    }
}
