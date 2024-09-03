using System.Net;

namespace PersonalFinance.Domain.Commands
{
    public class ResultCommand<T>
    {
        public HttpStatusCode StatuCode { get; private set; }
        public T Data { get; private set; }
        public List<string> Errors { get; private set; } = new();

        // Resultado caso não ocorra nenhum erro
        public ResultCommand(HttpStatusCode statuscode, T data)
        {
            Data = data;
            StatuCode = statuscode;
        }

        public ResultCommand(HttpStatusCode statuscode, T data, List<string> errors)
        {
            Data = data;
            Errors = errors;
            StatuCode = statuscode;
        }

        // Resultado caso apenas ocorra erro
        public ResultCommand(HttpStatusCode statuscode, List<string> errors)
        {
            Errors = errors;
            StatuCode = statuscode;
        }

        public ResultCommand(HttpStatusCode statuscode, string error)
        {
            Errors.Add(error);
            StatuCode = statuscode;
        }
    }
}
