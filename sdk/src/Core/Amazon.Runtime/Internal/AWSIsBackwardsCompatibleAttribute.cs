using System;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Marker attribute that indicates an interface in Core is intended to be implemented
    /// only within the current assembly (i.e., not by service packages or external consumers).
    /// This allows the interface to evolve without breaking known, supported implementations,
    /// but it is not a general backward-compatibility guarantee for arbitrary external implementers.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false)]
    internal sealed class AWSIsBackwardsCompatibleAttribute : Attribute { }
}
