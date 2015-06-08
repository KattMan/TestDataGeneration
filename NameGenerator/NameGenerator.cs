using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerationService.Services;
using DataGenerationService.Repositories;

namespace NameGenerator
{
    public class NameGenerator: INameGenerator 
    {
        private INameRepository _nameRepository;
        private Random r = new Random();

        public NameGenerator(INameRepository nameRepository)
        {
            _nameRepository = nameRepository;
        }

        public string GenerateFemaleName()
        {
            var names = _nameRepository.GetFemaleNames();
            return names[r.Next(0, names.Count)];
        }

        public string GenerateFemaleTitle()
        {
            var names = _nameRepository.GetFemaleTitles();
            names.AddRange(_nameRepository.GetTitles());
            return names[r.Next(0, names.Count)];
        }

        public string GenerateMaleName()
        {
            var names = _nameRepository.GetMaleNames();
            return names[r.Next(0, names.Count)];
        }

        public string GenerateMaleTitle()
        {
            var names = _nameRepository.GetMaleTitles();
            names.AddRange(_nameRepository.GetTitles());
            return names[r.Next(0, names.Count)];
        }

        public string GenerateSurname()
        {
            var names = _nameRepository.GetSurnames();
            return names[r.Next(0, names.Count)];
        }

        public string GenerateSuffix()
        {
            var names = _nameRepository.GetSuffixes();
            return names[r.Next(0, names.Count)];
        }

        public string GenerateFullName(Gender gender)
        {
            var title = string.Empty;
            var firstName = string.Empty;
            var middleName = string.Empty;

            switch(gender)
            {
                case Gender.Female:
                    title = GenerateFemaleTitle();
                    firstName = GenerateFemaleName();
                    middleName = GenerateFemaleName();
                    break;
                case Gender.Male:
                    title = GenerateMaleTitle();
                    firstName = GenerateMaleName();
                    middleName = GenerateMaleName();
                    break;
            }
            var lastName = GenerateSurname();
            var suffix = GenerateSuffix();

            return string.Format("{0} {1} {2} {3} {4}", title, firstName, middleName, lastName, suffix);
        }
    }
}
