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

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Get the test assembly directory and navigate to the source directory
            var assemblyLocation = Assembly.GetExecutingAssembly().Location;
            var testProjectDirectory = Path.GetDirectoryName(assemblyLocation);
            
            // Navigate up from bin/Debug/net472 to the test project root
            while (testProjectDirectory != null && !File.Exists(Path.Combine(testProjectDirectory, "Custom", "TestData", "mapping.json")))
            {
                testProjectDirectory = Directory.GetParent(testProjectDirectory)?.FullName;
            }
            
            if (testProjectDirectory == null)
            {
                throw new FileNotFoundException("Could not locate mapping.json file in test project directory structure");
            }
            
            var testDataPath = Path.Combine(testProjectDirectory, "Custom", "TestData", "mapping.json");
            
            // Load the mapping configuration
            var jsonContent = File.ReadAllText(testDataPath);
            _mappingJson = JsonDocument.Parse(jsonContent);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _mappingJson?.Dispose();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MapPutObjectResponse_AllMappingsFromJson_PropertiesExist()
        {
            // Get the expected mappings from JSON
            var putObjectMappings = _mappingJson.RootElement
                .GetProperty("Conversion")
                .GetProperty("PutObjectResponse")
                .GetProperty("UploadResponse")
                .EnumerateArray()
                .Select(prop => prop.GetString())
                .ToList();

            Console.WriteLine($"Testing {putObjectMappings.Count} property mappings from JSON configuration");

            // Use reflection to verify each mapping exists
            var sourceType = typeof(PutObjectResponse);
            var targetType = typeof(TransferUtilityUploadResponse);

            var missingSourceProperties = new List<string>();
            var missingTargetProperties = new List<string>();

            foreach (var propertyName in putObjectMappings)
            {
                Console.WriteLine($"Verifying property exists: {propertyName}");

                // Check if source property exists
                var sourceProperty = sourceType.GetProperty(propertyName);
                if (sourceProperty == null)
                {
                    missingSourceProperties.Add(propertyName);
                }

                // Check if target property exists
                var targetProperty = targetType.GetProperty(propertyName);
                if (targetProperty == null)
                {
                    missingTargetProperties.Add(propertyName);
                }
            }

            // Assert no missing properties
            if (missingSourceProperties.Any())
            {
                Assert.Fail($"Missing source properties in PutObjectResponse: {string.Join(", ", missingSourceProperties)}");
            }

            if (missingTargetProperties.Any())
            {
                Assert.Fail($"Missing target properties in TransferUtilityUploadResponse: {string.Join(", ", missingTargetProperties)}");
            }

            Console.WriteLine("✅ All property mappings exist successfully!");
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

            Console.WriteLine($"Testing {putObjectMappings.Count} property mappings from JSON configuration");

            // Create source object with dynamically generated test data
            var sourceResponse = new PutObjectResponse();
            var sourceType = typeof(PutObjectResponse);
            var testDataValues = new Dictionary<string, object>();

            // Generate test data for each mapped property
            foreach (var propertyName in putObjectMappings)
            {
                var sourceProperty = sourceType.GetProperty(propertyName);
                if (sourceProperty?.CanWrite == true)
                {
                    var testValue = GenerateTestValue(sourceProperty.PropertyType, propertyName);
                    sourceProperty.SetValue(sourceResponse, testValue);
                    testDataValues[propertyName] = testValue;
                    Console.WriteLine($"Set {propertyName} = {testValue} ({sourceProperty.PropertyType.Name})");
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
                var sourceProperty = sourceType.GetProperty(propertyName);
                var targetProperty = targetType.GetProperty(propertyName);

                if (sourceProperty == null)
                {
                    failedAssertions.Add($"Source property '{propertyName}' not found in PutObjectResponse");
                    continue;
                }

                if (targetProperty == null)
                {
                    failedAssertions.Add($"Target property '{propertyName}' not found in TransferUtilityUploadResponse");
                    continue;
                }

                var sourceValue = sourceProperty.GetValue(sourceResponse);
                var targetValue = targetProperty.GetValue(mappedResponse);

                // Special handling for complex object comparisons
                if (!AreValuesEqual(sourceValue, targetValue, propertyName))
                {
                    failedAssertions.Add($"{propertyName}: Expected '{sourceValue ?? "null"}', got '{targetValue ?? "null"}'");
                }
                else
                {
                    Console.WriteLine($"✅ {propertyName}: {sourceValue ?? "null"} -> {targetValue ?? "null"}");
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

            Console.WriteLine($"✅ All {putObjectMappings.Count} property mappings verified successfully!");
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

                Console.WriteLine("✅ Null values handled correctly");
            }

            Console.WriteLine("✅ All null value scenarios work correctly!");
        }

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
            // If weve reached this point it means there is an unhandled scenario/missing mapping in our test code that we need to handle. 
            throw new NotSupportedException(
                $"GenerateTestValue does not support type '{propertyType.FullName}' for property '{propertyName}'. " +
                $"Please add support for this type to ensure comprehensive test coverage.");
        }

        /// <summary>
        /// Compares two values for equality with special handling for complex objects
        /// </summary>
        private static bool AreValuesEqual(object sourceValue, object targetValue, string propertyName)
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
    }
}
