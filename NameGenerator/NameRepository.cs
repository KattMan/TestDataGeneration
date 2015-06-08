using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerationService.Repositories;

using System.Reflection;

namespace NameGenerator
{
    public class NameRepository : INameRepository
    {
        public List<string> GetMaleNames()
        {
            return LoadList("MaleNames");
        }

        public List<string> GetFemaleNames()
        {
            return LoadList("FemaleNames");
        }

        public List<string> GetSurnames()
        {
            return LoadList("Surnames");
        }

        public List<string> GetMaleTitles()
        {
            return LoadList("MaleTitles");
        }

        public List<string> GetFemaleTitles()
        {
            return LoadList("FemaleTitles");
        }

        public List<string> GetTitles()
        {
            return LoadList("GenericTitles");
        }

        public List<string> GetSuffixes()
        {
            return LoadList("Suffixes");
        }

        private List<string> LoadList(string listToLoad)
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var localNamespace = executingAssembly.GetName().Name;
            var resourceName = string.Format("{0}.Data.{1}.txt", localNamespace, listToLoad);
            var dataList = new List<string>();

            using (var stream = executingAssembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            dataList.Add(reader.ReadLine());
                        }
                    }
                }
            }

            return dataList;

        }
    }
}
