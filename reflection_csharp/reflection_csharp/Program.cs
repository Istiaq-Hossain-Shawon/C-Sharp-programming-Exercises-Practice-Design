using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection_csharp
{
    static class Methods
    {
        public static void Inform(string parameter)
        {
            Console.WriteLine("Inform:parameter={0}", parameter);
        }
    }
    public class Customer{
        public Customer(){

        }
        public bool Validate(Customer customerObj){
            return true;
        }
        public int Id{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string Address{get; set;}
        public static int Height;
        public static int Width;
        public static int Weight;
    }
class Program
    {
        

        public static void Main()
        {

            Type type = typeof(Customer);

            PropertyInfo[] propertyInfo = type.GetProperties();

            Console.WriteLine("The list of properties of the Customer class are:--");

            foreach (PropertyInfo pInfo in propertyInfo)
            {

                Console.WriteLine(pInfo.Name);

            }


            Type type2 = typeof(Customer);

            ConstructorInfo[] constructorInfo = type2.GetConstructors();

            Console.WriteLine("The Customer class contains the following Constructors:--");

            foreach (ConstructorInfo c in constructorInfo)

            {

                Console.WriteLine(c);

            }



            Type type3 = typeof(Customer);

            MethodInfo[] methodInfo = type3.GetMethods();

            Console.WriteLine("The methods of the Customer class are:--");

            foreach (MethodInfo temp in methodInfo)
            {
                Console.WriteLine(temp.Name);
            }


            Console.WriteLine("The fields of the Customer class are:--");

            Type type4 = typeof(Customer);

            FieldInfo[] fields = type4.GetFields();
            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
            }

            //// Name of the method we want to call.
            //string name = "Inform";

            //// Call it with each of these parameters.
            //string[] parameters = { "Sam", "Perls" };

            //// Get MethodInfo.
            //Type type = typeof(Methods);
            //MethodInfo info = type.GetMethod(name);

            //// Loop over parameters.
            //foreach (string parameter in parameters)
            //{
            //    info.Invoke(null, new object[] { parameter });
            //}


            //////////////////
            //Type t = typeof(System.String);
            //Console.WriteLine(t.Assembly);
            //Console.ReadKey();
            //int a = 20;
            //Type type = a.GetType();
            //Console.WriteLine(type.Assembly);
            //Console.WriteLine(type);
            //Console.WriteLine(type.FullName);
            //Console.WriteLine(type.IsClass);
            //Console.WriteLine(type.BaseType);
            //Console.WriteLine(type.IsEnum);
            //Console.WriteLine(type.IsInterface);

            //Type type = typeof(System.String);
            //ConstructorInfo[] cons = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            //foreach (ConstructorInfo data in cons)
            //{
            //    Console.WriteLine(data);
            //}
            //MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            //foreach (MethodInfo data in methods)
            //{
            //    Console.WriteLine(data);
            //}

            //FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
            //foreach (FieldInfo data in fields)
            //{
            //    Console.WriteLine(data);
            //}
            Console.ReadKey();
        }
    }
}
