using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sol_Demo.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember(EmitDefaultValue = false)]
        public String FirstName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public String LastName { get; set; }
    }
}