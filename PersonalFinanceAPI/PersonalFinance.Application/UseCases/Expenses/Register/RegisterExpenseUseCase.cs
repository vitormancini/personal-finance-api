using PersonalFinance.Domain.Commands;
using System.Net;

namespace PersonalFinance.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase
    {
        public ResultCommand<RegisterExpenseCommand> Execute(RegisterExpenseCommand request)
        {
            // Fail Fast Validation
            request.Validate();

            if (!request.Valid)
                return new ResultCommand<RegisterExpenseCommand>(HttpStatusCode.BadRequest, request.Notifications.ToList());

            return new ResultCommand<RegisterExpenseCommand>(HttpStatusCode.Created, "Registro inserido com sucesso");
        }
    }
}
