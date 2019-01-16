/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the StartRestoreJob operation.
    /// Recovers the saved resource identified by an Amazon Resource Name (ARN). 
    /// 
    ///  
    /// <para>
    /// If the resource ARN is included in the request, then the last complete backup of that
    /// resource is recovered. If the ARN of a recovery point is supplied, then that recovery
    /// point is restored.
    /// </para>
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
        /// The Amazon Resource Name (ARN) of the IAM role that AWS Backup uses to create the
        /// target recovery point; for example, <code>arn:aws:iam::123456789012:role/S3Access</code>.
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
        /// A customer chosen string that can be used to distinguish between calls to <code>StartRestoreJob</code>.
        /// Idempotency tokens time out after one hour. Therefore, if you call <code>StartRestoreJob</code>
        /// multiple times with the same idempotency token within one hour, AWS Backup recognizes
        /// that you are requesting only one restore job and initiates only one. If you change
        /// the idempotency token for each call, AWS Backup recognizes that you are requesting
        /// to start multiple restores. 
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
        /// A set of metadata key-value pairs. Lists the metadata that the recovery point was
        /// created with.
        /// </para>
        /// </summary>
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
        ///  <code>EBS</code> for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SGW</code> for AWS Storage Gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RDS</code> for Amazon Relational Database Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DDB</code> for Amazon DynamoDB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EFS</code> for Amazon Elastic File System
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