namespace Domain.Accounts
{
    public class SecurityDescriptor : Dolittle.Security.SecurityDescriptor
    {
        public SecurityDescriptor()
        {
            //When.Handling().Commands().InNamespace(typeof(OpenAccount).Namespace, _ => _.User().MustBe("administrator"));
        }
    }
}