using Xunit;
using Json.LitJson;
using ServiceClientGenerator;

namespace ServiceClientGeneratorTests
{

    [Trait("Category", "UnitTests")]
    public class JMESPathToNativeValueTests
    {
        private const string _modelsPath = "../../Content/TestModelComplexParameters.json";
        private const string _paginatorsPath = "../../Content/TestPaginators.json";

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

            Assert.Equal("Nested.ListOfObjects.Select(element => element)", nativeValue);
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

            Assert.Equal("Nested.Map.Values.Select(element => element)", nativeValue);
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

            Assert.Equal("Nested.Map.Keys.ToList()", nativeValue);
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

            Assert.Equal("List.Select(element => element.Inner)", nativeValue);
        }
    }
}
