// ReSharper disable PartialTypeWithSinglePart
namespace NServiceBus_6.Testing
{
    /// <summary>
    /// A testable implementation of <see cref="IMessageHandlerContext" />.
    /// </summary>
    public partial class TestableMessageHandlerContext : TestableInvokeHandlerContext
    {
        /// <summary>
        /// Creates a new instance of a <see cref="TestableMessageHandlerContext" />.
        /// </summary>
        public TestableMessageHandlerContext(IMessageCreator messageCreator = null) : base(messageCreator)
        {
        }
    }
}