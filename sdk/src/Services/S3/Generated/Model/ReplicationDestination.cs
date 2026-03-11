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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies information about where to publish analysis or configuration results for
    /// an Amazon S3 bucket and S3 Replication Time Control (S3 RTC).
    /// </summary>
    public partial class ReplicationDestination
    {
        private AccessControlTranslation _accessControlTranslation;
        private string _accountId;
        private string _bucketArn;
        private EncryptionConfiguration _encryptionConfiguration;
        private Metrics _metrics;
        private ReplicationTime _replicationTime;
        private S3StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property AccessControlTranslation. 
        /// <para>
        /// Specify this only in a cross-account scenario (where source and destination bucket
        /// owners are not the same), and you want to change replica ownership to the Amazon Web
        /// Services account that owns the destination bucket. If this is not specified in the
        /// replication configuration, the replicas are owned by same Amazon Web Services account
        /// that owns the source object.
        /// </para>
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
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Destination bucket owner account ID. In a cross-account scenario, if you direct Amazon
        /// S3 to change replica ownership to the Amazon Web Services account that owns the destination
        /// bucket by specifying the <c>AccessControlTranslation</c> property, this is the account
        /// ID of the destination bucket owner. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-change-owner.html">Replication
        /// Additional Configuration: Changing the Replica Owner</a> in the <i>Amazon S3 User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the bucket where you want Amazon S3 to store the
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A container that provides information about encryption. If <c>SourceSelectionCriteria</c>
        /// is specified, you must specify this element.
        /// </para>
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
        ///  A container specifying replication metrics-related settings enabling replication
        /// metrics and events. 
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
        ///  A container specifying S3 Replication Time Control (S3 RTC), including whether S3
        /// RTC is enabled and the time when all objects and operations on objects must be replicated.
        /// Must be specified together with a <c>Metrics</c> block. 
        /// </para>
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
        ///  The storage class to use when replicating objects, such as S3 Standard or reduced
        /// redundancy. By default, Amazon S3 uses the storage class of the source object to create
        /// the object replica. 
        /// </para>
        ///  
        /// <para>
        /// For valid values, see the <c>StorageClass</c> element of the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTreplication.html">PUT
        /// Bucket replication</a> action in the <i>Amazon S3 API Reference</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>FSX_OPENZFS</c> is not an accepted value when replicating objects.
        /// </para>
        /// </summary>
        public S3StorageClass StorageClass
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