using Ninject;
using Sample.Domains.Domains;
using Sample.Repositories.Inquiry;
using Sample.UseCases.Inquiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domains.Applications
{
    public class SendInquiryInterractor : ISendInquiryUserCase
    {
        [Inject]
        public IInquiryRepository InquiryRepository { private get; set; }

        //public SendInquiryInterractor(IInquiryRepository inquiryRepository)
        //{
        //    InquiryRepository = inquiryRepository;
        //}

        public SendInquiryResponse Handle(SendInquiryRequest request)
        {
            var inquiry = new Inquiry(request.Name, request.Age, request.Sex, request.InquiryTypes, request.Content);

            InquiryRepository.Save(inquiry);
            SendInquiryResponse response = new SendInquiryResponse();

            return response;
        }
    }
}
