using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Sample.Defines;

namespace Sample.Models.ViewModel.Inquiry
{
    public class ConfirmViewModel
    {
        public string Name { get; set; }
        public Defines.Age Age { get; set; }
        public Defines.Sex Sex { get; set; }
        public List<InquiryType> InquiryTypes { get; set; }
        public string Content { get; set; }

        public ConfirmViewModel(string name, Defines.Age age, Defines.Sex sex, List<InquiryType> inquiryTypes, string content)
        {
            Name = name;
            Age = age;
            Sex = sex;
            InquiryTypes = inquiryTypes;
            Content = content;
        }
    }
}