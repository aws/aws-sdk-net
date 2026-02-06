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
        /// <summary>
        /// The NDoc-style signature that uniquely identifies this member (e.g., "M:Namespace.Type.Method(Params)").
        /// </summary>
        public string Signature { get; }

        /// <summary>
        /// The fully qualified name of the type that declares this member.
        /// </summary>
        public string DeclaringTypeFullName { get; }

        /// <summary>
        /// The set of platform names where this member is available (e.g., "net472", "net8.0").
        /// </summary>
        public HashSet<string> Platforms { get; }

        /// <summary>
        /// For exclusive methods (not on primary platform), the loaded method wrapper for page generation.
        /// Set by <see cref="PlatformMapBuilder"/> after all platforms are scanned.
        /// </summary>
        public MethodInfoWrapper ExclusiveMethodWrapper { get; internal set; }

        /// <summary>
        /// The platform that exclusively provides this method (e.g., "net8.0" for H2-only APIs).
        /// Set by <see cref="PlatformMapBuilder"/> after all platforms are scanned.
        /// </summary>
        public string ExclusivePlatform { get; internal set; }

        /// <summary>True if this entry represents a method (M: prefix).</summary>
        public bool IsMethod => Signature.StartsWith("M:", StringComparison.Ordinal);
        /// <summary>True if this entry represents a property (P: prefix).</summary>
        public bool IsProperty => Signature.StartsWith("P:", StringComparison.Ordinal);
        /// <summary>True if this entry represents a type (T: prefix).</summary>
        public bool IsType => Signature.StartsWith("T:", StringComparison.Ordinal);
        /// <summary>True if this entry represents a field (F: prefix).</summary>
        public bool IsField => Signature.StartsWith("F:", StringComparison.Ordinal);
        /// <summary>True if this entry represents an event (E: prefix).</summary>
        public bool IsEvent => Signature.StartsWith("E:", StringComparison.Ordinal);

        public PlatformMemberEntry(string signature, string declaringTypeFullName)
        {
            Signature = signature ?? throw new ArgumentNullException(nameof(signature));
            DeclaringTypeFullName = declaringTypeFullName ?? throw new ArgumentNullException(nameof(declaringTypeFullName));
            Platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }
    }
}
