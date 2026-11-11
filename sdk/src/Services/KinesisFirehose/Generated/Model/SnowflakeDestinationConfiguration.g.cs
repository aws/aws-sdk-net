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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Configure Snowflake destination
    /// </summary>
    public partial class SnowflakeDestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountUrl. 
        /// <para>
        /// URL for accessing your Snowflake account. This URL must include your <a href="https://docs.snowflake.com/en/user-guide/admin-account-identifier">account
        /// identifier</a>. Note that the protocol (https://) and port number are optional.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 24, Max = 2048)]
        public string AccountUrl { get; set; }

        /// <summary>
        /// Checks to see if the AccountUrl property is set.
        /// </summary>
        internal bool IsSetAccountUrl() => this.AccountUrl != null;

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        ///  Describes the buffering to perform before delivering data to the Snowflake destination.
        /// If you do not specify any value, Firehose uses the default values. 
        /// </para>
        /// </summary>
        public SnowflakeBufferingHints BufferingHints { get; set; }

        /// <summary>
        /// Checks to see if the BufferingHints property is set.
        /// </summary>
        internal bool IsSetBufferingHints() => this.BufferingHints != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions.
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null;

        /// <summary>
        /// Gets and sets the property ContentColumnName. 
        /// <para>
        /// The name of the record content column.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string ContentColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ContentColumnName property is set.
        /// </summary>
        internal bool IsSetContentColumnName() => this.ContentColumnName != null;

        /// <summary>
        /// Gets and sets the property DataLoadingOption. 
        /// <para>
        /// Choose to load JSON keys mapped to table column names or choose to split the JSON
        /// payload where content is mapped to a record content column and source metadata is
        /// mapped to a record metadata column.
        /// </para>
        /// </summary>
        public SnowflakeDataLoadingOption DataLoadingOption { get; set; }

        /// <summary>
        /// Checks to see if the DataLoadingOption property is set.
        /// </summary>
        internal bool IsSetDataLoadingOption() => this.DataLoadingOption != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// All data in Snowflake is maintained in databases.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property KeyPassphrase. 
        /// <para>
        /// Passphrase to decrypt the private key when the key is encrypted. For information,
        /// see <a href="https://docs.snowflake.com/en/user-guide/data-load-snowpipe-streaming-configuration#using-key-pair-authentication-key-rotation">Using
        /// Key Pair Authentication &amp; Key Rotation</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 7, Max = 255)]
        public string KeyPassphrase { get; set; }

        /// <summary>
        /// Checks to see if the KeyPassphrase property is set.
        /// </summary>
        internal bool IsSetKeyPassphrase() => this.KeyPassphrase != null;

        /// <summary>
        /// Gets and sets the property MetaDataColumnName. 
        /// <para>
        /// Specify a column name in the table, where the metadata information has to be loaded.
        /// When you enable this field, you will see the following column in the snowflake table,
        /// which differs based on the source type.
        /// </para>
        ///  
        /// <para>
        /// For Direct PUT as source 
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "firehoseDeliveryStreamName" : "streamname", "IngestionTime" : "timestamp" }</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For Kinesis Data Stream as source 
        /// </para>
        ///  
        /// <para>
        ///  <c> "kinesisStreamName" : "streamname", "kinesisShardId" : "Id", "kinesisPartitionKey"
        /// : "key", "kinesisSequenceNumber" : "1234", "subsequenceNumber" : "2334", "IngestionTime"
        /// : "timestamp" }</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string MetaDataColumnName { get; set; }

        /// <summary>
        /// Checks to see if the MetaDataColumnName property is set.
        /// </summary>
        internal bool IsSetMetaDataColumnName() => this.MetaDataColumnName != null;

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// The private key used to encrypt your Snowflake client. For information, see <a href="https://docs.snowflake.com/en/user-guide/data-load-snowpipe-streaming-configuration#using-key-pair-authentication-key-rotation">Using
        /// Key Pair Authentication &amp; Key Rotation</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 256, Max = 4096)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKey property is set.
        /// </summary>
        internal bool IsSetPrivateKey() => this.PrivateKey != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The time period where Firehose will retry sending data to the chosen HTTP endpoint.
        /// </para>
        /// </summary>
        public SnowflakeRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetryOptions property is set.
        /// </summary>
        internal bool IsSetRetryOptions() => this.RetryOptions != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Snowflake role
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// Choose an S3 backup mode
        /// </para>
        /// </summary>
        public SnowflakeS3BackupMode S3BackupMode { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupMode property is set.
        /// </summary>
        internal bool IsSetS3BackupMode() => this.S3BackupMode != null;

        /// <summary>
        /// Gets and sets the property S3Configuration.
        /// </summary>
        [AWSProperty(Required = true)]
        public S3DestinationConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Each database consists of one or more schemas, which are logical groupings of database
        /// objects, such as tables and views
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerConfiguration. 
        /// <para>
        ///  The configuration that defines how you access secrets for Snowflake. 
        /// </para>
        /// </summary>
        public SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerConfiguration property is set.
        /// </summary>
        internal bool IsSetSecretsManagerConfiguration() => this.SecretsManagerConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnowflakeRoleConfiguration. 
        /// <para>
        /// Optionally configure a Snowflake role. Otherwise the default user role will be used.
        /// </para>
        /// </summary>
        public SnowflakeRoleConfiguration SnowflakeRoleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeRoleConfiguration property is set.
        /// </summary>
        internal bool IsSetSnowflakeRoleConfiguration() => this.SnowflakeRoleConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnowflakeVpcConfiguration. 
        /// <para>
        /// The VPCE ID for Firehose to privately connect with Snowflake. The ID format is com.amazonaws.vpce.[region].vpce-svc-&lt;[id]>.
        /// For more information, see <a href="https://docs.snowflake.com/en/user-guide/admin-security-privatelink">Amazon
        /// PrivateLink &amp; Snowflake</a> 
        /// </para>
        /// </summary>
        public SnowflakeVpcConfiguration SnowflakeVpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeVpcConfiguration property is set.
        /// </summary>
        internal bool IsSetSnowflakeVpcConfiguration() => this.SnowflakeVpcConfiguration != null;

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// All data in Snowflake is stored in database tables, logically structured as collections
        /// of columns and rows.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// User login name for the Snowflake account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
