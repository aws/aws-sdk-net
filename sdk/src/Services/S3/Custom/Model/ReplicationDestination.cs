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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies information about where to publish analysis or configuration results for
    /// an Amazon S3 bucket and S3 Replication Time Control (S3 RTC).
    /// </summary>
    public class ReplicationDestination
    {
        private AccessControlTranslation accessControlTranslation;
        private string accountId;
        private string bucketArn;
        private EncryptionConfiguration encryptionConfiguration;
        private Metrics metrics;
        private ReplicationTime replicationTime;
        private S3StorageClass storageClass;

        /// <summary>
        /// Gets and sets the property AccessControlTranslation. 
        /// <para>
        /// Specify this only in a cross-account scenario (where source and destination bucket
        /// owners are not the same), and you want to change replica ownership to the AWS account
        /// that owns the destination bucket. If this is not specified in the replication configuration,
        /// the replicas are owned by same AWS account that owns the source object.
        /// </para>
        /// </summary>
        public AccessControlTranslation AccessControlTranslation
        {
            get { return this.accessControlTranslation; }
            set { this.accessControlTranslation = value; }
        }

        // Check to see if AccessControlTranslation property is set
        public bool IsSetAccessControlTranslation()
        {
            return this.accessControlTranslation != null;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Destination bucket owner account ID. In a cross-account scenario, if you direct Amazon
        /// S3 to change replica ownership to the AWS account that owns the destination bucket
        /// by specifying the <code>AccessControlTranslation</code> property, this is the account
        /// ID of the destination bucket owner. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-change-owner.html">Replication
        /// Additional Configuration: Changing the Replica Owner</a> in the <i>Amazon S3 User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }
        }

        // Check to see if AccountId property is set
        public bool IsSetAccountId()
        {
            return !(string.IsNullOrEmpty(this.accountId));
        }

        /// <summary>
        /// <para> Amazon resource name (ARN) of the bucket where you want Amazon
        /// S3 to store replicas of the object identified by the rule. </para>
        /// <para> If you have multiple rules in your replication configuration, all
        /// rules must specify the same bucket as the destination. A replication
        /// configuration can replicate objects only to one destination bucket. </para>
        /// </summary>
        public string BucketArn
        {
            get { return this.bucketArn; }
            set { this.bucketArn = value; }
        }

        /// <summary>
        /// Checks to see if BucketArn property is set.
        /// </summary>
        /// <returns>true if BucketArn property is set.</returns>
        internal bool IsSetBucketArn()
        {
            return !System.String.IsNullOrEmpty(this.bucketArn);
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A container that provides information about encryption. If <code>SourceSelectionCriteria</code>
        /// is specified, you must specify this element.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this.encryptionConfiguration; }
            set { this.encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        public bool IsSetEncryptionConfiguration()
        {
            return this.encryptionConfiguration != null;
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
            get { return this.metrics; }
            set { this.metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this.metrics != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTime. 
        /// <para>
        ///  A container specifying S3 Replication Time Control (S3 RTC), including whether S3
        /// RTC is enabled and the time when all objects and operations on objects must be replicated.
        /// Must be specified together with a <code>Metrics</code> block. 
        /// </para>
        /// </summary>
        public ReplicationTime ReplicationTime
        {
            get { return this.replicationTime; }
            set { this.replicationTime = value; }
        }

        // Check to see if ReplicationTime property is set
        internal bool IsSetReplicationTime()
        {
            return this.replicationTime != null;
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
        /// For valid values, see the <code>StorageClass</code> element of the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTreplication.html">PUT
        /// Bucket replication</a> action in the <i>Amazon S3 API Reference</i>.
        /// </para>
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }
    }
}
