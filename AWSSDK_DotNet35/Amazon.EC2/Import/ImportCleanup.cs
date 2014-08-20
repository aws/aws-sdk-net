/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

namespace Amazon.EC2.Import
{

    /// <summary>
    /// Callback signature to report progress on the deletion of the artifacts.
    /// </summary>
    /// <param name="message">Describes the current in-progress task.</param>
    /// <param name="percentComplete">If not null, the percentage completion of the deletion process.</param>
    public delegate void CleanupProgressCallback(string message, int? percentComplete);

#if BCL
    /// <summary>
    /// Collection of helper methods for removing VM image file artifacts from Amazon S3 after
    /// an instance or volume conversion has been performed. 
    /// </summary>
    public abstract class ImportCleanup
    {
        /// <summary>
        /// Deletes the image file artifacts associated with the specified conversion task.
        /// If the task is still active, ignoreActiveTask must be set true to enable artifact
        /// deletion, which will cause the task to fail. Use this option at your own risk.
        /// </summary>
        /// <param name="awsCredentials">
        /// Credentials to use to instantiate the Amazon EC2 and Amazon S3 clients needed to
        /// complete the operation.
        /// </param>
        /// <param name="region">
        /// The region containing the bucket where the image file artifacts were stored
        /// </param>
        /// <param name="conversionTaskId">
        /// The ID of the conversion task that used the image file
        /// </param>
        /// <param name="ignoreActiveTask">
        /// If true the artifacts are deleted even if the conversion task is still in progress
        /// </param>
        /// <param name="progressCallback">Optional progress callback</param>
        public static void DeleteImageArtifacts(AWSCredentials awsCredentials, 
                                                RegionEndpoint region, 
                                                string conversionTaskId, 
                                                bool ignoreActiveTask,
                                                CleanupProgressCallback progressCallback)
        {
            DeleteImageArtifacts(new AmazonEC2Client(awsCredentials, region), 
                                 new AmazonS3Client(awsCredentials, region), 
                                 conversionTaskId, 
                                 ignoreActiveTask,
                                 progressCallback);                        
        }

        /// <summary>
        /// Deletes the image file artifacts associated with the specified conversion task.
        /// If the task is still active, ignoreActiveTask must be set true to enable artifact
        /// deletion, which will cause the task to fail. Use this option at your own risk.
        /// </summary>
        /// <param name="region">
        /// The region containing the bucket where the image file artifacts were stored
        /// </param>
        /// <param name="conversionTaskId">
        /// The ID of the conversion task that used the image file
        /// </param>
        /// <param name="ignoreActiveTask">
        /// If true the artifacts are deleted even if the conversion task is still in progress
        /// </param>
        /// <param name="progressCallback">Optional progress callback</param>
        /// <remarks>
        /// Amazon EC2 and S3 clients will be constructed using the specified region and
        /// default credentials.
        /// </remarks>
        public static void DeleteImageArtifacts(RegionEndpoint region, 
                                                string conversionTaskId, 
                                                bool ignoreActiveTask,
                                                CleanupProgressCallback progressCallback)
        {
            DeleteImageArtifacts(new AmazonEC2Client(region), 
                                 new AmazonS3Client(region), 
                                 conversionTaskId, 
                                 ignoreActiveTask,
                                 progressCallback);
        }

        /// <summary>
        /// Deletes the image file artifacts associated with the specified conversion task.
        /// If the task is still active, ignoreActiveTask must be set true to enable artifact
        /// deletion, which will cause the task to fail. Use this option at your own risk.
        /// </summary>
        /// <param name="ec2Client">
        /// Amazon EC2 client to use in the process. This should have been instantiated
        /// with credentials that have access to the conversion task and the region in
        /// which the import was performed.
        /// </param>
        /// <param name="s3Client">
        /// Amazon S3 client to use use in the process. This should have been instantiated
        /// with credentials that have access to the bucket containing the image file artifacts
        /// and the region in which the bucket exists.
        /// </param>
        /// <param name="conversionTaskId">
        /// The ID of the conversion task that used the image file
        /// </param>
        /// <param name="ignoreActiveTask">
        /// If true the artifacts are deleted even if the conversion task is still in progress
        /// </param>
        /// <param name="progressCallback">Optional progress callback</param>
        public static void DeleteImageArtifacts(IAmazonEC2 ec2Client, 
                                                IAmazonS3 s3Client, 
                                                string conversionTaskId, 
                                                bool ignoreActiveTask,
                                                CleanupProgressCallback progressCallback)
        {
            if (string.IsNullOrEmpty(conversionTaskId))
                throw new ArgumentException("Missing conversion task id", "conversionTaskId");

            SendProgressNotification(progressCallback, "Inspecting conversion task", null);

            var request = new DescribeConversionTasksRequest();
            request.ConversionTaskIds.Add(conversionTaskId);
            try
            {
                var response = ec2Client.DescribeConversionTasks(request);
                if (response.ConversionTasks.Count == 0)
                    throw new ArgumentException("Invalid conversion task id", "conversionTaskId");

                var conversionTask = response.ConversionTasks[0];

                if (!ignoreActiveTask && conversionTask.State.Equals(ConversionTaskState.Active))
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, 
                                                                      "Import task '{0}' is still active.", 
                                                                      conversionTaskId));

