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

using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.Json;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ResponseMapperTests
    {
        private static JsonDocument _mappingJson;
        private static JsonDocument _propertyAliasesJson;
        private static Dictionary<string, string> _propertyAliases;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Read mapping.json using robust resource loading (same pattern as Utils.cs)
            using (var stream = GetResourceStream("mapping.json"))
            {
                if (stream == null)
                {
                    throw new FileNotFoundException("Could not find embedded resource: mapping.json");
                }
                    
                using (var reader = new StreamReader(stream))
                {
                    var jsonContent = reader.ReadToEnd();
                    _mappingJson = JsonDocument.Parse(jsonContent);
                }
            }
            
            // Read property-aliases.json using robust resource loading
            using (var stream = GetResourceStream("property-aliases.json"))
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var aliasContent = reader.ReadToEnd();
                        _propertyAliasesJson = JsonDocument.Parse(aliasContent);
                        
                        // Convert to dictionary for fast lookup
                        _propertyAliases = new Dictionary<string, string>();
                        var aliasesElement = _propertyAliasesJson.RootElement.GetProperty("PropertyAliases");
                        foreach (var alias in aliasesElement.EnumerateObject())
                        {
                            _propertyAliases[alias.Name] = alias.Value.GetString();
                        }
                    }
                }
                else
                {
                    _propertyAliases = new Dictionary<string, string>();
                }
            }
        }

        /// <summary>
        /// Gets embedded resource stream using partial name matching (same pattern as Utils.cs)
        /// </summary>
        private static Stream GetResourceStream(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var resource = FindResourceName(assembly, resourceName);
            if(resource == null)
            {
                assembly = Assembly.GetCallingAssembly();
                resource = FindResourceName(assembly, resourceName);
            }

            return resource != null ? assembly.GetManifestResourceStream(resource) : null;
        }

        /// <summary>
        /// Finds resource name using case-insensitive partial matching (same pattern as Utils.cs) 
        /// </summary>
        private static string FindResourceName(Assembly assembly, string partialName)
        {
            var resources = FindResourceName(assembly, s => s.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0);
            return resources.FirstOrDefault();
        }

        /// <summary>
        /// Finds resource names matching predicate (same pattern as Utils.cs)
        /// </summary>
        private static IEnumerable<string> FindResourceName(Assembly assembly, Predicate<string> match)
        {    
            var allResources = assembly.GetManifestResourceNames();
            foreach (var resource in allResources)
            {
                if (match(resource))
                    yield return resource;
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _mappingJson?.Dispose();
            _propertyAliasesJson?.Dispose();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MapPutObjectResponse_AllMappedProperties_WorkCorrectly()
        {
            // Get the expected mappings from JSON
            var putObjectMappings = _mappingJson.RootElement
                .GetProperty("Conversion")
                .GetProperty("PutObjectResponse")
                .GetProperty("UploadResponse")
                .EnumerateArray()
                .Select(prop => prop.GetString())
                .ToList();

            // Create source object with dynamically generated test data
            var sourceResponse = new PutObjectResponse();
            var sourceType = typeof(PutObjectResponse);
            var testDataValues = new Dictionary<string, object>();

            // Generate test data for each mapped property
            foreach (var propertyName in putObjectMappings)
            {
                // Resolve alias to actual property name
                var resolvedPropertyName = ResolvePropertyName(propertyName);
                var sourceProperty = sourceType.GetProperty(resolvedPropertyName);
                if (sourceProperty?.CanWrite == true)
                {
                    var testValue = GenerateTestValue(sourceProperty.PropertyType, propertyName);
                    sourceProperty.SetValue(sourceResponse, testValue);
                    testDataValues[propertyName] = testValue;
                }
            }

            // Add inherited properties for comprehensive testing
            sourceResponse.HttpStatusCode = HttpStatusCode.OK;
            sourceResponse.ContentLength = 1024;

            // Map the response
            var mappedResponse = ResponseMapper.MapPutObjectResponse(sourceResponse);
            Assert.IsNotNull(mappedResponse, "Mapped response should not be null");

            // Verify all mapped properties using reflection
            var targetType = typeof(TransferUtilityUploadResponse);
            var failedAssertions = new List<string>();

            foreach (var propertyName in putObjectMappings)
            {
                // Resolve alias to actual property name for reflection lookups
                var resolvedPropertyName = ResolvePropertyName(propertyName);
                var sourceProperty = sourceType.GetProperty(resolvedPropertyName);
                var targetProperty = targetType.GetProperty(resolvedPropertyName);

                if (sourceProperty == null)
                {
                    failedAssertions.Add($"Source property '{propertyName}' (resolved to: {resolvedPropertyName}) not found in PutObjectResponse");
                    continue;
                }

                if (targetProperty == null)
                {
                    failedAssertions.Add($"Target property '{propertyName}' (resolved to: {resolvedPropertyName}) not found in TransferUtilityUploadResponse");
                    continue;
                }

                var sourceValue = sourceProperty.GetValue(sourceResponse);
                var targetValue = targetProperty.GetValue(mappedResponse);

                // Special handling for complex object comparisons
                if (!AreValuesEqual(sourceValue, targetValue))
                {
                    failedAssertions.Add($"{propertyName}: Expected '{sourceValue ?? "null"}', got '{targetValue ?? "null"}'");
                }
            }

            // Test inherited properties
            Assert.AreEqual(sourceResponse.HttpStatusCode, mappedResponse.HttpStatusCode, "HttpStatusCode should match");
            Assert.AreEqual(sourceResponse.ContentLength, mappedResponse.ContentLength, "ContentLength should match");

            // Report any failures
            if (failedAssertions.Any())
            {
                Assert.Fail($"Property mapping failures:\n{string.Join("\n", failedAssertions)}");
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MapPutObjectResponse_NullValues_HandledCorrectly()
        {
            // Test null handling scenarios
            var testCases = new[]
            {
                // Test null Expiration
                new PutObjectResponse { Expiration = null },
                
                // Test null enum conversions
                new PutObjectResponse { ChecksumType = null, RequestCharged = null, ServerSideEncryptionMethod = null }
            };

            foreach (var testCase in testCases)
            {
                var mapped = ResponseMapper.MapPutObjectResponse(testCase);
                Assert.IsNotNull(mapped, "Response should always be mappable");

                // Test null handling
                if (testCase.Expiration == null)
                {
                    Assert.IsNull(mapped.Expiration, "Null Expiration should map to null");
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ValidateTransferUtilityUploadResponseDefinitionCompleteness()
        {
            ValidateResponseDefinitionCompleteness<TransferUtilityUploadResponse>(
                new[] { "Definition", "UploadResponse", "PutObjectResponse" },
                "TransferUtilityUploadResponse");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ValidateCompleteMultipartUploadResponseConversionCompleteness()
        {
            ValidateResponseDefinitionCompleteness<TransferUtilityUploadResponse>(
                new[] { "Conversion", "CompleteMultipartResponse", "UploadResponse" },
                "TransferUtilityUploadResponse");
        }
        
        // Uncomment for DOTNET-8277

        // [TestMethod]
        // [TestCategory("S3")]
        // public void ValidatePutObjectRequestDefinitionCompleteness()
        // {
        //     ValidateResponseDefinitionCompleteness<PutObjectRequest>(
        //         new[] { "Definition", "UploadRequest", "PutObjectRequest" },
        //         "PutObjectRequest");
        // }

        // [TestMethod]
        // [TestCategory("S3")]
        // public void ValidateGetObjectRequestDefinitionCompleteness()
        // {
        //     ValidateResponseDefinitionCompleteness<GetObjectRequest>(
        //         new[] { "Definition", "DownloadRequest", "GetObjectRequest" },
        //         "GetObjectRequest");
        // }

        // [TestMethod]
        // [TestCategory("S3")]
        // public void ValidateGetObjectRequestDefinitionCompleteness()
        // {
        //     ValidateResponseDefinitionCompleteness<GetObjectRequest>(
        //         new[] { "Definition", "DownloadRequest", "GetObjectRequest" },
        //         "TransferUtilityDownloadRequest");
        // }

        /// <summary>
        /// Generates appropriate test data for a given property type
        /// </summary>
        private static object GenerateTestValue(Type propertyType, string propertyName)
        {
            // Handle nullable types
            if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                var underlyingType = Nullable.GetUnderlyingType(propertyType);
                return GenerateTestValue(underlyingType, propertyName);
            }

            // String properties
            if (propertyType == typeof(string))
            {
                return $"test-{propertyName.ToLower()}";
            }

            // Boolean properties
            if (propertyType == typeof(bool))
            {
                return true;
            }

            // Enum properties
            if (propertyType.IsEnum)
            {
                // For all enums, use the first available value
                var enumValues = Enum.GetValues(propertyType);
                return enumValues.Length > 0 ? enumValues.GetValue(0) : 
                    throw new InvalidOperationException($"Enum {propertyType.Name} has no values");
            }

            // AWS SDK ConstantClass properties (like ChecksumType, RequestCharged, etc.)
            if (typeof(ConstantClass).IsAssignableFrom(propertyType))
            {
                // Use reflection to get static readonly fields that are of the same type
                var constantFields = propertyType.GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Where(f => f.IsStatic && f.IsInitOnly && f.FieldType == propertyType);
                
                var firstConstant = constantFields.FirstOrDefault();
                return firstConstant?.GetValue(null) ?? 
                    throw new InvalidOperationException($"ConstantClass {propertyType.Name} has no static constants");
            }

            // Special object types
            if (propertyType == typeof(Expiration))
            {
                return new Expiration 
                { 
                    ExpiryDate = DateTime.UtcNow.AddDays(30), 
                    RuleId = "test-expiration-rule" 
                };
            }

            // Integer types
            if (propertyType == typeof(int) || propertyType == typeof(long))
            {
                return 1024;
            }

            // For unknown types, throw an exception instead of returning null
            // If we've reached this point it means there is an unhandled scenario/missing mapping in our test code that we need to handle. 
            throw new NotSupportedException(
                $"GenerateTestValue does not support type '{propertyType.FullName}' for property '{propertyName}'. " +
                $"Please add support for this type to ensure comprehensive test coverage.");
        }

        /// <summary>
        /// Compares two values for equality with special handling for complex objects
        /// </summary>
        private static bool AreValuesEqual(object sourceValue, object targetValue)
        {
            // Both null
            if (sourceValue == null && targetValue == null)
                return true;

            // One null, other not
            if (sourceValue == null || targetValue == null)
                return false;

            // Special handling for Expiration objects
            if (sourceValue is Expiration sourceExpiration && targetValue is Expiration targetExpiration)
            {
                return sourceExpiration.ExpiryDate == targetExpiration.ExpiryDate &&
                       sourceExpiration.RuleId == targetExpiration.RuleId;
            }

            // For most cases, use default equality
            return sourceValue.Equals(targetValue);
        }

        /// <summary>
        /// Resolves a property name to its actual class property name, checking aliases if needed
        /// </summary>
        private static string ResolvePropertyName(string propertyName)
        {
            // Check if there's an alias for this property name
            if (_propertyAliases.TryGetValue(propertyName, out var aliasedName))
            {
                return aliasedName;
            }
            
            // Return the original name if no alias exists
            return propertyName;
        }

        /// <summary>
        /// Generic helper method to validate response definition completeness.
        /// This method ensures that all properties defined in mapping.json actually exist 
        /// in the corresponding AWS SDK response classes, supporting property name aliases
        /// for backwards compatibility and maintainability.
        /// </summary>
        private static void ValidateResponseDefinitionCompleteness<TResponse>(
            string[] jsonPath,
            string responseTypeName,
            Func<IEnumerable<string>> getAdditionalProperties = null)
        {
            // Get direct properties from response class
            var directProperties = typeof(TResponse)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead)
                .Select(p => p.Name)
                .ToList();

            // Get additional properties if provided (e.g., HeadersCollection properties)
            var additionalProperties = getAdditionalProperties?.Invoke()?.ToList() ?? new List<string>();

            // Combine direct and additional properties
            var actualProperties = directProperties.Union(additionalProperties)
                .OrderBy(name => name)
                .ToList();

            // Navigate to the JSON definition using the provided path
            var jsonElement = _mappingJson.RootElement;
            foreach (var pathSegment in jsonPath)
            {
                jsonElement = jsonElement.GetProperty(pathSegment);
            }

            var definitionProperties = jsonElement
                .EnumerateArray()
                .Select(prop => prop.GetString())
                .OrderBy(name => name)
                .ToList();

            // Check each definition property, resolving aliases as needed
            var extraInDefinition = new List<string>();
            
            foreach (var definitionProperty in definitionProperties)
            {
                var resolvedPropertyName = ResolvePropertyName(definitionProperty);
                
                // Check if the resolved property name exists in the actual class
                if (!actualProperties.Contains(resolvedPropertyName))
                {
                    extraInDefinition.Add($"{definitionProperty} (resolved to: {resolvedPropertyName})");
                }
            }

            // Assert no extra properties
            if (extraInDefinition.Any())
            {
                var additionalContext = additionalProperties.Any() 
                    ? $" or additional properties" 
                    : "";
                
                Assert.Fail($"Definition section contains {extraInDefinition.Count} extra properties that don't exist in the actual {responseTypeName} class{additionalContext}: {string.Join(", ", extraInDefinition)}. " +
                           $"Please verify they exist in the response class{additionalContext}.");
            }
        }
    }
}
