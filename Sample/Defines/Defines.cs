using System.ComponentModel.DataAnnotations;
using Sample.Defines;

namespace Sample.Defines
{
    public enum Sex
    {
        [Label("未選択")]
        Unselected = 99,
        [Label("男性")]
        Man = 0,
        [Label("女性")]
        Woman = 1
    }

    public enum InquiryType
    {
        [Label("未選択")]
        Unselected = 99,
        [Label("販売前の商品の問い合わせ")]
        BeforeSaleProduct = 0,
        [Label("販売中の商品のお問い合わせ")]
        OnSaleProduct = 1,
        [Label("商品の故障について")]
        AboutProductFailure = 2
    }

    public enum Age
    {
        [Display(Name = "選択してください")]
        [Label("選択してください")]
        Unselected = 99,
        [Display(Name = "10代")]
        [Label("10代")]
        Teens,
        [Display(Name = "20代")]
        [Label("20代")]
        Twenties,
        [Display(Name = "30代")]
        [Label("30代")]
        Thirties,
        [Display(Name = "40代")]
        [Label("40代")]
        Forties
    }
}