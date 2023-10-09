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
        private const string _modelsPath = "../../Content/TestModel.json";
        private const string _paginatorsPath = "../../Content/TestPaginators.json";

        [Theory]
        [InlineData("notJmespath", false)]
        [InlineData("notJmespath.", false)]
        [InlineData(".notJmespath", false)]
        [InlineData("Is.Jmespath", true)]
        [InlineData("Is.Jmespath2", true)]
        [InlineData("One.Two.Three", true)]
        [InlineData("One.Two.Three.", false)]
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
        [InlineData("ListItems", "ParentItem.SubItem.ChildItem", "ChildItem")]
        public void TestHandleJmesPathWithServiceModel(string operationName, string jmesPathInput, string childName)
        {
            var model = new ServiceModel(_modelsPath, null, _paginatorsPath);

            var operation = model.Operations.Single(x => x.Name.Equals(operationName));
            var shapes = operation.model.Shapes;
            var testNode = new JsonData(jmesPathInput);

            // Use reflection to get internal static method
            MethodInfo handleJmesPathMethod = typeof(OperationPaginatorConfig).GetMethod("HandleJmesPath",
                BindingFlags.NonPublic | BindingFlags.Static);

            var methodResult = handleJmesPathMethod.Invoke(null, new object[] { testNode, '.', operation });
            Assert.Equal(childName, ((OperationPaginatorConfigOption)methodResult).Member.PropertyName);
            Assert.Equal(jmesPathInput, ((OperationPaginatorConfigOption)methodResult).PropertyName);
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
