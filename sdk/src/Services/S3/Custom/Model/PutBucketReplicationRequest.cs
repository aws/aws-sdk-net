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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketReplication operation.
    /// <para>Sets replication configuration for your bucket. If a replication configuration exists, this replaces it.</para>
    /// </summary>
    public partial class PutBucketReplicationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ReplicationConfiguration configuration;

        /// <summary>
        /// The name of the bucket to have the replication configuration applied.
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

        /// <summary>
        /// The replication configuration to be applied.
        /// </summary>
        public ReplicationConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        // Check to see if ReplicationConfiguration property is set
        internal bool IsSetConfiguration()
        {
            return this.configuration != null;
        }

    }
}

