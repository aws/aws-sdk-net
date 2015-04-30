using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class MD5Tests
    {
        [TestMethod]
        public void TestMD5Managed()
        {

            System.Security.Cryptography.MD5 md5;
            try
            {
                md5 = System.Security.Cryptography.MD5.Create();
            }
            catch
            {
                Console.WriteLine("FIPS enabled, exiting test");
                return;
            }

            var md5m = new ThirdParty.MD5.MD5Managed();

            Assert.AreEqual(md5.CanReuseTransform, md5m.CanReuseTransform);
            Assert.AreEqual(md5.CanTransformMultipleBlocks, md5m.CanTransformMultipleBlocks);
            Assert.AreEqual(md5.HashSize, md5m.HashSize);
            Assert.AreEqual(md5.InputBlockSize, md5m.InputBlockSize);
            Assert.AreEqual(md5.OutputBlockSize, md5m.OutputBlockSize);

            var data1 = "foo";
            var data2 = "bar";
            var bytes1 = Encoding.UTF8.GetBytes(data1);
            var bytes2 = Encoding.UTF8.GetBytes(data2);

            //CollectionAssert.AreEqual(md5.Hash, md5m.Hash);
            CollectionAssert.AreEqual(md5.ComputeHash(bytes1), md5m.ComputeHash(bytes1));

            HashMultiple(md5, bytes1, bytes2);
            HashMultiple(md5m, bytes1, bytes2);
            CollectionAssert.AreEqual(md5.Hash, md5m.Hash);

            //HashMultiple(md5, bytes1, bytes2);
            //HashMultiple(md5m, bytes1, bytes2);
            //CollectionAssert.AreEqual(md5.Hash, md5m.Hash);

            md5.Initialize();
            md5m.Initialize();

            Assert.AreEqual(data1, Encoding.UTF8.GetString(bytes1));
            Assert.AreEqual(data2, Encoding.UTF8.GetString(bytes2));


            md5.Clear();
            md5m.Clear();

            Utils.AssertExceptionExpected<ObjectDisposedException>(() => HashMultiple(md5, bytes1, bytes2));
            Utils.AssertExceptionExpected<ObjectDisposedException>(() => HashMultiple(md5m, bytes1, bytes2));
        }

        private static void HashMultiple(System.Security.Cryptography.HashAlgorithm md5, byte[] bytes1, byte[] bytes2)
        {
            int offset = 0;
            // For each block:
            offset += md5.TransformBlock(bytes1, 0, bytes1.Length, bytes1, 0);
            offset += md5.TransformBlock(bytes2, 0, bytes2.Length, bytes2, 0);
            offset += md5.TransformBlock(bytes1, 0, bytes1.Length, null, 0);
            offset += md5.TransformBlock(bytes2, 0, bytes2.Length, null, 0);
            // For last block:
            //md5.TransformFinalBlock(bytes2, 0, bytes2.Length);
            md5.TransformFinalBlock(new byte[0], 0, 0);
        }
    }
}
