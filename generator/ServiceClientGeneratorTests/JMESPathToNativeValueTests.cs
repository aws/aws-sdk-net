using Xunit;
using Json.LitJson;
using ServiceClientGenerator;
using System.Collections.Generic;

namespace ServiceClientGeneratorTests
{

    [Trait("Category", "UnitTests")]
    public class JMESPathToNativeValueTests
    {
        private const string _modelsPath = "../../Content/TestModelComplexParameters.json";

        private ServiceModel testModel = new ServiceModel(_modelsPath, null, null);

        [Fact]
        public void SimplePath_ShouldReturnCorrectCodePath()
        {
            var topShapeJson = @"
                {
                    ""type"": ""structure"",
                    ""members"": {
                        ""nested"": {
                            ""shape"": ""NestedShape""
                        }
                    }
                }";

            var topShape = Shape.CreateShape(testModel, "topShape", JsonMapper.ToObject(topShapeJson));

            var nativeValue = ServiceClientGenerator.Utils.JMESPathToNativeValue("nested", topShape);

            Assert.Equal("Nested", nativeValue);
        }

        [Fact]
        public void WildcardList_ShouldReturnCorrectCodePath()
        {
            var topShapeJson = @"
                    {
                        ""type"": ""structure"",
                        ""members"": {
                            ""nested"": {
                                ""shape"": ""NestedShape""
                            }
                        }
                    }";

            var topShape = Shape.CreateShape(testModel, "topShape", JsonMapper.ToObject(topShapeJson));

            var nativeValue = ServiceClientGenerator.Utils.JMESPathToNativeValue("nested.listOfObjects[*]", topShape);

            Assert.Equal("Nested?.ListOfObjects?.Select(element => element)", nativeValue);
        }

        [Fact]
        public void WildcardMap_ShouldReturnCorrectCodePath()
        {
            var topShapeJson = @"
                    {
                        ""type"": ""structure"",
                        ""members"": {
                            ""nested"": {
                                ""shape"": ""NestedShape""
                            }
                        }
                    }"; 
            
            var topShape = Shape.CreateShape(testModel, "topShape", JsonMapper.ToObject(topShapeJson));

            var nativeValue = ServiceClientGenerator.Utils.JMESPathToNativeValue("nested.map*", topShape);

            Assert.Equal("Nested?.Map?.Values.Select(element => element)", nativeValue);
        }

        [Fact]
        public void MapKey_ShouldReturnCorrectCodePath()
        {
            var topShapeJson = @"
                        {
                            ""type"": ""structure"",
                            ""members"": {
                                ""nested"": {
                                    ""shape"": ""NestedShape""
                                }
                            }
                        }";

            var topShape = Shape.CreateShape(testModel, "topShape", JsonMapper.ToObject(topShapeJson));

            var nativeValue = ServiceClientGenerator.Utils.JMESPathToNativeValue("nested.keys(map)", topShape);

            Assert.Equal("Nested?.Map?.Keys.ToList()", nativeValue);
        }

        [Fact]
        public void NonExistentMember_ShouldReturnNull()
        {
            var topShapeJson = @"
                    {
                        ""type"": ""structure"",
                        ""members"": {
                            ""existingMember"": {
                                ""shape"": ""SomeShape""
                            }
                        }
                    }";

            var topShape = Shape.CreateShape(testModel, "topShape", JsonMapper.ToObject(topShapeJson));

            var nativeValue = ServiceClientGenerator.Utils.JMESPathToNativeValue("nonexistent", topShape);

            Assert.Null(nativeValue);
        }

        [Fact]
        public void ComplexPath_ShouldReturnCorrectCodePath()
        {
            var topShapeJson = @"
                {
                    ""type"": ""structure"",
                    ""members"": {
                            ""list"": {
                                ""shape"": ""ListOfObjects""
                            }
                        }
                    }";

            var topShape = Shape.CreateShape(testModel, "topShape", JsonMapper.ToObject(topShapeJson));

            var nativeValue = ServiceClientGenerator.Utils.JMESPathToNativeValue("list[*].inner", topShape);

            Assert.Equal("List?.Select(element => element?.Inner)", nativeValue);
        }

        [Fact]
        public void ComplexPathWithMultiSelectAndFlattenOperator()
        {
            var topShapeJson = @"
                {
                    ""type"": ""structure"",
                    ""members"": {
                            ""listOfUnions"":{""shape"":""ListOfUnions""}
                        }
                    }";

            var topShape = Shape.CreateShape(testModel, "topShape", JsonMapper.ToObject(topShapeJson));

            var nativeValue = ServiceClientGenerator.Utils.JMESPathToNativeValue("listOfUnions[*][string, object.key][]", topShape);

            Assert.Equal("ListOfUnions?.Select(element => new [] { element?.String, element?.Object?.Key })?.SelectMany(element => element).Where(element => element != null)", nativeValue);
        }

        [Fact]
        public void SplitJMESPath_ShouldSplitSimplePathCorrectly()
        {
            var input = "foo.bar.baz";
            var expected = new List<string> { "foo", "bar", "baz" };

            var result = ServiceClientGenerator.Utils.SplitJMESPath(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitJMESPath_ShouldHandleWildcardCorrectly()
        {
            var input = "items[*].value";
            var expected = new List<string> { "items", "[*]", "value" };

            var result = ServiceClientGenerator.Utils.SplitJMESPath(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitJMESPath_ShouldHandleNestedArraysCorrectly()
        {
            var input = "listOfUnions[*][string, object.key][]";
            var expected = new List<string> { "listOfUnions", "[*]", "[string, object.key]", "[]" };

            var result = ServiceClientGenerator.Utils.SplitJMESPath(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitMultiSelectExpression_ShouldSplitBasicExpression()
        {
            var input = "foo, bar, baz";
            var expected = new List<string> { "foo", "bar", "baz" };

            var result = ServiceClientGenerator.Utils.SplitMultiSelectExpression(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitMultiSelectExpression_ShouldHandleComplexExpressions()
        {
            var input = "foo, bar.baz[1], data[*].value";
            var expected = new List<string> { "foo", "bar.baz[1]", "data[*].value" };

            var result = ServiceClientGenerator.Utils.SplitMultiSelectExpression(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitMultiSelectExpression_ShouldHandleNestedArrayWithComma()
        {
            var input = "foo, bar[string, object.key], baz.list[*]";
            var expected = new List<string> { "foo", "bar[string, object.key]", "baz.list[*]" };

            var result = ServiceClientGenerator.Utils.SplitMultiSelectExpression(input);

            Assert.Equal(expected, result);
        }
    }
}
