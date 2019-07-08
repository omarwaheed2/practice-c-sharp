using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtocolBuffer.EmployeeMemDB;

namespace ProtocolBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Employee");
            Console.ReadLine();

            Employee someEmployee = new Employee(100, "John", "UX Designer");
            string empJson = Employee.ToJson(someEmployee);
            Console.WriteLine(string.Format("1 Empoyee Created id : {0} | name : {1} | title : {2} | json size : {3}, following is the Json", someEmployee.id, someEmployee.name, someEmployee.title, empJson.Length));
            Console.WriteLine(empJson);
            Employee someEmployeeRecovered = Employee.JsonToObj(empJson);
            Console.WriteLine(
                string.Format("1 Employee back to object from json id : {0} | name : {1} | title : {2}",
                someEmployeeRecovered.id, someEmployeeRecovered.name, someEmployeeRecovered.title)
            );
            Console.WriteLine("Serializing Employee using Protobuf");
            byte[] EmpProto = Employee.EmployeeProtoSerialization(someEmployee);
            Console.WriteLine(string.Format("1 Empoyee Created id : {0} | name : {1} | title : {2} | Proto size : {3}, following is the proto", someEmployee.id, someEmployee.name, someEmployee.title, EmpProto.Length));
            Console.WriteLine(Encoding.UTF8.GetString(EmpProto));
            Console.WriteLine("DeSerializing Employee from Protobuf to Employee object");
            Object someEmployeeRecoveredProto = (Employee) Employee.EmployeeProtoDeserialization(EmpProto);
            Console.ReadLine();
            Console.WriteLine(
                string.Format("1 Employee back to object from proto id : {0} | name : {1} | title : {2}",
                someEmployeeRecovered.id, someEmployeeRecovered.name, someEmployeeRecovered.title)
            );
            Console.ReadLine();

            Console.WriteLine("Starting Company");
            EmployeeMemDB.Company myCompany = new EmployeeMemDB.Company("Techn-O");
            myCompany.AddEmpoyee("Omar", "CEO");
            myCompany.AddEmpoyee("Clyde", "CTO");
            myCompany.AddEmpoyee("Bonnie", "HR Specialist");
            string compJson = EmployeeMemDB.Company.ToJson(myCompany);
            Console.WriteLine("Created a json for employees db for company");
            Console.WriteLine(compJson);
            Console.ReadLine();

        }
    }
}
