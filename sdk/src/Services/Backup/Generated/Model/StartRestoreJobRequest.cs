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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the StartRestoreJob operation.
    /// Recovers the saved resource identified by an Amazon Resource Name (ARN).
    /// </summary>
    public partial class StartRestoreJobRequest : AmazonBackupRequest
    {
        private string _iamRoleArn;
        private string _idempotencyToken;
        private Dictionary<string, string> _metadata = new Dictionary<string, string>();
        private string _recoveryPointArn;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Backup uses to create the target
        /// resource; for example: <code>arn:aws:iam::123456789012:role/S3Access</code>.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <code>StartRestoreJob</code>. Retrying a successful request with the same
        /// idempotency token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// A set of metadata key-value pairs. Contains information, such as a resource name,
        /// required to restore a recovery point.
        /// </para>
        ///  
        /// <para>
        ///  You can get configuration metadata about a resource at the time it was backed up
        /// by calling <code>GetRecoveryPointRestoreMetadata</code>. However, values in addition
        /// to those provided by <code>GetRecoveryPointRestoreMetadata</code> might be required
        /// to restore a resource. For example, you might need to provide a new resource name
        /// if the original already exists.
        /// </para>
        ///  
        /// <para>
        /// You need to specify specific metadata to restore an Amazon Elastic File System (Amazon
        /// EFS) instance:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>file-system-id</code>: The ID of the Amazon EFS file system that is backed
        /// up by Backup. Returned in <code>GetRecoveryPointRestoreMetadata</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Encrypted</code>: A Boolean value that, if true, specifies that the file system
        /// is encrypted. If <code>KmsKeyId</code> is specified, <code>Encrypted</code> must be
        /// set to <code>true</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KmsKeyId</code>: Specifies the Amazon Web Services KMS key that is used to
        /// encrypt the restored file system. You can specify a key from another Amazon Web Services
        /// account provided that key it is properly shared with your account via Amazon Web Services
        /// KMS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PerformanceMode</code>: Specifies the throughput mode of the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationToken</code>: A user-supplied value that ensures the uniqueness (idempotency)
        /// of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>newFileSystem</code>: A Boolean value that, if true, specifies that the recovery
        /// point is restored to a new Amazon EFS file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ItemsToRestore</code>: An array of one to five strings where each string is
        /// a file path. Use <code>ItemsToRestore</code> to restore specific files or directories
        /// rather than the entire file system. This parameter is optional. For example, <code>"itemsToRestore":"[\"/my.test\"]"</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && this._metadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point; for example, <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecoveryPointArn
        {
            get { return this._recoveryPointArn; }
            set { this._recoveryPointArn = value; }
        }

        // Check to see if RecoveryPointArn property is set
        internal bool IsSetRecoveryPointArn()
        {
            return this._recoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Starts a job to restore a recovery point for one of the following resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Aurora</code> for Amazon Aurora
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DocumentDB</code> for Amazon DocumentDB (with MongoDB compatibility)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DynamoDB</code> for Amazon DynamoDB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EBS</code> for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EC2</code> for Amazon Elastic Compute Cloud
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EFS</code> for Amazon Elastic File System
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FSx</code> for Amazon FSx
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Neptune</code> for Amazon Neptune
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RDS</code> for Amazon Relational Database Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Storage Gateway</code> for Storage Gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>S3</code> for Amazon S3
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VirtualMachine</code> for virtual machines
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}