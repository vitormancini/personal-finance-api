using Microsoft.AspNetCore.Mvc;
using PersonalFinance.Application.UseCases.Expenses.Register;
using PersonalFinance.Domain.Commands;

namespace PersonalFinance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RegisterExpenseCommand request)
        {
            var useCase = new RegisterExpenseUseCase();
            var response = useCase.Execute(request);

            return Ok(response);
        }
    }
}
