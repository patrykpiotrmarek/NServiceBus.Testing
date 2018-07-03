namespace NServiceBus_6.Testing
{
    abstract class ExpectInvocation
    {
        public abstract void Validate(TestableMessageHandlerContext context);

        protected void Fail(string message)
        {
            throw new ExpectationException(message);
        }
    }
}