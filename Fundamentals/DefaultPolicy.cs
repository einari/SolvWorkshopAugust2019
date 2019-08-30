using Dolittle.Resilience;

namespace Fundamentals
{
    public class DefaultPolicy : IDefineDefaultPolicy
    {
        public Polly.Policy Define()
        {
            return Polly.Policy.NoOp();
        }
    }
}