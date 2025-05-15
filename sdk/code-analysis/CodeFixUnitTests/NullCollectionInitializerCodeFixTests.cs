using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerifyCS = CodeFixUnitTests.CSharpCodeFixVerifier<MockAnalyzer.NullCollectionInitializerAnalyzer, Amazon.CodeAnalysis.Shared.CodeFixes.NullCollectionInitializerCodeFixProvider>;

namespace CodeFixUnitTests
{
    [TestClass]
    public sealed class NullCollectionInitializerCodeFixTests
    {
        [TestMethod]
        public async Task TestDictionaryInitialization()
        {
            var before = @"
using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

class Test
{
    void Method()
    {
        var request = new PutItemRequest
        {
            Item =
            {
                { ""Key1"", new AttributeValue {S = ""hello""} },
            }
        };
    }
}";

            var after = @"
using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

class Test
{
    void Method()
    {
        var request = new PutItemRequest
        {
            Item = new Dictionary<string, AttributeValue>()
            {
                { ""Key1"", new AttributeValue {S = ""hello""} },
            }
        };
    }
}";

            var test = new VerifyCS.Test
            {
                TestCode = before,
                FixedCode = after,
                ReferenceAssemblies = ReferenceAssemblies.NetCore.NetCoreApp31,
                ExpectedDiagnostics =
                {
                    new DiagnosticResult("AWSSDK2000", DiagnosticSeverity.Warning)
                        .WithMessage("The property 'Item' defaults to null in V4 of the AWS SDK for .NET. The collection must be initialized before adding items to it.")
                        .WithSpan(13, 13, 15, 14)
                        .WithArguments("Item")
                }
            };

            test.SolutionTransforms.Add((solution, projectId) =>
            {
                return solution.AddMetadataReference(projectId, MetadataReference.CreateFromFile(typeof(Amazon.DynamoDBv2.Model.PutItemRequest).Assembly.Location));
            });
            await test.RunAsync();
        }

        [TestMethod]
        public async Task TestListInitialization()
        {
            var before = @"
using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

class Test
{
    void Method()
    {
        var request = new GetItemRequest
        {
            AttributesToGet =
            {
                ""attribute1""
            }
        };
    }
}";

            var after = @"
using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

class Test
{
    void Method()
    {
        var request = new GetItemRequest
        {
            AttributesToGet = new List<string>()
            {
                ""attribute1""
            }
        };
    }
}";

            var test = new VerifyCS.Test
            {
                TestCode = before,
                FixedCode = after,
                ReferenceAssemblies = ReferenceAssemblies.NetCore.NetCoreApp31,
                ExpectedDiagnostics =
                {
                    new DiagnosticResult("AWSSDK2000", DiagnosticSeverity.Warning)
                        .WithMessage("The property 'AttributesToGet' defaults to null in V4 of the AWS SDK for .NET. The collection must be initialized before adding items to it.")
                        .WithSpan(13, 13, 15, 14)
                        .WithArguments("AttributesToGet")
                }
            };

            test.SolutionTransforms.Add((solution, projectId) =>
            {
                return solution.AddMetadataReference(projectId, MetadataReference.CreateFromFile(typeof(Amazon.DynamoDBv2.Model.GetItemRequest).Assembly.Location));
            });
            await test.RunAsync();
        }
    }
}
