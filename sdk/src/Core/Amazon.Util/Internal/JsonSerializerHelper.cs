using System;

#if NET6_0_OR_GREATER
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
#endif

namespace Amazon.Util.Internal
{
    public static class JsonSerializerHelper
    {
#if NET6_0_OR_GREATER
        public static T Deserialize<T>(string json, JsonSerializerContext context)
        {
            return JsonSerializer.Deserialize<T>(json, context.GetTypeInfo(typeof(T)) as JsonTypeInfo<T>);
        }
#else
        public static T Deserialize<T>(string json, object typeInfo)
        {
            return ThirdParty.Json.LitJson.JsonMapper.ToObject<T>(json);
        }
#endif
    }

    [JsonSerializable(typeof(IAMInstanceProfileMetadata))]
    [JsonSerializable(typeof(IAMSecurityCredentialMetadata))]
    public partial class EC2InstanceMetadataJsonSerializerContexts : JsonSerializerContext
    {
    }


    // For targets below .NET 6 create stub versions of the System.Text.Json types so that the context objects can still compile.
    // None of these type are actually used because the JSON parsing ends up using JsonMapper from LitJson for targets below .NET 6.
    // Doing this allows the SDK to have a single JsonSerializerHelper.Deserialize method to use throughout the SDK to handle JSON marshalling.
#if !NET6_0_OR_GREATER
    public class JsonSerializerContext
    {
        public JsonSerializerContext() { }

        public JsonSerializerContext(JsonSerializerOptions DefaultOptions) { }

        public static JsonSerializerContext Default { get; set; }
    }

    public class JsonSerializerOptions
    {
        public bool PropertyNameCaseInsensitive { get; set; }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal sealed class JsonSerializableAttribute : Attribute { internal JsonSerializableAttribute(Type type) { } }
#endif
}
