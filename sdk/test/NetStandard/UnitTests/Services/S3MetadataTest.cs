using Amazon.S3.Transfer;
using Xunit;

namespace AWSSDK_NetStandard.UnitTests
{
    public class S3MetadataTest
    {
        [Fact]
        [Trait("Category", "S3")]
        public void MetadataCollectionClearTest()
        {
            TransferUtilityUploadRequest uploadRequest = new TransferUtilityUploadRequest();

            uploadRequest.Metadata.Add("dummymetadata", "dummyvalue");
            uploadRequest.Metadata.Add("x-amz-meta-explicitmetadata", "value-explicitmetadata");
            Assert.Equal(2, uploadRequest.Metadata.Count);

            uploadRequest.Metadata.Clear();
            Assert.Equal(0, uploadRequest.Metadata.Count);
        }
    }
}
