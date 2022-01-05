using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample.Models.ViewModel.Inquiry
{
    public class InputViewModel : IValidatableObject
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public List<string> InquiryTypes { get; set; }
        public string Content { get; set; }

        public InputViewModel()
        {
            InquiryTypes = new List<string>();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // バリデーション実装
            if (String.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("お名前をご入力ください", new[] { "Name" });
            }
            if (String.IsNullOrEmpty(Age))
            {
                yield return new ValidationResult("年齢をご選択ください", new[] { "Age" });
            }
            if (String.IsNullOrEmpty(Sex))
            {
                yield return new ValidationResult("性別をご選択ください", new[] { "Sex" });
            }
            if (InquiryTypes　== null || InquiryTypes.Count == 0)
            {
                yield return new ValidationResult("お問い合わせ種別をご選択ください", new[] { "InquiryTypes" });
            }

        }
    }
}