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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBSnapshot operation.
    /// Copies the specified DB snapshot. The source DB snapshot must be in the <c>available</c>
    /// state.
    /// 
    ///  
    /// <para>
    /// You can copy a snapshot from one Amazon Web Services Region to another. In that case,
    /// the Amazon Web Services Region where you call the <c>CopyDBSnapshot</c> operation
    /// is the destination Amazon Web Services Region for the DB snapshot copy.
    /// </para>
    ///  
    /// <para>
    /// This command doesn't apply to RDS Custom.
    /// </para>
    ///  
    /// <para>
    /// For more information about copying snapshots, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopySnapshot.html#USER_CopyDBSnapshot">Copying
    /// a DB Snapshot</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CopyDBSnapshotRequest : AmazonRDSRequest
    {
        private bool? _copyOptionGroup;
        private bool? _copyTags;
        private string _kmsKeyId;
        private string _optionGroupName;
        private string _preSignedUrl;
        private string _snapshotAvailabilityZone;
        private string _snapshotTarget;
        private string _sourceDBSnapshotIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetCustomAvailabilityZone;
        private string _targetDBSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property CopyOptionGroup. 
        /// <para>
        /// Specifies whether to copy the DB option group associated with the source DB snapshot
        /// to the target Amazon Web Services account and associate with the target DB snapshot.
        /// The associated option group can be copied only with cross-account snapshot copy calls.
        /// </para>
        /// </summary>
        public bool? CopyOptionGroup
        {
            get { return this._copyOptionGroup; }
            set { this._copyOptionGroup = value; }
        }

        // Check to see if CopyOptionGroup property is set
        internal bool IsSetCopyOptionGroup()
        {
            return this._copyOptionGroup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Specifies whether to copy all tags from the source DB snapshot to the target DB snapshot.
        /// By default, tags aren't copied.
        /// </para>
        /// </summary>
        public bool? CopyTags
        {
            get { return this._copyTags; }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for an encrypted DB snapshot. The Amazon
        /// Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias name for
        /// the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB snapshot from your Amazon Web Services account, you can
        /// specify a value for this parameter to encrypt the copy with a new KMS key. If you
        /// don't specify a value for this parameter, then the copy of the DB snapshot is encrypted
        /// with the same Amazon Web Services KMS key as the source DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB snapshot that is shared from another Amazon Web Services
        /// account, then you must specify a value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter when you copy an unencrypted snapshot, the copy is encrypted.
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted snapshot to a different Amazon Web Services Region, then
        /// you must specify an Amazon Web Services KMS key identifier for the destination Amazon
        /// Web Services Region. KMS keys are specific to the Amazon Web Services Region that
        /// they are created in, and you can't use KMS keys from one Amazon Web Services Region
        /// in another Amazon Web Services Region.
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
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The name of an option group to associate with the copy of the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Specify this option if you are copying a snapshot from one Amazon Web Services Region
        /// to another, and your DB instance uses a nondefault option group. If your source DB
        /// instance uses Transparent Data Encryption for Oracle or Microsoft SQL Server, you
        /// must specify this option when copying across Amazon Web Services Regions. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopySnapshot.html#USER_CopySnapshot.Options">Option
        /// group considerations</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// When you are copying a snapshot from one Amazon Web Services GovCloud (US) Region
        /// to another, the URL that contains a Signature Version 4 signed request for the <c>CopyDBSnapshot</c>
        /// API operation in the source Amazon Web Services Region that contains the source DB
        /// snapshot to copy.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to Amazon Web Services GovCloud (US) Regions. It's ignored
        /// in other Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// You must specify this parameter when you copy an encrypted DB snapshot from another
        /// Amazon Web Services Region by using the Amazon RDS API. Don't specify <c>PreSignedUrl</c>
        /// when you are copying an encrypted DB snapshot in the same Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// The presigned URL must be a valid request for the <c>CopyDBClusterSnapshot</c> API
        /// operation that can run in the source Amazon Web Services Region that contains the
        /// encrypted DB cluster snapshot to copy. The presigned URL request must contain the
        /// following parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DestinationRegion</c> - The Amazon Web Services Region that the encrypted DB snapshot
        /// is copied to. This Amazon Web Services Region is the same one where the <c>CopyDBSnapshot</c>
        /// operation is called that contains this presigned URL.
        /// </para>
        ///  
        /// <para>
        /// For example, if you copy an encrypted DB snapshot from the us-west-2 Amazon Web Services
        /// Region to the us-east-1 Amazon Web Services Region, then you call the <c>CopyDBSnapshot</c>
        /// operation in the us-east-1 Amazon Web Services Region and provide a presigned URL
        /// that contains a call to the <c>CopyDBSnapshot</c> operation in the us-west-2 Amazon
        /// Web Services Region. For this example, the <c>DestinationRegion</c> in the presigned
        /// URL must be set to the us-east-1 Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KmsKeyId</c> - The KMS key identifier for the KMS key to use to encrypt the copy
        /// of the DB snapshot in the destination Amazon Web Services Region. This is the same
        /// identifier for both the <c>CopyDBSnapshot</c> operation that is called in the destination
        /// Amazon Web Services Region, and the operation contained in the presigned URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceDBSnapshotIdentifier</c> - The DB snapshot identifier for the encrypted
        /// snapshot to be copied. This identifier must be in the Amazon Resource Name (ARN) format
        /// for the source Amazon Web Services Region. For example, if you are copying an encrypted
        /// DB snapshot from the us-west-2 Amazon Web Services Region, then your <c>SourceDBSnapshotIdentifier</c>
        /// looks like the following example: <c>arn:aws:rds:us-west-2:123456789012:snapshot:mysql-instance1-snapshot-20161115</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">Authenticating
        /// Requests: Using Query Parameters (Amazon Web Services Signature Version 4)</a> and
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 Signing Process</a>.
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
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property SnapshotAvailabilityZone. 
        /// <para>
        /// Specifies the name of the Availability Zone where RDS stores the DB snapshot. This
        /// value is valid only for snapshots that RDS stores on a Dedicated Local Zone.
        /// </para>
        /// </summary>
        public string SnapshotAvailabilityZone
        {
            get { return this._snapshotAvailabilityZone; }
            set { this._snapshotAvailabilityZone = value; }
        }

        // Check to see if SnapshotAvailabilityZone property is set
        internal bool IsSetSnapshotAvailabilityZone()
        {
            return this._snapshotAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotTarget. 
        /// <para>
        /// Configures the location where RDS will store copied snapshots.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>local</c> (Dedicated Local Zone)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>outposts</c> (Amazon Web Services Outposts)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region</c> (Amazon Web Services Region)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SnapshotTarget
        {
            get { return this._snapshotTarget; }
            set { this._snapshotTarget = value; }
        }

        // Check to see if SnapshotTarget property is set
        internal bool IsSetSnapshotTarget()
        {
            return this._snapshotTarget != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBSnapshotIdentifier. 
        /// <para>
        /// The identifier for the source DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// If the source snapshot is in the same Amazon Web Services Region as the copy, specify
        /// a valid DB snapshot identifier. For example, you might specify <c>rds:mysql-instance1-snapshot-20130805</c>.
        /// </para>
        ///  
        /// <para>
        /// If you are copying from a shared manual DB snapshot, this parameter must be the Amazon
        /// Resource Name (ARN) of the shared DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// If the source snapshot is in a different Amazon Web Services Region than the copy,
        /// specify a valid DB snapshot ARN. You can also specify an ARN of a snapshot that is
        /// in a different account and a different Amazon Web Services Region. For example, you
        /// might specify <c>arn:aws:rds:us-west-2:123456789012:snapshot:mysql-instance1-snapshot-20130805</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid source snapshot in the "available" state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>rds:mydb-2012-04-02-00-01</c> 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>arn:aws:rds:us-west-2:123456789012:snapshot:mysql-instance1-snapshot-20130805</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDBSnapshotIdentifier
        {
            get { return this._sourceDBSnapshotIdentifier; }
            set { this._sourceDBSnapshotIdentifier = value; }
        }

        // Check to see if SourceDBSnapshotIdentifier property is set
        internal bool IsSetSourceDBSnapshotIdentifier()
        {
            return this._sourceDBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetCustomAvailabilityZone. 
        /// <para>
        /// The external custom Availability Zone (CAZ) identifier for the target CAZ.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>rds-caz-aiqhTgQv</c>.
        /// </para>
        /// </summary>
        public string TargetCustomAvailabilityZone
        {
            get { return this._targetCustomAvailabilityZone; }
            set { this._targetCustomAvailabilityZone = value; }
        }

        // Check to see if TargetCustomAvailabilityZone property is set
        internal bool IsSetTargetCustomAvailabilityZone()
        {
            return this._targetCustomAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDBSnapshotIdentifier. 
        /// <para>
        /// The identifier for the copy of the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be null, empty, or blank
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 255 letters, numbers, or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-db-snapshot</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetDBSnapshotIdentifier
        {
            get { return this._targetDBSnapshotIdentifier; }
            set { this._targetDBSnapshotIdentifier = value; }
        }

        // Check to see if TargetDBSnapshotIdentifier property is set
        internal bool IsSetTargetDBSnapshotIdentifier()
        {
            return this._targetDBSnapshotIdentifier != null;
        }

    }
}