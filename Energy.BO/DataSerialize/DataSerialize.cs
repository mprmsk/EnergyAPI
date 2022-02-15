using EnergyAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAPI.Energy.BO.DataSerialize
{
    public class DataSerialize : IDataSerialize
    {
        public List<EnergyModel> DataSerializeFromJson(string path, EnergyModel model)
        {
            StreamReader reader = new StreamReader(path);
            return JsonConvert.DeserializeObject<List<EnergyModel>>(reader.ReadToEnd());
        }

        public void DataSerializetoJson(string path, EnergyModel model)
        {
            TextWriter writer;
            using (writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine(JsonConvert.SerializeObject(model));
            }
        }
    }
}
