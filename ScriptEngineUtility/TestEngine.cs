using System;
using System.Dynamic;

namespace ScriptEngineUtility
{
    public class TestEngine
    {
        public static void Main()
        {
            //Test1 直接 return 
            Console.WriteLine("==== Test1 => retuen 100 ====");
            var test1 = Agent.Excute(@"return 100;");
            Console.WriteLine(test1);
            Console.WriteLine("");


            // Test2 直接 建立Class
            Console.WriteLine("==== Test2 => retuen dynamic  ====");

            var text = @"
                    using System;
                   
                    public class User
                    {
                       public  string Name {get;set;}
                       public  DateTime Birth {get;set;}
                    }

                    var user=new User();
                    user.Name=""許當麻"";
                    user.Birth=new DateTime(1980,6,21);
                    return user;
                    
                ";

            dynamic test2 = Agent.Excute(
              text);

            Console.WriteLine(test2.Name + "," + (test2.Birth is DateTime ? (DateTime) test2.Birth : new DateTime()).ToString());
            Console.WriteLine("");

        }
    }
}
