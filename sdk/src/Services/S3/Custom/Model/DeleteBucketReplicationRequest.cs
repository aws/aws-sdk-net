/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Request object for the DeleteBucketReplication operation.
    /// </summary>
    public partial class DeleteBucketReplicationRequest : AmazonWebServiceRequest
    {
        private string bucketName;

        /// <summary>
        /// Gets and sets the property BucketName.
        /// <p>Deletes the replication subresource associated with the specified
        /// bucket.</p> <note> <p>There is usually some time lag before
        /// replication configuration deletion is fully propagated to all the
        /// Amazon S3 systems.</p> </note> <p> For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/crr.html">
        /// Cross-Region Replication (CRR)</a> in the Amazon S3 Developer
        /// Guide. </p>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }
    }
}
