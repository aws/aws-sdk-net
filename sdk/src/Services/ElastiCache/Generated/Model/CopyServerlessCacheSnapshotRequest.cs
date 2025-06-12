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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
    /// Container for the parameters to the CopyServerlessCacheSnapshot operation.
    /// Creates a copy of an existing serverless cache’s snapshot. Available for Valkey, Redis
    /// OSS and Serverless Memcached only.
    /// </summary>
    public partial class CopyServerlessCacheSnapshotRequest : AmazonElastiCacheRequest
    {
        private string _kmsKeyId;
        private string _sourceServerlessCacheSnapshotName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetServerlessCacheSnapshotName;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the KMS key used to encrypt the target snapshot. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier of the existing serverless cache’s snapshot to be copied. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceServerlessCacheSnapshotName
        {
            get { return this._sourceServerlessCacheSnapshotName; }
            set { this._sourceServerlessCacheSnapshotName = value; }
        }

        // Check to see if SourceServerlessCacheSnapshotName property is set
        internal bool IsSetSourceServerlessCacheSnapshotName()
        {
            return this._sourceServerlessCacheSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to the target snapshot resource. A tag is a key-value pair.
        /// Available for Valkey, Redis OSS and Serverless Memcached only. Default: NULL
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier for the snapshot to be created. Available for Valkey, Redis OSS and
        /// Serverless Memcached only.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetServerlessCacheSnapshotName
        {
            get { return this._targetServerlessCacheSnapshotName; }
            set { this._targetServerlessCacheSnapshotName = value; }
        }

        // Check to see if TargetServerlessCacheSnapshotName property is set
        internal bool IsSetTargetServerlessCacheSnapshotName()
        {
            return this._targetServerlessCacheSnapshotName != null;
        }

    }
}