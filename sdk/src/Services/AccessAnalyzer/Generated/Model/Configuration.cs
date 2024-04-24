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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Access control configuration structures for your resource. You specify the configuration
    /// as a type-value pair. You can specify only one type of access control configuration.
    /// </summary>
    public partial class Configuration
    {
        private DynamodbStreamConfiguration _dynamodbStream;
        private DynamodbTableConfiguration _dynamodbTable;
        private EbsSnapshotConfiguration _ebsSnapshot;
        private EcrRepositoryConfiguration _ecrRepository;
        private EfsFileSystemConfiguration _efsFileSystem;
        private IamRoleConfiguration _iamRole;
        private KmsKeyConfiguration _kmsKey;
        private RdsDbClusterSnapshotConfiguration _rdsDbClusterSnapshot;
        private RdsDbSnapshotConfiguration _rdsDbSnapshot;
        private S3BucketConfiguration _s3Bucket;
        private S3ExpressDirectoryBucketConfiguration _s3ExpressDirectoryBucket;
        private SecretsManagerSecretConfiguration _secretsManagerSecret;
        private SnsTopicConfiguration _snsTopic;
        private SqsQueueConfiguration _sqsQueue;

        /// <summary>
        /// Gets and sets the property DynamodbStream. 
        /// <para>
        /// The access control configuration is for a DynamoDB stream.
        /// </para>
        /// </summary>
        public DynamodbStreamConfiguration DynamodbStream
        {
            get { return this._dynamodbStream; }
            set { this._dynamodbStream = value; }
        }

        // Check to see if DynamodbStream property is set
        internal bool IsSetDynamodbStream()
        {
            return this._dynamodbStream != null;
        }

        /// <summary>
        /// Gets and sets the property DynamodbTable. 
        /// <para>
        /// The access control configuration is for a DynamoDB table or index.
        /// </para>
        /// </summary>
        public DynamodbTableConfiguration DynamodbTable
        {
            get { return this._dynamodbTable; }
            set { this._dynamodbTable = value; }
        }

        // Check to see if DynamodbTable property is set
        internal bool IsSetDynamodbTable()
        {
            return this._dynamodbTable != null;
        }

        /// <summary>
        /// Gets and sets the property EbsSnapshot. 
        /// <para>
        /// The access control configuration is for an Amazon EBS volume snapshot.
        /// </para>
        /// </summary>
        public EbsSnapshotConfiguration EbsSnapshot
        {
            get { return this._ebsSnapshot; }
            set { this._ebsSnapshot = value; }
        }

        // Check to see if EbsSnapshot property is set
        internal bool IsSetEbsSnapshot()
        {
            return this._ebsSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property EcrRepository. 
        /// <para>
        /// The access control configuration is for an Amazon ECR repository.
        /// </para>
        /// </summary>
        public EcrRepositoryConfiguration EcrRepository
        {
            get { return this._ecrRepository; }
            set { this._ecrRepository = value; }
        }

        // Check to see if EcrRepository property is set
        internal bool IsSetEcrRepository()
        {
            return this._ecrRepository != null;
        }

        /// <summary>
        /// Gets and sets the property EfsFileSystem. 
        /// <para>
        /// The access control configuration is for an Amazon EFS file system.
        /// </para>
        /// </summary>
        public EfsFileSystemConfiguration EfsFileSystem
        {
            get { return this._efsFileSystem; }
            set { this._efsFileSystem = value; }
        }

        // Check to see if EfsFileSystem property is set
        internal bool IsSetEfsFileSystem()
        {
            return this._efsFileSystem != null;
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The access control configuration is for an IAM role. 
        /// </para>
        /// </summary>
        public IamRoleConfiguration IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The access control configuration is for a KMS key. 
        /// </para>
        /// </summary>
        public KmsKeyConfiguration KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbClusterSnapshot. 
        /// <para>
        /// The access control configuration is for an Amazon RDS DB cluster snapshot.
        /// </para>
        /// </summary>
        public RdsDbClusterSnapshotConfiguration RdsDbClusterSnapshot
        {
            get { return this._rdsDbClusterSnapshot; }
            set { this._rdsDbClusterSnapshot = value; }
        }

        // Check to see if RdsDbClusterSnapshot property is set
        internal bool IsSetRdsDbClusterSnapshot()
        {
            return this._rdsDbClusterSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbSnapshot. 
        /// <para>
        /// The access control configuration is for an Amazon RDS DB snapshot.
        /// </para>
        /// </summary>
        public RdsDbSnapshotConfiguration RdsDbSnapshot
        {
            get { return this._rdsDbSnapshot; }
            set { this._rdsDbSnapshot = value; }
        }

        // Check to see if RdsDbSnapshot property is set
        internal bool IsSetRdsDbSnapshot()
        {
            return this._rdsDbSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The access control configuration is for an Amazon S3 bucket. 
        /// </para>
        /// </summary>
        public S3BucketConfiguration S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3ExpressDirectoryBucket. 
        /// <para>
        /// The access control configuration is for an Amazon S3 directory bucket.
        /// </para>
        /// </summary>
        public S3ExpressDirectoryBucketConfiguration S3ExpressDirectoryBucket
        {
            get { return this._s3ExpressDirectoryBucket; }
            set { this._s3ExpressDirectoryBucket = value; }
        }

        // Check to see if S3ExpressDirectoryBucket property is set
        internal bool IsSetS3ExpressDirectoryBucket()
        {
            return this._s3ExpressDirectoryBucket != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerSecret. 
        /// <para>
        /// The access control configuration is for a Secrets Manager secret.
        /// </para>
        /// </summary>
        public SecretsManagerSecretConfiguration SecretsManagerSecret
        {
            get { return this._secretsManagerSecret; }
            set { this._secretsManagerSecret = value; }
        }

        // Check to see if SecretsManagerSecret property is set
        internal bool IsSetSecretsManagerSecret()
        {
            return this._secretsManagerSecret != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopic. 
        /// <para>
        /// The access control configuration is for an Amazon SNS topic
        /// </para>
        /// </summary>
        public SnsTopicConfiguration SnsTopic
        {
            get { return this._snsTopic; }
            set { this._snsTopic = value; }
        }

        // Check to see if SnsTopic property is set
        internal bool IsSetSnsTopic()
        {
            return this._snsTopic != null;
        }

        /// <summary>
        /// Gets and sets the property SqsQueue. 
        /// <para>
        /// The access control configuration is for an Amazon SQS queue. 
        /// </para>
        /// </summary>
        public SqsQueueConfiguration SqsQueue
        {
            get { return this._sqsQueue; }
            set { this._sqsQueue = value; }
        }

        // Check to see if SqsQueue property is set
        internal bool IsSetSqsQueue()
        {
            return this._sqsQueue != null;
        }

    }
}