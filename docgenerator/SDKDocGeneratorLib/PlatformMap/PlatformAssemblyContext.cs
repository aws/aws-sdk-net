using System;

namespace SDKDocGenerator.PlatformMap
{
    /// <summary>
    /// Manages the lifetime of an assembly loaded for platform map building.
    /// Keeps the assembly loaded during generation so wrappers remain valid,
    /// then disposes cleanly at the end.
    ///
    /// Memory Model:
    /// - Created during PlatformMapBuilder.BuildMap()
    /// - Stays alive throughout doc generation
    /// - Disposed via PlatformAvailabilityMap.Dispose() at end of generation
    /// - Multiple contexts can exist for different platforms (net472, net8.0, etc.)
    /// </summary>
    public class PlatformAssemblyContext : IDisposable
    {
        private bool _disposed;

        /// <summary>
        /// The platform this assembly represents (e.g., "net472", "net8.0").
        /// </summary>
        public string Platform { get; }

        /// <summary>
        /// The loaded assembly wrapper. Contains all types and their wrappers.
        /// Remains valid until Dispose() is called.
        /// </summary>
        public AssemblyWrapper Assembly { get; }

        /// <summary>
        /// The service name this assembly provides (e.g., "S3", "BedrockRuntime").
        /// </summary>
        public string ServiceName { get; }

        /// <summary>
        /// The full path to the assembly file.
        /// </summary>
        public string AssemblyPath { get; }

        /// <summary>
        /// Whether this is the primary platform for documentation.
        /// Primary platform assemblies are used for the main doc generation pass.
        /// Non-primary (supplemental) platforms only contribute exclusive members.
        /// </summary>
        public bool IsPrimaryPlatform { get; }

        /// <summary>
        /// Creates a context for a platform assembly.
        /// </summary>
        /// <param name="platform">Platform name (e.g., "net8.0")</param>
        /// <param name="assembly">The loaded assembly wrapper</param>
        /// <param name="serviceName">Service name</param>
        /// <param name="assemblyPath">Full path to the assembly file</param>
        /// <param name="isPrimary">Whether this is the primary documentation platform</param>
        public PlatformAssemblyContext(
            string platform,
            AssemblyWrapper assembly,
            string serviceName,
            string assemblyPath,
            bool isPrimary = false)
        {
            Platform = platform ?? throw new ArgumentNullException(nameof(platform));
            Assembly = assembly ?? throw new ArgumentNullException(nameof(assembly));
            ServiceName = serviceName ?? throw new ArgumentNullException(nameof(serviceName));
            AssemblyPath = assemblyPath ?? throw new ArgumentNullException(nameof(assemblyPath));
            IsPrimaryPlatform = isPrimary;
        }

        /// <summary>
        /// Unloads the assembly and frees resources.
        /// After disposal, all wrappers from this assembly become invalid.
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
                return;

            Assembly.Unload();
            _disposed = true;
        }

        public override string ToString()
        {
            var primary = IsPrimaryPlatform ? " [PRIMARY]" : "";
            return $"{ServiceName}/{Platform}{primary}";
        }
    }
}
