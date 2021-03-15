using Newtonsoft.Json;
using System.IO;

namespace nvan.FdsFfA320McduConnector.Config
{
    public class JsonWriter<T>
    {
        private string file;

        public JsonWriter(string file)
        {
            this.file = file;
        }

        public void WriteFile(T obj)
        {
            File.WriteAllText(file, JsonConvert.SerializeObject(obj));
        }
    }
}
