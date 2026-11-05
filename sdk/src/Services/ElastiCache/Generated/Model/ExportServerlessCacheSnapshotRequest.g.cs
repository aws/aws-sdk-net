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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the ExportServerlessCacheSnapshot operation. Provides
    /// the functionality to export the serverless cache snapshot data to Amazon S3. Available
    /// for Valkey and Redis OSS only.
    /// </summary>
    public partial class ExportServerlessCacheSnapshotRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// Name of the Amazon S3 bucket to export the snapshot to. The Amazon S3 bucket must
        /// also be in same region as the snapshot. Available for Valkey and Redis OSS only.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property ServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier of the serverless cache snapshot to be exported to S3. Available for
        /// Valkey and Redis OSS only.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServerlessCacheSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheSnapshotName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheSnapshotName() => this.ServerlessCacheSnapshotName != null;
    }
}
