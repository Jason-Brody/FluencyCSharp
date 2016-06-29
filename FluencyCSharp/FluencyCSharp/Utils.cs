using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FluencyCSharp
{
    public static class Utils
    {
        public static T GetObjFromXml<T>(string file) where T:new() {
            if (!File.Exists(file))
                return new T();

            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(file, FileMode.Open)) {
                return (T)xs.Deserialize(fs);
            }


        }
    }
}
