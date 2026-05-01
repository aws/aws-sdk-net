/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Collections.Generic;
#if NET8_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;
#endif
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Amazon.BedrockRuntime;

/// <summary>Provides type information for use with <see cref="JsonSerializer"/>.</summary>
[JsonSourceGenerationOptions(JsonSerializerDefaults.Web,
    UseStringEnumConverter = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    WriteIndented = true)]
[JsonSerializable(typeof(Dictionary<string, object?>))]
[JsonSerializable(typeof(IDictionary<string, object?>))]
[JsonSerializable(typeof(bool))]
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(long))]
[JsonSerializable(typeof(float))]
[JsonSerializable(typeof(double))]
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(JsonElement))]
[JsonSerializable(typeof(JsonNode))]
[JsonSerializable(typeof(EmbeddingRequest))]
[JsonSerializable(typeof(EmbeddingResponse))]
internal partial class BedrockJsonContext : JsonSerializerContext
{
    /// <summary>Gets the <see cref="JsonSerializerOptions"/> singleton used as the default in JSON serialization operations.</summary>
    public static readonly JsonSerializerOptions DefaultOptions = CreateDefaultToolJsonOptions();

    /// <summary>Creates the default <see cref="JsonSerializerOptions"/> to use for serialization-related operations.</summary>
#if NET8_0_OR_GREATER
    [UnconditionalSuppressMessage("AotAnalysis", "IL3050", Justification = "DefaultJsonTypeInfoResolver is only used when reflection-based serialization is enabled")]
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "DefaultJsonTypeInfoResolver is only used when reflection-based serialization is enabled")]
#endif
    private static JsonSerializerOptions CreateDefaultToolJsonOptions()
    {
        // If reflection-based serialization is enabled by default, use it, as it's the most permissive in terms of what it can serialize,
        // and we want to be flexible in terms of what can be put into the various collections in the object model.
        // Otherwise, use the source-generated options to enable trimming and Native AOT.

        if (JsonSerializer.IsReflectionEnabledByDefault)
        {
            // Keep in sync with the JsonSourceGenerationOptions attribute on JsonContext above.
            JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
            {
                TypeInfoResolver = new DefaultJsonTypeInfoResolver(),
                Converters = { new JsonStringEnumConverter() },
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                WriteIndented = true,
            };

            options.MakeReadOnly();
            return options;
        }

        // When reflection is disabled (NativeAOT / trimming), we cannot access the static
        // "Default" singleton here because it is also a static member of this class.
        // Accessing Default.Options during the static field initializer for DefaultOptions
        // causes a circular dependency: the static constructor is already running to
        // initialize DefaultOptions, so Default is still null, producing a
        // NullReferenceException that permanently breaks the type.
        //
        // Instead, create a fresh JsonSerializerOptions and attach a new instance of this
        // source-generated context as the TypeInfoResolver. This gives us the same
        // source-generated metadata without the circular static initialization issue.
        var aotOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            TypeInfoResolver = new BedrockJsonContext(),
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true,
        };

        aotOptions.MakeReadOnly();
        return aotOptions;
    }
}