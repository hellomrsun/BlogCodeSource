﻿using System.Runtime.Serialization;

namespace WcfSoapWebService
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}