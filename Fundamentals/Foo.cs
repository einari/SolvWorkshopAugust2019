using Dolittle.Resilience;
using Dolittle.Types;

namespace Fundamentals
{

    public class Foo : IFoo
    {
        public Foo(MyConfig config, IPolicyFor<Foo> policy, IInstancesOf<ISomething> somethings)
        {
            policy.Execute(() => {

            });
        }

    }
}