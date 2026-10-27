/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// The Amazon S3 source configuration for an ingestion job.
    /// </summary>
    public partial class IngestionJobS3Source
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the Amazon S3 bucket to ingest data from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 2048)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property BucketOwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string BucketOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BucketOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetBucketOwnerAccountId() => this.BucketOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// A key prefix that limits ingestion to objects in the Amazon S3 bucket whose keys begin
        /// with the prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the KeyPrefix property is set.
        /// </summary>
        internal bool IsSetKeyPrefix() => this.KeyPrefix != null;
    }
}
