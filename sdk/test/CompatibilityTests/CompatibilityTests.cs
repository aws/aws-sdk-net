using System.Reflection;
using System.Runtime.CompilerServices;
using Amazon.S3;
using Amazon.DynamoDBv2;
using Amazon.SQS;
using Amazon.BedrockRuntime;
using Amazon.SimpleSystemsManagement;
using Xunit;

namespace CompatibilityTests
{
    /// <summary>
    /// Compatibility tests for testing newer .NET Core versions with older AWS SDK service DLLs
    /// This directly instantiates service clients to trigger CLR type checking, which will
    /// catch compatibility issues like missing methods (e.g., get_ServiceFullName) when
    /// mixing old service packages with newer Core versions.
    /// </summary>
    public class CompatibilityTests
    {
        [Fact]
        public void TestS3SimpleCall()
        {
            using (var s3Client = new AmazonS3Client())
            {
                s3Client.ListBucketsAsync();
            }
        }

        [Fact]
        public void TestDynamoDBSimpleCall()
        {
            using (var ddbClient = new AmazonDynamoDBClient())
            {
                try
                {
                    ddbClient.ListTablesAsync(5);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Simple ListTables creation failed with {ex.GetType().Name}: {ex.Message}");
                    throw ex;
                }
            }
        }

        [Fact]
        public void TestSQSClientCreation()
        {
            // Act & Assert
            var exception = Record.Exception(() =>
            {
                var sqsClient = new AmazonSQSClient();
                Assert.NotNull(sqsClient);
            });

            if (exception != null)
            {
                Console.WriteLine($"SQS client creation failed with: {exception.GetType().Name}: {exception.Message}");
                throw exception;
            }
        }

        [Fact]
        public void TestBedrockRuntimeClientCreation()
        {
            // Act & Assert
            var exception = Record.Exception(() =>
            {
                var bedrockClient = new AmazonBedrockRuntimeClient();
                Assert.NotNull(bedrockClient);
            });

            if (exception != null)
            {
                Console.WriteLine($"BedrockRuntime client creation failed with: {exception.GetType().Name}: {exception.Message}");
                throw exception;
            }
        }

        [Fact]
        public void TestSimpleSystemsManagementClientCreation()
        {
            // Act & Assert
            // This is the service mentioned in the GitHub issue - SSM
            var exception = Record.Exception(() =>
            {
                var ssmClient = new AmazonSimpleSystemsManagementClient();
                Assert.NotNull(ssmClient);
            });

            if (exception != null)
            {
                Console.WriteLine($"SSM client creation failed with: {exception.GetType().Name}: {exception.Message}");
                throw exception;
            }
        }

        private static readonly string[] TestedServiceDlls = new[]
        {
            "AWSSDK.S3.dll",
            "AWSSDK.DynamoDBv2.dll",
            "AWSSDK.SQS.dll",
            "AWSSDK.BedrockRuntime.dll",
            "AWSSDK.SimpleSystemsManagement.dll"
        };

        [Fact]
        public void VerifyAllMethodReferencesResolve()
        {
            var dllsPath = Path.Combine(AppContext.BaseDirectory, "DownloadedDlls");
            if (!Directory.Exists(dllsPath))
            {
                dllsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "DownloadedDlls");
            }

            Assert.True(Directory.Exists(dllsPath), $"Downloaded DLLs directory not found at: {dllsPath}");

            var dllFiles = TestedServiceDlls
                .Select(name => Path.Combine(dllsPath, name))
                .Where(File.Exists)
                .ToArray();
            Assert.NotEmpty(dllFiles);

            var failures = new List<string>();

            foreach (var dll in dllFiles)
            {
                Assembly assembly;
                try
                {
                    assembly = Assembly.LoadFrom(dll);
                }
                catch (Exception ex)
                {
                    failures.Add($"Failed to load assembly {Path.GetFileName(dll)}: {ex.Message}");
                    continue;
                }

                Type[] types;
                try
                {
                    types = assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    types = ex.Types.Where(t => t != null).ToArray();
                }

                foreach (var type in types)
                {
                    MethodInfo[] methods;
                    try
                    {
                        methods = type.GetMethods(
                            BindingFlags.Instance | BindingFlags.Static |
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.DeclaredOnly);
                    }
                    catch
                    {
                        continue;
                    }

                    foreach (var method in methods)
                    {
                        try
                        {
                            if (method.IsAbstract || method.ContainsGenericParameters)
                                continue;

                            RuntimeHelpers.PrepareMethod(method.MethodHandle);
                        }
                        catch (Exception ex) when (ex is MissingMethodException || ex is MissingFieldException || ex is TypeLoadException)
                        {
                            failures.Add($"{Path.GetFileName(dll)}: {type.FullName}.{method.Name} - {ex.GetType().Name}: {ex.Message}");
                        }
                        catch
                        {
                            // Ignore other exceptions (e.g., FileNotFoundException for unrelated dependencies)
                        }
                    }
                }
            }

            if (failures.Count > 0)
            {
                var message = $"Found {failures.Count} compatibility issue(s):\n" + string.Join("\n", failures);
                Console.WriteLine(message);
                Assert.Fail(message);
            }
        }
    }
}
