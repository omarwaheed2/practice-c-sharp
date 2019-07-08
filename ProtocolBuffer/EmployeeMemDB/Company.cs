using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProtocolBuffer.EmployeeMemDB
{

    class Company
    {
        [JsonProperty]
        internal IDictionary<short, EmployeeMemDB.Employee> employees;
        [JsonProperty]
        internal string companyName;
        short currentId;

        public Company(string companyName)
        {
            this.companyName = companyName;
            employees = new Dictionary<short, EmployeeMemDB.Employee>();
            currentId = 1;
        }

        public void AddEmpoyee(string name, string title)
        {
            Employee newEmp = new Employee(currentId, name, title);
            employees.Add(currentId, newEmp);
            currentId++;
        }

        public void RemoveEmployee(short id)
        {
            if (!employees.Remove(id))
            {
                Console.WriteLine(string.Format("Failed to remove employee with ID : {0} Error : Does not exist", id));
            }
            else
            {
                Console.WriteLine(string.Format("Employee id:{0} has been removed from the system", id));
            }
        }

        public static string ToJson(Company companyDB)
        {
            return JsonConvert.SerializeObject(companyDB);
        }

        public static Company JsonToObj(string json)
        {
            return JsonConvert.DeserializeObject<Company>(json);
        }
    }
}
