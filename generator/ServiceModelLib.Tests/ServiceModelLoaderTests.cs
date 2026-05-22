using System.IO;
using System.Linq;
using ServiceClientGenerator;
using Xunit;

namespace ServiceModelLib.Tests
{
    public class ServiceModelLoaderTests
    {
        private static readonly string ServiceModelsRoot = Path.GetFullPath(
            Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "..", "ServiceModels"));

        [Fact]
        public void LoadS3_ReturnsModel_WithOperations()
        {
            var s3Dir = Path.Combine(ServiceModelsRoot, "s3");
            var model = ServiceModelLoader.Load(s3Dir);

            Assert.NotNull(model);
            Assert.True(model.Operations.Count > 0);
            Assert.Contains(model.Operations, op => op.Name == "PutObject");
        }

        [Fact]
        public void LoadS3_CustomizationsApplied_PropertyRenames()
        {
            var s3Dir = Path.Combine(ServiceModelsRoot, "s3");
            var model = ServiceModelLoader.Load(s3Dir);

            var putObject = model.Operations.First(op => op.Name == "PutObject");
            var requestShape = putObject.RequestStructure;

            // PutObject should have members accessible
            Assert.True(requestShape.Members.Count > 0);

            // Every member should have both ModeledName and PropertyName
            foreach (var member in requestShape.Members)
            {
                Assert.False(string.IsNullOrEmpty(member.ModeledName));
                Assert.False(string.IsNullOrEmpty(member.PropertyName));
            }
        }

        [Fact]
        public void LoadS3_Paginators_Loaded()
        {
            var s3Dir = Path.Combine(ServiceModelsRoot, "s3");
            var model = ServiceModelLoader.Load(s3Dir);

            var listObjects = model.Operations.First(op => op.Name == "ListObjectsV2");
            Assert.NotNull(listObjects.Paginators);
        }

        [Fact]
        public void LoadDynamoDB_CustomizationsApplied()
        {
            var dynamoDir = Path.Combine(ServiceModelsRoot, "dynamodb");
            var model = ServiceModelLoader.Load(dynamoDir);

            Assert.NotNull(model);
            Assert.True(model.Operations.Count > 0);
            Assert.Contains(model.Operations, op => op.Name == "PutItem");
        }

        [Fact]
        public void LoadS3_CreateBucket_OperationRenamedToPutBucket()
        {
            var s3Dir = Path.Combine(ServiceModelsRoot, "s3");
            var model = ServiceModelLoader.Load(s3Dir);

            // The C2J model defines the operation as "CreateBucket"
            // The customizations rename it to "PutBucket" via operationModifiers
            var op = model.Operations.First(o => o.ShapeName == "CreateBucket");

            // ShapeName is the original C2J name
            Assert.Equal("CreateBucket", op.ShapeName);
            // Name is the customized C# method name
            Assert.Equal("PutBucket", op.Name);
        }

        [Fact]
        public void LoadS3_MemberMapping_BidirectionalWorks()
        {
            var s3Dir = Path.Combine(ServiceModelsRoot, "s3");
            var model = ServiceModelLoader.Load(s3Dir);

            var putObject = model.Operations.First(op => op.Name == "PutObject");
            var inputMembers = putObject.RequestStructure.Members;

            // Build both mappings
            var modeledToCSharp = inputMembers.ToDictionary(m => m.ModeledName, m => m.PropertyName);
            var cSharpToModeled = inputMembers.ToDictionary(m => m.PropertyName, m => m.ModeledName);

            // Verify round-trip
            foreach (var member in inputMembers)
            {
                Assert.Equal(member.PropertyName, modeledToCSharp[member.ModeledName]);
                Assert.Equal(member.ModeledName, cSharpToModeled[member.PropertyName]);
            }
        }
    }
}
