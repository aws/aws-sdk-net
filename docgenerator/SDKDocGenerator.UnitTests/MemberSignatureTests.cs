using System;
using Xunit;
using SDKDocGenerator.PlatformMap;

namespace SDKDocGenerator.UnitTests
{
    public class MemberSignatureTests
    {
        #region GetMemberType

        [Theory]
        [InlineData("M:Namespace.Type.Method(Params)", "M")]
        [InlineData("T:Amazon.S3.Model.GetObjectRequest", "T")]
        [InlineData("P:Amazon.Runtime.ClientConfig.Timeout", "P")]
        [InlineData("F:Amazon.S3.Model.Region.USEast1", "F")]
        [InlineData("E:Amazon.S3.Transfer.TransferUtility.UploadProgressEvent", "E")]
        public void GetMemberType_ReturnsCorrectPrefix(string signature, string expected)
        {
            Assert.Equal(expected, MemberSignature.GetMemberType(signature));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("X")]
        [InlineData("MissingColon")]
        public void GetMemberType_ThrowsOnInvalidSignature(string signature)
        {
            Assert.Throws<ArgumentException>(() => MemberSignature.GetMemberType(signature));
        }

        #endregion

        #region GetMemberName

        [Theory]
        [InlineData("M:Amazon.S3.AmazonS3Client.GetObject(Amazon.S3.Model.GetObjectRequest)", "Amazon.S3.AmazonS3Client.GetObject")]
        [InlineData("M:Amazon.S3.AmazonS3Client.GetObject", "Amazon.S3.AmazonS3Client.GetObject")]
        [InlineData("T:Amazon.S3.Model.GetObjectRequest", "Amazon.S3.Model.GetObjectRequest")]
        [InlineData("P:Amazon.Runtime.ClientConfig.Timeout", "Amazon.Runtime.ClientConfig.Timeout")]
        [InlineData("M:Amazon.S3.AmazonS3Client.#ctor(System.String)", "Amazon.S3.AmazonS3Client.#ctor")]
        public void GetMemberName_StripsParameterList(string signature, string expected)
        {
            Assert.Equal(expected, MemberSignature.GetMemberName(signature));
        }

        #endregion

        #region GetDeclaringTypeName

        [Theory]
        [InlineData("M:Amazon.S3.AmazonS3Client.GetObject(Amazon.S3.Model.GetObjectRequest)", "Amazon.S3.AmazonS3Client")]
        [InlineData("P:Amazon.Runtime.ClientConfig.ReadWriteTimeout", "Amazon.Runtime.ClientConfig")]
        [InlineData("F:Amazon.S3.Model.Region.USEast1", "Amazon.S3.Model.Region")]
        [InlineData("E:Amazon.S3.Transfer.TransferUtility.UploadProgressEvent", "Amazon.S3.Transfer.TransferUtility")]
        [InlineData("M:Amazon.S3.AmazonS3Client.#ctor(System.String)", "Amazon.S3.AmazonS3Client")]
        public void GetDeclaringTypeName_ExtractsTypeFromMember(string signature, string expected)
        {
            Assert.Equal(expected, MemberSignature.GetDeclaringTypeName(signature));
        }

        [Fact]
        public void GetDeclaringTypeName_ReturnsFullName_ForTypeSignature()
        {
            // Type signatures have no member name after last dot, so this returns the namespace
            var result = MemberSignature.GetDeclaringTypeName("T:Amazon.S3.Model.GetObjectRequest");
            Assert.Equal("Amazon.S3.Model", result);
        }

        #endregion

        #region ExtractMethodName

        [Theory]
        [InlineData("M:Amazon.S3.AmazonS3Client.GetObject(Amazon.S3.Model.GetObjectRequest)", "GetObject")]
        [InlineData("M:Amazon.S3.AmazonS3Client.#ctor(System.String)", "#ctor")]
        [InlineData("P:Amazon.Runtime.ClientConfig.Timeout", "Timeout")]
        [InlineData("M:Amazon.TranscribeStreaming.AmazonTranscribeStreamingClient.StartTranscription(Amazon.TranscribeStreaming.Model.StartTranscriptionRequest)", "StartTranscription")]
        public void ExtractMethodName_ReturnsMethodNameOnly(string signature, string expected)
        {
            Assert.Equal(expected, MemberSignature.ExtractMethodName(signature));
        }

        #endregion

        #region Delegation Consistency

        [Fact]
        public void ForMethod_ProducesSameOutputAsNDocUtilities()
        {
            // Verify that MemberSignature.ForMethod and NDocUtilities.DetermineNDocNameLookupSignature
            // produce the same result for the same input
            var methodInfo = typeof(TestMethods).GetMethod("Query", new Type[] { typeof(string) });
            var directResult = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo, "");
            var wrapperResult = MemberSignature.ForMethod(new MethodInfoWrapper(methodInfo, ""));
            Assert.Equal(directResult, wrapperResult);
        }

        #endregion
    }
}
