using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Glacier;
using Amazon.Glacier.Model;
using Amazon.Glacier.Resources;
using System.IO;
using System.Globalization;

namespace AWSSDK_DotNet.IntegrationTests.Tests.ResourcesAPI
{
    /// <summary>
    /// Summary description for Glacier
    /// </summary>
    [TestClass]
    public class GlacierTests
    {

        static Amazon.Glacier.Resources.Glacier glacier;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            glacier = new Amazon.Glacier.Resources.Glacier();
        }

        [TestMethod]
        public void TestGetVaults()
        {
            var vaults = glacier.GetVaults();
            if (vaults.Any())
                Console.WriteLine(vaults.First().Name);
        }

        [TestMethod]
        public void TestVaultCreateDelete()
        {
            var vaultName = Utils.UtilityMethods.GenerateName();
            var vault = glacier.CreateVault("-", vaultName);

            Assert.IsNotNull(vault.VaultARN);
            Assert.IsNotNull(vault.CreationDate);

            Assert.IsTrue(glacier.GetVaults().Where(v => v.Name == vaultName).Any());

            vault.Delete();

            Assert.IsFalse(glacier.GetVaults().Where(v => v.Name == vaultName).Any());
        }

        // Commented out because leaving data in Glacer will incur costs
        //[TestMethod]
        public void TestArchive()
        {
            var vaultName = Utils.UtilityMethods.GenerateName();
            var vault = glacier.CreateVault("-", vaultName);

            try
            {
                var body = new MemoryStream(Encoding.UTF8.GetBytes("this is a test"));

                var archive = vault.UploadArchive(body, TreeHashGenerator.CalculateTreeHash(body));

                Assert.IsNotNull(archive.Id);
            }
            finally
            {
                vault.Delete();
            }
        }

        // Commented out because leaving data in Glacer will incur costs
        //[TestMethod]
        public void TestMultipart()
        {
            var vaultName = Utils.UtilityMethods.GenerateName();
            var vault = glacier.CreateVault("-", vaultName);

            try 
            {
                var upload = vault.InitiateMultipartUpload("dotnet resources upload", 1048576);

                Assert.IsNotNull(upload.Id);

                MemoryStream totalStream = new MemoryStream();
                for (int i = 0; i < 1048576 + 1048576 / 2; i++)
                {
                    totalStream.WriteByte((byte)(i % byte.MaxValue));
                }
                totalStream.Position = 0;

                List<string> md5s = new List<string>();
                long currentPosition = 0;
                long partSize = 1048576;
                while (totalStream.Position < totalStream.Length)
                {
                    Stream partStream = GlacierUtils.CreatePartStream(totalStream, partSize);
                    string checkSum = TreeHashGenerator.CalculateTreeHash(partStream);
                    md5s.Add(checkSum);

                    var range = string.Format(CultureInfo.InvariantCulture, "bytes {0}-{1}/*", currentPosition, currentPosition + partStream.Length - 1);

                    upload.UploadPart(partStream, checkSum, range);

                    currentPosition += partStream.Length;
                }

                var archiveSize = totalStream.Length.ToString();
                var finalChecksum = TreeHashGenerator.CalculateTreeHash(md5s);

                upload.Complete(archiveSize, finalChecksum);

            }
            finally
            {
                vault.Delete();
            }
        }
    }
}
