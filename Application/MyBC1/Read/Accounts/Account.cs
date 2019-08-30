using System.Linq;
using Dolittle.Queries;
using Dolittle.ReadModels;

namespace Read.Accounts
{
    public class Account : IReadModel
    {
        public string Owner {  get; set; }
    }

    public class AllAccounts : IQueryFor<Account>
    {
        public AllAccounts(IReadModelRepositoryFor<Account> repository) => Query = repository.Query;

        public IQueryable<Account> Query { get; }
    }
}