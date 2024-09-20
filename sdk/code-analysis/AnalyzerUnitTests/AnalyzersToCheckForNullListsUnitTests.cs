using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;
using VerifyCS = AnalyzerUnitTests.Test.CSharpAnalyzerVerifier<MockAnalyzer.NullCollectionInitializerAnalyzer>;

namespace AnalyzerUnitTests.Test
{
    [TestClass]
    public class AnalyzerUnitTestsUnitTest
    {
        [TestMethod]
        public async Task ObjectInitializationWithAddList()
        {
            var test = new VerifyCS.Test
            {
                TestState =
                {
                    Sources =
                    {
                        (Path.Combine("Snapshots", "ObjectInitializationWithAddList.cs"), await File.ReadAllTextAsync(Path.Combine("Snapshots", "ObjectInitializationWithAddList.cs"))),
                    }
                },
                ExpectedDiagnostics =
                {
                    new DiagnosticResult("AWSSDK2000", DiagnosticSeverity.Warning)
                        .WithMessage("The property 'Item' defaults to null in V4 of the AWS SDK for .NET. The collection must be initialized before adding items to it.")
                        .WithSpan(@"Snapshots\ObjectInitializationWithAddList.cs", 13, 17, 15, 18)
                        .WithArguments("Item")
                },
                ReferenceAssemblies = ReferenceAssemblies.Net.Net80
            };

            test.SolutionTransforms.Add((solution, projectId) =>
            {
                return solution.AddMetadataReference(projectId, MetadataReference.CreateFromFile(typeof(Amazon.DynamoDBv2.Model.PutItemRequest).Assembly.Location));
            });

            await test.RunAsync();

        }
    }
}
