using Amazon.S3;
using Amazon.S3.Util;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal;
using Amazon.Runtime;

namespace CommonTests.Framework
{
    internal class UtilityMethods
    {
        public const string SDK_TEST_PREFIX = "aws-net-sdk";

        public async static Task<string> CreateBucketAsync(IAmazonS3 s3Client)
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.Now.Ticks;
            await s3Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName });
            return bucketName;
        }

        public static string GenerateName()
        {
            return GenerateName(SDK_TEST_PREFIX + "-");
        }

        public static string GenerateName(string name)
        {
            return name + new Random().Next();
        }

        public static Task DeleteBucketWithObjectsAsync(IAmazonS3 s3Client, string bucketName)
        {
            return DeleteS3BucketWithObjectsAsync(s3Client, bucketName);
        }

        private async static Task DeleteS3BucketWithObjectsAsync(IAmazonS3 s3Client, string bucketName,
            CancellationToken cancellationToken = new CancellationToken())
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

            ListVersionsResponse listVersionsResponse;

            // Iterate through the objects in the bucket and delete them.
            do
            {
                // Check if the operation has been canceled.
                cancellationToken.ThrowIfCancellationRequested();
                
                // List all the versions of all the objects in the bucket.
                listVersionsResponse = await s3Client.ListVersionsAsync(listVersionsRequest);

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

                try
                {
                    // Delete the current set of objects.
                    var deleteObjectsResponse = await s3Client.DeleteObjectsAsync(new DeleteObjectsRequest
                    {
                        BucketName = bucketName,
                        Objects = keyVersionList,
                        Quiet = true
                    });

                    //if (!deleteOptions.QuietMode)
                    //{
                    //    // If quiet mode is not set, update the client with list of deleted objects.
                    //    InvokeS3DeleteBucketWithObjectsUpdateCallback(
                    //                    updateCallback,
                    //                    new S3DeleteBucketWithObjectsUpdate
                    //                    {
                    //                        DeletedObjects = deleteObjectsResponse.DeletedObjects
                    //                    }
                    //                );
                    //}
                }
                catch //(DeleteObjectsException deleteObjectsException)
                {
                    //if (deleteOptions.ContinueOnError)
                    //{
                    //    // Continue the delete operation if an error was encountered.
                    //    // Update the client with the list of objects that were deleted and the 
                    //    // list of objects on which the delete failed.
                    //    InvokeS3DeleteBucketWithObjectsUpdateCallback(
                    //            updateCallback,
                    //            new S3DeleteBucketWithObjectsUpdate
                    //            {
                    //                DeletedObjects = deleteObjectsException.Response.DeletedObjects,
                    //                DeleteErrors = deleteObjectsException.Response.DeleteErrors
                    //            }
                    //        );
                    //}
                    //else
                    //{
                    //    // Re-throw the exception if an error was encountered.
                    //    throw;
                    //}

                    throw;
                }

                // Set the markers to get next set of objects from the bucket.
                listVersionsRequest.KeyMarker = listVersionsResponse.NextKeyMarker;
                listVersionsRequest.VersionIdMarker = listVersionsResponse.NextVersionIdMarker;

            }
            // Continue listing objects and deleting them until the bucket is empty.
            while (listVersionsResponse.IsTruncated);

            const int maxRetries = 10;
            for (int retries = 1; retries <= maxRetries; retries++)
            {
                try
                {
                    // Bucket is empty, delete the bucket.
                    await s3Client.DeleteBucketAsync(new DeleteBucketRequest
                    {
                        BucketName = bucketName
                    });
                    break;
                }
                catch (AmazonS3Exception e)
                {
                    if (e.StatusCode != HttpStatusCode.Conflict || retries == maxRetries)
                        throw;
                    else
                        DefaultRetryPolicy.WaitBeforeRetry(retries, 5000);
                }
            }

            //// Signal that the operation is completed.
            //asyncCancelableResult.SignalWaitHandleOnCompleted();
        }



        public static T WaitUntilSuccess<T>(Func<T> loadFunction, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            T result = default(T);
            WaitUntil(() =>
            {
                try
                {
                    result = loadFunction();
                    return true;
                }
                catch
                {
                    return false;
                }
            }, sleepSeconds, maxWaitSeconds);
            return result;
        }
        public static void WaitUntilSuccess(Action action, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            WaitUntil(() =>
            {
                try
                {
                    action();
                    return true;
                }
                catch
                {
                    return false;
                }
            }, sleepSeconds, maxWaitSeconds);
        }
        public static void WaitUntil(Func<bool> matchFunction, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            if (sleepSeconds < 0) throw new ArgumentOutOfRangeException("sleepSeconds");
            if (maxWaitSeconds < 0) throw new ArgumentOutOfRangeException("maxWaitSeconds");

            var sleepTime = TimeSpan.FromSeconds(sleepSeconds);
            var maxTime = TimeSpan.FromSeconds(maxWaitSeconds);
            var endTime = DateTime.Now + maxTime;

            while (DateTime.Now < endTime)
            {
                if (matchFunction())
                    return;
                Sleep(sleepTime);
            }

            throw new TimeoutException(string.Format("Wait condition was not satisfied for {0} seconds", maxWaitSeconds));
        }

        public static void Sleep(TimeSpan ts)
        {
            Task.Delay(ts).Wait();
        }
        public static async Task SleepAsync(TimeSpan ts)
        {
            await Task.Delay(ts);
        }

        public static void RunAsSync(Func<Task> asyncFunc)
        {
            Task.Run(asyncFunc).Wait();
        }

        public static T CreateClient<T>()
            where T : AmazonServiceClient
        {
            var client = (T)Activator.CreateInstance(typeof(T),
                new object[] { TestRunner.Credentials, TestRunner.RegionEndpoint });
            return client;
        }
    }
}
