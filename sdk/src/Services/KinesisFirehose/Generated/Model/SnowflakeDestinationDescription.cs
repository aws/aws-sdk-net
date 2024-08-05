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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Optional Snowflake destination description
    /// </summary>
    public partial class SnowflakeDestinationDescription
    {
        private string _accountUrl;
        private SnowflakeBufferingHints _bufferingHints;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private string _contentColumnName;
        private string _database;
        private SnowflakeDataLoadingOption _dataLoadingOption;
        private string _metaDataColumnName;
        private ProcessingConfiguration _processingConfiguration;
        private SnowflakeRetryOptions _retryOptions;
        private string _roleARN;
        private SnowflakeS3BackupMode _s3BackupMode;
        private S3DestinationDescription _s3DestinationDescription;
        private string _schema;
        private SecretsManagerConfiguration _secretsManagerConfiguration;
        private SnowflakeRoleConfiguration _snowflakeRoleConfiguration;
        private SnowflakeVpcConfiguration _snowflakeVpcConfiguration;
        private string _table;
        private string _user;

        /// <summary>
        /// Gets and sets the property AccountUrl. 
        /// <para>
        /// URL for accessing your Snowflake account. This URL must include your <a href="https://docs.snowflake.com/en/user-guide/admin-account-identifier">account
        /// identifier</a>. Note that the protocol (https://) and port number are optional.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=24, Max=2048)]
        public string AccountUrl
        {
            get { return this._accountUrl; }
            set { this._accountUrl = value; }
        }

        // Check to see if AccountUrl property is set
        internal bool IsSetAccountUrl()
        {
            return this._accountUrl != null;
        }

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        ///  Describes the buffering to perform before delivering data to the Snowflake destination.
        /// If you do not specify any value, Firehose uses the default values. 
        /// </para>
        /// </summary>
        public SnowflakeBufferingHints BufferingHints
        {
            get { return this._bufferingHints; }
            set { this._bufferingHints = value; }
        }

        // Check to see if BufferingHints property is set
        internal bool IsSetBufferingHints()
        {
            return this._bufferingHints != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions.
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ContentColumnName. 
        /// <para>
        /// The name of the record content column
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string ContentColumnName
        {
            get { return this._contentColumnName; }
            set { this._contentColumnName = value; }
        }

        // Check to see if ContentColumnName property is set
        internal bool IsSetContentColumnName()
        {
            return this._contentColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// All data in Snowflake is maintained in databases.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property DataLoadingOption. 
        /// <para>
        /// Choose to load JSON keys mapped to table column names or choose to split the JSON
        /// payload where content is mapped to a record content column and source metadata is
        /// mapped to a record metadata column.
        /// </para>
        /// </summary>
        public SnowflakeDataLoadingOption DataLoadingOption
        {
            get { return this._dataLoadingOption; }
            set { this._dataLoadingOption = value; }
        }

        // Check to see if DataLoadingOption property is set
        internal bool IsSetDataLoadingOption()
        {
            return this._dataLoadingOption != null;
        }

        /// <summary>
        /// Gets and sets the property MetaDataColumnName. 
        /// <para>
        /// The name of the record metadata column
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string MetaDataColumnName
        {
            get { return this._metaDataColumnName; }
            set { this._metaDataColumnName = value; }
        }

        // Check to see if MetaDataColumnName property is set
        internal bool IsSetMetaDataColumnName()
        {
            return this._metaDataColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration
        {
            get { return this._processingConfiguration; }
            set { this._processingConfiguration = value; }
        }

        // Check to see if ProcessingConfiguration property is set
        internal bool IsSetProcessingConfiguration()
        {
            return this._processingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The time period where Firehose will retry sending data to the chosen HTTP endpoint.
        /// </para>
        /// </summary>
        public SnowflakeRetryOptions RetryOptions
        {
            get { return this._retryOptions; }
            set { this._retryOptions = value; }
        }

        // Check to see if RetryOptions property is set
        internal bool IsSetRetryOptions()
        {
            return this._retryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Snowflake role
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// Choose an S3 backup mode
        /// </para>
        /// </summary>
        public SnowflakeS3BackupMode S3BackupMode
        {
            get { return this._s3BackupMode; }
            set { this._s3BackupMode = value; }
        }

        // Check to see if S3BackupMode property is set
        internal bool IsSetS3BackupMode()
        {
            return this._s3BackupMode != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationDescription.
        /// </summary>
        public S3DestinationDescription S3DestinationDescription
        {
            get { return this._s3DestinationDescription; }
            set { this._s3DestinationDescription = value; }
        }

        // Check to see if S3DestinationDescription property is set
        internal bool IsSetS3DestinationDescription()
        {
            return this._s3DestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Each database consists of one or more schemas, which are logical groupings of database
        /// objects, such as tables and views
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerConfiguration. 
        /// <para>
        ///  The configuration that defines how you access secrets for Snowflake. 
        /// </para>
        /// </summary>
        public SecretsManagerConfiguration SecretsManagerConfiguration
        {
            get { return this._secretsManagerConfiguration; }
            set { this._secretsManagerConfiguration = value; }
        }

        // Check to see if SecretsManagerConfiguration property is set
        internal bool IsSetSecretsManagerConfiguration()
        {
            return this._secretsManagerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SnowflakeRoleConfiguration. 
        /// <para>
        /// Optionally configure a Snowflake role. Otherwise the default user role will be used.
        /// </para>
        /// </summary>
        public SnowflakeRoleConfiguration SnowflakeRoleConfiguration
        {
            get { return this._snowflakeRoleConfiguration; }
            set { this._snowflakeRoleConfiguration = value; }
        }

        // Check to see if SnowflakeRoleConfiguration property is set
        internal bool IsSetSnowflakeRoleConfiguration()
        {
            return this._snowflakeRoleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SnowflakeVpcConfiguration. 
        /// <para>
        /// The VPCE ID for Firehose to privately connect with Snowflake. The ID format is com.amazonaws.vpce.[region].vpce-svc-&lt;[id]&gt;.
        /// For more information, see <a href="https://docs.snowflake.com/en/user-guide/admin-security-privatelink">Amazon
        /// PrivateLink &amp; Snowflake</a> 
        /// </para>
        /// </summary>
        public SnowflakeVpcConfiguration SnowflakeVpcConfiguration
        {
            get { return this._snowflakeVpcConfiguration; }
            set { this._snowflakeVpcConfiguration = value; }
        }

        // Check to see if SnowflakeVpcConfiguration property is set
        internal bool IsSetSnowflakeVpcConfiguration()
        {
            return this._snowflakeVpcConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// All data in Snowflake is stored in database tables, logically structured as collections
        /// of columns and rows.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// User login name for the Snowflake account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}