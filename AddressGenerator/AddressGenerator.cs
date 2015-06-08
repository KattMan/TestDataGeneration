using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataGenerationService.Repositories;
using DataGenerationService.Services;

namespace AddressGenerator
{
    public class AddressGenerator: IAddressGenerator
    {
        private IAddressRepository _repository;
        private Random r = new Random();

        public AddressGenerator(IAddressRepository repository)
        {
            _repository = repository;
        }

        public string GenerateCity()
        {
            var items = _repository.GetZipCodeInfo();
            var item = items[r.Next(0, items.Count)].Split(',');

            return item[1].Trim();

        }

        public string GenerateState()
        {
            var items = _repository.GetZipCodeInfo();
            var item = items[r.Next(0, items.Count)].Split(',');

            return item[2].Trim();
        }

        public string GenerateCounty()
        {
            var items = _repository.GetZipCodeInfo();
            var item = items[r.Next(0, items.Count)].Split(',');

            return item[3].Trim();
        }

        public string GenerateZipcode()
        {
            var items = _repository.GetZipCodeInfo();
            var item = items[r.Next(0, items.Count)].Split(',');

            return item[0].Trim();
        }

        public string GenerateCombinedZipInfo()
        {
            var items = _repository.GetZipCodeInfo();
            var item = items[r.Next(0, items.Count)].Split(',');

            return string.Format("{0}\r\n{1}, {2} {3}", item[3].Trim(), item[1].Trim(), item[2].Trim(), item[0].Trim());
        }

        public string GenerateStreetNumber()
        {
            return r.Next(0, 10000).ToString();
        }

        public string GenerateStreetName()
        {
            var adjectives = _repository.GetAdjectives();
            var nouns = _repository.GetNouns();
            var types = _repository.GetStreetTypes();

            return string.Format("{0} {1} {2}"
                , adjectives[r.Next(0, adjectives.Count)]
                , nouns[r.Next(0, nouns.Count)]
                , types[r.Next(0, types.Count)]
                );
        }

        public string GenerateSubType()
        {
            var items = _repository.GetSubTypes();
            return items[r.Next(0, items.Count)];
        }

        public string GenerateSubNumber()
        {
            return r.Next(0, 100).ToString();
        }

    }
}
