using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Enums;
using PersonalFinance.Exception;

namespace PersonalFinance.Domain.Commands
{
    public class RegisterExpenseCommand : Entity, ICommand
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime InsertDate { get; set; }
        public decimal Amount { get; set; }
        public EPaymentType PaymentType { get; set; }

        public void Validate()
        {
            if (String.IsNullOrEmpty(Title))
                AddNotification(ResourceNotifications.NOT_EMPTY_TITLE);

            if (Title.Length < 3)
                AddNotification(ResourceNotifications.MORE_THAN_3_LETTERS);

            if (String.IsNullOrEmpty(Description))
                AddNotification(ResourceNotifications.DESCRIPTION_NOT_EMPTY);

            if (Amount <= 0)
                AddNotification(ResourceNotifications.VALUE_BIGGER_THAN_ZERO);

            bool PaymentTypeValid = Enum.IsDefined(typeof(EPaymentType), PaymentType);
            if (!PaymentTypeValid)
                AddNotification(ResourceNotifications.INVALID_PAYMENT_TYPE);

            if (Notifications.Count == 0)
                Valid = true;
        }
    }
}
