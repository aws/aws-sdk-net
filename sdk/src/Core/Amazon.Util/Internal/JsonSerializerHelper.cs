using System;
using System.Collections.Generic;
using System.Text;

#if NET8_0_OR_GREATER
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
#endif

namespace Amazon.Util.Internal
{
    public static class JsonSerializerHelper
    {
#if NET8_0_OR_GREATER
        public static T Deserialize<T>(string json, JsonSerializerContext context)
        {
            return JsonSerializer.Deserialize<T>(json, context.GetTypeInfo(typeof(T)) as JsonTypeInfo<T>);
        }

        public static string Serialize<T>(object obj, JsonSerializerContext context)
        {
            return JsonSerializer.Serialize(obj, typeof(T), context);
        }
#else
        public static T Deserialize<T>(string json, JsonSerializerContext typeInfo)
        {
            return ThirdParty.Json.LitJson.JsonMapper.ToObject<T>(json);
        }

        public static string Serialize<T>(object obj, JsonSerializerContext typeInfo)
        {
            var json = new StringBuilder();
            var writer = new ThirdParty.Json.LitJson.JsonWriter(json)
            {
                PrettyPrint = (typeInfo?.Options?.WriteIndented).GetValueOrDefault()
            };

            ThirdParty.Json.LitJson.JsonMapper.ToJson(obj, writer);
            return json.ToString();
        }
#endif
    }

    [JsonSerializable(typeof(IAMInstanceProfileMetadata))]
    [JsonSerializable(typeof(IAMSecurityCredentialMetadata))]
    public partial class EC2InstanceMetadataJsonSerializerContexts : JsonSerializerContext
    {
    }

    [JsonSerializable(typeof(Dictionary<string, string>))]
    public partial class DictionaryStringStringJsonSerializerContexts : JsonSerializerContext
    {
#if !NET8_0_OR_GREATER
        public DictionaryStringStringJsonSerializerContexts(JsonSerializerOptions defaultOptions)
            : base(defaultOptions)
        {
        }
#endif
    }

    [JsonSerializable(typeof(Dictionary<string, Dictionary<string, string>>))]
    public partial class DictionaryStringDictionaryStringJsonSerializerContexts : JsonSerializerContext
    {
#if !NET8_0_OR_GREATER
        public DictionaryStringDictionaryStringJsonSerializerContexts(JsonSerializerOptions defaultOptions)
            : base(defaultOptions)
        {
        }
#endif
    }

    [JsonSerializable(typeof(Dictionary<string, object>))]
    [JsonSerializable(typeof(Dictionary<string, string>))]
    [JsonSerializable(typeof(long))]
    public partial class DictionaryStringObjectJsonSerializerContexts : JsonSerializerContext
    {
#if !NET8_0_OR_GREATER
        public DictionaryStringObjectJsonSerializerContexts(JsonSerializerOptions defaultOptions)
            : base(defaultOptions)
        {
        }
#endif
    }

    [JsonSerializable(typeof(List<string>))]
    public partial class ListStringJsonSerializerContexts : JsonSerializerContext
    {

    }

    [JsonSerializable(typeof(Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityCredentials))]
    public partial class SecurityCredentialsJsonSerializerContexts : JsonSerializerContext
    {
    }

    [JsonSerializable(typeof(Amazon.Runtime.URIBasedRefreshingCredentialHelper.SecurityInfo))]
    public partial class SecurityInfoJsonSerializerContexts : JsonSerializerContext
    {
    }

    [JsonSerializable(typeof(Amazon.Runtime.Internal.ProcessCredentialVersion1))]
    public partial class ProcessCredentialVersion1JsonSerializerContexts : JsonSerializerContext
    {
    }

    [JsonSerializable(typeof(Amazon.Runtime.Internal.Endpoints.StandardLibrary.PartitionFunctionShape))]
    public partial class PartitionFunctionShapeJsonSerializerContexts : JsonSerializerContext
    {
    }

    // For targets below .NET 6 create stub versions of the System.Text.Json types so that the context objects can still compile.
    // None of these type are actually used because the JSON parsing ends up using JsonMapper from LitJson for targets below .NET 6.
    // Doing this allows the SDK to have a single JsonSerializerHelper.Deserialize method to use throughout the SDK to handle JSON marshalling.
#if !NET8_0_OR_GREATER
    public class JsonSerializerContext
    {
        public JsonSerializerContext() { }

        public JsonSerializerContext(JsonSerializerOptions defaultOptions) 
        {
            Options = defaultOptions;
        }

        public JsonSerializerOptions Options { get; private set; }

        public static JsonSerializerContext Default { get; set; }
    }

    public class JsonSerializerOptions
    {
        public bool PropertyNameCaseInsensitive { get; set; }

        public bool WriteIndented {get;set;}
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal sealed class JsonSerializableAttribute : Attribute { internal JsonSerializableAttribute(Type type) { } }
#endif
}
