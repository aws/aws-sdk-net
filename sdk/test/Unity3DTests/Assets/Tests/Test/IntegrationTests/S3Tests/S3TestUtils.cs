using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
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

        public static void DeleteObjectHelper(AmazonS3Client client, string bucketName, string key)
        {
            Exception responseException = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            client.DeleteObjectsAsync(new DeleteObjectsRequest()
            {
                BucketName = bucketName,
                Objects = new List<KeyVersion> { new KeyVersion() { Key = key } }
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
            var s3ObjectList = ListObjectsHelper(client, bucketName);
            foreach (var s3Object in s3ObjectList)
            {
                DeleteObjectHelper(client, bucketName, s3Object.Key);
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
    }
}
