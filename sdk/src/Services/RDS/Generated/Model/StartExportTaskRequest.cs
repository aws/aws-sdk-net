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
    /// Container for the parameters to the StartExportTask operation.
    /// Starts an export of DB snapshot or DB cluster data to Amazon S3. The provided IAM
    /// role must have access to the S3 bucket.
    /// 
    ///  
    /// <para>
    /// You can't export snapshot data from RDS Custom DB instances. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RDS_Fea_Regions_DB-eng.Feature.ExportSnapshotToS3.html">
    /// Supported Regions and DB engines for exporting snapshots to S3 in Amazon RDS</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information on exporting DB snapshot data, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ExportSnapshot.html">Exporting
    /// DB snapshot data to Amazon S3</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-export-snapshot.html">Exporting
    /// DB cluster snapshot data to Amazon S3</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information on exporting DB cluster data, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/export-cluster-data.html">Exporting
    /// DB cluster data to Amazon S3</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartExportTaskRequest : AmazonRDSRequest
    {
        private List<string> _exportOnly = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _exportTaskIdentifier;
        private string _iamRoleArn;
        private string _kmsKeyId;
        private string _s3BucketName;
        private string _s3Prefix;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property ExportOnly. 
        /// <para>
        /// The data to be exported from the snapshot or cluster. If this parameter isn't provided,
        /// all of the data is exported.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>database</c> - Export all the data from a specified database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database.table</c> <i>table-name</i> - Export a table of the snapshot or cluster.
        /// This format is valid only for RDS for MySQL, RDS for MariaDB, and Aurora MySQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database.schema</c> <i>schema-name</i> - Export a database schema of the snapshot
        /// or cluster. This format is valid only for RDS for PostgreSQL and Aurora PostgreSQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database.schema.table</c> <i>table-name</i> - Export a table of the database schema.
        /// This format is valid only for RDS for PostgreSQL and Aurora PostgreSQL.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportOnly
        {
            get { return this._exportOnly; }
            set { this._exportOnly = value; }
        }

        // Check to see if ExportOnly property is set
        internal bool IsSetExportOnly()
        {
            return this._exportOnly != null && (this._exportOnly.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExportTaskIdentifier. 
        /// <para>
        /// A unique identifier for the export task. This ID isn't an identifier for the Amazon
        /// S3 bucket where the data is to be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExportTaskIdentifier
        {
            get { return this._exportTaskIdentifier; }
            set { this._exportTaskIdentifier = value; }
        }

        // Check to see if ExportTaskIdentifier property is set
        internal bool IsSetExportTaskIdentifier()
        {
            return this._exportTaskIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The name of the IAM role to use for writing to the Amazon S3 bucket when exporting
        /// a snapshot or cluster.
        /// </para>
        ///  
        /// <para>
        /// In the IAM policy attached to your IAM role, include the following required actions
        /// to allow the transfer of files from Amazon RDS or Amazon Aurora to an S3 bucket:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// s3:PutObject*
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:GetObject*
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:ListBucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:DeleteObject*
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:GetBucketLocation 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In the policy, include the resources to identify the S3 bucket and objects in the
        /// bucket. The following list of resources shows the Amazon Resource Name (ARN) format
        /// for accessing S3:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:s3:::<i>your-s3-bucket</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:s3:::<i>your-s3-bucket</i>/*</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services KMS key to use to encrypt the data exported to Amazon
        /// S3. The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN,
        /// or alias name for the KMS key. The caller of this operation must be authorized to
        /// run the following operations. These can be set in the Amazon Web Services KMS key
        /// policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// kms:CreateGrant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:DescribeKey
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket to export the snapshot or cluster data to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The Amazon S3 bucket prefix to use as the file name and path of the exported data.
        /// </para>
        /// </summary>
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot or cluster to export to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

    }
}