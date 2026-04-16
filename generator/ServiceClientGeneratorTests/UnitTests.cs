using Json.LitJson;
using ServiceClientGenerator;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;

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

        [Theory]
        [InlineData("string", "str", "\"str\"")]
        [InlineData("integer", 5, "5")]
        [InlineData("float", 0.4, "0.4")]
        [InlineData("double", 0.5, "0.5")]
        public void TestExampleShapes(string shapeType, object value, string expectedText)
        {
            TextReader tr = new StringReader("{}");
            ServiceModel testModel = new(tr, null);

            JsonData shapeJsonData = new()
            {
                ["type"] = shapeType
            };

            var sb = new StringBuilder();
            var cb = new CodeBuilder(sb, 0);

            string operationName = "fake";
            Example example = new(testModel, operationName, null);

            Shape shape = Shape.CreateShape(testModel, operationName, shapeJsonData);
            JsonData sampleData = new(value);

            CultureInfo originalCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR"); // In French, the comma is used as a decimal point

            example.GetSampleLiteral(shape, sampleData, cb);

            CultureInfo.CurrentCulture = originalCulture;

            var printedText = sb.ToString();
            Assert.Equal(expectedText, printedText);
        }

        #region Deprecation Message Sanitization Tests

        private const string _deprecatedModelsPath = "../../Content/TestModelDeprecated.json";

        // The expected sanitized message after removing \r, \n, replacing " with ',
        // removing <p></p>, and replacing <code></code> with <c></c>.
        private const string _expectedSanitizedMessage = "This operation is deprecated.Use <c>NewOperation</c> instead.See 'docs' for details.";
        private const string _expectedSanitizedMemberMessage = "This field is deprecated.Use <c>NewField</c> instead.See 'docs' for details.";
        private const string _expectedSanitizedShapeMessage = "This shape is deprecated.Use <c>NewShape</c> instead.See 'docs' for details.";

        [Fact]
        public void OperationDeprecationMessageIsSanitized()
        {
            var model = new ServiceModel(_deprecatedModelsPath, null);
            var operation = model.Operations.Single(x => x.Name.Equals("DeprecatedOperation"));

            Assert.True(operation.IsDeprecated);
            var message = operation.DeprecationMessage;

            Assert.DoesNotContain("\n", message);
            Assert.DoesNotContain("\r", message);
            Assert.DoesNotContain("\"", message);
            Assert.DoesNotContain("<p>", message);
            Assert.DoesNotContain("</p>", message);
            Assert.DoesNotContain("<code>", message);
            Assert.DoesNotContain("</code>", message);
            Assert.Equal(_expectedSanitizedMessage, message);
        }

        [Fact]
        public void ShapeDeprecationMessageIsSanitized()
        {
            var model = new ServiceModel(_deprecatedModelsPath, null);
            var shape = model.Shapes.Single(x => x.Name.Equals("DeprecatedShape"));

            Assert.True(shape.IsDeprecated);
            var message = shape.DeprecationMessage;

            Assert.DoesNotContain("\n", message);
            Assert.DoesNotContain("\r", message);
            Assert.DoesNotContain("\"", message);
            Assert.DoesNotContain("<p>", message);
            Assert.DoesNotContain("</p>", message);
            Assert.DoesNotContain("<code>", message);
            Assert.DoesNotContain("</code>", message);
            Assert.Equal(_expectedSanitizedShapeMessage, message);
        }

        [Fact]
        public void MemberDeprecationMessageIsSanitized()
        {
            var model = new ServiceModel(_deprecatedModelsPath, null);
            var shape = model.Shapes.Single(x => x.Name.Equals("DeprecatedOperationInput"));
            var member = shape.Members.Single(x => x.ModeledName.Equals("OldField"));

            Assert.True(member.IsDeprecated);
            var message = member.DeprecationMessage;

            Assert.DoesNotContain("\n", message);
            Assert.DoesNotContain("\r", message);
            Assert.DoesNotContain("\"", message);
            Assert.DoesNotContain("<p>", message);
            Assert.DoesNotContain("</p>", message);
            Assert.DoesNotContain("<code>", message);
            Assert.DoesNotContain("</code>", message);
            Assert.Equal(_expectedSanitizedMemberMessage, message);
        }

        #endregion
    }
}
