using System;

namespace Smithy.Identity.Abstractions
{
    /// <summary>
    /// An identity is an entity within the SDK representing who the customer is.
    /// For example, the customer's identity could be anonymouus, a token, a public / private key pair, etc...
    /// </summary>
    public abstract class BaseIdentity
    {
        /// <summary>
        /// The time after which this identity will no longer be valid. If this is null, an expiration time
        /// is not known (for example, when using long-term credentials).
        /// </summary>
        public virtual DateTime? Expiration { get; set; }
    }
}
