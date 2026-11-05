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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the StartDBInstanceAutomatedBackupsReplication operation.
    /// Enables replication of automated backups to a different Amazon Web Services Region.
    /// <para> This command doesn't apply to RDS Custom. </para> <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReplicateBackups.html">
    /// Replicating Automated Backups to Another Amazon Web Services Region</a> in the <i>Amazon
    /// RDS User Guide.</i> </para>
    /// </summary>
    public partial class StartDBInstanceAutomatedBackupsReplicationRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The retention period for the replicated automated backups.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encryption of the replicated automated
        /// backups. The KMS key ID is the Amazon Resource Name (ARN) for the KMS encryption key
        /// in the destination Amazon Web Services Region, for example, <c>arn:aws:kms:us-east-1:123456789012:key/AKIAIOSFODNN7EXAMPLE</c>.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// In an Amazon Web Services GovCloud (US) Region, an URL that contains a Signature Version
        /// 4 signed request for the <c>StartDBInstanceAutomatedBackupsReplication</c> operation
        /// to call in the Amazon Web Services Region of the source DB instance. The presigned
        /// URL must be a valid request for the <c>StartDBInstanceAutomatedBackupsReplication</c>
        /// API operation that can run in the Amazon Web Services Region that contains the source
        /// DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to Amazon Web Services GovCloud (US) Regions. It's ignored
        /// in other Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (Amazon Web Services Signature Version
        /// 4)</a> and <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">
        /// Signature Version 4 Signing Process</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using an Amazon Web Services SDK tool or the CLI, you can specify <c>SourceRegion</c>
        /// (or <c>--source-region</c> for the CLI) instead of specifying <c>PreSignedUrl</c>
        /// manually. Specifying <c>SourceRegion</c> autogenerates a presigned URL that is a valid
        /// request for the operation that can run in the source Amazon Web Services Region.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PreSignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the PreSignedUrl property is set.
        /// </summary>
        internal bool IsSetPreSignedUrl() => this.PreSignedUrl != null;

        /// <summary>
        /// Gets and sets the property SourceDBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source DB instance for the replicated automated
        /// backups, for example, <c>arn:aws:rds:us-west-2:123456789012:db:mydatabase</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceDBInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBInstanceArn property is set.
        /// </summary>
        internal bool IsSetSourceDBInstanceArn() => this.SourceDBInstanceArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the replicated automated backups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
