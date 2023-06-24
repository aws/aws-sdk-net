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
    /// Settings for exporting data to Amazon S3.
    /// </summary>
    public partial class S3Settings
    {
        private bool? _addColumnName;
        private bool? _addTrailingPaddingCharacter;
        private string _bucketFolder;
        private string _bucketName;
        private CannedAclForObjectsValue _cannedAclForObjects;
        private bool? _cdcInsertsAndUpdates;
        private bool? _cdcInsertsOnly;
        private int? _cdcMaxBatchInterval;
        private int? _cdcMinFileSize;
        private string _cdcPath;
        private CompressionTypeValue _compressionType;
        private string _csvDelimiter;
        private string _csvNoSupValue;
        private string _csvNullValue;
        private string _csvRowDelimiter;
        private DataFormatValue _dataFormat;
        private int? _dataPageSize;
        private DatePartitionDelimiterValue _datePartitionDelimiter;
        private bool? _datePartitionEnabled;
        private DatePartitionSequenceValue _datePartitionSequence;
        private string _datePartitionTimezone;
        private int? _dictPageSizeLimit;
        private bool? _enableStatistics;
        private EncodingTypeValue _encodingType;
        private EncryptionModeValue _encryptionMode;
        private string _expectedBucketOwner;
        private string _externalTableDefinition;
        private bool? _glueCatalogGeneration;
        private int? _ignoreHeaderRows;
        private bool? _includeOpForFullLoad;
        private int? _maxFileSize;
        private bool? _parquetTimestampInMillisecond;
        private ParquetVersionValue _parquetVersion;
        private bool? _preserveTransactions;
        private bool? _rfc4180;
        private int? _rowGroupLength;
        private string _serverSideEncryptionKmsKeyId;
        private string _serviceAccessRoleArn;
        private string _timestampColumnName;
        private bool? _useCsvNoSupValue;
        private bool? _useTaskStartTimeForFullLoadTimestamp;

        /// <summary>
        /// Gets and sets the property AddColumnName. 
        /// <para>
        /// An optional parameter that, when set to <code>true</code> or <code>y</code>, you can
        /// use to add column name information to the .csv output file.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>false</code>. Valid values are <code>true</code>, <code>false</code>,
        /// <code>y</code>, and <code>n</code>.
        /// </para>
        /// </summary>
        public bool AddColumnName
        {
            get { return this._addColumnName.GetValueOrDefault(); }
            set { this._addColumnName = value; }
        }

        // Check to see if AddColumnName property is set
        internal bool IsSetAddColumnName()
        {
            return this._addColumnName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AddTrailingPaddingCharacter. 
        /// <para>
        /// Use the S3 target endpoint setting <code>AddTrailingPaddingCharacter</code> to add
        /// padding on string data. The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool AddTrailingPaddingCharacter
        {
            get { return this._addTrailingPaddingCharacter.GetValueOrDefault(); }
            set { this._addTrailingPaddingCharacter = value; }
        }

        // Check to see if AddTrailingPaddingCharacter property is set
        internal bool IsSetAddTrailingPaddingCharacter()
        {
            return this._addTrailingPaddingCharacter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        ///  An optional parameter to set a folder name in the S3 bucket. If provided, tables
        /// are created in the path <code> <i>bucketFolder</i>/<i>schema_name</i>/<i>table_name</i>/</code>.
        /// If this parameter isn't specified, then the path used is <code> <i>schema_name</i>/<i>table_name</i>/</code>.
        /// 
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
        ///  The name of the S3 bucket. 
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
        /// Gets and sets the property CannedAclForObjects. 
        /// <para>
        /// A value that enables DMS to specify a predefined (canned) access control list for
        /// objects created in an Amazon S3 bucket as .csv or .parquet files. For more information
        /// about Amazon S3 canned ACLs, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned
        /// ACL</a> in the <i>Amazon S3 Developer Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// The default value is NONE. Valid values include NONE, PRIVATE, PUBLIC_READ, PUBLIC_READ_WRITE,
        /// AUTHENTICATED_READ, AWS_EXEC_READ, BUCKET_OWNER_READ, and BUCKET_OWNER_FULL_CONTROL.
        /// </para>
        /// </summary>
        public CannedAclForObjectsValue CannedAclForObjects
        {
            get { return this._cannedAclForObjects; }
            set { this._cannedAclForObjects = value; }
        }

        // Check to see if CannedAclForObjects property is set
        internal bool IsSetCannedAclForObjects()
        {
            return this._cannedAclForObjects != null;
        }

        /// <summary>
        /// Gets and sets the property CdcInsertsAndUpdates. 
        /// <para>
        /// A value that enables a change data capture (CDC) load to write INSERT and UPDATE operations
        /// to .csv or .parquet (columnar storage) output files. The default setting is <code>false</code>,
        /// but when <code>CdcInsertsAndUpdates</code> is set to <code>true</code> or <code>y</code>,
        /// only INSERTs and UPDATEs from the source database are migrated to the .csv or .parquet
        /// file. 
        /// </para>
        ///  
        /// <para>
        /// For .csv file format only, how these INSERTs and UPDATEs are recorded depends on the
        /// value of the <code>IncludeOpForFullLoad</code> parameter. If <code>IncludeOpForFullLoad</code>
        /// is set to <code>true</code>, the first field of every CDC record is set to either
        /// <code>I</code> or <code>U</code> to indicate INSERT and UPDATE operations at the source.
        /// But if <code>IncludeOpForFullLoad</code> is set to <code>false</code>, CDC records
        /// are written without an indication of INSERT or UPDATE operations at the source. For
        /// more information about how these settings work together, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring.InsertOps">Indicating
        /// Source DB Operations in Migrated S3 Data</a> in the <i>Database Migration Service
        /// User Guide.</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the use of the <code>CdcInsertsAndUpdates</code> parameter in versions
        /// 3.3.1 and later.
        /// </para>
        ///  
        /// <para>
        ///  <code>CdcInsertsOnly</code> and <code>CdcInsertsAndUpdates</code> can't both be set
        /// to <code>true</code> for the same endpoint. Set either <code>CdcInsertsOnly</code>
        /// or <code>CdcInsertsAndUpdates</code> to <code>true</code> for the same endpoint, but
        /// not both.
        /// </para>
        ///  </note>
        /// </summary>
        public bool CdcInsertsAndUpdates
        {
            get { return this._cdcInsertsAndUpdates.GetValueOrDefault(); }
            set { this._cdcInsertsAndUpdates = value; }
        }

        // Check to see if CdcInsertsAndUpdates property is set
        internal bool IsSetCdcInsertsAndUpdates()
        {
            return this._cdcInsertsAndUpdates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CdcInsertsOnly. 
        /// <para>
        /// A value that enables a change data capture (CDC) load to write only INSERT operations
        /// to .csv or columnar storage (.parquet) output files. By default (the <code>false</code>
        /// setting), the first field in a .csv or .parquet record contains the letter I (INSERT),
        /// U (UPDATE), or D (DELETE). These values indicate whether the row was inserted, updated,
        /// or deleted at the source database for a CDC load to the target.
        /// </para>
        ///  
        /// <para>
        /// If <code>CdcInsertsOnly</code> is set to <code>true</code> or <code>y</code>, only
        /// INSERTs from the source database are migrated to the .csv or .parquet file. For .csv
        /// format only, how these INSERTs are recorded depends on the value of <code>IncludeOpForFullLoad</code>.
        /// If <code>IncludeOpForFullLoad</code> is set to <code>true</code>, the first field
        /// of every CDC record is set to I to indicate the INSERT operation at the source. If
        /// <code>IncludeOpForFullLoad</code> is set to <code>false</code>, every CDC record is
        /// written without a first field to indicate the INSERT operation at the source. For
        /// more information about how these settings work together, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring.InsertOps">Indicating
        /// Source DB Operations in Migrated S3 Data</a> in the <i>Database Migration Service
        /// User Guide.</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the interaction described preceding between the <code>CdcInsertsOnly</code>
        /// and <code>IncludeOpForFullLoad</code> parameters in versions 3.1.4 and later. 
        /// </para>
        ///  
        /// <para>
        ///  <code>CdcInsertsOnly</code> and <code>CdcInsertsAndUpdates</code> can't both be set
        /// to <code>true</code> for the same endpoint. Set either <code>CdcInsertsOnly</code>
        /// or <code>CdcInsertsAndUpdates</code> to <code>true</code> for the same endpoint, but
        /// not both.
        /// </para>
        ///  </note>
        /// </summary>
        public bool CdcInsertsOnly
        {
            get { return this._cdcInsertsOnly.GetValueOrDefault(); }
            set { this._cdcInsertsOnly = value; }
        }

        // Check to see if CdcInsertsOnly property is set
        internal bool IsSetCdcInsertsOnly()
        {
            return this._cdcInsertsOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CdcMaxBatchInterval. 
        /// <para>
        /// Maximum length of the interval, defined in seconds, after which to output a file to
        /// Amazon S3.
        /// </para>
        ///  
        /// <para>
        /// When <code>CdcMaxBatchInterval</code> and <code>CdcMinFileSize</code> are both specified,
        /// the file write is triggered by whichever parameter condition is met first within an
        /// DMS CloudFormation template.
        /// </para>
        ///  
        /// <para>
        /// The default value is 60 seconds.
        /// </para>
        /// </summary>
        public int CdcMaxBatchInterval
        {
            get { return this._cdcMaxBatchInterval.GetValueOrDefault(); }
            set { this._cdcMaxBatchInterval = value; }
        }

        // Check to see if CdcMaxBatchInterval property is set
        internal bool IsSetCdcMaxBatchInterval()
        {
            return this._cdcMaxBatchInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CdcMinFileSize. 
        /// <para>
        /// Minimum file size, defined in kilobytes, to reach for a file output to Amazon S3.
        /// </para>
        ///  
        /// <para>
        /// When <code>CdcMinFileSize</code> and <code>CdcMaxBatchInterval</code> are both specified,
        /// the file write is triggered by whichever parameter condition is met first within an
        /// DMS CloudFormation template.
        /// </para>
        ///  
        /// <para>
        /// The default value is 32 MB.
        /// </para>
        /// </summary>
        public int CdcMinFileSize
        {
            get { return this._cdcMinFileSize.GetValueOrDefault(); }
            set { this._cdcMinFileSize = value; }
        }

        // Check to see if CdcMinFileSize property is set
        internal bool IsSetCdcMinFileSize()
        {
            return this._cdcMinFileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CdcPath. 
        /// <para>
        /// Specifies the folder path of CDC files. For an S3 source, this setting is required
        /// if a task captures change data; otherwise, it's optional. If <code>CdcPath</code>
        /// is set, DMS reads CDC files from this path and replicates the data changes to the
        /// target endpoint. For an S3 target if you set <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-PreserveTransactions">
        /// <code>PreserveTransactions</code> </a> to <code>true</code>, DMS verifies that you
        /// have set this parameter to a folder path on your S3 target where DMS can save the
        /// transaction order for the CDC load. DMS creates this CDC folder path in either your
        /// S3 target working directory or the S3 target location specified by <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-BucketFolder">
        /// <code>BucketFolder</code> </a> and <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-BucketName">
        /// <code>BucketName</code> </a>.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <code>CdcPath</code> as <code>MyChangedData</code>, and
        /// you specify <code>BucketName</code> as <code>MyTargetBucket</code> but do not specify
        /// <code>BucketFolder</code>, DMS creates the CDC folder path following: <code>MyTargetBucket/MyChangedData</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify the same <code>CdcPath</code>, and you specify <code>BucketName</code>
        /// as <code>MyTargetBucket</code> and <code>BucketFolder</code> as <code>MyTargetData</code>,
        /// DMS creates the CDC folder path following: <code>MyTargetBucket/MyTargetData/MyChangedData</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information on CDC including transaction order on an S3 target, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.EndpointSettings.CdcPath">Capturing
        /// data changes (CDC) including transaction order on the S3 target</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is supported in DMS versions 3.4.2 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public string CdcPath
        {
            get { return this._cdcPath; }
            set { this._cdcPath = value; }
        }

        // Check to see if CdcPath property is set
        internal bool IsSetCdcPath()
        {
            return this._cdcPath != null;
        }

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// An optional parameter to use GZIP to compress the target files. Set to GZIP to compress
        /// the target files. Either set this parameter to NONE (the default) or don't use it
        /// to leave the files uncompressed. This parameter applies to both .csv and .parquet
        /// file formats. 
        /// </para>
        /// </summary>
        public CompressionTypeValue CompressionType
        {
            get { return this._compressionType; }
            set { this._compressionType = value; }
        }

        // Check to see if CompressionType property is set
        internal bool IsSetCompressionType()
        {
            return this._compressionType != null;
        }

        /// <summary>
        /// Gets and sets the property CsvDelimiter. 
        /// <para>
        ///  The delimiter used to separate columns in the .csv file for both source and target.
        /// The default is a comma. 
        /// </para>
        /// </summary>
        public string CsvDelimiter
        {
            get { return this._csvDelimiter; }
            set { this._csvDelimiter = value; }
        }

        // Check to see if CsvDelimiter property is set
        internal bool IsSetCsvDelimiter()
        {
            return this._csvDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property CsvNoSupValue. 
        /// <para>
        /// This setting only applies if your Amazon S3 output files during a change data capture
        /// (CDC) load are written in .csv format. If <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-UseCsvNoSupValue">
        /// <code>UseCsvNoSupValue</code> </a> is set to true, specify a string value that you
        /// want DMS to use for all columns not included in the supplemental log. If you do not
        /// specify a string value, DMS uses the null value for these columns regardless of the
        /// <code>UseCsvNoSupValue</code> setting.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is supported in DMS versions 3.4.1 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public string CsvNoSupValue
        {
            get { return this._csvNoSupValue; }
            set { this._csvNoSupValue = value; }
        }

        // Check to see if CsvNoSupValue property is set
        internal bool IsSetCsvNoSupValue()
        {
            return this._csvNoSupValue != null;
        }

        /// <summary>
        /// Gets and sets the property CsvNullValue. 
        /// <para>
        /// An optional parameter that specifies how DMS treats null values. While handling the
        /// null value, you can use this parameter to pass a user-defined string as null when
        /// writing to the target. For example, when target columns are not nullable, you can
        /// use this option to differentiate between the empty string value and the null value.
        /// So, if you set this parameter value to the empty string ("" or ''), DMS treats the
        /// empty string as the null value instead of <code>NULL</code>.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>NULL</code>. Valid values include any valid string.
        /// </para>
        /// </summary>
        public string CsvNullValue
        {
            get { return this._csvNullValue; }
            set { this._csvNullValue = value; }
        }

        // Check to see if CsvNullValue property is set
        internal bool IsSetCsvNullValue()
        {
            return this._csvNullValue != null;
        }

        /// <summary>
        /// Gets and sets the property CsvRowDelimiter. 
        /// <para>
        ///  The delimiter used to separate rows in the .csv file for both source and target.
        /// The default is a carriage return (<code>\n</code>). 
        /// </para>
        /// </summary>
        public string CsvRowDelimiter
        {
            get { return this._csvRowDelimiter; }
            set { this._csvRowDelimiter = value; }
        }

        // Check to see if CsvRowDelimiter property is set
        internal bool IsSetCsvRowDelimiter()
        {
            return this._csvRowDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The format of the data that you want to use for output. You can choose one of the
        /// following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>csv</code> : This is a row-based file format with comma-separated values (.csv).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>parquet</code> : Apache Parquet (.parquet) is a columnar storage file format
        /// that features efficient compression and provides faster query response. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataFormatValue DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DataPageSize. 
        /// <para>
        /// The size of one data page in bytes. This parameter defaults to 1024 * 1024 bytes (1
        /// MiB). This number is used for .parquet file format only. 
        /// </para>
        /// </summary>
        public int DataPageSize
        {
            get { return this._dataPageSize.GetValueOrDefault(); }
            set { this._dataPageSize = value; }
        }

        // Check to see if DataPageSize property is set
        internal bool IsSetDataPageSize()
        {
            return this._dataPageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatePartitionDelimiter. 
        /// <para>
        /// Specifies a date separating delimiter to use during folder partitioning. The default
        /// value is <code>SLASH</code>. Use this parameter when <code>DatePartitionedEnabled</code>
        /// is set to <code>true</code>.
        /// </para>
        /// </summary>
        public DatePartitionDelimiterValue DatePartitionDelimiter
        {
            get { return this._datePartitionDelimiter; }
            set { this._datePartitionDelimiter = value; }
        }

        // Check to see if DatePartitionDelimiter property is set
        internal bool IsSetDatePartitionDelimiter()
        {
            return this._datePartitionDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property DatePartitionEnabled. 
        /// <para>
        /// When set to <code>true</code>, this parameter partitions S3 bucket folders based on
        /// transaction commit dates. The default value is <code>false</code>. For more information
        /// about date-based folder partitioning, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.DatePartitioning">Using
        /// date-based folder partitioning</a>.
        /// </para>
        /// </summary>
        public bool DatePartitionEnabled
        {
            get { return this._datePartitionEnabled.GetValueOrDefault(); }
            set { this._datePartitionEnabled = value; }
        }

        // Check to see if DatePartitionEnabled property is set
        internal bool IsSetDatePartitionEnabled()
        {
            return this._datePartitionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatePartitionSequence. 
        /// <para>
        /// Identifies the sequence of the date format to use during folder partitioning. The
        /// default value is <code>YYYYMMDD</code>. Use this parameter when <code>DatePartitionedEnabled</code>
        /// is set to <code>true</code>.
        /// </para>
        /// </summary>
        public DatePartitionSequenceValue DatePartitionSequence
        {
            get { return this._datePartitionSequence; }
            set { this._datePartitionSequence = value; }
        }

        // Check to see if DatePartitionSequence property is set
        internal bool IsSetDatePartitionSequence()
        {
            return this._datePartitionSequence != null;
        }

        /// <summary>
        /// Gets and sets the property DatePartitionTimezone. 
        /// <para>
        /// When creating an S3 target endpoint, set <code>DatePartitionTimezone</code> to convert
        /// the current UTC time into a specified time zone. The conversion occurs when a date
        /// partition folder is created and a CDC filename is generated. The time zone format
        /// is Area/Location. Use this parameter when <code>DatePartitionedEnabled</code> is set
        /// to <code>true</code>, as shown in the following example.
        /// </para>
        ///  
        /// <para>
        ///  <code>s3-settings='{"DatePartitionEnabled": true, "DatePartitionSequence": "YYYYMMDDHH",
        /// "DatePartitionDelimiter": "SLASH", "DatePartitionTimezone":"<i>Asia/Seoul</i>", "BucketName":
        /// "dms-nattarat-test"}'</code> 
        /// </para>
        /// </summary>
        public string DatePartitionTimezone
        {
            get { return this._datePartitionTimezone; }
            set { this._datePartitionTimezone = value; }
        }

        // Check to see if DatePartitionTimezone property is set
        internal bool IsSetDatePartitionTimezone()
        {
            return this._datePartitionTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property DictPageSizeLimit. 
        /// <para>
        /// The maximum size of an encoded dictionary page of a column. If the dictionary page
        /// exceeds this, this column is stored using an encoding type of <code>PLAIN</code>.
        /// This parameter defaults to 1024 * 1024 bytes (1 MiB), the maximum size of a dictionary
        /// page before it reverts to <code>PLAIN</code> encoding. This size is used for .parquet
        /// file format only. 
        /// </para>
        /// </summary>
        public int DictPageSizeLimit
        {
            get { return this._dictPageSizeLimit.GetValueOrDefault(); }
            set { this._dictPageSizeLimit = value; }
        }

        // Check to see if DictPageSizeLimit property is set
        internal bool IsSetDictPageSizeLimit()
        {
            return this._dictPageSizeLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableStatistics. 
        /// <para>
        /// A value that enables statistics for Parquet pages and row groups. Choose <code>true</code>
        /// to enable statistics, <code>false</code> to disable. Statistics include <code>NULL</code>,
        /// <code>DISTINCT</code>, <code>MAX</code>, and <code>MIN</code> values. This parameter
        /// defaults to <code>true</code>. This value is used for .parquet file format only.
        /// </para>
        /// </summary>
        public bool EnableStatistics
        {
            get { return this._enableStatistics.GetValueOrDefault(); }
            set { this._enableStatistics = value; }
        }

        // Check to see if EnableStatistics property is set
        internal bool IsSetEnableStatistics()
        {
            return this._enableStatistics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncodingType. 
        /// <para>
        /// The type of encoding you are using: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RLE_DICTIONARY</code> uses a combination of bit-packing and run-length encoding
        /// to store repeated values more efficiently. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PLAIN</code> doesn't use encoding at all. Values are stored as they are.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PLAIN_DICTIONARY</code> builds a dictionary of the values encountered in a
        /// given column. The dictionary is stored in a dictionary page for each column chunk.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncodingTypeValue EncodingType
        {
            get { return this._encodingType; }
            set { this._encodingType = value; }
        }

        // Check to see if EncodingType property is set
        internal bool IsSetEncodingType()
        {
            return this._encodingType != null;
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
        /// To use <code>SSE_S3</code>, you need an Identity and Access Management (IAM) role
        /// with permission to allow <code>"arn:aws:s3:::dms-*"</code> to use the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>s3:CreateBucket</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:ListBucket</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:DeleteBucket</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:GetBucketLocation</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:GetObject</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:PutObject</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:DeleteObject</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:GetObjectVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:GetBucketPolicy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:PutBucketPolicy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:DeleteBucketPolicy</code> 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// To specify a bucket owner and prevent sniping, you can use the <code>ExpectedBucketOwner</code>
        /// endpoint setting. 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>--s3-settings='{"ExpectedBucketOwner": "<i>AWS_Account_ID</i>"}'</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// When you make a request to test a connection or perform a migration, S3 checks the
        /// account ID of the bucket owner against the specified parameter.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalTableDefinition. 
        /// <para>
        ///  Specifies how tables are defined in the S3 source files only. 
        /// </para>
        /// </summary>
        public string ExternalTableDefinition
        {
            get { return this._externalTableDefinition; }
            set { this._externalTableDefinition = value; }
        }

        // Check to see if ExternalTableDefinition property is set
        internal bool IsSetExternalTableDefinition()
        {
            return this._externalTableDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property GlueCatalogGeneration. 
        /// <para>
        /// When true, allows Glue to catalog your S3 bucket. Creating an Glue catalog lets you
        /// use Athena to query your data.
        /// </para>
        /// </summary>
        public bool GlueCatalogGeneration
        {
            get { return this._glueCatalogGeneration.GetValueOrDefault(); }
            set { this._glueCatalogGeneration = value; }
        }

        // Check to see if GlueCatalogGeneration property is set
        internal bool IsSetGlueCatalogGeneration()
        {
            return this._glueCatalogGeneration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnoreHeaderRows. 
        /// <para>
        /// When this value is set to 1, DMS ignores the first row header in a .csv file. A value
        /// of 1 turns on the feature; a value of 0 turns off the feature.
        /// </para>
        ///  
        /// <para>
        /// The default is 0.
        /// </para>
        /// </summary>
        public int IgnoreHeaderRows
        {
            get { return this._ignoreHeaderRows.GetValueOrDefault(); }
            set { this._ignoreHeaderRows = value; }
        }

        // Check to see if IgnoreHeaderRows property is set
        internal bool IsSetIgnoreHeaderRows()
        {
            return this._ignoreHeaderRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeOpForFullLoad. 
        /// <para>
        /// A value that enables a full load to write INSERT operations to the comma-separated
        /// value (.csv) output files only to indicate how the rows were added to the source database.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <code>IncludeOpForFullLoad</code> parameter in versions 3.1.4 and
        /// later.
        /// </para>
        ///  </note> 
        /// <para>
        /// For full load, records can only be inserted. By default (the <code>false</code> setting),
        /// no information is recorded in these output files for a full load to indicate that
        /// the rows were inserted at the source database. If <code>IncludeOpForFullLoad</code>
        /// is set to <code>true</code> or <code>y</code>, the INSERT is recorded as an I annotation
        /// in the first field of the .csv file. This allows the format of your target records
        /// from a full load to be consistent with the target records from a CDC load.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting works together with the <code>CdcInsertsOnly</code> and the <code>CdcInsertsAndUpdates</code>
        /// parameters for output to .csv files only. For more information about how these settings
        /// work together, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring.InsertOps">Indicating
        /// Source DB Operations in Migrated S3 Data</a> in the <i>Database Migration Service
        /// User Guide.</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool IncludeOpForFullLoad
        {
            get { return this._includeOpForFullLoad.GetValueOrDefault(); }
            set { this._includeOpForFullLoad = value; }
        }

        // Check to see if IncludeOpForFullLoad property is set
        internal bool IsSetIncludeOpForFullLoad()
        {
            return this._includeOpForFullLoad.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// A value that specifies the maximum size (in KB) of any .csv file to be created while
        /// migrating to an S3 target during full load.
        /// </para>
        ///  
        /// <para>
        /// The default value is 1,048,576 KB (1 GB). Valid values include 1 to 1,048,576.
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
        /// Gets and sets the property ParquetTimestampInMillisecond. 
        /// <para>
        /// A value that specifies the precision of any <code>TIMESTAMP</code> column values that
        /// are written to an Amazon S3 object file in .parquet format.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <code>ParquetTimestampInMillisecond</code> parameter in versions
        /// 3.1.4 and later.
        /// </para>
        ///  </note> 
        /// <para>
        /// When <code>ParquetTimestampInMillisecond</code> is set to <code>true</code> or <code>y</code>,
        /// DMS writes all <code>TIMESTAMP</code> columns in a .parquet formatted file with millisecond
        /// precision. Otherwise, DMS writes them with microsecond precision.
        /// </para>
        ///  
        /// <para>
        /// Currently, Amazon Athena and Glue can handle only millisecond precision for <code>TIMESTAMP</code>
        /// values. Set this parameter to <code>true</code> for S3 endpoint object files that
        /// are .parquet formatted only if you plan to query or process the data with Athena or
        /// Glue.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS writes any <code>TIMESTAMP</code> column values written to an S3 file in .csv
        /// format with microsecond precision.
        /// </para>
        ///  
        /// <para>
        /// Setting <code>ParquetTimestampInMillisecond</code> has no effect on the string format
        /// of the timestamp column value that is inserted by setting the <code>TimestampColumnName</code>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public bool ParquetTimestampInMillisecond
        {
            get { return this._parquetTimestampInMillisecond.GetValueOrDefault(); }
            set { this._parquetTimestampInMillisecond = value; }
        }

        // Check to see if ParquetTimestampInMillisecond property is set
        internal bool IsSetParquetTimestampInMillisecond()
        {
            return this._parquetTimestampInMillisecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParquetVersion. 
        /// <para>
        /// The version of the Apache Parquet format that you want to use: <code>parquet_1_0</code>
        /// (the default) or <code>parquet_2_0</code>.
        /// </para>
        /// </summary>
        public ParquetVersionValue ParquetVersion
        {
            get { return this._parquetVersion; }
            set { this._parquetVersion = value; }
        }

        // Check to see if ParquetVersion property is set
        internal bool IsSetParquetVersion()
        {
            return this._parquetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveTransactions. 
        /// <para>
        /// If set to <code>true</code>, DMS saves the transaction order for a change data capture
        /// (CDC) load on the Amazon S3 target specified by <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-CdcPath">
        /// <code>CdcPath</code> </a>. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.EndpointSettings.CdcPath">Capturing
        /// data changes (CDC) including transaction order on the S3 target</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is supported in DMS versions 3.4.2 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public bool PreserveTransactions
        {
            get { return this._preserveTransactions.GetValueOrDefault(); }
            set { this._preserveTransactions = value; }
        }

        // Check to see if PreserveTransactions property is set
        internal bool IsSetPreserveTransactions()
        {
            return this._preserveTransactions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rfc4180. 
        /// <para>
        /// For an S3 source, when this value is set to <code>true</code> or <code>y</code>, each
        /// leading double quotation mark has to be followed by an ending double quotation mark.
        /// This formatting complies with RFC 4180. When this value is set to <code>false</code>
        /// or <code>n</code>, string literals are copied to the target as is. In this case, a
        /// delimiter (row or column) signals the end of the field. Thus, you can't use a delimiter
        /// as part of the string, because it signals the end of the value.
        /// </para>
        ///  
        /// <para>
        /// For an S3 target, an optional parameter used to set behavior to comply with RFC 4180
        /// for data migrated to Amazon S3 using .csv file format only. When this value is set
        /// to <code>true</code> or <code>y</code> using Amazon S3 as a target, if the data has
        /// quotation marks or newline characters in it, DMS encloses the entire column with an
        /// additional pair of double quotation marks ("). Every quotation mark within the data
        /// is repeated twice.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>true</code>. Valid values include <code>true</code>, <code>false</code>,
        /// <code>y</code>, and <code>n</code>.
        /// </para>
        /// </summary>
        public bool Rfc4180
        {
            get { return this._rfc4180.GetValueOrDefault(); }
            set { this._rfc4180 = value; }
        }

        // Check to see if Rfc4180 property is set
        internal bool IsSetRfc4180()
        {
            return this._rfc4180.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RowGroupLength. 
        /// <para>
        /// The number of rows in a row group. A smaller row group size provides faster reads.
        /// But as the number of row groups grows, the slower writes become. This parameter defaults
        /// to 10,000 rows. This number is used for .parquet file format only. 
        /// </para>
        ///  
        /// <para>
        /// If you choose a value larger than the maximum, <code>RowGroupLength</code> is set
        /// to the max row group length in bytes (64 * 1024 * 1024). 
        /// </para>
        /// </summary>
        public int RowGroupLength
        {
            get { return this._rowGroupLength.GetValueOrDefault(); }
            set { this._rowGroupLength = value; }
        }

        // Check to see if RowGroupLength property is set
        internal bool IsSetRowGroupLength()
        {
            return this._rowGroupLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKmsKeyId. 
        /// <para>
        /// If you are using <code>SSE_KMS</code> for the <code>EncryptionMode</code>, provide
        /// the KMS key ID. The key that you use needs an attached policy that enables Identity
        /// and Access Management (IAM) user permissions and allows use of the key.
        /// </para>
        ///  
        /// <para>
        /// Here is a CLI example: <code>aws dms create-endpoint --endpoint-identifier <i>value</i>
        /// --endpoint-type target --engine-name s3 --s3-settings ServiceAccessRoleArn=<i>value</i>,BucketFolder=<i>value</i>,BucketName=<i>value</i>,EncryptionMode=SSE_KMS,ServerSideEncryptionKmsKeyId=<i>value</i>
        /// </code> 
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
        ///  The Amazon Resource Name (ARN) used by the service to access the IAM role. The role
        /// must allow the <code>iam:PassRole</code> action. It is a required parameter that enables
        /// DMS to write and read objects from an S3 bucket.
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
        /// Gets and sets the property TimestampColumnName. 
        /// <para>
        /// A value that when nonblank causes DMS to add a column with timestamp information to
        /// the endpoint data for an Amazon S3 target.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <code>TimestampColumnName</code> parameter in versions 3.1.4 and
        /// later.
        /// </para>
        ///  </note> 
        /// <para>
        /// DMS includes an additional <code>STRING</code> column in the .csv or .parquet object
        /// files of your migrated data when you set <code>TimestampColumnName</code> to a nonblank
        /// value.
        /// </para>
        ///  
        /// <para>
        /// For a full load, each row of this timestamp column contains a timestamp for when the
        /// data was transferred from the source to the target by DMS. 
        /// </para>
        ///  
        /// <para>
        /// For a change data capture (CDC) load, each row of the timestamp column contains the
        /// timestamp for the commit of that row in the source database.
        /// </para>
        ///  
        /// <para>
        /// The string format for this timestamp column value is <code>yyyy-MM-dd HH:mm:ss.SSSSSS</code>.
        /// By default, the precision of this value is in microseconds. For a CDC load, the rounding
        /// of the precision depends on the commit timestamp supported by DMS for the source database.
        /// </para>
        ///  
        /// <para>
        /// When the <code>AddColumnName</code> parameter is set to <code>true</code>, DMS also
        /// includes a name for the timestamp column that you set with <code>TimestampColumnName</code>.
        /// </para>
        /// </summary>
        public string TimestampColumnName
        {
            get { return this._timestampColumnName; }
            set { this._timestampColumnName = value; }
        }

        // Check to see if TimestampColumnName property is set
        internal bool IsSetTimestampColumnName()
        {
            return this._timestampColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property UseCsvNoSupValue. 
        /// <para>
        /// This setting applies if the S3 output files during a change data capture (CDC) load
        /// are written in .csv format. If set to <code>true</code> for columns not included in
        /// the supplemental log, DMS uses the value specified by <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-CsvNoSupValue">
        /// <code>CsvNoSupValue</code> </a>. If not set or set to <code>false</code>, DMS uses
        /// the null value for these columns.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is supported in DMS versions 3.4.1 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public bool UseCsvNoSupValue
        {
            get { return this._useCsvNoSupValue.GetValueOrDefault(); }
            set { this._useCsvNoSupValue = value; }
        }

        // Check to see if UseCsvNoSupValue property is set
        internal bool IsSetUseCsvNoSupValue()
        {
            return this._useCsvNoSupValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseTaskStartTimeForFullLoadTimestamp. 
        /// <para>
        /// When set to true, this parameter uses the task start time as the timestamp column
        /// value instead of the time data is written to target. For full load, when <code>useTaskStartTimeForFullLoadTimestamp</code>
        /// is set to <code>true</code>, each row of the timestamp column contains the task start
        /// time. For CDC loads, each row of the timestamp column contains the transaction commit
        /// time.
        /// </para>
        ///  
        /// <para>
        /// When <code>useTaskStartTimeForFullLoadTimestamp</code> is set to <code>false</code>,
        /// the full load timestamp in the timestamp column increments with the time data arrives
        /// at the target. 
        /// </para>
        /// </summary>
        public bool UseTaskStartTimeForFullLoadTimestamp
        {
            get { return this._useTaskStartTimeForFullLoadTimestamp.GetValueOrDefault(); }
            set { this._useTaskStartTimeForFullLoadTimestamp = value; }
        }

        // Check to see if UseTaskStartTimeForFullLoadTimestamp property is set
        internal bool IsSetUseTaskStartTimeForFullLoadTimestamp()
        {
            return this._useTaskStartTimeForFullLoadTimestamp.HasValue; 
        }

    }
}