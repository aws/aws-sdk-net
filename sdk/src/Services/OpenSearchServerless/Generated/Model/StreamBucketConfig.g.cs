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
    /// S3 bucket configuration for SQS-driven ingestion. The scan mode controls only the
    /// optional one-time delta scan of existing objects in this bucket.
    /// </summary>
    public partial class StreamBucketConfig
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the Amazon S3 bucket to ingest data from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 2048)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property BucketOwnerAccountId. The AWS account ID that owns the
        /// S3 bucket. Optional. If omitted, the control plane derives it from the account segment
        /// of sqsArn.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string BucketOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BucketOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetBucketOwnerAccountId() => this.BucketOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property InitialScan. 
        /// <para>
        /// Specifies whether to perform a one-time scan of the objects that already exist in
        /// the bucket before the stream begins processing Amazon S3 event notifications. If <c>DISABLED</c>,
        /// only new objects are ingested.
        /// </para>
        /// </summary>
        public InitialScan InitialScan { get; set; }

        /// <summary>
        /// Checks to see if the InitialScan property is set.
        /// </summary>
        internal bool IsSetInitialScan() => this.InitialScan != null;
    }
}
