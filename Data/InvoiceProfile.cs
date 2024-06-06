using AutoMapper;

namespace AutoMapperTest.Data
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile() 
        {
            CreateMap<Invoice, InvoiceDto>();
        }
    }
}
