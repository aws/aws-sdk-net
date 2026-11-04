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
    /// Container for the parameters to the CopyServerlessCacheSnapshot operation. Creates
    /// a copy of an existing serverless cache’s snapshot. Available for Valkey, Redis OSS
    /// and Serverless Memcached only.
    /// </summary>
    public partial class CopyServerlessCacheSnapshotRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the KMS key used to encrypt the target snapshot. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SourceServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier of the existing serverless cache’s snapshot to be copied. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceServerlessCacheSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerlessCacheSnapshotName property is set.
        /// </summary>
        internal bool IsSetSourceServerlessCacheSnapshotName() => this.SourceServerlessCacheSnapshotName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to the target snapshot resource. A tag is a key-value pair.
        /// Available for Valkey, Redis OSS and Serverless Memcached only. Default: NULL
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier for the snapshot to be created. Available for Valkey, Redis OSS and
        /// Serverless Memcached only. This value is stored as a lowercase string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetServerlessCacheSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the TargetServerlessCacheSnapshotName property is set.
        /// </summary>
        internal bool IsSetTargetServerlessCacheSnapshotName() => this.TargetServerlessCacheSnapshotName != null;
    }
}
