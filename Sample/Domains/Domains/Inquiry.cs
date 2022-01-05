using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Domains.Domains
{
    public class Inquiry
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public List<string> InquiryTypes { get; set; }
        public string Content { get; set; }

        public Inquiry(string name, string age, string sex, List<string> inquiryTypes, string content)
        {
            Name = name;
            Age = age;
            Sex = sex;
            InquiryTypes = inquiryTypes;
            Content = content;
        }
    }
}