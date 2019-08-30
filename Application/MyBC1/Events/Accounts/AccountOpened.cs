using Dolittle.Events;

namespace Events.Accounts
{
    public class AccountOpened : IEvent
    {
        public AccountOpened(string owner)
        {
            Owner = owner;
        }

        public string Owner { get; }
    }
}