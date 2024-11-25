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
    /// The resource representing a serverless cache snapshot. Available for Valkey, Redis
    /// OSS and Serverless Memcached only.
    /// </summary>
    public partial class ServerlessCacheSnapshot
    {
        private string _arn;
        private string _bytesUsedForCache;
        private DateTime? _createTime;
        private DateTime? _expiryTime;
        private string _kmsKeyId;
        private ServerlessCacheConfiguration _serverlessCacheConfiguration;
        private string _serverlessCacheSnapshotName;
        private string _snapshotType;
        private string _status;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a serverless cache snapshot. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BytesUsedForCache. 
        /// <para>
        /// The total size of a serverless cache snapshot, in bytes. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public string BytesUsedForCache
        {
            get { return this._bytesUsedForCache; }
            set { this._bytesUsedForCache = value; }
        }

        // Check to see if BytesUsedForCache property is set
        internal bool IsSetBytesUsedForCache()
        {
            return this._bytesUsedForCache != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time that the source serverless cache's metadata and cache data set was
        /// obtained for the snapshot. Available for Valkey, Redis OSS and Serverless Memcached
        /// only.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// The time that the serverless cache snapshot will expire. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public DateTime? ExpiryTime
        {
            get { return this._expiryTime; }
            set { this._expiryTime = value; }
        }

        // Check to see if ExpiryTime property is set
        internal bool IsSetExpiryTime()
        {
            return this._expiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services Key Management Service (KMS) key of a serverless
        /// cache snapshot. Available for Valkey, Redis OSS and Serverless Memcached only.
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
        /// Gets and sets the property ServerlessCacheConfiguration. 
        /// <para>
        /// The configuration of the serverless cache, at the time the snapshot was taken. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// </summary>
        public ServerlessCacheConfiguration ServerlessCacheConfiguration
        {
            get { return this._serverlessCacheConfiguration; }
            set { this._serverlessCacheConfiguration = value; }
        }

        // Check to see if ServerlessCacheConfiguration property is set
        internal bool IsSetServerlessCacheConfiguration()
        {
            return this._serverlessCacheConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessCacheSnapshotName. 
        /// <para>
        /// The identifier of a serverless cache snapshot. Available for Valkey, Redis OSS and
        /// Serverless Memcached only.
        /// </para>
        /// </summary>
        public string ServerlessCacheSnapshotName
        {
            get { return this._serverlessCacheSnapshotName; }
            set { this._serverlessCacheSnapshotName = value; }
        }

        // Check to see if ServerlessCacheSnapshotName property is set
        internal bool IsSetServerlessCacheSnapshotName()
        {
            return this._serverlessCacheSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of snapshot of serverless cache. Available for Valkey, Redis OSS and Serverless
        /// Memcached only.
        /// </para>
        /// </summary>
        public string SnapshotType
        {
            get { return this._snapshotType; }
            set { this._snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this._snapshotType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the serverless cache. Available for Valkey, Redis OSS and Serverless
        /// Memcached only.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}