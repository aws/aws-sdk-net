using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SDKDocGenerator.PlatformMap
{
    /// <summary>
    /// Builds a unified PlatformAvailabilityMap by scanning assemblies across multiple platforms.
    ///
    /// Unified Architecture:
    /// 1. Load ALL platform assemblies upfront (not just signature scan)
    /// 2. Scan all public types and members, recording signatures AND wrappers
    /// 3. Keep assemblies loaded throughout generation (via PlatformAssemblyContext)
    /// 4. For exclusive members, store the MethodInfoWrapper for page generation
    /// 5. Return map with contexts - caller disposes when done
    ///
    /// Memory Model:
    /// - Assemblies stay loaded after BuildMap() returns
    /// - Map holds references to all assembly contexts
    /// - Caller must call map.Dispose() to release resources
    /// - For typical builds (3-4 platforms), memory usage is acceptable
    /// </summary>
    public class PlatformMapBuilder
    {
        private readonly string _sdkAssembliesRoot;

        public PlatformMapBuilder(string sdkAssembliesRoot)
        {
            if (string.IsNullOrEmpty(sdkAssembliesRoot))
                throw new ArgumentNullException(nameof(sdkAssembliesRoot));
            _sdkAssembliesRoot = sdkAssembliesRoot;
        }

        #region Public API

        /// <summary>
        /// Builds a complete platform availability map for a service.
        /// Assemblies are kept loaded - caller must dispose the returned map.
        /// </summary>
        /// <param name="serviceName">Service name (e.g., "S3", "Core")</param>
        /// <param name="assemblyName">Assembly name without extension (e.g., "AWSSDK.S3")</param>
        /// <param name="platformsToScan">List of platform folders to scan (e.g., ["net472", "net8.0"])</param>
        /// <param name="primaryPlatform">The primary platform subfolder (e.g., "net472") used as the documentation baseline</param>
        /// <param name="isVerbose">Whether to emit additional diagnostic messages</param>
        /// <returns>PlatformAvailabilityMap with loaded assemblies - must be disposed</returns>
        public PlatformAvailabilityMap BuildMap(
            string serviceName,
            string assemblyName,
            IEnumerable<string> platformsToScan,
            string primaryPlatform,
            bool isVerbose)
        {
            if (string.IsNullOrEmpty(serviceName))
                throw new ArgumentNullException(nameof(serviceName));
            if (string.IsNullOrEmpty(assemblyName))
                throw new ArgumentNullException(nameof(assemblyName));
            if (platformsToScan == null)
                throw new ArgumentNullException(nameof(platformsToScan));
            if (string.IsNullOrEmpty(primaryPlatform))
                throw new ArgumentNullException(nameof(primaryPlatform));

            var platforms = platformsToScan.ToList();
            if (!platforms.Any())
                throw new ArgumentException("Must specify at least one platform to scan", nameof(platformsToScan));

            if (isVerbose)
                Trace.WriteLine($"Building unified platform map for {serviceName} across {platforms.Count} platforms...");

            // Accumulator: { signature → PlatformMemberEntry }
            var memberIndex = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal);
            var scannedPlatforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var loadedContexts = new List<PlatformAssemblyContext>();

            // Ensure primary platform is scanned first to establish baseline signatures
            var orderedPlatforms = new List<string> { primaryPlatform };
            orderedPlatforms.AddRange(platforms.Where(p => !p.Equals(primaryPlatform, StringComparison.OrdinalIgnoreCase)));

            try
            {
                foreach (var platform in orderedPlatforms)
                {
                    var isPrimary = platform.Equals(primaryPlatform, StringComparison.OrdinalIgnoreCase);
                    var assemblyPath = Path.GetFullPath(Path.Combine(_sdkAssembliesRoot, platform, assemblyName + ".dll"));

                    if (!File.Exists(assemblyPath))
                    {
                        if (isPrimary)
                        {
                            throw new FileNotFoundException(
                                $"Primary platform assembly not found. The assembly for primary platform '{primaryPlatform}' " +
                                $"is required for documentation generation. Expected path: {assemblyPath}",
                                assemblyPath);
                        }

                        if (isVerbose)
                            Trace.WriteLine($"  Skipping {platform}: assembly not found");
                        continue;
                    }

                    try
                    {
                        var context = LoadAndScanPlatform(
                            assemblyPath,
                            platform,
                            serviceName,
                            memberIndex,
                            isPrimary);

                        if (context != null)
                        {
                            loadedContexts.Add(context);
                            scannedPlatforms.Add(platform);
                            if (isVerbose)
                            {
                                var label = isPrimary ? $"primary platform {platform}" : platform;
                                Trace.WriteLine($"  Scanned {label}: {memberIndex.Count} unique signatures total");
                            }
                        }
                    }
                    catch (Exception ex) when (!isPrimary)
                    {
                        Trace.WriteLine($"  WARNING: Failed to scan {platform}: {ex.Message}");
                        // Continue with other platforms even if a supplemental one fails
                    }
                }

                if (!scannedPlatforms.Any())
                {
                    throw new InvalidOperationException(
                        $"Failed to scan any platforms for {serviceName}. " +
                        $"Checked platforms: {string.Join(", ", platforms)}");
                }

                // After all platforms scanned, identify and store wrappers for exclusive methods
                IdentifyAndStoreExclusiveWrappers(memberIndex, primaryPlatform, loadedContexts, isVerbose);

                var map = new PlatformAvailabilityMap(
                    serviceName,
                    primaryPlatform,
                    memberIndex,
                    scannedPlatforms,
                    loadedContexts);

                if (isVerbose)
                    map.WriteToTrace();

                return map;
            }
            catch
            {
                // Dispose all loaded contexts on partial failure to prevent resource leaks (C3)
                foreach (var context in loadedContexts)
                {
                    try
                    {
                        context.Dispose();
                    }
                    catch (Exception disposeEx)
                    {
                        Trace.WriteLine($"  WARNING: Failed to dispose context during cleanup: {disposeEx.Message}");
                    }
                }

                throw;
            }
        }

        #endregion

        #region Private Loading Logic

        /// <summary>
        /// Loads a platform assembly and scans it, keeping the assembly loaded.
        /// </summary>
        private PlatformAssemblyContext LoadAndScanPlatform(
            string assemblyPath,
            string platform,
            string serviceName,
            Dictionary<string, PlatformMemberEntry> memberIndex,
            bool isPrimary)
        {
            var docId = NDocUtilities.GenerateDocId(serviceName, platform);
            var wrapper = new AssemblyWrapper(docId);

            try
            {
                // Use isolated context to avoid "assembly already loaded" conflicts
                wrapper.LoadAssembly(assemblyPath, useIsolatedContext: true);

                // Scan all types
                foreach (var type in wrapper.GetTypes())
                {
                    ScanType(type, platform, memberIndex);
                }

                // Create context that keeps the assembly alive
                return new PlatformAssemblyContext(
                    platform,
                    wrapper,
                    serviceName,
                    assemblyPath,
                    isPrimary);
            }
            catch (Exception)
            {
                // If loading fails, clean up and rethrow
                wrapper.Unload();
                throw;
            }
        }

        /// <summary>
        /// Scans a single type and all its members, adding to the member index.
        /// </summary>
        private void ScanType(
            TypeWrapper type,
            string platform,
            Dictionary<string, PlatformMemberEntry> memberIndex)
        {
            var typeFullName = type.FullName;

            // Type itself
            RecordMember(MemberSignature.ForType(type), typeFullName, platform, memberIndex);

            // Constructors
            foreach (var ctor in type.GetConstructors())
            {
                if (ctor.IsPublic)
                {
                    RecordMember(MemberSignature.ForConstructor(ctor), typeFullName, platform, memberIndex);
                }
            }

            // Methods (only those we document)
            // Use DeclaringType.FullName so inherited methods are attributed to their
            // actual declaring type, not every derived class that inherits them.
            // This prevents inherited net472-only methods (like SetWebProxy(IWebProxy)
            // from ClientConfig) from appearing as exclusive on every service config subclass.
            foreach (var method in type.GetMethodsToDocument())
            {
                var declaringType = method.DeclaringType.FullName ?? typeFullName;
                RecordMember(MemberSignature.ForMethod(method), declaringType, platform, memberIndex);
            }

            // Properties — signature already uses DeclaringType (via NDocUtilities),
            // so use the property's actual declaring type for consistency.
            foreach (var property in type.GetProperties())
            {
                if (property.IsPublic)
                {
                    var declaringType = property.DeclaringType.FullName ?? typeFullName;
                    RecordMember(MemberSignature.ForProperty(property), declaringType, platform, memberIndex);
                }
            }

            // Fields
            foreach (var field in type.GetFields())
            {
                if (field.IsPublic)
                {
                    var declaringType = field.DeclaringType.FullName ?? typeFullName;
                    RecordMember(MemberSignature.ForField(field), declaringType, platform, memberIndex);
                }
            }

            // Events
            foreach (var eventInfo in type.GetEvents())
            {
                var declaringType = eventInfo.DeclaringType.FullName ?? typeFullName;
                RecordMember(MemberSignature.ForEvent(eventInfo), declaringType, platform, memberIndex);
            }
        }

        /// <summary>
        /// Records that a member exists on a platform.
        /// </summary>
        private void RecordMember(
            string signature,
            string declaringTypeFullName,
            string platform,
            Dictionary<string, PlatformMemberEntry> memberIndex)
        {
            if (string.IsNullOrEmpty(signature))
                return;

            if (!memberIndex.TryGetValue(signature, out var entry))
            {
                entry = new PlatformMemberEntry(signature, declaringTypeFullName);
                memberIndex[signature] = entry;
            }

            entry.Platforms.Add(platform);
        }

        /// <summary>
        /// After all platforms are scanned, identifies exclusive methods and stores their wrappers.
        /// A member is "exclusive" if it exists on some platforms but NOT on the primary platform.
        /// </summary>
        private void IdentifyAndStoreExclusiveWrappers(
            Dictionary<string, PlatformMemberEntry> memberIndex,
            string primaryPlatform,
            List<PlatformAssemblyContext> loadedContexts,
            bool isVerbose)
        {
            // Find method entries that are not on primary platform
            foreach (var kvp in memberIndex)
            {
                var entry = kvp.Value;

                // Only handle methods (M: prefix) that are exclusive to non-primary platforms
                if (!entry.IsMethod)
                    continue;

                if (entry.Platforms.Contains(primaryPlatform))
                    continue; // Available on primary, not exclusive

                // Pick any platform that has this method (all are non-primary per the filter above)
                var exclusivePlatform = entry.Platforms.FirstOrDefault();
                if (exclusivePlatform == null)
                    continue;

                // Get the assembly context for this platform
                var context = loadedContexts.FirstOrDefault(c =>
                    c.Platform.Equals(exclusivePlatform, StringComparison.OrdinalIgnoreCase));

                if (context == null)
                {
                    if (isVerbose)
                        Trace.WriteLine($"  WARNING: No assembly context for platform '{exclusivePlatform}' while processing {entry.Signature}");
                    continue;
                }

                // Find the method wrapper in the loaded assembly
                var methodWrapper = FindMethodInAssembly(context.Assembly, entry);

                if (methodWrapper != null)
                {
                    entry.ExclusiveMethodWrapper = methodWrapper;
                }
            }
        }

        /// <summary>
        /// Finds a method wrapper in the assembly matching the signature.
        /// </summary>
        private MethodInfoWrapper FindMethodInAssembly(AssemblyWrapper assembly, PlatformMemberEntry entry)
        {
            if (string.IsNullOrEmpty(entry.DeclaringTypeFullName))
                return null;

            var type = assembly.GetType(entry.DeclaringTypeFullName);
            if (type == null)
                return null;

            // Find matching method
            foreach (var method in type.GetMethodsToDocument())
            {
                var sig = MemberSignature.ForMethod(method);
                if (sig == entry.Signature)
                {
                    return method;
                }
            }

            return null;
        }

        #endregion
    }
}
