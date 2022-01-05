using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample.Models.ViewModel.Inquiry
{
    public class ConfirmViewModel
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public List<string> InquiryTypes { get; set; }
        public string Content { get; set; }

        public ConfirmViewModel(string name, string age, string sex, List<string> inquiryTypes, string content)
        {
            Name = name;
            Age = age;
            Sex = sex;
            InquiryTypes = inquiryTypes;
            Content = content;
        }
    }
}