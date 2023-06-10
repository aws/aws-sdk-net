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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Specifies information about the replication destination bucket and its settings for
    /// an S3 on Outposts replication configuration.
    /// </summary>
    public partial class Destination
    {
        private AccessControlTranslation _accessControlTranslation;
        private string _account;
        private string _bucket;
        private EncryptionConfiguration _encryptionConfiguration;
        private Metrics _metrics;
        private ReplicationTime _replicationTime;
        private ReplicationStorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property AccessControlTranslation. 
        /// <para>
        /// Specify this property only in a cross-account scenario (where the source and destination
        /// bucket owners are not the same), and you want to change replica ownership to the Amazon
        /// Web Services account that owns the destination bucket. If this property is not specified
        /// in the replication configuration, the replicas are owned by same Amazon Web Services
        /// account that owns the source object.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public AccessControlTranslation AccessControlTranslation
        {
            get { return this._accessControlTranslation; }
            set { this._accessControlTranslation = value; }
        }

        // Check to see if AccessControlTranslation property is set
        internal bool IsSetAccessControlTranslation()
        {
            return this._accessControlTranslation != null;
        }

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The destination bucket owner's account ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access point for the destination bucket where
        /// you want S3 on Outposts to store the replication results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A container that provides information about encryption. If <code>SourceSelectionCriteria</code>
        /// is specified, you must specify this element.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        ///  A container that specifies replication metrics-related settings. 
        /// </para>
        /// </summary>
        public Metrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTime. 
        /// <para>
        /// A container that specifies S3 Replication Time Control (S3 RTC) settings, including
        /// whether S3 RTC is enabled and the time when all objects and operations on objects
        /// must be replicated. Must be specified together with a <code>Metrics</code> block.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicationTime ReplicationTime
        {
            get { return this._replicationTime; }
            set { this._replicationTime = value; }
        }

        // Check to see if ReplicationTime property is set
        internal bool IsSetReplicationTime()
        {
            return this._replicationTime != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        ///  The storage class to use when replicating objects. All objects stored on S3 on Outposts
        /// are stored in the <code>OUTPOSTS</code> storage class. S3 on Outposts uses the <code>OUTPOSTS</code>
        /// storage class to create the object replicas. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Values other than <code>OUTPOSTS</code> are not supported by Amazon S3 on Outposts.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicationStorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

    }
}