using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FluencyCSharp
{
    public static class CSharpExtension
    {
        public static T AppendTo<T>(this T item, ICollection<T> collections) {
            collections.Add(item);
            return item;
            
            
        }

        

       

        public static void SaveToXml<T>(this T obj, string file) where T:new()  {
            XmlSerializer xs = new XmlSerializer(obj.GetType());
            using (var fs = new FileStream(file, FileMode.Create)) {
                xs.Serialize(fs, obj);
            }
        }
    }
}
