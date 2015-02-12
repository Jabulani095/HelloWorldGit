using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;
using HelloWorld.BusinessLogic;
using ServiceStack.OrmLite;

namespace ServiceInterface.HelloWorld
{
    public class HelloService : Service
    {

        public object Any(Hello request)
        {
            if (!string.IsNullOrEmpty(request.Name)) { 
            string name = request.Name;
            if (name[0].ToString().Equals("A", StringComparison.OrdinalIgnoreCase))
            {
                return new HelloResponse { Result = "Hello, " + name + "  Welcome Back" };
            }
            else
            {
                return new HelloResponse { Result = "Hello, " + name};
            }

            }
            else
            {
                return new HelloResponse { Result = "Hello, " + "World!" };
            }
        }
    }
}
