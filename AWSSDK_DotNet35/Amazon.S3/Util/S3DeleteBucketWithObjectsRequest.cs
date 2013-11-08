/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Linq;
using System.Text;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Internal class used to pass the parameters for DeleteS3BucketWithObjects operation.
    /// </summary>
    internal class S3DeleteBucketWithObjectsRequest
    {
        /// <summary>
        /// Name of the bucket to be deleted.
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// The Amazon S3 Client to use for S3 specific operations.
        /// </summary>
        public IAmazonS3 S3Client { get; set; }

        /// <summary>
        /// Options to control the behavior of the delete operation.
        /// </summary>
        public S3DeleteBucketWithObjectsOptions DeleteOptions { get; set; }

        /// <summary>
        /// Represents the status of an asynchronous operation. 
        /// </summary>
        public AsyncCancelableResult AsyncCancelableResult { get; set; }

        /// <summary>
        /// The callback which is used to send updates about the delete operation.
        /// </summary>
        public Action<S3DeleteBucketWithObjectsUpdate> UpdateCallback { get; set; }
    }
}
