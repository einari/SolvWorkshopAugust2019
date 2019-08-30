using System;
using Dolittle.Commands.Handling;
using Dolittle.Domain;
using Dolittle.Runtime.Events;
using Events.Accounts;

namespace Domain.Accounts
{
    public class AccountCommandHandlers : ICanHandleCommands
    {
        private readonly IAggregateRootRepositoryFor<Account> _repository;

        public AccountCommandHandlers(IAggregateRootRepositoryFor<Account> repository)
        {
            _repository = repository;
        }

        public void Handle(OpenAccount command)
        {
            var account = _repository.Get(Guid.NewGuid());
            account.Open(command.Owner);
        }
    }

    public class Account : AggregateRoot
    {
        public Account(EventSourceId eventSourceId) : base(eventSourceId) {}

        public void Open(string owner)
        {
            Apply(new AccountOpened(owner));

        }
    }

}