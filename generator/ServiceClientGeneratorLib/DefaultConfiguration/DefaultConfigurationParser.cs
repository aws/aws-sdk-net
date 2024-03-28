using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Json.LitJson;

namespace ServiceClientGenerator.DefaultConfiguration
{
    public interface IDefaultConfigurationParser
    {
        /// <summary>
        /// Parses the passed <paramref name="json"/> to populate a
        /// <see cref="DefaultConfigurationModel"/>
        /// </summary>
        DefaultConfigurationModel Parse(string json);
    }

    public class DefaultConfigurationParser : IDefaultConfigurationParser
    {
        /// <inheritdoc />
        public DefaultConfigurationModel Parse(string json)
        {
            try
            {
                var dataModel = JsonMapper.ToObject<SdkDefaultConfigurationJsonDataModel>(json);

                return ConvertDataModel(dataModel);
            }
            catch (Exception e)
            {
                throw new Exception(
                    $"Error processing Default Configuration Json: {e.Message} \r\n\r\n" +
                    $"Json: \r\n{json}", e);
            }
        }

        private DefaultConfigurationModel ConvertDataModel(SdkDefaultConfigurationJsonDataModel dataModel)
        {
            var modes =
                dataModel
                    .documentation
                    .Modes
                    .Select(x => new
                    {
                        DocumentationModel = x,
                        ModeModel = dataModel.Modes.FirstOrDefault(m => m.Name == x.ModeName)
                    })
                    .Select(x =>
                        new DefaultConfigurationMode
                        {
                            Name = x.DocumentationModel.ModeName.ToPascalCase(),
                            Documentation = x.DocumentationModel.Documentation,

                            RetryMode =
                                ApplyModifiersEnum(
                                    EnumParse<RequestRetryMode>(dataModel.@base.retryMode),
                                    x.ModeModel.ModifiersForConfiguration(nameof(SdkDefaultConfigurationJsonDataModel.BaseConfig.retryMode))),

                            S3UsEast1RegionalEndpoint =
                                ApplyModifiersEnum(
                                    EnumParse<S3UsEast1RegionalEndpointValue>(dataModel.@base.s3UsEast1RegionalEndpoints),
                                    x.ModeModel.ModifiersForConfiguration(nameof(SdkDefaultConfigurationJsonDataModel.BaseConfig.s3UsEast1RegionalEndpoints))),

                            ConnectTimeout =
                                ApplyModifiersTimeSpan(
                                    dataModel.@base.connectTimeoutInMillis,
                                    x.ModeModel.ModifiersForConfiguration(nameof(SdkDefaultConfigurationJsonDataModel.BaseConfig.connectTimeoutInMillis))),

                            TlsNegotiationTimeout =
                                ApplyModifiersTimeSpan(
                                    dataModel.@base.tlsNegotiationTimeoutInMillis,
                                    x.ModeModel.ModifiersForConfiguration(nameof(SdkDefaultConfigurationJsonDataModel.BaseConfig.tlsNegotiationTimeoutInMillis))),

                            TimeToFirstByteTimeout =
                                ApplyModifiersTimeSpan(
                                    dataModel.@base.timeToFirstByteTimeoutInMillis,
                                    x.ModeModel.ModifiersForConfiguration(nameof(SdkDefaultConfigurationJsonDataModel.BaseConfig.timeToFirstByteTimeoutInMillis))),

                            HttpRequestTimeout =
                                ApplyModifiersTimeSpan(
                                    dataModel.@base.httpRequestTimeoutInMillis,
                                    x.ModeModel.ModifiersForConfiguration(nameof(SdkDefaultConfigurationJsonDataModel.BaseConfig.httpRequestTimeoutInMillis)))
                        })
                    .ToList();

            return new DefaultConfigurationModel
            {
                Modes = modes,
                ConfigurationOptionDocumentation = 
                    dataModel
                        .documentation
                        .Configuration
                        .ToDictionary(
                            kvp => kvp.ConfigurationName.ToUpperFirstCharacter(),
                            kvp => kvp.Documentation)
            };
        }

        private TimeSpan? ApplyModifiersTimeSpan(int? baseTimeInMillis, IEnumerable<SdkDefaultConfigurationJsonDataModel.Modifier> modifiers)
        {
            modifiers = modifiers ?? Enumerable.Empty<SdkDefaultConfigurationJsonDataModel.Modifier>();

            TimeSpan? workingValue =
                baseTimeInMillis.HasValue
                    ? (TimeSpan?) TimeSpan.FromMilliseconds(baseTimeInMillis.Value)
                    : null;
            
            foreach (var modifier in modifiers)
            {
                switch (modifier.Operation)
                {
                    case SdkDefaultConfigurationJsonDataModel.ModifierOperation.add:
                        workingValue = (workingValue ?? TimeSpan.Zero).Add(TimeSpan.FromMilliseconds(double.Parse(modifier.Value.ToString())));
                        break;

                    case SdkDefaultConfigurationJsonDataModel.ModifierOperation.multiply:
                        workingValue = TimeSpan.FromMilliseconds((workingValue?.TotalMilliseconds ?? 1) * double.Parse(modifier.Value.ToString()));
                        break;

                    case SdkDefaultConfigurationJsonDataModel.ModifierOperation.@override:
                        workingValue = TimeSpan.FromMilliseconds(double.Parse(modifier.Value.ToString()));
                        break;

                    default:
                        throw new ArgumentOutOfRangeException($"Error:  Update switch statement to handle case [{modifier.Operation}]");
                }
            }

            return workingValue;
        }

        private T ApplyModifiersEnum<T>(T baseValue, IEnumerable<SdkDefaultConfigurationJsonDataModel.Modifier> modifiers)
            where T: struct
        {
            modifiers = modifiers ?? new SdkDefaultConfigurationJsonDataModel.Modifier[0];

            var workingValue = baseValue;

            foreach (var modifier in modifiers)
            {
                switch (modifier.Operation)
                {
                    case SdkDefaultConfigurationJsonDataModel.ModifierOperation.@override:
                        workingValue = EnumParse<T>(modifier.Value?.ToString());
                        break;

                    case SdkDefaultConfigurationJsonDataModel.ModifierOperation.add:
                    case SdkDefaultConfigurationJsonDataModel.ModifierOperation.multiply:
                        throw new InvalidOperationException($"Can not apply Operation [{modifier.Operation}] to Enum");

                    default:
                        throw new ArgumentOutOfRangeException($"Error:  Update switch statement to handle case [{modifier.Operation}]");
                }
            }

            return workingValue;
        }

        private T EnumParse<T>(string s) 
            where T : struct
        {
            s = s ?? "";

            if (Enum.TryParse<T>(s, ignoreCase: true, out var result))
                return result;

            throw new Exception(
                $"Failed parsing [{s}] as [{typeof(T).Name}].  " +
                $"Valid values are [{string.Join(",", Enum.GetNames(typeof(T)))}]");
        }
    }
}