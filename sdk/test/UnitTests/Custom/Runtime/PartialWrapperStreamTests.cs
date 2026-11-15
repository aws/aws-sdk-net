using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class PartialWrapperStreamTests
    {
        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(0, 3)]
        [DataRow(5, 0)]
        [DataRow(5, 3)]
        [TestCategory("Runtime")]
        public void SeekFromEnd_IsRelativeToTheSegmentEnd(int initialPosition, int bytesRead)
        {
            using (var source = new MemoryStream(Enumerable.Range(0, 20).Select(i => (byte)i).ToArray()))
            {
                source.Position = initialPosition;
                using (var stream = new PartialWrapperStream(source, 8))
                {
                    stream.Read(new byte[bytesRead], 0, bytesRead);

                    Assert.AreEqual(6L, stream.Seek(-2, SeekOrigin.End));
                    Assert.AreEqual(initialPosition + 6L, source.Position);
                    Assert.AreEqual(initialPosition + 6, stream.ReadByte());
                    Assert.AreEqual(6L, stream.Seek(-2, SeekOrigin.End));
                    Assert.AreEqual(initialPosition + 6, stream.ReadByte());
                }
            }
        }

        [DataTestMethod]
        [DataRow(-20, 0)]
        [DataRow(0, 8)]
        [DataRow(20, 8)]
        [TestCategory("Runtime")]
        public void SeekFromEnd_PreservesSegmentBounds(int offset, int expectedPosition)
        {
            using (var source = new MemoryStream(new byte[20]))
            {
                source.Position = 5;
                using (var stream = new PartialWrapperStream(source, 8))
                {
                    stream.ReadByte();
                    Assert.AreEqual((long)expectedPosition, stream.Seek(offset, SeekOrigin.End));
                    Assert.AreEqual(5L + expectedPosition, source.Position);
                }
            }
        }
    }
}
