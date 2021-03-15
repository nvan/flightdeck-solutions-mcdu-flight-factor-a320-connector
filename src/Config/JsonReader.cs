using Newtonsoft.Json;
using System.IO;

namespace nvan.FdsFfA320McduConnector.Config
{
    public class JsonReader<T>
    {
        private string file;

        public JsonReader(string file) {
            this.file = file;
        }

        public string GetFile()
        {
            return file;
        }

        public T ReadFile()
        {
            string json = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
