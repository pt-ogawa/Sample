using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.UseCases.Inquiry
{
    public interface ISendInquiryUserCase
    {
        SendInquiryResponse Handle(SendInquiryRequest request);
    }
}
