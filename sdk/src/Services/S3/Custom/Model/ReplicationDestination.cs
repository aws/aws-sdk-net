/*
 * Copyright 2010-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Destination configuration for a replication rule.
    /// </summary>
    public class ReplicationDestination
    {
        private string bucketArn;
        private S3StorageClass storageClass;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the bucket to which replicas are sent.
        /// </summary>
        public string BucketArn
        {
            get { return this.bucketArn; }
            set { this.bucketArn = value; }
        }

        /// <summary>
        /// Checks to see if BucketArn property is set.
        /// </summary>
        /// <returns>true if BucketArn property is set.</returns>
        internal bool IsSetBucketArn()
        {
            return !System.String.IsNullOrEmpty(this.bucketArn);
        }


        /// <summary>
        /// The class of storage used to store the object.
        ///  
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }
    }
}
