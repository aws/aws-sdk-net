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
    /// The resource representing a serverless cache snapshot. Available for Valkey, Redis
    /// OSS and Serverless Memcached only.
    /// </summary>
    public partial class ServerlessCacheSnapshot
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a serverless cache snapshot. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property BytesUsedForCache. 
        /// <para>
        /// The total size of a serverless cache snapshot, in bytes. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string BytesUsedForCache { get; set; }

        /// <summary>
        /// Checks to see if the BytesUsedForCache property is set.
        /// </summary>
        internal bool IsSetBytesUsedForCache() => this.BytesUsedForCache != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time that the source serverless cache's metadata and cache data set was
        /// obtained for the snapshot. Available for Valkey, Redis OSS and Serverless Memcached
        /// only.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// The time that the serverless cache snapshot will expire. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTime property is set.
        /// </summary>
        internal bool IsSetExpiryTime() => this.ExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services Key Management Service (KMS) key of a serverless
        /// cache snapshot. Available for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ServerlessCacheConfiguration. 
        /// <para>
        /// The configuration of the serverless cache, at the time the snapshot was taken. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public ServerlessCacheConfiguration ServerlessCacheConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheConfiguration property is set.
        /// </summary>
        internal bool IsSetServerlessCacheConfiguration() => this.ServerlessCacheConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier of a serverless cache snapshot. Available for Valkey, Redis OSS and
        /// Serverless Memcached only.
        /// </para>
        /// </summary>
        public string ServerlessCacheSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheSnapshotName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheSnapshotName() => this.ServerlessCacheSnapshotName != null;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of snapshot of serverless cache. Available for Valkey, Redis OSS and Serverless
        /// Memcached only.
        /// </para>
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the serverless cache. Available for Valkey, Redis OSS and Serverless
        /// Memcached only.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
