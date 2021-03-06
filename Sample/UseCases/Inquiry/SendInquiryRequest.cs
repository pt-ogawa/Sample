using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sample.Defines;

namespace Sample.UseCases.Inquiry
{
    public class SendInquiryRequest
    {
        public string Name { get; set; }
        public Defines.Age Age { get; set; }
        public Defines.Sex Sex { get; set; }
        public List<InquiryType> InquiryTypes { get; set; }
        public string Content { get; set; }

        public SendInquiryRequest(string name, Defines.Age age, Defines.Sex sex, List<InquiryType> inquiryTypes, string content)
        {
            Name = name;
            Age = age;
            Sex = sex;
            InquiryTypes = inquiryTypes;
            Content = content;
        }
    }
}