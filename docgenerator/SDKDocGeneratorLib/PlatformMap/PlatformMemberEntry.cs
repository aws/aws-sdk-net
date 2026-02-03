using System;
using System.Collections.Generic;

namespace SDKDocGenerator.PlatformMap
{
    /// <summary>
    /// Represents a member entry in the platform availability map.
    /// Stores the signature, which platforms it's available on, and optionally
    /// the wrapper for exclusive methods (methods not on the primary platform).
    ///
    /// HISTORICAL CONTEXT (2026-01): Before unified platform map, doc generator used
    /// net472 as single source of truth. H2 bidirectional streaming APIs only exist
    /// in net8.0 and were completely missing from documentation.
    ///
    /// This entry tracks member availability across platforms and caches wrappers
    /// for exclusive members (those not on primary platform) to enable page generation
    /// without reloading assemblies.
    /// </summary>
    public class PlatformMemberEntry
    {
        public string Signature { get; }
        public string DeclaringTypeFullName { get; }
        public HashSet<string> Platforms { get; }
        public MethodInfoWrapper ExclusiveMethodWrapper { get; set; }
        public string ExclusivePlatform { get; set; }
        public bool IsMethod => Signature.StartsWith("M:", StringComparison.Ordinal);
        public bool IsProperty => Signature.StartsWith("P:", StringComparison.Ordinal);
        public bool IsType => Signature.StartsWith("T:", StringComparison.Ordinal);
        public bool IsField => Signature.StartsWith("F:", StringComparison.Ordinal);
        public bool IsEvent => Signature.StartsWith("E:", StringComparison.Ordinal);

        public PlatformMemberEntry(string signature, string declaringTypeFullName)
        {
            Signature = signature ?? throw new ArgumentNullException(nameof(signature));
            DeclaringTypeFullName = declaringTypeFullName ?? throw new ArgumentNullException(nameof(declaringTypeFullName));
            Platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }
    }
}
