using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProtoBuf;
using System.IO;

namespace ProtocolBuffer.EmployeeMemDB
{
    [ProtoContract(SkipConstructor = true)]
    class Employee
    {
        [JsonProperty, ProtoMember(1)]
        internal short id { get; set; }
        [JsonProperty, ProtoMember(2)]
        internal string name { get; set; }
        [JsonProperty, ProtoMember(3)]
        internal string title { get; set; }

        public Employee(short id, string name, string title)
        {
            this.id = id;
            this.name = name;
            /* This is for testing space benchmarks
             * for (int i = 0; i < 0; i++) {
                this.name += this.name;
            }
            */
            this.title = title;
        }

        public static string ToJson(Employee emp)
        {
            return JsonConvert.SerializeObject(emp);
        }

        public static Employee JsonToObj(string json)
        {
            return JsonConvert.DeserializeObject<Employee>(json);
        }

        public static byte[] EmployeeProtoSerialization(object obj)
        {
            if (obj == null)
                return null;

            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    Serializer.Serialize(stream, obj);
                    return stream.ToArray();
                }
            }
            catch
            {
                throw;
            }
        }

        public static object EmployeeProtoDeserialization(byte[] protoEmp)
        {
            if (protoEmp == null)
                return null;

            try
            {
                using (MemoryStream stream = new MemoryStream(protoEmp))
                {
                    return Serializer.Deserialize(typeof(Employee), stream);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
