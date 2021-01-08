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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the StartDBInstanceAutomatedBackupsReplication operation.
    /// Enables replication of automated backups to a different AWS Region.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReplicateBackups.html">
    /// Replicating Automated Backups to Another AWS Region</a> in the <i>Amazon RDS User
    /// Guide.</i> 
    /// </para>
    /// </summary>
    public partial class StartDBInstanceAutomatedBackupsReplicationRequest : AmazonRDSRequest
    {
        private int? _backupRetentionPeriod;
        private string _kmsKeyId;
        private string _preSignedUrl;
        private string _sourceDBInstanceArn;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The retention period for the replicated automated backups.
        /// </para>
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod.GetValueOrDefault(); }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS KMS key identifier for encryption of the replicated automated backups. The
        /// KMS key ID is the Amazon Resource Name (ARN) for the KMS encryption key in the destination
        /// AWS Region, for example, <code>arn:aws:kms:us-east-1:123456789012:key/AKIAIOSFODNN7EXAMPLE</code>.
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
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// A URL that contains a Signature Version 4 signed request for the StartDBInstanceAutomatedBackupsReplication
        /// action to be called in the AWS Region of the source DB instance. The presigned URL
        /// must be a valid request for the StartDBInstanceAutomatedBackupsReplication API action
        /// that can be executed in the AWS Region that contains the source DB instance.
        /// </para>
        /// </summary>
        public string PreSignedUrl
        {
            get { return this._preSignedUrl; }
            set { this._preSignedUrl = value; }
        }

        // Check to see if PreSignedUrl property is set
        internal bool IsSetPreSignedUrl()
        {
            return this._preSignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source DB instance for the replicated automated
        /// backups, for example, <code>arn:aws:rds:us-west-2:123456789012:db:mydatabase</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDBInstanceArn
        {
            get { return this._sourceDBInstanceArn; }
            set { this._sourceDBInstanceArn = value; }
        }

        // Check to see if SourceDBInstanceArn property is set
        internal bool IsSetSourceDBInstanceArn()
        {
            return this._sourceDBInstanceArn != null;
        }

    }
}