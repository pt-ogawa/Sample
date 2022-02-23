using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Sample.Defines;

namespace Sample.Models.ViewModel.Inquiry
{
    public class InputViewModel : IValidatableObject
    {
        public string Name { get; set; }
        public Defines.Sex Sex { get; set; }
        public List<InquiryType> InquiryTypes { get; set; }
        public string Content { get; set; }

        public Defines.Age Age { get; set; }

        public InputViewModel()
        {
            Sex = Defines.Sex.Unselected;
            Age = Defines.Age.Unselected;
            InquiryTypes = new List<InquiryType>();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("お名前をご入力ください", new[] { "Name" });
            }
            if (Age == Defines.Age.Unselected || !Enum.IsDefined(typeof(Defines.Age), Age))
            {
                yield return new ValidationResult("年齢をご選択ください", new[] { "Age" });
            }
            if (Sex == Defines.Sex.Unselected || !Enum.IsDefined(typeof(Defines.Sex), Sex))
            {
                yield return new ValidationResult("性別をご選択ください", new[] { "Sex" });
            }
            if (InquiryTypes.Count == 0)
            {
                yield return new ValidationResult("お問い合わせ種別をご選択ください", new[] { "InquiryTypes" });
            }

        }
    }
}