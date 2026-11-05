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
    /// This is the response object from the CreateCustomDBEngineVersion operation.
    /// </summary>
    public partial class CreateCustomDBEngineVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The creation time of the DB engine version.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

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
        [AWSProperty(Min = 1, Max = 51000)]
        public string CustomDBEngineVersionManifest { get; set; }

        /// <summary>
        /// Checks to see if the CustomDBEngineVersionManifest property is set.
        /// </summary>
        internal bool IsSetCustomDBEngineVersionManifest() => this.CustomDBEngineVersionManifest != null;

        /// <summary>
        /// Gets and sets the property DBEngineDescription. 
        /// <para>
        /// The description of the database engine.
        /// </para>
        /// </summary>
        public string DBEngineDescription { get; set; }

        /// <summary>
        /// Checks to see if the DBEngineDescription property is set.
        /// </summary>
        internal bool IsSetDBEngineDescription() => this.DBEngineDescription != null;

        /// <summary>
        /// Gets and sets the property DBEngineMediaType. 
        /// <para>
        /// The source of the installation media for this engine version. A value of <c>Customer
        /// Provided</c> indicates that the engine version was created from customer-supplied
        /// installation media using <c>CreateCustomDBEngineVersion</c>. Applicable to RDS Custom
        /// for SQL Server and to RDS for SQL Server engine versions (<c>sqlserver-ee</c> and
        /// <c>sqlserver-se</c> with the <c>bring-your-own-media</c> license model, and <c>sqlserver-dev-ee</c>).
        /// </para>
        /// </summary>
        public string DBEngineMediaType { get; set; }

        /// <summary>
        /// Checks to see if the DBEngineMediaType property is set.
        /// </summary>
        internal bool IsSetDBEngineMediaType() => this.DBEngineMediaType != null;

        /// <summary>
        /// Gets and sets the property DBEngineVersionArn. 
        /// <para>
        /// The ARN of the custom engine version.
        /// </para>
        /// </summary>
        public string DBEngineVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the DBEngineVersionArn property is set.
        /// </summary>
        internal bool IsSetDBEngineVersionArn() => this.DBEngineVersionArn != null;

        /// <summary>
        /// Gets and sets the property DBEngineVersionDescription. 
        /// <para>
        /// The description of the database engine version.
        /// </para>
        /// </summary>
        public string DBEngineVersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the DBEngineVersionDescription property is set.
        /// </summary>
        internal bool IsSetDBEngineVersionDescription() => this.DBEngineVersionDescription != null;

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of the DB parameter group family for the database engine.
        /// </para>
        /// </summary>
        public string DBParameterGroupFamily { get; set; }

        /// <summary>
        /// Checks to see if the DBParameterGroupFamily property is set.
        /// </summary>
        internal bool IsSetDBParameterGroupFamily() => this.DBParameterGroupFamily != null;

        /// <summary>
        /// Gets and sets the property DatabaseInstallationFiles. 
        /// <para>
        /// The database installation files (ISO and EXE) that were uploaded to Amazon S3 and
        /// used to import the database engine version to Amazon RDS. Returned for RDS for SQL
        /// Server engine versions (<c>sqlserver-ee</c>, <c>sqlserver-se</c>, and <c>sqlserver-dev-ee</c>)
        /// created from customer-supplied installation media.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DatabaseInstallationFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DatabaseInstallationFiles property is set.
        /// </summary>
        internal bool IsSetDatabaseInstallationFiles() => this.DatabaseInstallationFiles != null && (this.DatabaseInstallationFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DatabaseInstallationFilesS3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket that contains your database installation files.
        /// </para>
        /// </summary>
        public string DatabaseInstallationFilesS3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseInstallationFilesS3BucketName property is set.
        /// </summary>
        internal bool IsSetDatabaseInstallationFilesS3BucketName() => this.DatabaseInstallationFilesS3BucketName != null;

        /// <summary>
        /// Gets and sets the property DatabaseInstallationFilesS3Prefix. 
        /// <para>
        /// The Amazon S3 directory that contains the database installation files. If not specified,
        /// then no prefix is assumed.
        /// </para>
        /// </summary>
        public string DatabaseInstallationFilesS3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseInstallationFilesS3Prefix property is set.
        /// </summary>
        internal bool IsSetDatabaseInstallationFilesS3Prefix() => this.DatabaseInstallationFilesS3Prefix != null;

        /// <summary>
        /// Gets and sets the property DefaultCharacterSet. 
        /// <para>
        /// The default character set for new instances of this engine version, if the <c>CharacterSetName</c>
        /// parameter of the CreateDBInstance API isn't specified.
        /// </para>
        /// </summary>
        public CharacterSet DefaultCharacterSet { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCharacterSet property is set.
        /// </summary>
        internal bool IsSetDefaultCharacterSet() => this.DefaultCharacterSet != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property ExportableLogTypes. 
        /// <para>
        /// The types of logs that the database engine has available for export to CloudWatch
        /// Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportableLogTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExportableLogTypes property is set.
        /// </summary>
        internal bool IsSetExportableLogTypes() => this.ExportableLogTypes != null && (this.ExportableLogTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the custom engine version creation failed with an <c>incompatible-installation-media</c>
        /// status. Applicable to RDS for SQL Server engine versions (<c>sqlserver-ee</c>, <c>sqlserver-se</c>,
        /// and <c>sqlserver-dev-ee</c>).
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The EC2 image
        /// </para>
        /// </summary>
        public CustomDBEngineVersionAMI Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for an encrypted CEV. This parameter is
        /// required for RDS Custom, but optional for Amazon RDS.
        /// </para>
        /// </summary>
        public string KMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyId property is set.
        /// </summary>
        internal bool IsSetKMSKeyId() => this.KMSKeyId != null;

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// The major engine version of the CEV.
        /// </para>
        /// </summary>
        public string MajorEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorEngineVersion property is set.
        /// </summary>
        internal bool IsSetMajorEngineVersion() => this.MajorEngineVersion != null;

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
        public ServerlessV2FeaturesSupport ServerlessV2FeaturesSupport { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessV2FeaturesSupport property is set.
        /// </summary>
        internal bool IsSetServerlessV2FeaturesSupport() => this.ServerlessV2FeaturesSupport != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB engine version, either <c>available</c> or <c>deprecated</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedCACertificateIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedCACertificateIdentifiers property is set.
        /// </summary>
        internal bool IsSetSupportedCACertificateIdentifiers() => this.SupportedCACertificateIdentifiers != null && (this.SupportedCACertificateIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedCharacterSets. 
        /// <para>
        /// A list of the character sets supported by this engine for the <c>CharacterSetName</c>
        /// parameter of the <c>CreateDBInstance</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CharacterSet> SupportedCharacterSets { get; set; } = AWSConfigs.InitializeCollections ? new List<CharacterSet>() : null;

        /// <summary>
        /// Checks to see if the SupportedCharacterSets property is set.
        /// </summary>
        internal bool IsSetSupportedCharacterSets() => this.SupportedCharacterSets != null && (this.SupportedCharacterSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedEngineModes. 
        /// <para>
        /// A list of the supported DB engine modes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngineModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedEngineModes property is set.
        /// </summary>
        internal bool IsSetSupportedEngineModes() => this.SupportedEngineModes != null && (this.SupportedEngineModes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedFeatureNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedFeatureNames property is set.
        /// </summary>
        internal bool IsSetSupportedFeatureNames() => this.SupportedFeatureNames != null && (this.SupportedFeatureNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedNcharCharacterSets. 
        /// <para>
        /// A list of the character sets supported by the Oracle DB engine for the <c>NcharCharacterSetName</c>
        /// parameter of the <c>CreateDBInstance</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CharacterSet> SupportedNcharCharacterSets { get; set; } = AWSConfigs.InitializeCollections ? new List<CharacterSet>() : null;

        /// <summary>
        /// Checks to see if the SupportedNcharCharacterSets property is set.
        /// </summary>
        internal bool IsSetSupportedNcharCharacterSets() => this.SupportedNcharCharacterSets != null && (this.SupportedNcharCharacterSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedTimezones. 
        /// <para>
        /// A list of the time zones supported by this engine for the <c>Timezone</c> parameter
        /// of the <c>CreateDBInstance</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Timezone> SupportedTimezones { get; set; } = AWSConfigs.InitializeCollections ? new List<Timezone>() : null;

        /// <summary>
        /// Checks to see if the SupportedTimezones property is set.
        /// </summary>
        internal bool IsSetSupportedTimezones() => this.SupportedTimezones != null && (this.SupportedTimezones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportsBabelfish. 
        /// <para>
        /// Indicates whether the engine version supports Babelfish for Aurora PostgreSQL.
        /// </para>
        /// </summary>
        public bool? SupportsBabelfish { get; set; }

        /// <summary>
        /// Checks to see if the SupportsBabelfish property is set.
        /// </summary>
        internal bool IsSetSupportsBabelfish() => this.SupportsBabelfish.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsCertificateRotationWithoutRestart. 
        /// <para>
        /// Indicates whether the engine version supports rotating the server certificate without
        /// rebooting the DB instance.
        /// </para>
        /// </summary>
        public bool? SupportsCertificateRotationWithoutRestart { get; set; }

        /// <summary>
        /// Checks to see if the SupportsCertificateRotationWithoutRestart property is set.
        /// </summary>
        internal bool IsSetSupportsCertificateRotationWithoutRestart() => this.SupportsCertificateRotationWithoutRestart.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsGlobalDatabases. 
        /// <para>
        /// Indicates whether you can use Aurora global databases with a specific DB engine version.
        /// </para>
        /// </summary>
        public bool? SupportsGlobalDatabases { get; set; }

        /// <summary>
        /// Checks to see if the SupportsGlobalDatabases property is set.
        /// </summary>
        internal bool IsSetSupportsGlobalDatabases() => this.SupportsGlobalDatabases.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsIntegrations. 
        /// <para>
        /// Indicates whether the DB engine version supports zero-ETL integrations with Amazon
        /// Redshift.
        /// </para>
        /// </summary>
        public bool? SupportsIntegrations { get; set; }

        /// <summary>
        /// Checks to see if the SupportsIntegrations property is set.
        /// </summary>
        internal bool IsSetSupportsIntegrations() => this.SupportsIntegrations.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsLimitlessDatabase. 
        /// <para>
        /// Indicates whether the DB engine version supports Aurora Limitless Database.
        /// </para>
        /// </summary>
        public bool? SupportsLimitlessDatabase { get; set; }

        /// <summary>
        /// Checks to see if the SupportsLimitlessDatabase property is set.
        /// </summary>
        internal bool IsSetSupportsLimitlessDatabase() => this.SupportsLimitlessDatabase.HasValue;

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
        public bool? SupportsLocalWriteForwarding { get; set; }

        /// <summary>
        /// Checks to see if the SupportsLocalWriteForwarding property is set.
        /// </summary>
        internal bool IsSetSupportsLocalWriteForwarding() => this.SupportsLocalWriteForwarding.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsLogExportsToCloudwatchLogs. 
        /// <para>
        /// Indicates whether the engine version supports exporting the log types specified by
        /// ExportableLogTypes to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool? SupportsLogExportsToCloudwatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the SupportsLogExportsToCloudwatchLogs property is set.
        /// </summary>
        internal bool IsSetSupportsLogExportsToCloudwatchLogs() => this.SupportsLogExportsToCloudwatchLogs.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsParallelQuery. 
        /// <para>
        /// Indicates whether you can use Aurora parallel query with a specific DB engine version.
        /// </para>
        /// </summary>
        public bool? SupportsParallelQuery { get; set; }

        /// <summary>
        /// Checks to see if the SupportsParallelQuery property is set.
        /// </summary>
        internal bool IsSetSupportsParallelQuery() => this.SupportsParallelQuery.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsReadReplica. 
        /// <para>
        /// Indicates whether the database engine version supports read replicas.
        /// </para>
        /// </summary>
        public bool? SupportsReadReplica { get; set; }

        /// <summary>
        /// Checks to see if the SupportsReadReplica property is set.
        /// </summary>
        internal bool IsSetSupportsReadReplica() => this.SupportsReadReplica.HasValue;

        /// <summary>
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidUpgradeTarget. 
        /// <para>
        /// A list of engine versions that this database engine version can be upgraded to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpgradeTarget> ValidUpgradeTarget { get; set; } = AWSConfigs.InitializeCollections ? new List<UpgradeTarget>() : null;

        /// <summary>
        /// Checks to see if the ValidUpgradeTarget property is set.
        /// </summary>
        internal bool IsSetValidUpgradeTarget() => this.ValidUpgradeTarget != null && (this.ValidUpgradeTarget.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