                string manifestUrl = null;
                try
                {
                    // At this time only one disk image per task
                    if (conversionTask.IsSetImportInstance())
                        manifestUrl = conversionTask.ImportInstance.Volumes[0].Image.ImportManifestUrl;
                    else if (conversionTask.IsSetImportVolume())
                        manifestUrl = conversionTask.ImportVolume.Image.ImportManifestUrl;
                }
                finally
                {
                    if (string.IsNullOrEmpty(manifestUrl))
                        throw new ArgumentException("Unable to obtain import manifest url from conversion task instance.");
                }

                DeleteImageArtifacts(s3Client, manifestUrl, progressCallback);
            }
            catch (AmazonEC2Exception e)
            {
                throw new ArgumentException("Expected the id of a valid conversion task", "conversionTaskId", e);
            }
        }

        /// <summary>
        /// Deletes the artifacts associated with an import task using a presigned
        /// url to address the manifest for the import. No check is performed to
        /// determine whether the associated conversion task is in progress.
        /// </summary>
        /// <param name="awsCredentials">
        /// Credentials to use to instantiate the Amazon EC2 and Amazon S3 clients needed to
        /// complete the operation.
        /// </param>
        /// <param name="region">
        /// The region containing the bucket where the image file artifacts were stored
        /// </param>
        /// <param name="manifestUrl">
        /// Presigned URL to the import manifest file
        /// </param>
        /// <param name="progressCallback">Optional progress callback</param>
        public static void DeleteImageArtifacts(AWSCredentials awsCredentials, 
                                                RegionEndpoint region, 
                                                string manifestUrl,
                                                CleanupProgressCallback progressCallback)
        {
            DeleteImageArtifacts(new AmazonS3Client(awsCredentials, region), 
                                 manifestUrl,
                                 progressCallback);    
        }

        /// <summary>
        /// Deletes the artifacts associated with an import task using a presigned
        /// url to address the manifest for the import. No check is performed to
        /// determine whether the associated conversion task is in progress.
        /// </summary>
        /// <param name="region">
        /// The region containing the bucket where the image file artifacts were stored
        /// </param>
        /// <param name="manifestUrl">
        /// Presigned URL to the import manifest file
        /// </param>
        /// <param name="progressCallback">Optional progress callback</param>
        /// <remarks>
        /// An Amazon S3 client will be constructed using the specified region and
        /// default credentials.
        /// </remarks>
        public static void DeleteImageArtifacts(RegionEndpoint region, 
                                                string manifestUrl,
                                                CleanupProgressCallback progressCallback)
        {
            DeleteImageArtifacts(new AmazonS3Client(region), manifestUrl, progressCallback);
        }

        /// <summary>
        /// Deletes the artifacts associated with an import task using a presigned
        /// url to address the manifest for the import. No check is performed to
        /// determine whether the associated conversion task is in progress.
        /// </summary>
        /// <param name="s3Client">
        /// An Amazon S3 client for the operation to use. This should have been constructed
        /// using credentials that have access to the bucket containing the image file
        /// artifacts and be scoped to the region containing the bucket.
        /// </param>
        /// <param name="manifestUrl">
        /// Presigned URL to the import manifest file
        /// </param>
        /// <param name="progressCallback">Optional progress callback</param>
        public static void DeleteImageArtifacts(IAmazonS3 s3Client, 
                                                string manifestUrl,
                                                CleanupProgressCallback progressCallback)
        {
            if (string.IsNullOrEmpty(manifestUrl))
                throw new ArgumentException("Expected valid presigned url to the import manifest.");

            var s3Uri = new AmazonS3Uri(manifestUrl);
            // strip the manifest object name away from the key to get the overall key prefix
            // to the objects
            var lastSlashPos = s3Uri.Key.LastIndexOf('/');
            DeleteImageArtifacts(s3Client, s3Uri.Bucket, s3Uri.Key.Substring(0, lastSlashPos), progressCallback);
        }

        /// <summary>
        /// Deletes the artifacts associated with an import task using the bucket name
        /// and key prefix to the artifacts in Amazon S3. No check is performed to
        /// determine whether the associated conversion task is in progress.
        /// </summary>
        /// <param name="awsCredentials">
        /// Credentials to use to instantiate the Amazon EC2 and Amazon S3 clients needed to
        /// complete the operation.
        /// </param>
        /// <param name="region">
        /// The region containing the bucket where the image file artifacts were stored
        /// </param>
        /// <param name="bucketName">The name of the bucket containing the artifacts</param>
        /// <param name="keyPrefix">The common key prefix of the artifacts</param>
        /// <param name="progressCallback">Optional progress callback</param>
        /// <remarks>
        /// An Amazon S3 client will be constructed using the specified region and
        /// credentials.
        /// </remarks>
        public static void DeleteImageArtifacts(AWSCredentials awsCredentials, 
                                                RegionEndpoint region, 
                                                string bucketName, 
                                                string keyPrefix,
                                                CleanupProgressCallback progressCallback)
        {
            DeleteImageArtifacts(new AmazonS3Client(awsCredentials, region), 
                                 bucketName, 
                                 keyPrefix,
                                 progressCallback);
        }

        /// <summary>
        /// Deletes the artifacts associated with an import task using the bucket name
        /// and key prefix to the artifacts in Amazon S3. No check is performed to
        /// determine whether the associated conversion task is in progress.
        /// </summary>
        /// <param name="region">
        /// The region containing the bucket where the image file artifacts were stored
        /// </param>
        /// <param name="bucketName">The name of the bucket containing the artifacts</param>
        /// <param name="keyPrefix">The common key prefix of the artifacts</param>
        /// <param name="progressCallback">Optional progress callback</param>
        /// <remarks>
        /// An Amazon S3 client will be constructed using the specified region and
        /// default profile credentials.
        /// </remarks>
        public static void DeleteImageArtifacts(RegionEndpoint region, 
                                                string bucketName, 
                                                string keyPrefix,
                                                CleanupProgressCallback progressCallback)
        {
            DeleteImageArtifacts(new AmazonS3Client(region), bucketName, keyPrefix, progressCallback);
        }

        /// <summary>
        /// Deletes the artifacts associated with an import task using the bucket name
        /// and key prefix to the artifacts in Amazon S3. No check is performed to
        /// determine whether the associated conversion task is in progress.
        /// </summary>
        /// <param name="s3Client">
        /// An Amazon S3 client for the operation to use. This should have been constructed
        /// using credentials that have access to the bucket containing the image file
        /// artifacts and be scoped to the region containing the bucket.
        /// </param>
        /// <param name="bucketName">The name of the bucket containing the artifacts</param>
        /// <param name="keyPrefix">The common key prefix of the artifacts</param>
        /// <param name="progressCallback">Optional progress callback</param>
        public static void DeleteImageArtifacts(IAmazonS3 s3Client, 
                                                string bucketName, 
                                                string keyPrefix,
                                                CleanupProgressCallback progressCallback)
        {
            // build the full collection of keys to be deleted so that any progress
            // indicator managed by the caller is accurate
            SendProgressNotification(progressCallback, "Collating keys to image file artifacts", null);

            var artifactKeys = new List<string>();
            string marker = null;
            do
            {
                var listResponse = s3Client.ListObjects(new ListObjectsRequest
                {
                    BucketName = bucketName,
                    Prefix = keyPrefix,
                    Marker = marker
                });
                artifactKeys.AddRange(listResponse.S3Objects.Select(o => o.Key));
                marker = listResponse.NextMarker;
            } while (!string.IsNullOrEmpty(marker));

            if (artifactKeys.Count == 0)
            {
                var msg = string.Format(CultureInfo.InvariantCulture,
                                        "Found no image file artifacts with key prefix '{0}' to delete in bucket '{1}'.",
                                        keyPrefix,      
                                        bucketName);
                SendProgressNotification(progressCallback, msg, null);
                return;
            }

            var deletionMsg = string.Format(CultureInfo.InvariantCulture,
                                            "Deleting {0} image file artifacts (key prefix '{1}', bucket '{2}').", 
                                            artifactKeys.Count,
                                            keyPrefix,
                                            bucketName);
            SendProgressNotification(progressCallback, deletionMsg, 0);

            var index = 0;
            var processed = 0;
            do
            {
                var request = new DeleteObjectsRequest { BucketName = bucketName };
                while (request.Objects.Count < 1000 && index < artifactKeys.Count)
                {
                    request.Objects.Add(new KeyVersion { Key = artifactKeys[index++] });
                }

                s3Client.DeleteObjects(request);
                processed += request.Objects.Count;

                SendProgressNotification(progressCallback, deletionMsg, processed/artifactKeys.Count * 100);

            } while (processed < artifactKeys.Count);
        }

        /// <summary>
        /// Callback processing if the caller supplied a delegate.
        /// </summary>
        /// <param name="progressCallback">
        /// The callback delegate that was supplied, or null if progress updates were not requested
        /// </param>
        /// <param name="msg">A message describing the current state of the cleanup process</param>
        /// <param name="percentComplete">When the deletion phase of the cleanup process starts, set 
        /// to the percentage of image file artifacts deleted so far
        /// </param>
        static void SendProgressNotification(CleanupProgressCallback progressCallback, string msg, int? percentComplete)
        {
            if (progressCallback == null)
                return;

            progressCallback(msg, percentComplete);
        }
    }
#endif
}
