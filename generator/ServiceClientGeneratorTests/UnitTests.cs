using Json.LitJson;
using ServiceClientGenerator;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;
using System.Linq;

namespace ServiceClientGeneratorTests
{
    [Trait("Category", "UnitTests")]
    public class UnitTests
    {
        // This goes serviceAbbreviation : serviceFullName : serviceId
        static readonly IList<Tuple<string, string, string>> serviceIDMetadata = new List<Tuple<string, string, string>>();
        private readonly ServiceModel _model;
        private readonly string _modelsPath = "../../../TestModel.json";
        private readonly string _paginatorsPath = "../../../TestPaginators.json";

        public UnitTests()
        {
            _model = new ServiceModel(_modelsPath, null, _paginatorsPath);
            serviceIDMetadata.Add(Tuple.Create("Amazon EC2", "Amazon Elastic Compute Cloud", "EC2"));
            serviceIDMetadata.Add(Tuple.Create("AWS IoT", string.Empty, "IoT"));
            serviceIDMetadata.Add(Tuple.Create(string.Empty, "Amazon DynamoDB Streams", "DynamoDB Streams"));
            serviceIDMetadata.Add(Tuple.Create("Route 53", "Amazon Route 53", "Route 53"));
            serviceIDMetadata.Add(Tuple.Create(string.Empty, "AWS Import/Export", "ImportExport"));
        }
        [Fact]
        public void TestDetermineServiceId()
        {
            foreach (var tuple in serviceIDMetadata)
            {
                Assert.Equal(tuple.Item3, Utils.DetermineServiceId(tuple.Item1, tuple.Item2));
            }
        }

        [Theory]
        [InlineData("notJmespath", false)]
        [InlineData("notJmespath.", false)]
        [InlineData(".notJmespath", false)]
        [InlineData("Not.Supported.Jmespath", false)]
        [InlineData("Is.Jmespath", true)]
        [InlineData("Is.Jmespath2", true)]
        public void TestIsJmesPath(string input, bool result)
        {
            JsonData node = new JsonData(input);
            char? jmespathChar = null;

            // Use reflection to get internal static method
            MethodInfo isJmesPathMethod = typeof(OperationPaginatorConfig).GetMethod("IsJmesPath",
                BindingFlags.NonPublic | BindingFlags.Static);

            var methodResult = isJmesPathMethod.Invoke(null, new object[] { node, jmespathChar });
            Assert.Equal(result, bool.Parse(methodResult.ToString()));
        }

        [Theory]
        [InlineData("ListItems", "ParentItem.ChildItem", "ChildItem")]
        [InlineData("ListItems", "ParentItem.NextToken", "NextToken")]
        public void TestHandleJmesPathWithServiceModel(string operationName, string jmesPathInput, string childName)
        {
            var operation = _model.Operations.Single(x => x.Name.Equals(operationName));
            var shapes = operation.model.Shapes;
            var testNode = new JsonData(jmesPathInput);

            // Use reflection to get internal static method
            MethodInfo handleJmesPathMethod = typeof(OperationPaginatorConfig).GetMethod("HandleJmesPath",
                BindingFlags.NonPublic | BindingFlags.Static);

            var methodResult = handleJmesPathMethod.Invoke(null, new object[] { testNode, '.', shapes });
            Assert.Equal(childName, ((OperationPaginatorConfigOption)methodResult).Member.PropertyName);

        }

        [Theory]
        [InlineData("us-east-1", "USEast1")]
        [InlineData("cn-northwest-1", "CNNorthWest1")]
        [InlineData("ap-southeast-1", "APSoutheast1")]
        [InlineData("us-gov-east-1", "USGovCloudEast1")]
        public void TestEndpointNameConstruction(string regionCode, string expectedName)
        {
            Assert.Equal(GeneratorDriver.ConstructEndpointName(regionCode), expectedName);
        }
    }
}
