using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SDKDocGenerator.PlatformMap
{
    /// <summary>
    /// Unified platform availability map that serves as both:
    /// 1. A lookup index for badge rendering (signature → platforms)
    /// 2. A wrapper cache for exclusive member page generation
    ///
    /// Design Philosophy:
    /// - Single source of truth for platform availability
    /// - Keeps assembly contexts alive during generation
    /// - O(1) lookup performance for both signatures and wrappers
    /// - IDisposable to properly clean up assembly contexts
    ///
    /// Memory Model:
    /// - Created during doc generation initialization
    /// - Holds references to loaded assemblies (via PlatformAssemblyContext)
    /// - Disposed at end of generation, releasing all assemblies
    /// </summary>
    public class PlatformAvailabilityMap : IDisposable
    {
        #region Fields

        private readonly Dictionary<string, PlatformMemberEntry> _memberIndex;
        private readonly Dictionary<string, HashSet<string>> _platformToMembers;
        private readonly HashSet<string> _allPlatforms;
        private readonly List<PlatformAssemblyContext> _loadedContexts;
        private bool _disposed;

        #endregion

        #region Properties

        /// <summary>
        /// The service name this map represents (e.g., "S3", "Core", "DynamoDBv2")
        /// </summary>
        public string ServiceName { get; }

        /// <summary>
        /// Primary platform used as baseline for documentation.
        /// Members NOT on this platform are considered "exclusive" to their platform.
        /// Example: net472 is primary, so net8.0-only methods are "exclusive".
        ///
        /// HISTORICAL CONTEXT (2026-01): The SDK historically used net472 as the
        /// sole source for documentation. Platform-exclusive APIs (like H2 streaming)
        /// were invisible. This property defines what "exclusive" means.
        /// </summary>
        public string PrimaryPlatform { get; }

        /// <summary>
        /// All platforms that were scanned to build this map.
        /// Example: ["net472", "netstandard2.0", "netcoreapp3.1", "net8.0"]
        /// </summary>
        public IReadOnlyCollection<string> AllPlatforms => _allPlatforms;

        /// <summary>
        /// Total number of unique member signatures in the map.
        /// </summary>
        public int MemberCount => _memberIndex.Count;

        /// <summary>
        /// Number of exclusive members (methods with wrappers stored).
        /// </summary>
        public int ExclusiveMemberCount => _memberIndex.Values.Count(e => e.ExclusiveMethodWrapper != null);

        #endregion

        #region Constructor

        /// <summary>
        /// Creates an immutable platform availability map.
        /// Should only be called by PlatformMapBuilder.
        /// </summary>
        internal PlatformAvailabilityMap(
            string serviceName,
            string primaryPlatform,
            Dictionary<string, PlatformMemberEntry> memberIndex,
            HashSet<string> allPlatforms,
            List<PlatformAssemblyContext> loadedContexts)
        {
            ServiceName = serviceName ?? throw new ArgumentNullException(nameof(serviceName));
            PrimaryPlatform = primaryPlatform ?? throw new ArgumentNullException(nameof(primaryPlatform));
            _allPlatforms = new HashSet<string>(allPlatforms, StringComparer.OrdinalIgnoreCase);
            _loadedContexts = loadedContexts ?? new List<PlatformAssemblyContext>();

            // Store the member index directly - PlatformMapBuilder has already done the work
            _memberIndex = memberIndex ?? throw new ArgumentNullException(nameof(memberIndex));

            // Build reverse index (platform → signatures)
            _platformToMembers = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
            foreach (var platform in _allPlatforms)
            {
                _platformToMembers[platform] = new HashSet<string>(StringComparer.Ordinal);
            }

            foreach (var kvp in _memberIndex)
            {
                var signature = kvp.Key;
                var entry = kvp.Value;
                foreach (var platform in entry.Platforms)
                {
                    if (_platformToMembers.ContainsKey(platform))
                    {
                        _platformToMembers[platform].Add(signature);
                    }
                }
            }
        }

        /// <summary>
        /// Legacy constructor for backward compatibility.
        /// Creates a map without wrapper storage (signature-only mode).
        /// </summary>
        internal PlatformAvailabilityMap(
            string serviceName,
            Dictionary<string, HashSet<string>> memberToPlatforms,
            HashSet<string> allPlatforms)
        {
            ServiceName = serviceName ?? throw new ArgumentNullException(nameof(serviceName));
            _allPlatforms = new HashSet<string>(allPlatforms, StringComparer.OrdinalIgnoreCase);
            _loadedContexts = new List<PlatformAssemblyContext>();

            // Legacy constructor infers primary platform from available platforms
            // Default to first platform or "net472" for backwards compatibility
            PrimaryPlatform = allPlatforms.OrderBy(p => p).FirstOrDefault() ?? "net472";

            // Convert legacy format to new format
            _memberIndex = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal);
            foreach (var kvp in memberToPlatforms)
            {
                // Extract declaring type from signature (e.g., "M:Namespace.Type.Method" -> "Namespace.Type")
                var declaringType = ExtractDeclaringTypeFromSignature(kvp.Key);
                var entry = new PlatformMemberEntry(kvp.Key, declaringType);
                foreach (var platform in kvp.Value)
                {
                    entry.Platforms.Add(platform);
                }
                _memberIndex[kvp.Key] = entry;
            }

            // Build reverse index
            _platformToMembers = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
            foreach (var platform in _allPlatforms)
            {
                _platformToMembers[platform] = new HashSet<string>(StringComparer.Ordinal);
            }

            foreach (var kvp in memberToPlatforms)
            {
                var signature = kvp.Key;
                var platforms = kvp.Value;
                foreach (var platform in platforms)
                {
                    if (_platformToMembers.ContainsKey(platform))
                    {
                        _platformToMembers[platform].Add(signature);
                    }
                }
            }
        }

        #endregion

        #region Query Methods - Signature Based (for badge rendering)

        /// <summary>
        /// Gets all platforms where a member exists.
        /// Returns empty set if member doesn't exist on any platform.
        /// </summary>
        /// <param name="memberSignature">The member signature (e.g., "M:Type.Method(Params)")</param>
        public IReadOnlyCollection<string> GetPlatformsForMember(string memberSignature)
        {
            if (string.IsNullOrEmpty(memberSignature))
                return Array.Empty<string>();

            if (_memberIndex.TryGetValue(memberSignature, out var entry))
                return entry.Platforms;

            return Array.Empty<string>();
        }

        /// <summary>
        /// Checks if a member exists on a specific platform.
        /// </summary>
        public bool IsMemberAvailableOnPlatform(string memberSignature, string platform)
        {
            if (string.IsNullOrEmpty(memberSignature) || string.IsNullOrEmpty(platform))
                return false;

            return _memberIndex.TryGetValue(memberSignature, out var entry) &&
                   entry.Platforms.Contains(platform);
        }

        /// <summary>
        /// Checks if a member exists on ALL platforms.
        /// </summary>
        public bool IsMemberAvailableOnAllPlatforms(string memberSignature)
        {
            if (string.IsNullOrEmpty(memberSignature))
                return false;

            if (!_memberIndex.TryGetValue(memberSignature, out var entry))
                return false;

            return entry.Platforms.Count == _allPlatforms.Count;
        }

        /// <summary>
        /// Checks if a member is platform-restricted (not available everywhere).
        /// This is the key method for badge rendering decisions.
        /// </summary>
        public bool IsMemberPlatformRestricted(string memberSignature)
        {
            if (string.IsNullOrEmpty(memberSignature))
                return false;

            if (!_memberIndex.TryGetValue(memberSignature, out var entry))
                return false; // Doesn't exist anywhere, not "restricted"

            return entry.Platforms.Count > 0 && entry.Platforms.Count < _allPlatforms.Count;
        }

        /// <summary>
        /// Gets all member signatures available on a specific platform.
        /// Useful for diagnostics and supplemental content generation.
        /// </summary>
        public IReadOnlyCollection<string> GetMembersForPlatform(string platform)
        {
            if (string.IsNullOrEmpty(platform))
                return Array.Empty<string>();

            if (_platformToMembers.TryGetValue(platform, out var members))
                return members;

            return Array.Empty<string>();
        }

        /// <summary>
        /// Finds members that exist ONLY on specific platforms (supplemental content).
        /// Example: Find all net8.0-only members that aren't in net472.
        /// </summary>
        /// <param name="targetPlatform">Platform to check (e.g., "net8.0")</param>
        /// <param name="excludePlatforms">Platforms to exclude (e.g., ["net472"])</param>
        public IEnumerable<string> FindSupplementalMembers(
            string targetPlatform,
            params string[] excludePlatforms)
        {
            if (string.IsNullOrEmpty(targetPlatform))
                yield break;

            var targetMembers = GetMembersForPlatform(targetPlatform);
            var excludeSet = new HashSet<string>(excludePlatforms, StringComparer.OrdinalIgnoreCase);

            foreach (var signature in targetMembers)
            {
                var memberPlatforms = GetPlatformsForMember(signature);

                // Is this member in the target platform but NOT in any exclude platform?
                if (memberPlatforms.Contains(targetPlatform) &&
                    !memberPlatforms.Any(p => excludeSet.Contains(p)))
                {
                    yield return signature;
                }
            }
        }

        #endregion

        #region Query Methods - Wrapper Based (for exclusive page generation)

        /// <summary>
        /// Gets the method wrapper for an exclusive member.
        /// Returns null if the member is not exclusive or is not a method.
        /// </summary>
        public MethodInfoWrapper GetMethodWrapper(string signature)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(PlatformAvailabilityMap));

            if (string.IsNullOrEmpty(signature))
                return null;

            if (_memberIndex.TryGetValue(signature, out var entry))
                return entry.ExclusiveMethodWrapper;

            return null;
        }

        /// <summary>
        /// Gets all exclusive methods for a specific type.
        /// Used for generating class pages that include exclusive methods.
        /// </summary>
        /// <param name="typeFullName">Full name of the declaring type</param>
        public IEnumerable<MethodInfoWrapper> GetExclusiveMethodsForType(string typeFullName)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(PlatformAvailabilityMap));

            if (string.IsNullOrEmpty(typeFullName))
                yield break;

            foreach (var entry in _memberIndex.Values)
            {
                if (entry.ExclusiveMethodWrapper != null &&
                    entry.DeclaringTypeFullName == typeFullName)
                {
                    yield return entry.ExclusiveMethodWrapper;
                }
            }
        }

        /// <summary>
        /// Gets all type full names that have exclusive members.
        /// Used to know which class pages need to be regenerated.
        /// </summary>
        public IEnumerable<string> GetTypesWithExclusiveMembers()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(PlatformAvailabilityMap));

            return _memberIndex.Values
                .Where(e => e.ExclusiveMethodWrapper != null && !string.IsNullOrEmpty(e.DeclaringTypeFullName))
                .Select(e => e.DeclaringTypeFullName)
                .Distinct();
        }

        /// <summary>
        /// Gets all exclusive method entries (for iteration during page generation).
        /// </summary>
        public IEnumerable<PlatformMemberEntry> GetExclusiveMethodEntries()
        {
            return _memberIndex.Values.Where(e => e.ExclusiveMethodWrapper != null);
        }

        /// <summary>
        /// Gets the assembly context for a specific platform.
        /// </summary>
        public PlatformAssemblyContext GetAssemblyContext(string platform)
        {
            return _loadedContexts.FirstOrDefault(c =>
                c.Platform.Equals(platform, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

        #region Statistics

        /// <summary>
        /// Number of members available on all platforms.
        /// </summary>
        public int UniversalMemberCount =>
            _memberIndex.Count(kvp => kvp.Value.Platforms.Count == _allPlatforms.Count);

        /// <summary>
        /// Number of members available on some but not all platforms.
        /// </summary>
        public int PlatformRestrictedMemberCount =>
            _memberIndex.Count(kvp => kvp.Value.Platforms.Count > 0 && kvp.Value.Platforms.Count < _allPlatforms.Count);

        /// <summary>
        /// Gets the count of members exclusive to a specific platform.
        /// </summary>
        public int GetExclusiveMemberCount(string platform)
        {
            var members = GetMembersForPlatform(platform);
            return members.Count(sig => GetPlatformsForMember(sig).Count == 1);
        }

        #endregion

        #region Logging

        /// <summary>
        /// Writes diagnostic information about the map to trace output.
        /// Useful for understanding what was scanned and detecting issues.
        /// </summary>
        public void WriteToTrace()
        {
            Trace.WriteLine($"Platform Availability Map for {ServiceName}:");
            Trace.WriteLine($"  Primary platform: {PrimaryPlatform ?? "(not set)"}");
            Trace.WriteLine($"  Platforms scanned: {string.Join(", ", _allPlatforms)}");
            Trace.WriteLine($"  Total unique members: {MemberCount}");
            Trace.WriteLine($"  Universal members (all platforms): {UniversalMemberCount}");
            Trace.WriteLine($"  Platform-restricted members: {PlatformRestrictedMemberCount}");
            Trace.WriteLine($"  Exclusive members with wrappers: {ExclusiveMemberCount}");
            Trace.WriteLine($"  Loaded assembly contexts: {_loadedContexts.Count}");

            foreach (var platform in _allPlatforms.OrderBy(p => p))
            {
                var totalMembers = GetMembersForPlatform(platform).Count;
                var exclusiveMembers = GetExclusiveMemberCount(platform);
                Trace.WriteLine($"  {platform}: {totalMembers} members ({exclusiveMembers} exclusive)");
            }

            // Show types with exclusive members
            var typesWithExclusive = GetTypesWithExclusiveMembers().ToList();
            if (typesWithExclusive.Any())
            {
                Trace.WriteLine($"  Types with exclusive members: {typesWithExclusive.Count}");
                foreach (var type in typesWithExclusive.Take(10))
                {
                    var methods = GetExclusiveMethodsForType(type).Count();
                    Trace.WriteLine($"    {type}: {methods} exclusive method(s)");
                }
                if (typesWithExclusive.Count > 10)
                {
                    Trace.WriteLine($"    ... and {typesWithExclusive.Count - 10} more types");
                }
            }
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Extracts the declaring type from an NDoc-style signature.
        /// For type signatures (T:), returns the type itself.
        /// For member signatures (M:, P:, F:, E:), returns the containing type.
        /// </summary>
        private static string ExtractDeclaringTypeFromSignature(string signature)
        {
            if (string.IsNullOrEmpty(signature) || signature.Length < 2)
                return "Unknown";

            // Remove the prefix (T:, M:, P:, F:, E:)
            var withoutPrefix = signature.Substring(2);

            // For type signatures, return as-is
            if (signature.StartsWith("T:", StringComparison.Ordinal))
                return withoutPrefix;

            // For member signatures, find the last dot before any parentheses
            var parenIndex = withoutPrefix.IndexOf('(');
            var nameWithoutParams = parenIndex >= 0 ? withoutPrefix.Substring(0, parenIndex) : withoutPrefix;

            var lastDot = nameWithoutParams.LastIndexOf('.');
            if (lastDot < 0)
                return nameWithoutParams; // No dot, just return what we have

            return nameWithoutParams.Substring(0, lastDot);
        }

        #endregion

        #region IDisposable

        /// <summary>
        /// Disposes all loaded assembly contexts, releasing memory.
        /// After disposal, wrapper-based queries will return invalid data.
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
                return;

            foreach (var context in _loadedContexts)
            {
                try
                {
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    Trace.WriteLine($"Warning: Failed to dispose assembly context {context}: {ex.Message}");
                }
            }

            _loadedContexts.Clear();
            _disposed = true;
        }

        #endregion
    }
}
