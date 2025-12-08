using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class RestoreObjectTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;
        private static string keyName = "test-restore-object";

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
        }

        [TestMethod]
        public void TestRestoreObject()
        {
            // Put object with Glacier storage class
            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                ContentBody = "Test content for restore",
                StorageClass = S3StorageClass.Glacier
            });

            // Restore the object
            var restoreRequest = new RestoreObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                Days = 1
            };

            var response = Client.RestoreObject(restoreRequest);
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Accepted, response.HttpStatusCode);
        }

        [TestMethod]
        public void TestRestoreObjectWithTier()
        {
            // Put object with Glacier storage class
            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                ContentBody = "Test content for restore",
                StorageClass = S3StorageClass.Glacier
            });

            // Restore the object
            // note: S3 does not accept RetrievalTier + Days combination for some reason. S3 expects the tier that is wrapped in
            // glacier job parameters when doing a barebones restore with tier and days set.
            // https://github.com/aws/aws-sdk/issues/246
            var restoreRequest = new RestoreObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                Days = 1,
                Tier = GlacierJobTier.Standard
            };

            var response = Client.RestoreObject(restoreRequest);
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Accepted, response.HttpStatusCode);
        }

        // Put object with Glacier storage class
        [TestMethod]
        public void TestRestoreObjectWithOutputLocation()
        {
            var keyNameWithOutput = "test-restore-object-output.csv";
            var csv = new StringBuilder()
            .AppendLine("Id,Name,Amount")
            .AppendLine("1,Alice,10.5")
            .AppendLine("2,Bob,42.0")
            .ToString();

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(csv)))
            {
                Client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyNameWithOutput,
                    StorageClass = S3StorageClass.Glacier,
                    InputStream = stream,
                    ContentType = "text/csv"
                });
            }

            // Restore the object with OutputLocation
            var restoreRequest = new RestoreObjectRequest
            {
                BucketName = bucketName,
                Key = keyNameWithOutput,
                RestoreRequestType = RestoreRequestType.SELECT,
                SelectParameters = new SelectParameters
                {
                    Expression = "SELECT * FROM S3Object s",
                    ExpressionType = ExpressionType.SQL,
                    InputSerialization = new InputSerialization
                    {
                        CSV = new CSVInput
                        {
                            FileHeaderInfo = FileHeaderInfo.Use,
                            FieldDelimiter = ","
                        }
                    },
                    // let s3 default to the newline character
                    OutputSerialization = new OutputSerialization
                    {
                        CSV = new CSVOutput
                        {
                        }
                    }
                },
                OutputLocation = new OutputLocation
                {
                    S3 = new S3Location
                    {

                        BucketName = bucketName,
                        Prefix = "restored-objects/",
                        StorageClass = S3StorageClass.Standard
                    }
                }
            };

            var response = Client.RestoreObject(restoreRequest);
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Accepted, response.HttpStatusCode);
        }

        [TestMethod]
        public void TestRestoreObjectWithOutputLocationAndAccessControlList()
        {
            var keyNameWithACL = "test-restore-object-with-acl.csv";
            var csv = new StringBuilder()
            .AppendLine("Id,Name,Amount")
            .AppendLine("1,Alice,10.5")
            .AppendLine("2,Bob,42.0")
            .ToString();

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(csv)))
            {
                Client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyNameWithACL,
                    StorageClass = S3StorageClass.Glacier,
                    InputStream = stream,
                    ContentType = "text/csv"
                });
            }

            // Restore the object with AccessControlList
            var restoreRequest = new RestoreObjectRequest
            {
                BucketName = bucketName,
                Key = keyNameWithACL,
                OutputLocation = new OutputLocation
                {
                    S3 = new S3Location
                    {
                        BucketName = bucketName,
                        Prefix = "restored-acl-objects/",
                        StorageClass = S3StorageClass.Standard,
                        AccessControlList = new S3AccessControlList
                        {
                            // Test that setting Owner doesn't do anything (since Owner isn't modeled)
                            Owner = new Owner { DisplayName = "test-owner" },
                            Grants = new List<S3Grant>
                            {
                                new S3Grant
                                {
                                    Grantee = new S3Grantee()
                                    {
                                        URI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers",
                                    },
                                    Permission = S3Permission.READ,
                                }
                            }
                        }
                    }
                },
                SelectParameters = new SelectParameters
                {
                    Expression = "SELECT * FROM S3Object s",
                    ExpressionType = ExpressionType.SQL,
                    InputSerialization = new InputSerialization
                    {
                        CSV = new CSVInput
                        {
                            FileHeaderInfo = FileHeaderInfo.Use,
                            FieldDelimiter = ","
                        }
                    },
                    // let s3 default to the newline character
                    OutputSerialization = new OutputSerialization
                    {
                        CSV = new CSVOutput
                        {
                            FieldDelimiter = "\n"
                        }
                    }
                },
                RestoreRequestType = RestoreRequestType.SELECT

            };

            var response = Client.RestoreObject(restoreRequest);
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Accepted, response.HttpStatusCode);
        }
    }
}
