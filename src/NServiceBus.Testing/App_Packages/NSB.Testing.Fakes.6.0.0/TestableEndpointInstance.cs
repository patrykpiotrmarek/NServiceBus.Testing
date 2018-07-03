﻿// ReSharper disable PartialTypeWithSinglePart
namespace NServiceBus_6.Testing
{
    using System.Threading.Tasks;

    /// <summary>
    /// A testable implementation of <see cref="IEndpointInstance" />.
    /// </summary>
    public partial class TestableEndpointInstance : TestableMessageSession, IEndpointInstance
    {
        /// <summary>
        /// Indicates whether <see cref="Stop" /> has been called or not.
        /// </summary>
        public bool EndpointStopped { get; private set; }

        /// <summary>
        /// Stops the endpoint.
        /// </summary>
        public virtual Task Stop()
        {
            EndpointStopped = true;
            return Task.FromResult(0);
        }
    }
}