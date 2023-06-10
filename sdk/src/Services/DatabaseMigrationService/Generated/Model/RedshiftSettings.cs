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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines an Amazon Redshift endpoint.
    /// </summary>
    public partial class RedshiftSettings
    {
        private bool? _acceptAnyDate;
        private string _afterConnectScript;
        private string _bucketFolder;
        private string _bucketName;
        private bool? _caseSensitiveNames;
        private bool? _compUpdate;
        private int? _connectionTimeout;
        private string _databaseName;
        private string _dateFormat;
        private bool? _emptyAsNull;
        private EncryptionModeValue _encryptionMode;
        private bool? _explicitIds;
        private int? _fileTransferUploadStreams;
        private int? _loadTimeout;
        private bool? _mapBooleanAsBoolean;
        private int? _maxFileSize;
        private string _password;
        private int? _port;
        private bool? _removeQuotes;
        private string _replaceChars;
        private string _replaceInvalidChars;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;
        private string _serverName;
        private string _serverSideEncryptionKmsKeyId;
        private string _serviceAccessRoleArn;
        private string _timeFormat;
        private bool? _trimBlanks;
        private bool? _truncateColumns;
        private string _username;
        private int? _writeBufferSize;

        /// <summary>
        /// Gets and sets the property AcceptAnyDate. 
        /// <para>
        /// A value that indicates to allow any date format, including invalid formats such as
        /// 00/00/00 00:00:00, to be loaded without generating an error. You can choose <code>true</code>
        /// or <code>false</code> (the default).
        /// </para>
        ///  
        /// <para>
        /// This parameter applies only to TIMESTAMP and DATE columns. Always use ACCEPTANYDATE
        /// with the DATEFORMAT parameter. If the date format for the data doesn't match the DATEFORMAT
        /// specification, Amazon Redshift inserts a NULL value into that field. 
        /// </para>
        /// </summary>
        public bool AcceptAnyDate
        {
            get { return this._acceptAnyDate.GetValueOrDefault(); }
            set { this._acceptAnyDate = value; }
        }

        // Check to see if AcceptAnyDate property is set
        internal bool IsSetAcceptAnyDate()
        {
            return this._acceptAnyDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AfterConnectScript. 
        /// <para>
        /// Code to run after connecting. This parameter should contain the code itself, not the
        /// name of a file containing the code.
        /// </para>
        /// </summary>
        public string AfterConnectScript
        {
            get { return this._afterConnectScript; }
            set { this._afterConnectScript = value; }
        }

        // Check to see if AfterConnectScript property is set
        internal bool IsSetAfterConnectScript()
        {
            return this._afterConnectScript != null;
        }

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        /// An S3 folder where the comma-separated-value (.csv) files are stored before being
        /// uploaded to the target Redshift cluster. 
        /// </para>
        ///  
        /// <para>
        /// For full load mode, DMS converts source records into .csv files and loads them to
        /// the <i>BucketFolder/TableID</i> path. DMS uses the Redshift <code>COPY</code> command
        /// to upload the .csv files to the target table. The files are deleted once the <code>COPY</code>
        /// operation has finished. For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/dg/r_COPY.html">COPY</a>
        /// in the <i>Amazon Redshift Database Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For change-data-capture (CDC) mode, DMS creates a <i>NetChanges</i> table, and loads
        /// the .csv files to this <i>BucketFolder/NetChangesTableID</i> path.
        /// </para>
        /// </summary>
        public string BucketFolder
        {
            get { return this._bucketFolder; }
            set { this._bucketFolder = value; }
        }

        // Check to see if BucketFolder property is set
        internal bool IsSetBucketFolder()
        {
            return this._bucketFolder != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the intermediate S3 bucket used to store .csv files before uploading data
        /// to Redshift.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property CaseSensitiveNames. 
        /// <para>
        /// If Amazon Redshift is configured to support case sensitive schema names, set <code>CaseSensitiveNames</code>
        /// to <code>true</code>. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool CaseSensitiveNames
        {
            get { return this._caseSensitiveNames.GetValueOrDefault(); }
            set { this._caseSensitiveNames = value; }
        }

        // Check to see if CaseSensitiveNames property is set
        internal bool IsSetCaseSensitiveNames()
        {
            return this._caseSensitiveNames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompUpdate. 
        /// <para>
        /// If you set <code>CompUpdate</code> to <code>true</code> Amazon Redshift applies automatic
        /// compression if the table is empty. This applies even if the table columns already
        /// have encodings other than <code>RAW</code>. If you set <code>CompUpdate</code> to
        /// <code>false</code>, automatic compression is disabled and existing column encodings
        /// aren't changed. The default is <code>true</code>.
        /// </para>
        /// </summary>
        public bool CompUpdate
        {
            get { return this._compUpdate.GetValueOrDefault(); }
            set { this._compUpdate = value; }
        }

        // Check to see if CompUpdate property is set
        internal bool IsSetCompUpdate()
        {
            return this._compUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionTimeout. 
        /// <para>
        /// A value that sets the amount of time to wait (in milliseconds) before timing out,
        /// beginning from when you initially establish a connection.
        /// </para>
        /// </summary>
        public int ConnectionTimeout
        {
            get { return this._connectionTimeout.GetValueOrDefault(); }
            set { this._connectionTimeout = value; }
        }

        // Check to see if ConnectionTimeout property is set
        internal bool IsSetConnectionTimeout()
        {
            return this._connectionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Amazon Redshift data warehouse (service) that you are working with.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DateFormat. 
        /// <para>
        /// The date format that you are using. Valid values are <code>auto</code> (case-sensitive),
        /// your date format string enclosed in quotes, or NULL. If this parameter is left unset
        /// (NULL), it defaults to a format of 'YYYY-MM-DD'. Using <code>auto</code> recognizes
        /// most strings, even some that aren't supported when you use a date format string. 
        /// </para>
        ///  
        /// <para>
        /// If your date and time values use formats different from each other, set this to <code>auto</code>.
        /// 
        /// </para>
        /// </summary>
        public string DateFormat
        {
            get { return this._dateFormat; }
            set { this._dateFormat = value; }
        }

        // Check to see if DateFormat property is set
        internal bool IsSetDateFormat()
        {
            return this._dateFormat != null;
        }

        /// <summary>
        /// Gets and sets the property EmptyAsNull. 
        /// <para>
        /// A value that specifies whether DMS should migrate empty CHAR and VARCHAR fields as
        /// NULL. A value of <code>true</code> sets empty CHAR and VARCHAR fields to null. The
        /// default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool EmptyAsNull
        {
            get { return this._emptyAsNull.GetValueOrDefault(); }
            set { this._emptyAsNull = value; }
        }

        // Check to see if EmptyAsNull property is set
        internal bool IsSetEmptyAsNull()
        {
            return this._emptyAsNull.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The type of server-side encryption that you want to use for your data. This encryption
        /// type is part of the endpoint settings or the extra connections attributes for Amazon
        /// S3. You can choose either <code>SSE_S3</code> (the default) or <code>SSE_KMS</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// For the <code>ModifyEndpoint</code> operation, you can change the existing value of
        /// the <code>EncryptionMode</code> parameter from <code>SSE_KMS</code> to <code>SSE_S3</code>.
        /// But you can’t change the existing value from <code>SSE_S3</code> to <code>SSE_KMS</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use <code>SSE_S3</code>, create an Identity and Access Management (IAM) role with
        /// a policy that allows <code>"arn:aws:s3:::*"</code> to use the following actions: <code>"s3:PutObject",
        /// "s3:ListBucket"</code> 
        /// </para>
        /// </summary>
        public EncryptionModeValue EncryptionMode
        {
            get { return this._encryptionMode; }
            set { this._encryptionMode = value; }
        }

        // Check to see if EncryptionMode property is set
        internal bool IsSetEncryptionMode()
        {
            return this._encryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property ExplicitIds. 
        /// <para>
        /// This setting is only valid for a full-load migration task. Set <code>ExplicitIds</code>
        /// to <code>true</code> to have tables with <code>IDENTITY</code> columns override their
        /// auto-generated values with explicit values loaded from the source data files used
        /// to populate the tables. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool ExplicitIds
        {
            get { return this._explicitIds.GetValueOrDefault(); }
            set { this._explicitIds = value; }
        }

        // Check to see if ExplicitIds property is set
        internal bool IsSetExplicitIds()
        {
            return this._explicitIds.HasValue; 
        }

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
        ///  <code>FileTransferUploadStreams</code> accepts a value from 1 through 64. It defaults
        /// to 10.
        /// </para>
        /// </summary>
        public int FileTransferUploadStreams
        {
            get { return this._fileTransferUploadStreams.GetValueOrDefault(); }
            set { this._fileTransferUploadStreams = value; }
        }

        // Check to see if FileTransferUploadStreams property is set
        internal bool IsSetFileTransferUploadStreams()
        {
            return this._fileTransferUploadStreams.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadTimeout. 
        /// <para>
        /// The amount of time to wait (in milliseconds) before timing out of operations performed
        /// by DMS on a Redshift cluster, such as Redshift COPY, INSERT, DELETE, and UPDATE.
        /// </para>
        /// </summary>
        public int LoadTimeout
        {
            get { return this._loadTimeout.GetValueOrDefault(); }
            set { this._loadTimeout = value; }
        }

        // Check to see if LoadTimeout property is set
        internal bool IsSetLoadTimeout()
        {
            return this._loadTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapBooleanAsBoolean. 
        /// <para>
        /// When true, lets Redshift migrate the boolean type as boolean. By default, Redshift
        /// migrates booleans as <code>varchar(1)</code>.
        /// </para>
        /// </summary>
        public bool MapBooleanAsBoolean
        {
            get { return this._mapBooleanAsBoolean.GetValueOrDefault(); }
            set { this._mapBooleanAsBoolean = value; }
        }

        // Check to see if MapBooleanAsBoolean property is set
        internal bool IsSetMapBooleanAsBoolean()
        {
            return this._mapBooleanAsBoolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// The maximum size (in KB) of any .csv file used to load data on an S3 bucket and transfer
        /// data to Amazon Redshift. It defaults to 1048576KB (1 GB).
        /// </para>
        /// </summary>
        public int MaxFileSize
        {
            get { return this._maxFileSize.GetValueOrDefault(); }
            set { this._maxFileSize = value; }
        }

        // Check to see if MaxFileSize property is set
        internal bool IsSetMaxFileSize()
        {
            return this._maxFileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the user named in the <code>username</code> property.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for Amazon Redshift. The default value is 5439.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveQuotes. 
        /// <para>
        /// A value that specifies to remove surrounding quotation marks from strings in the incoming
        /// data. All characters within the quotation marks, including delimiters, are retained.
        /// Choose <code>true</code> to remove quotation marks. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool RemoveQuotes
        {
            get { return this._removeQuotes.GetValueOrDefault(); }
            set { this._removeQuotes = value; }
        }

        // Check to see if RemoveQuotes property is set
        internal bool IsSetRemoveQuotes()
        {
            return this._removeQuotes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplaceChars. 
        /// <para>
        /// A value that specifies to replaces the invalid characters specified in <code>ReplaceInvalidChars</code>,
        /// substituting the specified characters instead. The default is <code>"?"</code>.
        /// </para>
        /// </summary>
        public string ReplaceChars
        {
            get { return this._replaceChars; }
            set { this._replaceChars = value; }
        }

        // Check to see if ReplaceChars property is set
        internal bool IsSetReplaceChars()
        {
            return this._replaceChars != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceInvalidChars. 
        /// <para>
        /// A list of characters that you want to replace. Use with <code>ReplaceChars</code>.
        /// </para>
        /// </summary>
        public string ReplaceInvalidChars
        {
            get { return this._replaceInvalidChars; }
            set { this._replaceInvalidChars = value; }
        }

        // Check to see if ReplaceInvalidChars property is set
        internal bool IsSetReplaceInvalidChars()
        {
            return this._replaceInvalidChars != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <code>SecretsManagerSecret</code>.
        /// The role must allow the <code>iam:PassRole</code> action. <code>SecretsManagerSecret</code>
        /// has the value of the Amazon Web Services Secrets Manager secret that allows access
        /// to the Amazon Redshift endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <code>SecretsManagerSecretId</code>. Or you can specify
        /// clear-text values for <code>UserName</code>, <code>Password</code>, <code>ServerName</code>,
        /// and <code>Port</code>. You can't specify both. For more information on creating this
        /// <code>SecretsManagerSecret</code> and the <code>SecretsManagerAccessRoleArn</code>
        /// and <code>SecretsManagerSecretId</code> required to access it, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
        /// secrets to access Database Migration Service resources</a> in the <i>Database Migration
        /// Service User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SecretsManagerAccessRoleArn
        {
            get { return this._secretsManagerAccessRoleArn; }
            set { this._secretsManagerAccessRoleArn = value; }
        }

        // Check to see if SecretsManagerAccessRoleArn property is set
        internal bool IsSetSecretsManagerAccessRoleArn()
        {
            return this._secretsManagerAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <code>SecretsManagerSecret</code>
        /// that contains the Amazon Redshift endpoint connection details.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId
        {
            get { return this._secretsManagerSecretId; }
            set { this._secretsManagerSecretId = value; }
        }

        // Check to see if SecretsManagerSecretId property is set
        internal bool IsSetSecretsManagerSecretId()
        {
            return this._secretsManagerSecretId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the Amazon Redshift cluster you are using.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKmsKeyId. 
        /// <para>
        /// The KMS key ID. If you are using <code>SSE_KMS</code> for the <code>EncryptionMode</code>,
        /// provide this key ID. The key that you use needs an attached policy that enables IAM
        /// user permissions and allows use of the key.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionKmsKeyId
        {
            get { return this._serverSideEncryptionKmsKeyId; }
            set { this._serverSideEncryptionKmsKeyId = value; }
        }

        // Check to see if ServerSideEncryptionKmsKeyId property is set
        internal bool IsSetServerSideEncryptionKmsKeyId()
        {
            return this._serverSideEncryptionKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that has access to the Amazon Redshift
        /// service. The role must allow the <code>iam:PassRole</code> action.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimeFormat. 
        /// <para>
        /// The time format that you want to use. Valid values are <code>auto</code> (case-sensitive),
        /// <code>'timeformat_string'</code>, <code>'epochsecs'</code>, or <code>'epochmillisecs'</code>.
        /// It defaults to 10. Using <code>auto</code> recognizes most strings, even some that
        /// aren't supported when you use a time format string. 
        /// </para>
        ///  
        /// <para>
        /// If your date and time values use formats different from each other, set this parameter
        /// to <code>auto</code>. 
        /// </para>
        /// </summary>
        public string TimeFormat
        {
            get { return this._timeFormat; }
            set { this._timeFormat = value; }
        }

        // Check to see if TimeFormat property is set
        internal bool IsSetTimeFormat()
        {
            return this._timeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TrimBlanks. 
        /// <para>
        /// A value that specifies to remove the trailing white space characters from a VARCHAR
        /// string. This parameter applies only to columns with a VARCHAR data type. Choose <code>true</code>
        /// to remove unneeded white space. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool TrimBlanks
        {
            get { return this._trimBlanks.GetValueOrDefault(); }
            set { this._trimBlanks = value; }
        }

        // Check to see if TrimBlanks property is set
        internal bool IsSetTrimBlanks()
        {
            return this._trimBlanks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TruncateColumns. 
        /// <para>
        /// A value that specifies to truncate data in columns to the appropriate number of characters,
        /// so that the data fits in the column. This parameter applies only to columns with a
        /// VARCHAR or CHAR data type, and rows with a size of 4 MB or less. Choose <code>true</code>
        /// to truncate data. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool TruncateColumns
        {
            get { return this._truncateColumns.GetValueOrDefault(); }
            set { this._truncateColumns = value; }
        }

        // Check to see if TruncateColumns property is set
        internal bool IsSetTruncateColumns()
        {
            return this._truncateColumns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// An Amazon Redshift user name for a registered user.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property WriteBufferSize. 
        /// <para>
        /// The size (in KB) of the in-memory file write buffer used when generating .csv files
        /// on the local disk at the DMS replication instance. The default value is 1000 (buffer
        /// size is 1000KB).
        /// </para>
        /// </summary>
        public int WriteBufferSize
        {
            get { return this._writeBufferSize.GetValueOrDefault(); }
            set { this._writeBufferSize = value; }
        }

        // Check to see if WriteBufferSize property is set
        internal bool IsSetWriteBufferSize()
        {
            return this._writeBufferSize.HasValue; 
        }

    }
}