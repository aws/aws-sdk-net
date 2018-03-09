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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBSnapshot operation.
    /// Copies the specified DB snapshot. The source DB snapshot must be in the "available"
    /// state.
    /// 
    ///  
    /// <para>
    /// You can copy a snapshot from one AWS Region to another. In that case, the AWS Region
    /// where you call the <code>CopyDBSnapshot</code> action is the destination AWS Region
    /// for the DB snapshot copy. 
    /// </para>
    ///  
    /// <para>
    /// For more information about copying snapshots, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopyDBSnapshot.html">Copying
    /// a DB Snapshot</a> in the Amazon RDS User Guide. 
    /// </para>
    /// </summary>
    public partial class CopyDBSnapshotRequest : AmazonRDSRequest
    {
        private bool? _copyTags;
        private string _kmsKeyId;
        private string _optionGroupName;
        private string _preSignedUrl;
        private string _sourceDBSnapshotIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private string _targetDBSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// True to copy all tags from the source DB snapshot to the target DB snapshot, and otherwise
        /// false. The default is false.
        /// </para>
        /// </summary>
        public bool CopyTags
        {
            get { return this._copyTags.GetValueOrDefault(); }
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
        /// The AWS KMS key ID for an encrypted DB snapshot. The KMS key ID is the Amazon Resource
        /// Name (ARN), KMS key identifier, or the KMS key alias for the KMS encryption key. 
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB snapshot from your AWS account, you can specify a value
        /// for this parameter to encrypt the copy with a new KMS encryption key. If you don't
        /// specify a value for this parameter, then the copy of the DB snapshot is encrypted
        /// with the same KMS key as the source DB snapshot. 
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted DB snapshot that is shared from another AWS account, then
        /// you must specify a value for this parameter. 
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter when you copy an unencrypted snapshot, the copy is encrypted.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you copy an encrypted snapshot to a different AWS Region, then you must specify
        /// a KMS key for the destination AWS Region. KMS encryption keys are specific to the
        /// AWS Region that they are created in, and you can't use encryption keys from one AWS
        /// Region in another AWS Region. 
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
        /// Specify this option if you are copying a snapshot from one AWS Region to another,
        /// and your DB instance uses a nondefault option group. If your source DB instance uses
        /// Transparent Data Encryption for Oracle or Microsoft SQL Server, you must specify this
        /// option when copying across AWS Regions. For more information, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopySnapshot.html#USER_CopySnapshot.Options">Option
        /// Group Considerations</a>. 
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
        /// The URL that contains a Signature Version 4 signed request for the <code>CopyDBSnapshot</code>
        /// API action in the source AWS Region that contains the source DB snapshot to copy.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must specify this parameter when you copy an encrypted DB snapshot from another
        /// AWS Region by using the Amazon RDS API. You can specify the <code>--source-region</code>
        /// option instead of this parameter when you copy an encrypted DB snapshot from another
        /// AWS Region by using the AWS CLI. 
        /// </para>
        ///  
        /// <para>
        /// The presigned URL must be a valid request for the <code>CopyDBSnapshot</code> API
        /// action that can be executed in the source AWS Region that contains the encrypted DB
        /// snapshot to be copied. The presigned URL request must contain the following parameter
        /// values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The AWS Region that the encrypted DB snapshot is
        /// copied to. This AWS Region is the same one where the <code>CopyDBSnapshot</code> action
        /// is called that contains this presigned URL. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you copy an encrypted DB snapshot from the us-west-2 AWS Region to
        /// the us-east-1 AWS Region, then you call the <code>CopyDBSnapshot</code> action in
        /// the us-east-1 AWS Region and provide a presigned URL that contains a call to the <code>CopyDBSnapshot</code>
        /// action in the us-west-2 AWS Region. For this example, the <code>DestinationRegion</code>
        /// in the presigned URL must be set to the us-east-1 AWS Region. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The AWS KMS key identifier for the key to use to encrypt
        /// the copy of the DB snapshot in the destination AWS Region. This is the same identifier
        /// for both the <code>CopyDBSnapshot</code> action that is called in the destination
        /// AWS Region, and the action contained in the presigned URL. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBSnapshotIdentifier</code> - The DB snapshot identifier for the encrypted
        /// snapshot to be copied. This identifier must be in the Amazon Resource Name (ARN) format
        /// for the source AWS Region. For example, if you are copying an encrypted DB snapshot
        /// from the us-west-2 AWS Region, then your <code>SourceDBSnapshotIdentifier</code> looks
        /// like the following example: <code>arn:aws:rds:us-west-2:123456789012:snapshot:mysql-instance1-snapshot-20161115</code>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">Authenticating
        /// Requests: Using Query Parameters (AWS Signature Version 4)</a> and <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 Signing Process</a>. 
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
        /// Gets and sets the property SourceDBSnapshotIdentifier. 
        /// <para>
        /// The identifier for the source DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// If the source snapshot is in the same AWS Region as the copy, specify a valid DB snapshot
        /// identifier. For example, you might specify <code>rds:mysql-instance1-snapshot-20130805</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the source snapshot is in a different AWS Region than the copy, specify a valid
        /// DB snapshot ARN. For example, you might specify <code>arn:aws:rds:us-west-2:123456789012:snapshot:mysql-instance1-snapshot-20130805</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you are copying from a shared manual DB snapshot, this parameter must be the Amazon
        /// Resource Name (ARN) of the shared DB snapshot. 
        /// </para>
        ///  
        /// <para>
        /// If you are copying an encrypted snapshot this parameter must be in the ARN format
        /// for the source AWS Region, and must match the <code>SourceDBSnapshotIdentifier</code>
        /// in the <code>PreSignedUrl</code> parameter. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid system snapshot in the "available" state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>rds:mydb-2012-04-02-00-01</code> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>arn:aws:rds:us-west-2:123456789012:snapshot:mysql-instance1-snapshot-20130805</code>
        /// 
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
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
        /// Cannot be null, empty, or blank
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
        /// Cannot end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>my-db-snapshot</code> 
        /// </para>
        /// </summary>
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