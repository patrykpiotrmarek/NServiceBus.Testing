namespace NServiceBus_6.Testing
{
    class ExpectHandleCurrentMessageLater : ExpectInvocation
    {
        public override void Validate(TestableMessageHandlerContext context)
        {
            if (!context.HandleCurrentMessageLaterWasCalled)
            {
                Fail($"Expected {nameof(context.HandleCurrentMessageLaterWasCalled)} to be called but it was not.");
            }
        }
    }
}