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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Access control configuration structures for your resource. You specify the configuration
    /// as a type-value pair. You can specify only one type of access control configuration.
    /// </summary>
    public partial class Configuration
    {
        /// <summary>
        /// Gets and sets the property DynamodbStream. 
        /// <para>
        /// The access control configuration is for a DynamoDB stream.
        /// </para>
        /// </summary>
        public DynamodbStreamConfiguration DynamodbStream { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbStream property is set.
        /// </summary>
        internal bool IsSetDynamodbStream() => this.DynamodbStream != null;

        /// <summary>
        /// Gets and sets the property DynamodbTable. 
        /// <para>
        /// The access control configuration is for a DynamoDB table or index.
        /// </para>
        /// </summary>
        public DynamodbTableConfiguration DynamodbTable { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbTable property is set.
        /// </summary>
        internal bool IsSetDynamodbTable() => this.DynamodbTable != null;

        /// <summary>
        /// Gets and sets the property EbsSnapshot. 
        /// <para>
        /// The access control configuration is for an Amazon EBS volume snapshot.
        /// </para>
        /// </summary>
        public EbsSnapshotConfiguration EbsSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the EbsSnapshot property is set.
        /// </summary>
        internal bool IsSetEbsSnapshot() => this.EbsSnapshot != null;

        /// <summary>
        /// Gets and sets the property EcrRepository. 
        /// <para>
        /// The access control configuration is for an Amazon ECR repository.
        /// </para>
        /// </summary>
        public EcrRepositoryConfiguration EcrRepository { get; set; }

        /// <summary>
        /// Checks to see if the EcrRepository property is set.
        /// </summary>
        internal bool IsSetEcrRepository() => this.EcrRepository != null;

        /// <summary>
        /// Gets and sets the property EfsFileSystem. 
        /// <para>
        /// The access control configuration is for an Amazon EFS file system.
        /// </para>
        /// </summary>
        public EfsFileSystemConfiguration EfsFileSystem { get; set; }

        /// <summary>
        /// Checks to see if the EfsFileSystem property is set.
        /// </summary>
        internal bool IsSetEfsFileSystem() => this.EfsFileSystem != null;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The access control configuration is for an IAM role. 
        /// </para>
        /// </summary>
        public IamRoleConfiguration IamRole { get; set; }

        /// <summary>
        /// Checks to see if the IamRole property is set.
        /// </summary>
        internal bool IsSetIamRole() => this.IamRole != null;

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The access control configuration is for a KMS key. 
        /// </para>
        /// </summary>
        public KmsKeyConfiguration KmsKey { get; set; }

        /// <summary>
        /// Checks to see if the KmsKey property is set.
        /// </summary>
        internal bool IsSetKmsKey() => this.KmsKey != null;

        /// <summary>
        /// Gets and sets the property RdsDbClusterSnapshot. 
        /// <para>
        /// The access control configuration is for an Amazon RDS DB cluster snapshot.
        /// </para>
        /// </summary>
        public RdsDbClusterSnapshotConfiguration RdsDbClusterSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbClusterSnapshot property is set.
        /// </summary>
        internal bool IsSetRdsDbClusterSnapshot() => this.RdsDbClusterSnapshot != null;

        /// <summary>
        /// Gets and sets the property RdsDbSnapshot. 
        /// <para>
        /// The access control configuration is for an Amazon RDS DB snapshot.
        /// </para>
        /// </summary>
        public RdsDbSnapshotConfiguration RdsDbSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbSnapshot property is set.
        /// </summary>
        internal bool IsSetRdsDbSnapshot() => this.RdsDbSnapshot != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The access control configuration is for an Amazon S3 bucket. 
        /// </para>
        /// </summary>
        public S3BucketConfiguration S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3ExpressDirectoryBucket. 
        /// <para>
        /// The access control configuration is for an Amazon S3 directory bucket.
        /// </para>
        /// </summary>
        public S3ExpressDirectoryBucketConfiguration S3ExpressDirectoryBucket { get; set; }

        /// <summary>
        /// Checks to see if the S3ExpressDirectoryBucket property is set.
        /// </summary>
        internal bool IsSetS3ExpressDirectoryBucket() => this.S3ExpressDirectoryBucket != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecret. 
        /// <para>
        /// The access control configuration is for a Secrets Manager secret.
        /// </para>
        /// </summary>
        public SecretsManagerSecretConfiguration SecretsManagerSecret { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecret property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecret() => this.SecretsManagerSecret != null;

        /// <summary>
        /// Gets and sets the property SnsTopic. 
        /// <para>
        /// The access control configuration is for an Amazon SNS topic
        /// </para>
        /// </summary>
        public SnsTopicConfiguration SnsTopic { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopic property is set.
        /// </summary>
        internal bool IsSetSnsTopic() => this.SnsTopic != null;

        /// <summary>
        /// Gets and sets the property SqsQueue. 
        /// <para>
        /// The access control configuration is for an Amazon SQS queue. 
        /// </para>
        /// </summary>
        public SqsQueueConfiguration SqsQueue { get; set; }

        /// <summary>
        /// Checks to see if the SqsQueue property is set.
        /// </summary>
        internal bool IsSetSqsQueue() => this.SqsQueue != null;
    }
}
