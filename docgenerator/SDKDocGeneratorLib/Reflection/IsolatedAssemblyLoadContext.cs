using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace SDKDocGenerator
{
    /// <summary>
    /// An isolated AssemblyLoadContext that allows loading assemblies with the same name
    /// from different paths. This is used for loading supplemental platform assemblies
    /// (e.g., net8.0) when the primary platform assembly (e.g., net472) is already loaded.
    /// </summary>
    public class IsolatedAssemblyLoadContext : AssemblyLoadContext
    {
        private readonly string _basePath;

        public IsolatedAssemblyLoadContext(string basePath)
        {
            _basePath = Path.GetDirectoryName(basePath) ?? string.Empty;
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            // Try to load from the same directory as the main assembly
            var assemblyPath = Path.Combine(_basePath, $"{assemblyName.Name}.dll");
            if (File.Exists(assemblyPath))
            {
                return LoadFromAssemblyPath(assemblyPath);
            }

            // Fall back to searching extension subfolders (e.g. extensions\CborProtocol\)
            var extensionsPath = Path.Combine(_basePath, "extensions");
            if (Directory.Exists(extensionsPath))
            {
                var nested = Directory.GetFiles(extensionsPath, $"{assemblyName.Name}.dll", SearchOption.AllDirectories);
                if (nested.Length > 0)
                {
                    return LoadFromAssemblyPath(nested[0]);
                }
            }

            // Fall back to default context for system assemblies
            return null;
        }
    }
}
