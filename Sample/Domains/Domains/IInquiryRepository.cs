using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Domains.Domains
{
    public interface IInquiryRepository
    {
        void Save(Inquiry inquiry);
    }
}