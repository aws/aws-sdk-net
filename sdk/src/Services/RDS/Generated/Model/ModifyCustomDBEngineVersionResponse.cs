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
    /// This data type is used as a response element in the action <c>DescribeDBEngineVersions</c>.
    /// </summary>
    public partial class ModifyCustomDBEngineVersionResponse : AmazonWebServiceResponse
    {
        private DateTime? _createTime;
        private string _customDBEngineVersionManifest;
        private string _databaseInstallationFilesS3BucketName;
        private string _databaseInstallationFilesS3Prefix;
        private string _dbEngineDescription;
        private string _dbEngineMediaType;
        private string _dbEngineVersionArn;
        private string _dbEngineVersionDescription;
        private string _dbParameterGroupFamily;
        private CharacterSet _defaultCharacterSet;
        private string _engine;
        private string _engineVersion;
        private List<string> _exportableLogTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CustomDBEngineVersionAMI _image;
        private string _kmsKeyId;
        private string _majorEngineVersion;
        private ServerlessV2FeaturesSupport _serverlessV2FeaturesSupport;
        private string _status;
        private List<string> _supportedCACertificateIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<CharacterSet> _supportedCharacterSets = AWSConfigs.InitializeCollections ? new List<CharacterSet>() : null;
        private List<string> _supportedEngineModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedFeatureNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<CharacterSet> _supportedNcharCharacterSets = AWSConfigs.InitializeCollections ? new List<CharacterSet>() : null;
        private List<Timezone> _supportedTimezones = AWSConfigs.InitializeCollections ? new List<Timezone>() : null;
        private bool? _supportsBabelfish;
        private bool? _supportsCertificateRotationWithoutRestart;
        private bool? _supportsGlobalDatabases;
        private bool? _supportsIntegrations;
        private bool? _supportsLimitlessDatabase;
        private bool? _supportsLocalWriteForwarding;
        private bool? _supportsLogExportsToCloudwatchLogs;
        private bool? _supportsParallelQuery;
        private bool? _supportsReadReplica;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<UpgradeTarget> _validUpgradeTarget = AWSConfigs.InitializeCollections ? new List<UpgradeTarget>() : null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The creation time of the DB engine version.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDBEngineVersionManifest. 
        /// <para>
        /// JSON string that lists the installation files and parameters that RDS Custom uses
        /// to create a custom engine version (CEV). RDS Custom applies the patches in the order
        /// in which they're listed in the manifest. You can set the Oracle home, Oracle base,
        /// and UNIX/Linux user and group using the installation parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.preparing.html#custom-cev.preparing.manifest.fields">JSON
        /// fields in the CEV manifest</a> in the <i>Amazon RDS User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=51000)]
        public string CustomDBEngineVersionManifest
        {
            get { return this._customDBEngineVersionManifest; }
            set { this._customDBEngineVersionManifest = value; }
        }

        // Check to see if CustomDBEngineVersionManifest property is set
        internal bool IsSetCustomDBEngineVersionManifest()
        {
            return this._customDBEngineVersionManifest != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseInstallationFilesS3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket that contains your database installation files.
        /// </para>
        /// </summary>
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
        /// The Amazon S3 directory that contains the database installation files. If not specified,
        /// then no prefix is assumed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DBEngineDescription. 
        /// <para>
        /// The description of the database engine.
        /// </para>
        /// </summary>
        public string DBEngineDescription
        {
            get { return this._dbEngineDescription; }
            set { this._dbEngineDescription = value; }
        }

        // Check to see if DBEngineDescription property is set
        internal bool IsSetDBEngineDescription()
        {
            return this._dbEngineDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBEngineMediaType. 
        /// <para>
        /// A value that indicates the source media provider of the AMI based on the usage operation.
        /// Applicable for RDS Custom for SQL Server.
        /// </para>
        /// </summary>
        public string DBEngineMediaType
        {
            get { return this._dbEngineMediaType; }
            set { this._dbEngineMediaType = value; }
        }

        // Check to see if DBEngineMediaType property is set
        internal bool IsSetDBEngineMediaType()
        {
            return this._dbEngineMediaType != null;
        }

        /// <summary>
        /// Gets and sets the property DBEngineVersionArn. 
        /// <para>
        /// The ARN of the custom engine version.
        /// </para>
        /// </summary>
        public string DBEngineVersionArn
        {
            get { return this._dbEngineVersionArn; }
            set { this._dbEngineVersionArn = value; }
        }

        // Check to see if DBEngineVersionArn property is set
        internal bool IsSetDBEngineVersionArn()
        {
            return this._dbEngineVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBEngineVersionDescription. 
        /// <para>
        /// The description of the database engine version.
        /// </para>
        /// </summary>
        public string DBEngineVersionDescription
        {
            get { return this._dbEngineVersionDescription; }
            set { this._dbEngineVersionDescription = value; }
        }

        // Check to see if DBEngineVersionDescription property is set
        internal bool IsSetDBEngineVersionDescription()
        {
            return this._dbEngineVersionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of the DB parameter group family for the database engine.
        /// </para>
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this._dbParameterGroupFamily; }
            set { this._dbParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this._dbParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCharacterSet. 
        /// <para>
        /// The default character set for new instances of this engine version, if the <c>CharacterSetName</c>
        /// parameter of the CreateDBInstance API isn't specified.
        /// </para>
        /// </summary>
        public CharacterSet DefaultCharacterSet
        {
            get { return this._defaultCharacterSet; }
            set { this._defaultCharacterSet = value; }
        }

        // Check to see if DefaultCharacterSet property is set
        internal bool IsSetDefaultCharacterSet()
        {
            return this._defaultCharacterSet != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine.
        /// </para>
        /// </summary>
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
        /// The version number of the database engine.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExportableLogTypes. 
        /// <para>
        /// The types of logs that the database engine has available for export to CloudWatch
        /// Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportableLogTypes
        {
            get { return this._exportableLogTypes; }
            set { this._exportableLogTypes = value; }
        }

        // Check to see if ExportableLogTypes property is set
        internal bool IsSetExportableLogTypes()
        {
            return this._exportableLogTypes != null && (this._exportableLogTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The EC2 image
        /// </para>
        /// </summary>
        public CustomDBEngineVersionAMI Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for an encrypted CEV. This parameter is
        /// required for RDS Custom, but optional for Amazon RDS.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// The major engine version of the CEV.
        /// </para>
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this._majorEngineVersion; }
            set { this._majorEngineVersion = value; }
        }

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this._majorEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2FeaturesSupport. 
        /// <para>
        /// Specifies any Aurora Serverless v2 properties or limits that differ between Aurora
        /// engine versions. You can test the values of this attribute when deciding which Aurora
        /// version to use in a new or upgraded DB cluster. You can also retrieve the version
        /// of an existing DB cluster and check whether that version supports certain Aurora Serverless
        /// v2 features before you attempt to use those features. 
        /// </para>
        /// </summary>
        public ServerlessV2FeaturesSupport ServerlessV2FeaturesSupport
        {
            get { return this._serverlessV2FeaturesSupport; }
            set { this._serverlessV2FeaturesSupport = value; }
        }

        // Check to see if ServerlessV2FeaturesSupport property is set
        internal bool IsSetServerlessV2FeaturesSupport()
        {
            return this._serverlessV2FeaturesSupport != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB engine version, either <c>available</c> or <c>deprecated</c>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedCACertificateIdentifiers. 
        /// <para>
        /// A list of the supported CA certificate identifiers.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>
        /// and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL.html">
        /// Using SSL/TLS to encrypt a connection to a DB cluster</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedCACertificateIdentifiers
        {
            get { return this._supportedCACertificateIdentifiers; }
            set { this._supportedCACertificateIdentifiers = value; }
        }

        // Check to see if SupportedCACertificateIdentifiers property is set
        internal bool IsSetSupportedCACertificateIdentifiers()
        {
            return this._supportedCACertificateIdentifiers != null && (this._supportedCACertificateIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedCharacterSets. 
        /// <para>
        /// A list of the character sets supported by this engine for the <c>CharacterSetName</c>
        /// parameter of the <c>CreateDBInstance</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CharacterSet> SupportedCharacterSets
        {
            get { return this._supportedCharacterSets; }
            set { this._supportedCharacterSets = value; }
        }

        // Check to see if SupportedCharacterSets property is set
        internal bool IsSetSupportedCharacterSets()
        {
            return this._supportedCharacterSets != null && (this._supportedCharacterSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedEngineModes. 
        /// <para>
        /// A list of the supported DB engine modes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngineModes
        {
            get { return this._supportedEngineModes; }
            set { this._supportedEngineModes = value; }
        }

        // Check to see if SupportedEngineModes property is set
        internal bool IsSetSupportedEngineModes()
        {
            return this._supportedEngineModes != null && (this._supportedEngineModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedFeatureNames. 
        /// <para>
        /// A list of features supported by the DB engine.
        /// </para>
        ///  
        /// <para>
        /// The supported features vary by DB engine and DB engine version.
        /// </para>
        ///  
        /// <para>
        /// To determine the supported features for a specific DB engine and DB engine version
        /// using the CLI, use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine &lt;engine_name&gt; --engine-version
        /// &lt;engine_version&gt;</c> 
        /// </para>
        ///  
        /// <para>
        /// For example, to determine the supported features for RDS for PostgreSQL version 13.3
        /// using the CLI, use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine postgres --engine-version 13.3</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The supported features are listed under <c>SupportedFeatureNames</c> in the output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedFeatureNames
        {
            get { return this._supportedFeatureNames; }
            set { this._supportedFeatureNames = value; }
        }

        // Check to see if SupportedFeatureNames property is set
        internal bool IsSetSupportedFeatureNames()
        {
            return this._supportedFeatureNames != null && (this._supportedFeatureNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedNcharCharacterSets. 
        /// <para>
        /// A list of the character sets supported by the Oracle DB engine for the <c>NcharCharacterSetName</c>
        /// parameter of the <c>CreateDBInstance</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CharacterSet> SupportedNcharCharacterSets
        {
            get { return this._supportedNcharCharacterSets; }
            set { this._supportedNcharCharacterSets = value; }
        }

        // Check to see if SupportedNcharCharacterSets property is set
        internal bool IsSetSupportedNcharCharacterSets()
        {
            return this._supportedNcharCharacterSets != null && (this._supportedNcharCharacterSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedTimezones. 
        /// <para>
        /// A list of the time zones supported by this engine for the <c>Timezone</c> parameter
        /// of the <c>CreateDBInstance</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Timezone> SupportedTimezones
        {
            get { return this._supportedTimezones; }
            set { this._supportedTimezones = value; }
        }

        // Check to see if SupportedTimezones property is set
        internal bool IsSetSupportedTimezones()
        {
            return this._supportedTimezones != null && (this._supportedTimezones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportsBabelfish. 
        /// <para>
        /// Indicates whether the engine version supports Babelfish for Aurora PostgreSQL.
        /// </para>
        /// </summary>
        public bool? SupportsBabelfish
        {
            get { return this._supportsBabelfish; }
            set { this._supportsBabelfish = value; }
        }

        // Check to see if SupportsBabelfish property is set
        internal bool IsSetSupportsBabelfish()
        {
            return this._supportsBabelfish.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsCertificateRotationWithoutRestart. 
        /// <para>
        /// Indicates whether the engine version supports rotating the server certificate without
        /// rebooting the DB instance.
        /// </para>
        /// </summary>
        public bool? SupportsCertificateRotationWithoutRestart
        {
            get { return this._supportsCertificateRotationWithoutRestart; }
            set { this._supportsCertificateRotationWithoutRestart = value; }
        }

        // Check to see if SupportsCertificateRotationWithoutRestart property is set
        internal bool IsSetSupportsCertificateRotationWithoutRestart()
        {
            return this._supportsCertificateRotationWithoutRestart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsGlobalDatabases. 
        /// <para>
        /// Indicates whether you can use Aurora global databases with a specific DB engine version.
        /// </para>
        /// </summary>
        public bool? SupportsGlobalDatabases
        {
            get { return this._supportsGlobalDatabases; }
            set { this._supportsGlobalDatabases = value; }
        }

        // Check to see if SupportsGlobalDatabases property is set
        internal bool IsSetSupportsGlobalDatabases()
        {
            return this._supportsGlobalDatabases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsIntegrations. 
        /// <para>
        /// Indicates whether the DB engine version supports zero-ETL integrations with Amazon
        /// Redshift.
        /// </para>
        /// </summary>
        public bool? SupportsIntegrations
        {
            get { return this._supportsIntegrations; }
            set { this._supportsIntegrations = value; }
        }

        // Check to see if SupportsIntegrations property is set
        internal bool IsSetSupportsIntegrations()
        {
            return this._supportsIntegrations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsLimitlessDatabase. 
        /// <para>
        /// Indicates whether the DB engine version supports Aurora Limitless Database.
        /// </para>
        /// </summary>
        public bool? SupportsLimitlessDatabase
        {
            get { return this._supportsLimitlessDatabase; }
            set { this._supportsLimitlessDatabase = value; }
        }

        // Check to see if SupportsLimitlessDatabase property is set
        internal bool IsSetSupportsLimitlessDatabase()
        {
            return this._supportsLimitlessDatabase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsLocalWriteForwarding. 
        /// <para>
        /// Indicates whether the DB engine version supports forwarding write operations from
        /// reader DB instances to the writer DB instance in the DB cluster. By default, write
        /// operations aren't allowed on reader DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? SupportsLocalWriteForwarding
        {
            get { return this._supportsLocalWriteForwarding; }
            set { this._supportsLocalWriteForwarding = value; }
        }

        // Check to see if SupportsLocalWriteForwarding property is set
        internal bool IsSetSupportsLocalWriteForwarding()
        {
            return this._supportsLocalWriteForwarding.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsLogExportsToCloudwatchLogs. 
        /// <para>
        /// Indicates whether the engine version supports exporting the log types specified by
        /// ExportableLogTypes to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool? SupportsLogExportsToCloudwatchLogs
        {
            get { return this._supportsLogExportsToCloudwatchLogs; }
            set { this._supportsLogExportsToCloudwatchLogs = value; }
        }

        // Check to see if SupportsLogExportsToCloudwatchLogs property is set
        internal bool IsSetSupportsLogExportsToCloudwatchLogs()
        {
            return this._supportsLogExportsToCloudwatchLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsParallelQuery. 
        /// <para>
        /// Indicates whether you can use Aurora parallel query with a specific DB engine version.
        /// </para>
        /// </summary>
        public bool? SupportsParallelQuery
        {
            get { return this._supportsParallelQuery; }
            set { this._supportsParallelQuery = value; }
        }

        // Check to see if SupportsParallelQuery property is set
        internal bool IsSetSupportsParallelQuery()
        {
            return this._supportsParallelQuery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsReadReplica. 
        /// <para>
        /// Indicates whether the database engine version supports read replicas.
        /// </para>
        /// </summary>
        public bool? SupportsReadReplica
        {
            get { return this._supportsReadReplica; }
            set { this._supportsReadReplica = value; }
        }

        // Check to see if SupportsReadReplica property is set
        internal bool IsSetSupportsReadReplica()
        {
            return this._supportsReadReplica.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidUpgradeTarget. 
        /// <para>
        /// A list of engine versions that this database engine version can be upgraded to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpgradeTarget> ValidUpgradeTarget
        {
            get { return this._validUpgradeTarget; }
            set { this._validUpgradeTarget = value; }
        }

        // Check to see if ValidUpgradeTarget property is set
        internal bool IsSetValidUpgradeTarget()
        {
            return this._validUpgradeTarget != null && (this._validUpgradeTarget.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}