using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System.Threading;
using System.IO;
using UnityEngine;
using Amazon.Runtime.Internal;
using ThirdParty.MD5;

namespace AWSSDK.IntegrationTests.S3
{
    [TestFixture(TestOf = typeof(MultipartTests))]
    [Category("Integration")]
    public class MultipartTests : TestBase<AmazonS3Client>
    {
        private string BucketName;
        [OneTimeSetUp]
        public void SetUp()
        {
            BucketName = "unity-test-bucket" + DateTime.Now.Ticks;
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception exception = null;
            Client.PutBucketAsync(BucketName, (result) =>
            {
                if (result.Exception != null)
                    exception = result.Exception;

                ars.Set();
            });

            ars.WaitOne();
            if (exception != null)
                throw exception;

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            S3TestUtils.CleanBucket(Client, BucketName);
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception exception = null;
            Client.DeleteBucketAsync(BucketName, (result) =>
            {
                if (result.Exception != null)
                    exception = result.Exception;

                ars.Set();
            });

            ars.WaitOne();
            if (exception != null)
                throw exception;
        }

        [Test]
        public void TestMultipartUpload()
        {
            string keyName = @"20mbfile" + DateTime.Now.Ticks;
            InitiateMultipartUploadResponse initResponse = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            string md5UploadString = string.Empty;
            List<string> md5s = new List<string>();
            Exception ex = null;
            try
            {
                List<UploadPartResponse> uploadResponses = new List<UploadPartResponse>();
                InitiateMultipartUploadRequest initiateRequest = new InitiateMultipartUploadRequest
                {
                    BucketName = BucketName,
                    Key = keyName
                };


                Client.InitiateMultipartUploadAsync(initiateRequest, (result) =>
                {
                    if (result.Exception != null)
                        ex = result.Exception;

                    initResponse = result.Response;

                    ars.Set();
                });
                ars.WaitOne();
                //catch at the bottom and abort the multipart upload
                if (ex != null)
                    throw ex;

                TextAsset largeFile = null;
                byte[] buffer = null;
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    largeFile = Resources.Load("20MBFile") as TextAsset;
                    buffer = largeFile.bytes;
                    ars.Set();
                });

                ars.WaitOne();

                long contentLength = buffer.Length;
                long partSize = 5242880; // 5 MB
                var inputStream = new MemoryStream(buffer);
                var ms = new MemoryStream(buffer);
                long filePosition = 0;
                for (int i = 1; filePosition < contentLength; i++)
                {
                    if (partSize > (contentLength - filePosition))
                        partSize = contentLength - filePosition;

                    byte[] bformd5 = new byte[partSize];

                    int read = ms.Read(bformd5, 0, bformd5.Length);

                    // Create request to upload a part.
                    UploadPartRequest uploadRequest = new UploadPartRequest
                    {
                        BucketName = BucketName,
                        Key = keyName,
                        UploadId = initResponse.UploadId,
                        PartNumber = i,
                        PartSize = partSize,
                        FilePosition = filePosition,
                        InputStream = inputStream,
                        MD5Digest = Md5Helper(bformd5)
                    };

                    // Upload part and add response to our list.
                    Client.UploadPartAsync(uploadRequest, (result) =>
                    {
                        if (result.Exception != null)
                            ex = result.Exception;
                        else
                            uploadResponses.Add(result.Response);

                        ars.Set();
                    });

                    ars.WaitOne();
                    if (ex != null)
                        throw ex;

                    filePosition += partSize;
                }


                //complete the multipart upload operation
                CompleteMultipartUploadRequest completeRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = BucketName,
                    Key = keyName,
                    UploadId = initResponse.UploadId,
                    PartETags = (from e in uploadResponses select new PartETag(e.PartNumber, e.ETag)).ToList<PartETag>()
                };

                CompleteMultipartUploadResponse completeUploadResponse = null;

                Client.CompleteMultipartUploadAsync(completeRequest, (result) =>
                {
                    if (result.Exception != null)
                        ex = result.Exception;
                    else
                        completeUploadResponse = result.Response;

                    ars.Set();
                });

                ars.WaitOne();
                if (ex != null)
                    throw ex;
                
                ms.Dispose();
            }
            catch (Exception e)
            {
                AbortMultipartUploadRequest abortMPURequest = new AbortMultipartUploadRequest
                {
                    BucketName = BucketName,
                    Key = keyName,
                    UploadId = initResponse.UploadId
                };
                Client.AbortMultipartUploadAsync(abortMPURequest, (result) =>
                {
                    ars.Set();
                });
                ars.WaitOne();

                //propogate the exception to indicate failed test
                throw e;
            }

        }

        private string Md5Helper(byte[] buffer)
        {
            using (var md5 = new MD5Managed())
            {
                return Convert.ToBase64String(md5.ComputeHash(buffer));
            }
        }

    }
}
