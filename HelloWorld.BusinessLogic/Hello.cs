using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ServiceStack;

namespace HelloWorld.BusinessLogic
{
    [DataContract]
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime TimeStamp { get; set; }
    }

    [DataContract]
    public class HelloResponse
    {
        [DataMember]
        public string Result { get; set; }
    }
}
