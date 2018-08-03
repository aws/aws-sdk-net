using System;
using System.Collections.Generic;
using Amazon.S3;
using AWSSDK_DotNet35.UnitTests.Generated.Customizations.ConstantClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.ConstantClasses.S3
{
    [TestClass]
    public class S3EnumerationsTest : ConstantClassTestBase
    {
        public S3EnumerationsTest() : base("s3")
        {
        }

        private static IEnumerable<object[]> ConstantTests =>
            new List<object[]> {
                new object[] {typeof(AnalyticsS3ExportFileFormat), "AnalyticsS3ExportFileFormat"},
                new object[] {typeof(BucketAccelerateStatus), "BucketAccelerateStatus"},
                new object[] {typeof(S3StorageClass), "ObjectStorageClass"}
            };

        [DataTestMethod]
        [DynamicData(nameof(ConstantTests))]
        public void EnumTests(Type constantClassType, string enumName)
        {
            AssertConstantsMatch(constantClassType, enumName);
        }
    }
}
