/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Model;
using Amazon.Util;
using System.Threading.Tasks;


namespace Amazon.S3.Util
{
    /// <summary>
    /// Provides utilities used by the Amazon S3 client implementation.
    /// These utilities might be useful to consumers of the Amazon S3
    /// library.
    /// </summary>
    public static partial class AmazonS3Util
    {
        /// <summary>
        /// Deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void DeleteS3BucketWithObjects(IAmazonS3 s3Client, string bucketName)
        {
            DeleteS3BucketWithObjectsAsync(s3Client, bucketName, CancellationToken.None).Wait();
        }

        /// <summary>
        /// Deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">Options to control the behavior of the delete operation.</param>
        public static void DeleteS3BucketWithObjects(IAmazonS3 s3Client, string bucketName, S3DeleteBucketWithObjectsOptions deleteOptions)
        {
            DeleteS3BucketWithObjectsAsync(s3Client, bucketName, deleteOptions, CancellationToken.None).Wait();
        }
    }
}
