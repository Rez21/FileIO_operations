using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Operations
{
    internal class JSONSerialization
    {
        public void JsonSerialize()
        {
            BlogSite blogsite = new BlogSite()
            {
                ApplicationName = "Prasad",
                ApplicationId = 298
            };
            string jsonData = JsonConvert.SerializeObject(blogsite);
            Console.WriteLine(jsonData);
        }

        public void JsonDeSerialize()
        {
            string json = @"{
                'ApplicationName':'Prasad',
                'ApplicationId': 298
            }";
            BlogSite blogsite = JsonConvert.DeserializeObject<BlogSite>(json);
            Console.WriteLine("Applicant Name: " + blogsite.ApplicationName + "\n" + "Applicant ID: " + blogsite.ApplicationId);
        }

    }


    [DataContract]
    class BlogSite
    {
        [DataMember]
        public string ApplicationName { get; set; }
        [DataMember]
        public int ApplicationId { get; set; }
    }
}
}
