using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;

namespace AWSSDK.IntegrationTests.S3
{
    class S3TestUtils
    {
        public delegate void PostObjectRequestManipulator(PostObjectRequest request);
        public static readonly string TestContent = "This is the content body!";
        public static PostObjectResponse PostObjectHelper(AmazonS3Client client, string bucketName, string key, PostObjectRequestManipulator manipulator = null)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                PostObjectResponse r = null;
                Exception responseException = null;
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(TestContent);
                writer.Flush();
                stream.Position = 0;
                AutoResetEvent ars = new AutoResetEvent(false);
                var request = new PostObjectRequest()
                {
                    Bucket = bucketName,
                    Key = key,
                    InputStream = stream
                };
                if (manipulator != null)
                {
                    manipulator(request);
                }
                client.PostObjectAsync(request, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        r = response.Response;
                    }
                    else
                    {
                        Debug.LogWarning(new StreamReader((responseException as Amazon.Runtime.Internal.HttpErrorResponseException).Response.ResponseBody.OpenResponse()).ReadToEnd());
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                if (responseException != null)
                {
                    throw responseException;
                }
                return r;
            }
        }

        public static void DeleteObjectHelper(AmazonS3Client client, string bucketName, string key, string versionId = null)
        {
            Exception responseException = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            client.DeleteObjectsAsync(new DeleteObjectsRequest()
            {
                BucketName = bucketName,
                Objects = new List<KeyVersion> { new KeyVersion() { Key = key, VersionId = versionId } }
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
        }

        public static void CleanBucket(AmazonS3Client client, string bucketName)
        {
            var s3ObjectVersionList = ListVersionsHelper(client, bucketName);
            foreach (var s3ObjectVersion in s3ObjectVersionList)
            {
                DeleteObjectHelper(client, bucketName, s3ObjectVersion.Key, s3ObjectVersion.VersionId);
            }
        }

        public static GetACLResponse GetACLHelper(AmazonS3Client client, string bucketName, string key)
        {
            GetACLResponse r = null;
            Exception responseException = null;
            AutoResetEvent ars = new AutoResetEvent(false);

            client.GetACLAsync(new GetACLRequest()
            {
                BucketName = bucketName,
                Key = key
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    r = response.Response;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            if (responseException != null)
            {
                throw responseException;
            }
            return r;
        }

        public static GetObjectResponse GetObjectHelper(AmazonS3Client client, string bucketName, string key)
        {
            GetObjectResponse r = null;
            Exception responseException = null;
            AutoResetEvent ars = new AutoResetEvent(false);

            client.GetObjectAsync(new GetObjectRequest()
            {
                BucketName = bucketName,
                Key = key
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    r = response.Response;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            if (responseException != null)
            {
                throw responseException;
            }
            return r;
        }

        public static List<S3Object> ListObjectsHelper(AmazonS3Client client, string bucketName)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            List<S3Object> s3Objects = null;
            client.ListObjectsAsync(new ListObjectsRequest()
            {
                BucketName = bucketName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    s3Objects = response.Response.S3Objects;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();
            if (responseException != null)
            {
                throw responseException;
            }
            return s3Objects;
        }

        public static List<S3ObjectVersion> ListVersionsHelper(AmazonS3Client client, string bucketName)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            List<S3ObjectVersion> s3ObjectVersions = null;
            client.ListVersionsAsync(new ListVersionsRequest()
            {
                BucketName = bucketName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    s3ObjectVersions = response.Response.Versions;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();
            if (responseException != null)
            {
                throw responseException;
            }
            return s3ObjectVersions;
        }

        // Used for SimplePathPostObjectTest
        public static string GetFileHelper(string fileName)
        {
            string filePath = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            Amazon.Runtime.Internal.UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                filePath = Application.persistentDataPath + Path.DirectorySeparatorChar + fileName;
                if (!File.Exists(filePath))
                {
                    var streamReader = File.CreateText(Application.persistentDataPath + Path.DirectorySeparatorChar + fileName);
                    streamReader.WriteLine("This is a file uploaded from unity s3 tests");
                    streamReader.Close();
                }
                ars.Set();
            });
            ars.WaitOne();
            return filePath;
        }

        public static string CreateBucket(IAmazonS3 s3Client)
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.Now.Ticks;
            var mre = new ManualResetEvent(false);
            var exception = new Exception();
            s3Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName }, (result) =>
            {
                exception = result.Exception;
                mre.Set();
            }, new AsyncOptions() { ExecuteCallbackOnMainThread = false });
            mre.WaitOne();
            if (exception != null)
                throw exception;

            return bucketName;
        }

        public static void DeleteBucketWithObjects(IAmazonS3 s3Client, string bucketName)
        {
            // Validations.
            if (s3Client == null)
            {
                throw new ArgumentNullException("s3Client", "The s3Client cannot be null!");
            }

            if (string.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "The bucketName cannot be null or empty string!");
            }

            var listVersionsRequest = new ListVersionsRequest
            {
                BucketName = bucketName
            };

            ListVersionsResponse listVersionsResponse = null;
            string lastRequestId = null;

            var exception = new Exception();
            var mre = new AutoResetEvent(false);

            // Iterate through the objects in the bucket and delete them.
            do
            {
                // List all the versions of all the objects in the bucket.
                s3Client.ListVersionsAsync(listVersionsRequest, (result) =>
               {
                   exception = result.Exception;
                   listVersionsResponse = result.Response;
                   mre.Set();
               }, new AsyncOptions() { ExecuteCallbackOnMainThread = false });
                mre.WaitOne();
                Utils.AssertExceptionIsNull(exception);


                lastRequestId = listVersionsResponse.ResponseMetadata.RequestId;

                if (listVersionsResponse.Versions.Count == 0)
                {
                    // If the bucket has no objects break the loop.
                    break;
                }

                var keyVersionList = new List<KeyVersion>(listVersionsResponse.Versions.Count);
                for (int index = 0; index < listVersionsResponse.Versions.Count; index++)
                {
                    keyVersionList.Add(new KeyVersion
                    {
                        Key = listVersionsResponse.Versions[index].Key,
                        VersionId = listVersionsResponse.Versions[index].VersionId
                    });
                }


                var deleteObjectsResponse = new DeleteObjectsResponse();
                // Delete the current set of objects.
                s3Client.DeleteObjectsAsync(new DeleteObjectsRequest
                {
                    BucketName = bucketName,
                    Objects = keyVersionList,
                    Quiet = true
                }, (result) =>
                {
                    deleteObjectsResponse = result.Response;
                    exception = result.Exception;
                    mre.Set();
                }, new AsyncOptions() { ExecuteCallbackOnMainThread = false });
                mre.WaitOne();
                Utils.AssertExceptionIsNull(exception);

                // Set the markers to get next set of objects from the bucket.
                listVersionsRequest.KeyMarker = listVersionsResponse.NextKeyMarker;
                listVersionsRequest.VersionIdMarker = listVersionsResponse.NextVersionIdMarker;

            }
            // Continue listing objects and deleting them until the bucket is empty.
            while (listVersionsResponse.IsTruncated);

            // Bucket is empty, delete the bucket.
            s3Client.DeleteBucketAsync(new DeleteBucketRequest
            {
                BucketName = bucketName
            }, (result) =>
            {
                exception = result.Exception;
                mre.Set();
            }, new AsyncOptions() { ExecuteCallbackOnMainThread = false });

            mre.WaitOne();
            Utils.AssertExceptionIsNull(exception);
        }
    }
}
