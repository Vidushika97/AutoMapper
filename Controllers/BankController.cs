using AutoMapper;
using AutoMapperTest.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IMapper _mapper;
        public BankController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetInvoice() 
        {
            Invoice invoiceFromDb = new Invoice()
            {
                Id = 1,
                Description = "Grocery",
                Amount = 100
            };

            //InvoiceDto invoiceDto = new InvoiceDto()
            //{
            //    Description = invoiceFromDb.Description,
            //    Amount = invoiceFromDb.Amount,
            //};
            
            //return Ok(invoiceDto);
            InvoiceDto invoiceDto = _mapper.Map<InvoiceDto>(invoiceFromDb);
            return Ok(invoiceDto);
        }

    }
}
