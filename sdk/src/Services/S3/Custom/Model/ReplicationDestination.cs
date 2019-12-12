/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Destination configuration for a replication rule.
    /// </summary>
    public class ReplicationDestination
    {
        private string bucketArn;
        private S3StorageClass storageClass;
        private EncryptionConfiguration encryptionConfiguration;
        private AccessControlTranslation accessControlTranslation;
        private string accountId;
        private ReplicationTime replicationTime;
        private Metrics metrics;

        /// <summary>
        /// <p> Amazon resource name (ARN) of the bucket where you want Amazon
        /// S3 to store replicas of the object identified by the rule. </p> <p>
        /// If you have multiple rules in your replication configuration, all
        /// rules must specify the same bucket as the destination. A replication
        /// configuration can replicate objects only to one destination bucket. </p>
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
        /// The class of storage used to store the object.
        ///  
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
        /// <summary>
        /// <p> Account ID of the destination bucket. Currently Amazon S3 verifies this
        /// value only if Access Control Translation is enabled. </p> <p> In a cross-account
        /// scenario, if you tell Amazon S3 to change replica ownership to the AWS account
        /// that owns the destination bucket by adding the <code>AccessControlTranslation</code>
        /// element, this is the account ID of the destination bucket owner. </p>
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
        /// <p> Container for information regarding the access control for replicas. </p>
        /// <p> Use only in a cross-account scenario, where source and destination bucket
        /// owners are not the same, when you want to change replica ownership to the AWS
        /// account that owns the destination bucket. If you don't add this element to the
        /// replication configuration, the replicas are owned by same AWS account that
        /// owns the source object. </p>
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
        /// <p> Container that provides encryption-related information. You must
        /// specify this element if the <code>SourceSelectionCriteria</code> is
        /// specified. </p>
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
        /// A container specifying the time when all objects and operations on objects are 
        /// replicated. Must be specified together with a <code>Metrics</code> block.
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
        /// A container specifying replication metrics-related information, including whether 
        /// emitting metrics and Amazon S3 events for replication are enabled. In addition, 
        /// contains configurations related to specific metrics or events. Must be specified 
        /// together with a <code>ReplicationTime</code> block.
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
    }
}
