namespace PersonalFinance.Domain.Entities
{
    public abstract class Entity
    {
        public IList<string> Notifications { get; private set; }
        public bool Valid { get; protected set; } = false;

        protected Entity()
        {
            Notifications = new List<string>();
        }

        protected void AddNotification(string notification)
        {
            Notifications.Add(notification);
        }
    }
}
