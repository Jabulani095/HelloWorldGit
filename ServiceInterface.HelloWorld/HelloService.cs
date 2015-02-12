using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;
using HelloWorld.BusinessLogic;
using ServiceStack.OrmLite;

namespace ServiceInterface.HelloWorld
{
    public class HelloService : Service, IHelloService
    {

        public object Any(Hello request)
        {
            if (!string.IsNullOrEmpty(request.Name)) { 
            string name = request.Name;
            if (name[0].ToString().Equals("A", StringComparison.OrdinalIgnoreCase))
            {
                return new HelloResponse { Hello = new Hello{Name = name, Result = string.Format("Hello {0} Welcome Back",name),TimeStamp = DateTime.Now}};
            }
            else
            {
                return new HelloResponse { Hello = new Hello { Name = name, Result = string.Format("Hello {0}", name), TimeStamp = DateTime.Now } };
            }

            }
            else
            {
                return new HelloResponse { Hello = new Hello { Name = "World!", Result = "Hello World!", TimeStamp = DateTime.Now } };
            }
        }
    }
}
