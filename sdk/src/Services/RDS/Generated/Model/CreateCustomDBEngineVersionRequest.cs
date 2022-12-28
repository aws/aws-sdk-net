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
    /// Container for the parameters to the CreateCustomDBEngineVersion operation.
    /// Creates a custom DB engine version (CEV).
    /// </summary>
    public partial class CreateCustomDBEngineVersionRequest : AmazonRDSRequest
    {
        private string _databaseInstallationFilesS3BucketName;
        private string _databaseInstallationFilesS3Prefix;
        private string _description;
        private string _engine;
        private string _engineVersion;
        private string _imageId;
        private string _kmsKeyId;
        private string _manifest;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DatabaseInstallationFilesS3BucketName. 
        /// <para>
        /// The name of an Amazon S3 bucket that contains database installation files for your
        /// CEV. For example, a valid bucket name is <code>my-custom-installation-files</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string DatabaseInstallationFilesS3BucketName
        {
            get { return this._databaseInstallationFilesS3BucketName; }
            set { this._databaseInstallationFilesS3BucketName = value; }
        }

        // Check to see if DatabaseInstallationFilesS3BucketName property is set
        internal bool IsSetDatabaseInstallationFilesS3BucketName()
        {
            return this._databaseInstallationFilesS3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseInstallationFilesS3Prefix. 
        /// <para>
        /// The Amazon S3 directory that contains the database installation files for your CEV.
        /// For example, a valid bucket name is <code>123456789012/cev1</code>. If this setting
        /// isn't specified, no prefix is assumed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DatabaseInstallationFilesS3Prefix
        {
            get { return this._databaseInstallationFilesS3Prefix; }
            set { this._databaseInstallationFilesS3Prefix = value; }
        }

        // Check to see if DatabaseInstallationFilesS3Prefix property is set
        internal bool IsSetDatabaseInstallationFilesS3Prefix()
        {
            return this._databaseInstallationFilesS3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of your CEV.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to use for your custom engine version (CEV). The only supported
        /// value is <code>custom-oracle-ee</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=35)]
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The name of your CEV. The name format is 19.<i>customized_string</i>. For example,
        /// a valid CEV name is <code>19.my_cev1</code>. This setting is required for RDS Custom
        /// for Oracle, but optional for Amazon RDS. The combination of <code>Engine</code> and
        /// <code>EngineVersion</code> is unique per customer per Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI. An AMI ID is required to create a CEV for RDS Custom for SQL Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for an encrypted CEV. A symmetric encryption
        /// KMS key is required for RDS Custom, but optional for Amazon RDS.
        /// </para>
        ///  
        /// <para>
        /// If you have an existing symmetric encryption KMS key in your account, you can use
        /// it with RDS Custom. No further action is necessary. If you don't already have a symmetric
        /// encryption KMS key in your account, follow the instructions in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keys.html#create-symmetric-cmk">
        /// Creating a symmetric encryption KMS key</a> in the <i>Amazon Web Services Key Management
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can choose the same symmetric encryption key when you create a CEV and a DB instance,
        /// or choose different keys.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KMSKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KMSKeyId property is set
        internal bool IsSetKMSKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// The CEV manifest, which is a JSON document that describes the installation .zip files
        /// stored in Amazon S3. Specify the name/value pairs in a file or a quoted string. RDS
        /// Custom applies the patches in the order in which they are listed.
        /// </para>
        ///  
        /// <para>
        /// The following JSON fields are valid:
        /// </para>
        ///  <dl> <dt>MediaImportTemplateVersion</dt> <dd> 
        /// <para>
        /// Version of the CEV manifest. The date is in the format <code>YYYY-MM-DD</code>.
        /// </para>
        ///  </dd> <dt>databaseInstallationFileNames</dt> <dd> 
        /// <para>
        /// Ordered list of installation files for the CEV.
        /// </para>
        ///  </dd> <dt>opatchFileNames</dt> <dd> 
        /// <para>
        /// Ordered list of OPatch installers used for the Oracle DB engine.
        /// </para>
        ///  </dd> <dt>psuRuPatchFileNames</dt> <dd> 
        /// <para>
        /// The PSU and RU patches for this CEV.
        /// </para>
        ///  </dd> <dt>OtherPatchFileNames</dt> <dd> 
        /// <para>
        /// The patches that are not in the list of PSU and RU patches. Amazon RDS applies these
        /// patches after applying the PSU and RU patches.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.html#custom-cev.preparing.manifest">
        /// Creating the CEV manifest</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=51000)]
        public string Manifest
        {
            get { return this._manifest; }
            set { this._manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return this._manifest != null;
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

    }
}