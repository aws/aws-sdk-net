using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Json.LitJson;

namespace ServiceClientGenerator.DefaultConfiguration
{
    /// <summary>
    /// Represents the sdk-default-configuration.json file so that it be serialized with
    /// <see cref="JsonMapper.ToObject{T}(string, bool)"/>
    ///
    /// Also contains some helper conversions for navigating the deserialized model.
    /// </summary>
    /// <remarks>
    /// See ServiceClientGeneratorTests.Content.sdk-default-configuration.json for example
    /// </remarks>
    internal class SdkDefaultConfigurationJsonDataModel
    {
        public int version { get; set; }
        public BaseConfig @base { get; set; }
        public ModesDictionary modes { get; set; }
        public Documentation documentation { get; set; }

        public Mode[] Modes =>
            modes
                .Select(x => new Mode
                {
                    Name = x.Key,
                    Modifiers = x.Value.ToConfigurationModifiers()
                })
                .ToArray();

        public class BaseConfig
        {
            public string retryMode { get; set; }
            public string stsRegionalEndpoints { get; set; }
            public string s3UsEast1RegionalEndpoints { get; set; }
            public int? connectTimeoutInMillis { get; set; }
            public int? tlsNegotiationTimeoutInMillis { get; set; }
            public int? timeToFirstByteTimeoutInMillis { get; set; }
            public int? httpRequestTimeoutInMillis { get; set; }
        }

        /// <summary>
        /// Key is mode.Name
        /// </summary>
        public class ModesDictionary : Dictionary<string, ConfigurationModifiersDictionary> { }

        [DebuggerDisplay("Mode {" + nameof(Name) + "}")]
        public class Mode
        {
            public string Name { get; set; }
            public ConfigurationModifiers[] Modifiers { get; set; }
        }

        /// <summary>
        /// Key is the configuration, as defined in BaseConfig. Ie <see cref="BaseConfig.retryMode"/>
        /// </summary>
        public class ConfigurationModifiersDictionary : Dictionary<string, ModifierDictionary>
        {
            public ConfigurationModifiers[] ToConfigurationModifiers() =>
                this
                    .Select(kvp => new ConfigurationModifiers
                    {
                        ConfigurationName = kvp.Key,
                        Modifiers = kvp.Value.ToModifiers()
                    })
                    .ToArray();
        }

        [DebuggerDisplay("Configuration {" + nameof(ConfigurationName) + "}")]
        public class ConfigurationModifiers
        {
            /// <summary>
            /// Configuration Name, as defined in BaseConfig. Ie <see cref="BaseConfig.retryMode"/>
            /// </summary>
            public string ConfigurationName { get; set; }

            public Modifier[] Modifiers { get; set; }
        }

        public class ModifierDictionary : Dictionary<string, object>
        {
            public Modifier[] ToModifiers() =>
                this
                    .Select(kvp => new Modifier
                    {
                        Operation = (ModifierOperation) Enum.Parse(typeof(ModifierOperation), kvp.Key),
                        Value = kvp.Value
                    })
                    .ToArray();
        }

        [DebuggerDisplay("{" +nameof(Operation) + "}: {" + nameof(Value) + "}")]
        public class Modifier
        {
            public ModifierOperation Operation { get; set; }
            public object Value { get; set; }
        }

        public enum ModifierOperation
        {
            /// <summary>
            /// It specifies the factor to be multiplied by the value of the corresponding option under base
            /// </summary>
            multiply,
            /// <summary>
            /// It specifies the number to be added to the value of the corresponding option under base
            /// </summary>
            add,
            /// <summary>
            /// This value overrides the value of the corresponding option under base.
            /// The type depends on the context - see the specific type being overridden in the base for the proper type.
            /// </summary>
            @override
        }

        public class Documentation
        {
            public Dictionary<string, string> modes { get; set; }

            public DocumentationModeEntry[] Modes =>
                modes
                    .Select(kvp => new DocumentationModeEntry
                    {
                        ModeName = kvp.Key,
                        Documentation = kvp.Value
                    })
                    .ToArray();

            public Dictionary<string, string> configuration { get; set; }
            public DocumentationConfigurationEntry[] Configuration =>
                configuration
                    .Select(kvp => new DocumentationConfigurationEntry
                    {
                        ConfigurationName = kvp.Key,
                        Documentation = kvp.Value
                    })
                    .ToArray();

            public class DocumentationModeEntry
            {
                /// <summary>
                /// Equivalent to <see cref="Mode.Name"/>
                /// </summary>
                public string ModeName { get; set; }
                public string Documentation { get; set; }
            }

            public class DocumentationConfigurationEntry
            {
                /// <summary>
                /// Configuration Name, as defined in BaseConfig. Ie <see cref="BaseConfig.retryMode"/>
                /// </summary>
                public string ConfigurationName { get; set; }
                public string Documentation { get; set; }
            }
        }
    }

    internal static class ModeExtensions
    {
        /// <summary>
        /// Convenience method that gathers all <see cref="SdkDefaultConfigurationJsonDataModel.Modifier"/>s
        /// that are associated with <paramref name="configurationName"/> into a single array.
        /// </summary>
        /// <param name="configurationName">
        /// <see cref="SdkDefaultConfigurationJsonDataModel.ConfigurationModifiers.ConfigurationName"/>
        /// </param>
        public static SdkDefaultConfigurationJsonDataModel.Modifier[] ModifiersForConfiguration(
            this SdkDefaultConfigurationJsonDataModel.Mode mode, 
            string configurationName)
        {
            return mode
                ?.Modifiers
                .Where(m => m.ConfigurationName == configurationName)
                .SelectMany(x => x.Modifiers)
                .ToArray();
        }
    }
}