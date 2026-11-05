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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines an Amazon Redshift endpoint.
    /// </summary>
    public partial class RedshiftSettings
    {
        /// <summary>
        /// Gets and sets the property AcceptAnyDate. 
        /// <para>
        /// A value that indicates to allow any date format, including invalid formats such as
        /// 00/00/00 00:00:00, to be loaded without generating an error. You can choose <c>true</c>
        /// or <c>false</c> (the default).
        /// </para>
        ///  
        /// <para>
        /// This parameter applies only to TIMESTAMP and DATE columns. Always use ACCEPTANYDATE
        /// with the DATEFORMAT parameter. If the date format for the data doesn't match the DATEFORMAT
        /// specification, Amazon Redshift inserts a NULL value into that field. 
        /// </para>
        /// </summary>
        public bool? AcceptAnyDate { get; set; }

        /// <summary>
        /// Checks to see if the AcceptAnyDate property is set.
        /// </summary>
        internal bool IsSetAcceptAnyDate() => this.AcceptAnyDate.HasValue;

        /// <summary>
        /// Gets and sets the property AfterConnectScript. 
        /// <para>
        /// Code to run after connecting. This parameter should contain the code itself, not the
        /// name of a file containing the code.
        /// </para>
        /// </summary>
        public string AfterConnectScript { get; set; }

        /// <summary>
        /// Checks to see if the AfterConnectScript property is set.
        /// </summary>
        internal bool IsSetAfterConnectScript() => this.AfterConnectScript != null;

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        /// An S3 folder where the comma-separated-value (.csv) files are stored before being
        /// uploaded to the target Redshift cluster. 
        /// </para>
        ///  
        /// <para>
        /// For full load mode, DMS converts source records into .csv files and loads them to
        /// the <i>BucketFolder/TableID</i> path. DMS uses the Redshift <c>COPY</c> command to
        /// upload the .csv files to the target table. The files are deleted once the <c>COPY</c>
        /// operation has finished. For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/dg/r_COPY.html">COPY</a>
        /// in the <i>Amazon Redshift Database Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For change-data-capture (CDC) mode, DMS creates a <i>NetChanges</i> table, and loads
        /// the .csv files to this <i>BucketFolder/NetChangesTableID</i> path.
        /// </para>
        /// </summary>
        public string BucketFolder { get; set; }

        /// <summary>
        /// Checks to see if the BucketFolder property is set.
        /// </summary>
        internal bool IsSetBucketFolder() => this.BucketFolder != null;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the intermediate S3 bucket used to store .csv files before uploading data
        /// to Redshift.
        /// </para>
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property CaseSensitiveNames. 
        /// <para>
        /// If Amazon Redshift is configured to support case sensitive schema names, set <c>CaseSensitiveNames</c>
        /// to <c>true</c>. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? CaseSensitiveNames { get; set; }

        /// <summary>
        /// Checks to see if the CaseSensitiveNames property is set.
        /// </summary>
        internal bool IsSetCaseSensitiveNames() => this.CaseSensitiveNames.HasValue;

        /// <summary>
        /// Gets and sets the property CompUpdate. 
        /// <para>
        /// If you set <c>CompUpdate</c> to <c>true</c> Amazon Redshift applies automatic compression
        /// if the table is empty. This applies even if the table columns already have encodings
        /// other than <c>RAW</c>. If you set <c>CompUpdate</c> to <c>false</c>, automatic compression
        /// is disabled and existing column encodings aren't changed. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? CompUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CompUpdate property is set.
        /// </summary>
        internal bool IsSetCompUpdate() => this.CompUpdate.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectionTimeout. 
        /// <para>
        /// A value that sets the amount of time to wait (in milliseconds) before timing out,
        /// beginning from when you initially establish a connection.
        /// </para>
        /// </summary>
        public int? ConnectionTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTimeout property is set.
        /// </summary>
        internal bool IsSetConnectionTimeout() => this.ConnectionTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Amazon Redshift data warehouse (service) that you are working with.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DateFormat. 
        /// <para>
        /// The date format that you are using. Valid values are <c>auto</c> (case-sensitive),
        /// your date format string enclosed in quotes, or NULL. If this parameter is left unset
        /// (NULL), it defaults to a format of 'YYYY-MM-DD'. Using <c>auto</c> recognizes most
        /// strings, even some that aren't supported when you use a date format string. 
        /// </para>
        ///  
        /// <para>
        /// If your date and time values use formats different from each other, set this to <c>auto</c>.
        /// 
        /// </para>
        /// </summary>
        public string DateFormat { get; set; }

        /// <summary>
        /// Checks to see if the DateFormat property is set.
        /// </summary>
        internal bool IsSetDateFormat() => this.DateFormat != null;

        /// <summary>
        /// Gets and sets the property EmptyAsNull. 
        /// <para>
        /// A value that specifies whether DMS should migrate empty CHAR and VARCHAR fields as
        /// NULL. A value of <c>true</c> sets empty CHAR and VARCHAR fields to null. The default
        /// is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EmptyAsNull { get; set; }

        /// <summary>
        /// Checks to see if the EmptyAsNull property is set.
        /// </summary>
        internal bool IsSetEmptyAsNull() => this.EmptyAsNull.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The type of server-side encryption that you want to use for your data. This encryption
        /// type is part of the endpoint settings or the extra connections attributes for Amazon
        /// S3. You can choose either <c>SSE_S3</c> (the default) or <c>SSE_KMS</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For the <c>ModifyEndpoint</c> operation, you can change the existing value of the
        /// <c>EncryptionMode</c> parameter from <c>SSE_KMS</c> to <c>SSE_S3</c>. But you can’t
        /// change the existing value from <c>SSE_S3</c> to <c>SSE_KMS</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use <c>SSE_S3</c>, create an Identity and Access Management (IAM) role with a policy
        /// that allows <c>"arn:aws:s3:::*"</c> to use the following actions: <c>"s3:PutObject",
        /// "s3:ListBucket"</c> 
        /// </para>
        /// </summary>
        public EncryptionModeValue EncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMode property is set.
        /// </summary>
        internal bool IsSetEncryptionMode() => this.EncryptionMode != null;

        /// <summary>
        /// Gets and sets the property ExplicitIds. 
        /// <para>
        /// This setting is only valid for a full-load migration task. Set <c>ExplicitIds</c>
        /// to <c>true</c> to have tables with <c>IDENTITY</c> columns override their auto-generated
        /// values with explicit values loaded from the source data files used to populate the
        /// tables. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ExplicitIds { get; set; }

        /// <summary>
        /// Checks to see if the ExplicitIds property is set.
        /// </summary>
        internal bool IsSetExplicitIds() => this.ExplicitIds.HasValue;

        /// <summary>
        /// Gets and sets the property FileTransferUploadStreams. 
        /// <para>
        /// The number of threads used to upload a single file. This parameter accepts a value
        /// from 1 through 64. It defaults to 10.
        /// </para>
        ///  
        /// <para>
        /// The number of parallel streams used to upload a single .csv file to an S3 bucket using
        /// S3 Multipart Upload. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
        /// upload overview</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <c>FileTransferUploadStreams</c> accepts a value from 1 through 64. It defaults to
        /// 10.
        /// </para>
        /// </summary>
        public int? FileTransferUploadStreams { get; set; }

        /// <summary>
        /// Checks to see if the FileTransferUploadStreams property is set.
        /// </summary>
        internal bool IsSetFileTransferUploadStreams() => this.FileTransferUploadStreams.HasValue;

        /// <summary>
        /// Gets and sets the property LoadTimeout. 
        /// <para>
        /// The amount of time to wait (in seconds) before timing out of operations performed
        /// by DMS on a Redshift cluster, such as Redshift COPY, INSERT, DELETE, and UPDATE.
        /// </para>
        /// </summary>
        public int? LoadTimeout { get; set; }

        /// <summary>
        /// Checks to see if the LoadTimeout property is set.
        /// </summary>
        internal bool IsSetLoadTimeout() => this.LoadTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property MapBooleanAsBoolean. 
        /// <para>
        /// When true, lets Redshift migrate the boolean type as boolean. By default, Redshift
        /// migrates booleans as <c>varchar(1)</c>. You must set this setting on both the source
        /// and target endpoints for it to take effect.
        /// </para>
        /// </summary>
        public bool? MapBooleanAsBoolean { get; set; }

        /// <summary>
        /// Checks to see if the MapBooleanAsBoolean property is set.
        /// </summary>
        internal bool IsSetMapBooleanAsBoolean() => this.MapBooleanAsBoolean.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// The maximum size (in KB) of any .csv file used to load data on an S3 bucket and transfer
        /// data to Amazon Redshift. It defaults to 1048576KB (1 GB).
        /// </para>
        /// </summary>
        public int? MaxFileSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxFileSize property is set.
        /// </summary>
        internal bool IsSetMaxFileSize() => this.MaxFileSize.HasValue;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the user named in the <c>username</c> property.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for Amazon Redshift. The default value is 5439.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveQuotes. 
        /// <para>
        /// A value that specifies to remove surrounding quotation marks from strings in the incoming
        /// data. All characters within the quotation marks, including delimiters, are retained.
        /// Choose <c>true</c> to remove quotation marks. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? RemoveQuotes { get; set; }

        /// <summary>
        /// Checks to see if the RemoveQuotes property is set.
        /// </summary>
        internal bool IsSetRemoveQuotes() => this.RemoveQuotes.HasValue;

        /// <summary>
        /// Gets and sets the property ReplaceChars. 
        /// <para>
        /// A value that specifies to replaces the invalid characters specified in <c>ReplaceInvalidChars</c>,
        /// substituting the specified characters instead. The default is <c>"?"</c>.
        /// </para>
        /// </summary>
        public string ReplaceChars { get; set; }

        /// <summary>
        /// Checks to see if the ReplaceChars property is set.
        /// </summary>
        internal bool IsSetReplaceChars() => this.ReplaceChars != null;

        /// <summary>
        /// Gets and sets the property ReplaceInvalidChars. 
        /// <para>
        /// A list of characters that you want to replace. Use with <c>ReplaceChars</c>.
        /// </para>
        /// </summary>
        public string ReplaceInvalidChars { get; set; }

        /// <summary>
        /// Checks to see if the ReplaceInvalidChars property is set.
        /// </summary>
        internal bool IsSetReplaceInvalidChars() => this.ReplaceInvalidChars != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <c>SecretsManagerSecret</c>.
        /// The role must allow the <c>iam:PassRole</c> action. <c>SecretsManagerSecret</c> has
        /// the value of the Amazon Web Services Secrets Manager secret that allows access to
        /// the Amazon Redshift endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <c>SecretsManagerSecretId</c>. Or you can specify clear-text
        /// values for <c>UserName</c>, <c>Password</c>, <c>ServerName</c>, and <c>Port</c>. You
        /// can't specify both. For more information on creating this <c>SecretsManagerSecret</c>
        /// and the <c>SecretsManagerAccessRoleArn</c> and <c>SecretsManagerSecretId</c> required
        /// to access it, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
        /// secrets to access Database Migration Service resources</a> in the <i>Database Migration
        /// Service User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SecretsManagerAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerAccessRoleArn() => this.SecretsManagerAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <c>SecretsManagerSecret</c> that
        /// contains the Amazon Redshift endpoint connection details.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecretId property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecretId() => this.SecretsManagerSecretId != null;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the Amazon Redshift cluster you are using.
        /// </para>
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKmsKeyId. 
        /// <para>
        /// The KMS key ID. If you are using <c>SSE_KMS</c> for the <c>EncryptionMode</c>, provide
        /// this key ID. The key that you use needs an attached policy that enables IAM user permissions
        /// and allows use of the key.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionKmsKeyId property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionKmsKeyId() => this.ServerSideEncryptionKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that has access to the Amazon Redshift
        /// service. The role must allow the <c>iam:PassRole</c> action.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property TimeFormat. 
        /// <para>
        /// The time format that you want to use. Valid values are <c>auto</c> (case-sensitive),
        /// <c>'timeformat_string'</c>, <c>'epochsecs'</c>, or <c>'epochmillisecs'</c>. It defaults
        /// to 10. Using <c>auto</c> recognizes most strings, even some that aren't supported
        /// when you use a time format string. 
        /// </para>
        ///  
        /// <para>
        /// If your date and time values use formats different from each other, set this parameter
        /// to <c>auto</c>. 
        /// </para>
        /// </summary>
        public string TimeFormat { get; set; }

        /// <summary>
        /// Checks to see if the TimeFormat property is set.
        /// </summary>
        internal bool IsSetTimeFormat() => this.TimeFormat != null;

        /// <summary>
        /// Gets and sets the property TrimBlanks. 
        /// <para>
        /// A value that specifies to remove the trailing white space characters from a VARCHAR
        /// string. This parameter applies only to columns with a VARCHAR data type. Choose <c>true</c>
        /// to remove unneeded white space. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? TrimBlanks { get; set; }

        /// <summary>
        /// Checks to see if the TrimBlanks property is set.
        /// </summary>
        internal bool IsSetTrimBlanks() => this.TrimBlanks.HasValue;

        /// <summary>
        /// Gets and sets the property TruncateColumns. 
        /// <para>
        /// A value that specifies to truncate data in columns to the appropriate number of characters,
        /// so that the data fits in the column. This parameter applies only to columns with a
        /// VARCHAR or CHAR data type, and rows with a size of 4 MB or less. Choose <c>true</c>
        /// to truncate data. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? TruncateColumns { get; set; }

        /// <summary>
        /// Checks to see if the TruncateColumns property is set.
        /// </summary>
        internal bool IsSetTruncateColumns() => this.TruncateColumns.HasValue;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// An Amazon Redshift user name for a registered user.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;

        /// <summary>
        /// Gets and sets the property WriteBufferSize. 
        /// <para>
        /// The size (in KB) of the in-memory file write buffer used when generating .csv files
        /// on the local disk at the DMS replication instance. The default value is 1000 (buffer
        /// size is 1000KB).
        /// </para>
        /// </summary>
        public int? WriteBufferSize { get; set; }

        /// <summary>
        /// Checks to see if the WriteBufferSize property is set.
        /// </summary>
        internal bool IsSetWriteBufferSize() => this.WriteBufferSize.HasValue;
    }
}
