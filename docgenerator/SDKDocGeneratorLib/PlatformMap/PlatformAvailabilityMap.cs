using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SDKDocGenerator.PlatformMap
{
    /// <summary>
    /// Unified platform availability map that serves as both:
    /// 1. A lookup index for platform availability queries (signature → platforms)
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

        #endregion

        #region Query Methods - Signature Based (for diagnostics and testing)

        /// <summary>
        /// Gets all platforms where a member exists.
        /// Returns empty set if member doesn't exist on any platform.
        /// </summary>
        /// <param name="memberSignature">The member signature (e.g., "M:Type.Method(Params)")</param>
        public IReadOnlyCollection<string> GetPlatformsForMember(string memberSignature)
        {
            ThrowIfDisposed();

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
            ThrowIfDisposed();

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
            ThrowIfDisposed();

            if (string.IsNullOrEmpty(memberSignature))
                return false;

            if (!_memberIndex.TryGetValue(memberSignature, out var entry))
                return false;

            return entry.Platforms.Count == _allPlatforms.Count;
        }

        /// <summary>
        /// Checks if a member is platform-restricted (not available everywhere).
        /// Useful for diagnostics and testing.
        /// </summary>
        public bool IsMemberPlatformRestricted(string memberSignature)
        {
            ThrowIfDisposed();

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
            ThrowIfDisposed();

            if (string.IsNullOrEmpty(platform))
                return Array.Empty<string>();

            if (_platformToMembers.TryGetValue(platform, out var members))
                return members;

            return Array.Empty<string>();
        }

        #endregion

        #region Query Methods - Wrapper Based (for exclusive page generation)

        /// <summary>
        /// Gets the method wrapper for an exclusive member.
        /// Returns null if the member is not exclusive or is not a method.
        /// </summary>
        public MethodInfoWrapper GetMethodWrapper(string signature)
        {
            ThrowIfDisposed();

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
            ThrowIfDisposed();

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
            ThrowIfDisposed();

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
            ThrowIfDisposed();

            return _memberIndex.Values.Where(e => e.ExclusiveMethodWrapper != null);
        }

        /// <summary>
        /// Gets the assembly context for a specific platform.
        /// </summary>
        public PlatformAssemblyContext GetAssemblyContext(string platform)
        {
            ThrowIfDisposed();

            return _loadedContexts.FirstOrDefault(c =>
                c.Platform.Equals(platform, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

        #region Statistics

        // Note: Statistics properties below recompute on each access via LINQ.
        // This is acceptable for current usage (diagnostics/logging). If called
        // in tight loops, consider caching the results.

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

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(PlatformAvailabilityMap));
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
