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
            // DEBUG: Log initial setup information
            Console.WriteLine("=== DEBUG: ResponseMapperTests ClassInitialize ===");
            Console.WriteLine($"Current Working Directory: {Directory.GetCurrentDirectory()}");
            
            // Get the test assembly directory and navigate to the source directory
            var assemblyLocation = Assembly.GetExecutingAssembly().Location;
            Console.WriteLine($"Assembly Location: {assemblyLocation}");
            
            var testProjectDirectory = Path.GetDirectoryName(assemblyLocation);
            Console.WriteLine($"Initial Test Project Directory: {testProjectDirectory}");
            
            // DEBUG: Log directory contents at starting point
            if (testProjectDirectory != null && Directory.Exists(testProjectDirectory))
            {
                Console.WriteLine($"Contents of starting directory '{testProjectDirectory}':");
                try
                {
                    var files = Directory.GetFiles(testProjectDirectory);
                    var dirs = Directory.GetDirectories(testProjectDirectory);
                    Console.WriteLine($"  Files: {string.Join(", ", files.Select(Path.GetFileName))}");
                    Console.WriteLine($"  Directories: {string.Join(", ", dirs.Select(Path.GetFileName))}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Error reading directory: {ex.Message}");
                }
            }
            
            // Navigate up from bin/Debug/net472 to the test project root
            int searchDepth = 0;
            const int maxSearchDepth = 10; // Prevent infinite loops
            
            while (testProjectDirectory != null && searchDepth < maxSearchDepth)
            {
                var targetPath = Path.Combine(testProjectDirectory, "Custom", "TestData", "mapping.json");
                Console.WriteLine($"Search attempt {searchDepth + 1}: Checking for file at '{targetPath}'");
                Console.WriteLine($"  Directory exists: {Directory.Exists(testProjectDirectory)}");
                Console.WriteLine($"  File exists: {File.Exists(targetPath)}");
                
                // DEBUG: Log what's in the current directory
                if (Directory.Exists(testProjectDirectory))
                {
                    try
                    {
                        var subdirs = Directory.GetDirectories(testProjectDirectory);
                        Console.WriteLine($"  Subdirectories: {string.Join(", ", subdirs.Select(Path.GetFileName))}");
                        
                        // Check if Custom directory exists
                        var customDir = Path.Combine(testProjectDirectory, "Custom");
                        if (Directory.Exists(customDir))
                        {
                            Console.WriteLine($"  Custom directory found at: {customDir}");
                            var customSubdirs = Directory.GetDirectories(customDir);
                            Console.WriteLine($"  Custom subdirectories: {string.Join(", ", customSubdirs.Select(Path.GetFileName))}");
                            
                            // Check if TestData directory exists
                            var testDataDir = Path.Combine(customDir, "TestData");
                            if (Directory.Exists(testDataDir))
                            {
                                Console.WriteLine($"  TestData directory found at: {testDataDir}");
                                var testDataFiles = Directory.GetFiles(testDataDir);
                                Console.WriteLine($"  TestData files: {string.Join(", ", testDataFiles.Select(Path.GetFileName))}");
                            }
                            else
                            {
                                Console.WriteLine($"  TestData directory NOT found at: {testDataDir}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"  Custom directory NOT found at: {customDir}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"  Error examining directory: {ex.Message}");
                    }
                }
                
                if (File.Exists(targetPath))
                {
                    Console.WriteLine($"SUCCESS: Found mapping.json at '{targetPath}'");
                    break;
                }
                
                var parentDir = Directory.GetParent(testProjectDirectory);
                testProjectDirectory = parentDir?.FullName;
                Console.WriteLine($"  Moving up to parent: {testProjectDirectory ?? "null"}");
                searchDepth++;
            }
            
            if (testProjectDirectory == null)
            {
                Console.WriteLine("ERROR: Exhausted directory search - testProjectDirectory is null");
                Console.WriteLine($"Searched {searchDepth} levels up from assembly location: {assemblyLocation}");
                throw new FileNotFoundException(
                    $"Could not locate mapping.json file in test project directory structure. " +
                    $"Started from: {assemblyLocation}, searched {searchDepth} levels up.");
            }
            
            if (searchDepth >= maxSearchDepth)
            {
                Console.WriteLine($"ERROR: Reached maximum search depth of {maxSearchDepth}");
                throw new FileNotFoundException(
                    $"Could not locate mapping.json file within {maxSearchDepth} directory levels. " +
                    $"Started from: {assemblyLocation}");
            }
            
            var testDataPath = Path.Combine(testProjectDirectory, "Custom", "TestData", "mapping.json");
            var aliasesPath = Path.Combine(testProjectDirectory, "Custom", "TestData", "property-aliases.json");
            
            Console.WriteLine($"Final resolved paths:");
            Console.WriteLine($"  Mapping file: {testDataPath}");
            Console.WriteLine($"  Aliases file: {aliasesPath}");
            Console.WriteLine($"  Mapping file exists: {File.Exists(testDataPath)}");
            Console.WriteLine($"  Aliases file exists: {File.Exists(aliasesPath)}");
            
            // Load the mapping configuration
            try
            {
                var jsonContent = File.ReadAllText(testDataPath);
                Console.WriteLine($"Successfully read mapping.json ({jsonContent.Length} characters)");
                _mappingJson = JsonDocument.Parse(jsonContent);
                Console.WriteLine("Successfully parsed mapping.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR reading or parsing mapping.json: {ex.Message}");
                throw;
            }
            
            // Load property aliases if the file exists
            if (File.Exists(aliasesPath))
            {
                try
                {
                    var aliasContent = File.ReadAllText(aliasesPath);
                    Console.WriteLine($"Successfully read property-aliases.json ({aliasContent.Length} characters)");
                    _propertyAliasesJson = JsonDocument.Parse(aliasContent);
                    
                    // Convert to dictionary for fast lookup
                    _propertyAliases = new Dictionary<string, string>();
                    var aliasesElement = _propertyAliasesJson.RootElement.GetProperty("PropertyAliases");
                    foreach (var alias in aliasesElement.EnumerateObject())
                    {
                        _propertyAliases[alias.Name] = alias.Value.GetString();
                    }
                    Console.WriteLine($"Loaded {_propertyAliases.Count} property aliases");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR reading or parsing property-aliases.json: {ex.Message}");
                    throw;
                }
            }
            else
            {
                Console.WriteLine("property-aliases.json not found, using empty aliases dictionary");
                _propertyAliases = new Dictionary<string, string>();
            }
            
            Console.WriteLine("=== END DEBUG: ClassInitialize completed successfully ===");
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
        public void ValidatePutObjectResponseDefinitionCompleteness()
        {
            ValidateResponseDefinitionCompleteness<PutObjectResponse>(
                new[] { "Definition", "UploadResponse", "PutObjectResponse" },
                "PutObjectResponse");
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


        [TestMethod]
        [TestCategory("S3")]
        public void ValidateGetObjectResponseDefinitionCompleteness()
        {
            ValidateResponseDefinitionCompleteness<GetObjectResponse>(
                new[] { "Definition", "DownloadResponse", "GetObjectResponse" },
                "GetObjectResponse",
                // GetObjectResponse has some properties returned in the Headers property for legacy reasons which is different
                // than the model, so we check the Headers as well.
                GetHeadersCollectionProperties);
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

        /// <summary>
        /// Gets properties from HeadersCollection that should be included in validation
        /// </summary>
        private static IEnumerable<string> GetHeadersCollectionProperties()
        {
            return typeof(HeadersCollection)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead && p.Name != "Count" && p.Name != "Keys") // Exclude collection metadata properties
                .Select(p => p.Name);
        }
    }
}
