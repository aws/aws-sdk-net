using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class MetadataCollectionTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void MetadataCollectionIndexerIsCaseInsensitive()
        {
            var sut = new MetadataCollection
            {
                ["KeYnAmE"] = "foo"
            };
            
            Assert.AreEqual(sut["kEyNaMe"], "foo");
        }
    }
}