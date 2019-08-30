using Dolittle.Events.Processing;
using Dolittle.ReadModels;
using Events.Accounts;

namespace Read.Accounts
{
    public class AccountEventProcessors : ICanProcessEvents
    {
        private readonly IReadModelRepositoryFor<Account> _repository;

        public AccountEventProcessors(IReadModelRepositoryFor<Account> repository)
        {
            _repository = repository;
        }

        [EventProcessor("c93703be-e2c7-4df5-9c60-45205b47489d")]
        public void Process(AccountOpened @event)
        {
            _repository.Insert(new Account { Owner = @event.Owner });

        }

    }
}