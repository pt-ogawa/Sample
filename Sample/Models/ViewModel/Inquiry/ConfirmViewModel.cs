using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample.Models.ViewModel.Inquiry
{
    public class ConfirmViewModel : IValidatableObject
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //入力パスワードと検証用パスワードが異なるかを検証する
            //if (!Password.Equals(ValidatePassword))
            //{
            //    //エラー内容を返却する
            yield return new ValidationResult("Password is not match.", new[] { "ValidatePassword" });
            //}
        }
    }
}