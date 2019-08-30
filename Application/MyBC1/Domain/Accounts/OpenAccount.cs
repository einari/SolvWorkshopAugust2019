using Dolittle.Commands;

namespace Domain.Accounts
{
    public class OpenAccount : ICommand
    {   
        public string Owner { get; set; }
        
    }
}