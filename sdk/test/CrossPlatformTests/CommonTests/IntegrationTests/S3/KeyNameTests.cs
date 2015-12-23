using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using CommonTests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.IntegrationTests.S3
{
    /// <summary>
    /// Just a class to ensure customers who try the most awkward names for S3 objects
    /// will be fully satisifed and leave us alone :-)
    /// </summary>
    [TestFixture]
    public class KeyNameTests : TestBase<AmazonS3Client>
    {
        private static readonly string[] AwkwardKeyNameBases =
        {
            @"ObjectWith!and?\+forgood:measureThis=And&InKeynÄme",
            @"ObjectWith\InKeyname",
            @"ObjectWith/InKeyname",
            @"ObjectWith\InKeynÄme",
            @"ObjectWith/InKeynÄme"
        };

        static string bucketName;

        [OneTimeSetUp]
        public void Initialize()
        {
            RunAsSync(async () =>
            {
                bucketName = await UtilityMethods.CreateBucketAsync(Client);
            });

        }

        [OneTimeTearDown]
        public void ClassCleanup()
        {
            RunAsSync(async () =>
            {
                try
                {
                    await UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName);
                }
                catch (Exception e)
                {
                    Console.WriteError("Exception while trying to delete bucket {0}: {1}", bucketName, e);
                }
            });
        }

        [Test]
        [Category("S3")]
        public void TestKeyNameWithAwkwardChars_AWS2Signing()
        {
            RunAsSync(async () =>
            {
                var original = AWSConfigsS3.UseSignatureVersion4;
                AWSConfigsS3.UseSignatureVersion4 = false;
                try
                {
                    IAmazonS3 s3Client = CreateNewClient();

                    foreach (var k in AwkwardKeyNameBases)
                    {
                        var keyName = k + ".AWS2.PCL";
                        await PutObjectWithQuestionableKey(s3Client, bucketName, keyName);
                    }
                }
                finally
                {
                    AWSConfigsS3.UseSignatureVersion4 = original;
                }
            });
        }

        [Test]
        [Category("S3")]
        public void TestKeyNameWithAwkwardChars_AWS4Signing()
        {
            RunAsSync(async () =>
            {
                var original = AWSConfigsS3.UseSignatureVersion4;
                AWSConfigsS3.UseSignatureVersion4 = true;
                try
                {
                    IAmazonS3 s3Client = CreateNewClient();

                    foreach (var k in AwkwardKeyNameBases)
                    {
                        var keyName = k + ".AWS2.PCL";
                        await PutObjectWithQuestionableKey(s3Client, bucketName, keyName);
                    }
                }
                finally
                {
                    AWSConfigsS3.UseSignatureVersion4 = original;
                }
            });
        }

        static async Task PutObjectWithQuestionableKey(IAmazonS3 s3Client, string bucketName, string keyName)
        {
            const string testContent = "Some stuff to write as content";

            await s3Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                ContentBody = testContent
            });

            var response = await s3Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = keyName
            });

            using (var s = new StreamReader(response.ResponseStream))
            {
                var responseContent = s.ReadToEnd();
                Assert.AreEqual(testContent, responseContent);
            }
        }
    }
}
