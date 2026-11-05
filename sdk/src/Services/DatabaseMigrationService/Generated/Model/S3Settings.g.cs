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
    /// Settings for exporting data to Amazon S3.
    /// </summary>
    public partial class S3Settings
    {
        /// <summary>
        /// Gets and sets the property AddColumnName. 
        /// <para>
        /// An optional parameter that, when set to <c>true</c> or <c>y</c>, you can use to add
        /// column name information to the .csv output file.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>. Valid values are <c>true</c>, <c>false</c>, <c>y</c>,
        /// and <c>n</c>.
        /// </para>
        /// </summary>
        public bool? AddColumnName { get; set; }

        /// <summary>
        /// Checks to see if the AddColumnName property is set.
        /// </summary>
        internal bool IsSetAddColumnName() => this.AddColumnName.HasValue;

        /// <summary>
        /// Gets and sets the property AddTrailingPaddingCharacter. 
        /// <para>
        /// Use the S3 target endpoint setting <c>AddTrailingPaddingCharacter</c> to add padding
        /// on string data. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? AddTrailingPaddingCharacter { get; set; }

        /// <summary>
        /// Checks to see if the AddTrailingPaddingCharacter property is set.
        /// </summary>
        internal bool IsSetAddTrailingPaddingCharacter() => this.AddTrailingPaddingCharacter.HasValue;

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        ///  An optional parameter to set a folder name in the S3 bucket. If provided, tables
        /// are created in the path <c> <i>bucketFolder</i>/<i>schema_name</i>/<i>table_name</i>/</c>.
        /// If this parameter isn't specified, then the path used is <c> <i>schema_name</i>/<i>table_name</i>/</c>.
        /// 
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
        ///  The name of the S3 bucket. 
        /// </para>
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

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
        public CannedAclForObjectsValue CannedAclForObjects { get; set; }

        /// <summary>
        /// Checks to see if the CannedAclForObjects property is set.
        /// </summary>
        internal bool IsSetCannedAclForObjects() => this.CannedAclForObjects != null;

        /// <summary>
        /// Gets and sets the property CdcInsertsAndUpdates. 
        /// <para>
        /// A value that enables a change data capture (CDC) load to write INSERT and UPDATE operations
        /// to .csv or .parquet (columnar storage) output files. The default setting is <c>false</c>,
        /// but when <c>CdcInsertsAndUpdates</c> is set to <c>true</c> or <c>y</c>, only INSERTs
        /// and UPDATEs from the source database are migrated to the .csv or .parquet file.
        /// </para>
        ///  <important> 
        /// <para>
        /// DMS supports the use of the .parquet files in versions 3.4.7 and later.
        /// </para>
        ///  </important> 
        /// <para>
        /// How these INSERTs and UPDATEs are recorded depends on the value of the <c>IncludeOpForFullLoad</c>
        /// parameter. If <c>IncludeOpForFullLoad</c> is set to <c>true</c>, the first field of
        /// every CDC record is set to either <c>I</c> or <c>U</c> to indicate INSERT and UPDATE
        /// operations at the source. But if <c>IncludeOpForFullLoad</c> is set to <c>false</c>,
        /// CDC records are written without an indication of INSERT or UPDATE operations at the
        /// source. For more information about how these settings work together, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring.InsertOps">Indicating
        /// Source DB Operations in Migrated S3 Data</a> in the <i>Database Migration Service
        /// User Guide.</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the use of the <c>CdcInsertsAndUpdates</c> parameter in versions 3.3.1
        /// and later.
        /// </para>
        ///  
        /// <para>
        ///  <c>CdcInsertsOnly</c> and <c>CdcInsertsAndUpdates</c> can't both be set to <c>true</c>
        /// for the same endpoint. Set either <c>CdcInsertsOnly</c> or <c>CdcInsertsAndUpdates</c>
        /// to <c>true</c> for the same endpoint, but not both.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? CdcInsertsAndUpdates { get; set; }

        /// <summary>
        /// Checks to see if the CdcInsertsAndUpdates property is set.
        /// </summary>
        internal bool IsSetCdcInsertsAndUpdates() => this.CdcInsertsAndUpdates.HasValue;

        /// <summary>
        /// Gets and sets the property CdcInsertsOnly. 
        /// <para>
        /// A value that enables a change data capture (CDC) load to write only INSERT operations
        /// to .csv or columnar storage (.parquet) output files. By default (the <c>false</c>
        /// setting), the first field in a .csv or .parquet record contains the letter I (INSERT),
        /// U (UPDATE), or D (DELETE). These values indicate whether the row was inserted, updated,
        /// or deleted at the source database for a CDC load to the target.
        /// </para>
        ///  
        /// <para>
        /// If <c>CdcInsertsOnly</c> is set to <c>true</c> or <c>y</c>, only INSERTs from the
        /// source database are migrated to the .csv or .parquet file. For .csv format only, how
        /// these INSERTs are recorded depends on the value of <c>IncludeOpForFullLoad</c>. If
        /// <c>IncludeOpForFullLoad</c> is set to <c>true</c>, the first field of every CDC record
        /// is set to I to indicate the INSERT operation at the source. If <c>IncludeOpForFullLoad</c>
        /// is set to <c>false</c>, every CDC record is written without a first field to indicate
        /// the INSERT operation at the source. For more information about how these settings
        /// work together, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring.InsertOps">Indicating
        /// Source DB Operations in Migrated S3 Data</a> in the <i>Database Migration Service
        /// User Guide.</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the interaction described preceding between the <c>CdcInsertsOnly</c>
        /// and <c>IncludeOpForFullLoad</c> parameters in versions 3.1.4 and later. 
        /// </para>
        ///  
        /// <para>
        ///  <c>CdcInsertsOnly</c> and <c>CdcInsertsAndUpdates</c> can't both be set to <c>true</c>
        /// for the same endpoint. Set either <c>CdcInsertsOnly</c> or <c>CdcInsertsAndUpdates</c>
        /// to <c>true</c> for the same endpoint, but not both.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? CdcInsertsOnly { get; set; }

        /// <summary>
        /// Checks to see if the CdcInsertsOnly property is set.
        /// </summary>
        internal bool IsSetCdcInsertsOnly() => this.CdcInsertsOnly.HasValue;

        /// <summary>
        /// Gets and sets the property CdcMaxBatchInterval. 
        /// <para>
        /// Maximum length of the interval, defined in seconds, after which to output a file to
        /// Amazon S3.
        /// </para>
        ///  
        /// <para>
        /// When <c>CdcMaxBatchInterval</c> and <c>CdcMinFileSize</c> are both specified, the
        /// file write is triggered by whichever parameter condition is met first within an DMS
        /// CloudFormation template.
        /// </para>
        ///  
        /// <para>
        /// The default value is 60 seconds.
        /// </para>
        /// </summary>
        public int? CdcMaxBatchInterval { get; set; }

        /// <summary>
        /// Checks to see if the CdcMaxBatchInterval property is set.
        /// </summary>
        internal bool IsSetCdcMaxBatchInterval() => this.CdcMaxBatchInterval.HasValue;

        /// <summary>
        /// Gets and sets the property CdcMinFileSize. 
        /// <para>
        /// Minimum file size, defined in kilobytes, to reach for a file output to Amazon S3.
        /// </para>
        ///  
        /// <para>
        /// When <c>CdcMinFileSize</c> and <c>CdcMaxBatchInterval</c> are both specified, the
        /// file write is triggered by whichever parameter condition is met first within an DMS
        /// CloudFormation template.
        /// </para>
        ///  
        /// <para>
        /// The default value is 32 MB.
        /// </para>
        /// </summary>
        public int? CdcMinFileSize { get; set; }

        /// <summary>
        /// Checks to see if the CdcMinFileSize property is set.
        /// </summary>
        internal bool IsSetCdcMinFileSize() => this.CdcMinFileSize.HasValue;

        /// <summary>
        /// Gets and sets the property CdcPath. 
        /// <para>
        /// Specifies the folder path of CDC files. For an S3 source, this setting is required
        /// if a task captures change data; otherwise, it's optional. If <c>CdcPath</c> is set,
        /// DMS reads CDC files from this path and replicates the data changes to the target endpoint.
        /// For an S3 target if you set <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-PreserveTransactions">
        /// <c>PreserveTransactions</c> </a> to <c>true</c>, DMS verifies that you have set this
        /// parameter to a folder path on your S3 target where DMS can save the transaction order
        /// for the CDC load. DMS creates this CDC folder path in either your S3 target working
        /// directory or the S3 target location specified by <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-BucketFolder">
        /// <c>BucketFolder</c> </a> and <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-BucketName">
        /// <c>BucketName</c> </a>.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>CdcPath</c> as <c>MyChangedData</c>, and you specify
        /// <c>BucketName</c> as <c>MyTargetBucket</c> but do not specify <c>BucketFolder</c>,
        /// DMS creates the CDC folder path following: <c>MyTargetBucket/MyChangedData</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify the same <c>CdcPath</c>, and you specify <c>BucketName</c> as <c>MyTargetBucket</c>
        /// and <c>BucketFolder</c> as <c>MyTargetData</c>, DMS creates the CDC folder path following:
        /// <c>MyTargetBucket/MyTargetData/MyChangedData</c>.
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
        public string CdcPath { get; set; }

        /// <summary>
        /// Checks to see if the CdcPath property is set.
        /// </summary>
        internal bool IsSetCdcPath() => this.CdcPath != null;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// An optional parameter to use GZIP to compress the target files. Set to GZIP to compress
        /// the target files. Either set this parameter to NONE (the default) or don't use it
        /// to leave the files uncompressed. This parameter applies to both .csv and .parquet
        /// file formats. 
        /// </para>
        /// </summary>
        public CompressionTypeValue CompressionType { get; set; }

        /// <summary>
        /// Checks to see if the CompressionType property is set.
        /// </summary>
        internal bool IsSetCompressionType() => this.CompressionType != null;

        /// <summary>
        /// Gets and sets the property CsvDelimiter. 
        /// <para>
        ///  The delimiter used to separate columns in the .csv file for both source and target.
        /// The default is a comma. 
        /// </para>
        /// </summary>
        public string CsvDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the CsvDelimiter property is set.
        /// </summary>
        internal bool IsSetCsvDelimiter() => this.CsvDelimiter != null;

        /// <summary>
        /// Gets and sets the property CsvNoSupValue. 
        /// <para>
        /// This setting only applies if your Amazon S3 output files during a change data capture
        /// (CDC) load are written in .csv format. If <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-UseCsvNoSupValue">
        /// <c>UseCsvNoSupValue</c> </a> is set to true, specify a string value that you want
        /// DMS to use for all columns not included in the supplemental log. If you do not specify
        /// a string value, DMS uses the null value for these columns regardless of the <c>UseCsvNoSupValue</c>
        /// setting.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is supported in DMS versions 3.4.1 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public string CsvNoSupValue { get; set; }

        /// <summary>
        /// Checks to see if the CsvNoSupValue property is set.
        /// </summary>
        internal bool IsSetCsvNoSupValue() => this.CsvNoSupValue != null;

        /// <summary>
        /// Gets and sets the property CsvNullValue. 
        /// <para>
        /// An optional parameter that specifies how DMS treats null values. While handling the
        /// null value, you can use this parameter to pass a user-defined string as null when
        /// writing to the target. For example, when target columns are nullable, you can use
        /// this option to differentiate between the empty string value and the null value. So,
        /// if you set this parameter value to the empty string ("" or ''), DMS treats the empty
        /// string as the null value instead of <c>NULL</c>.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>NULL</c>. Valid values include any valid string.
        /// </para>
        /// </summary>
        public string CsvNullValue { get; set; }

        /// <summary>
        /// Checks to see if the CsvNullValue property is set.
        /// </summary>
        internal bool IsSetCsvNullValue() => this.CsvNullValue != null;

        /// <summary>
        /// Gets and sets the property CsvRowDelimiter. 
        /// <para>
        ///  The delimiter used to separate rows in the .csv file for both source and target.
        /// The default is a carriage return (<c>\n</c>). 
        /// </para>
        /// </summary>
        public string CsvRowDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the CsvRowDelimiter property is set.
        /// </summary>
        internal bool IsSetCsvRowDelimiter() => this.CsvRowDelimiter != null;

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The format of the data that you want to use for output. You can choose one of the
        /// following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>csv</c> : This is a row-based file format with comma-separated values (.csv).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>parquet</c> : Apache Parquet (.parquet) is a columnar storage file format that
        /// features efficient compression and provides faster query response. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataFormatValue DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

        /// <summary>
        /// Gets and sets the property DataPageSize. 
        /// <para>
        /// The size of one data page in bytes. This parameter defaults to 1024 * 1024 bytes (1
        /// MiB). This number is used for .parquet file format only. 
        /// </para>
        /// </summary>
        public int? DataPageSize { get; set; }

        /// <summary>
        /// Checks to see if the DataPageSize property is set.
        /// </summary>
        internal bool IsSetDataPageSize() => this.DataPageSize.HasValue;

        /// <summary>
        /// Gets and sets the property DatePartitionDelimiter. 
        /// <para>
        /// Specifies a date separating delimiter to use during folder partitioning. The default
        /// value is <c>SLASH</c>. Use this parameter when <c>DatePartitionedEnabled</c> is set
        /// to <c>true</c>.
        /// </para>
        /// </summary>
        public DatePartitionDelimiterValue DatePartitionDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the DatePartitionDelimiter property is set.
        /// </summary>
        internal bool IsSetDatePartitionDelimiter() => this.DatePartitionDelimiter != null;

        /// <summary>
        /// Gets and sets the property DatePartitionEnabled. 
        /// <para>
        /// When set to <c>true</c>, this parameter partitions S3 bucket folders based on transaction
        /// commit dates. The default value is <c>false</c>. For more information about date-based
        /// folder partitioning, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.DatePartitioning">Using
        /// date-based folder partitioning</a>.
        /// </para>
        /// </summary>
        public bool? DatePartitionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DatePartitionEnabled property is set.
        /// </summary>
        internal bool IsSetDatePartitionEnabled() => this.DatePartitionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DatePartitionSequence. 
        /// <para>
        /// Identifies the sequence of the date format to use during folder partitioning. The
        /// default value is <c>YYYYMMDD</c>. Use this parameter when <c>DatePartitionedEnabled</c>
        /// is set to <c>true</c>.
        /// </para>
        /// </summary>
        public DatePartitionSequenceValue DatePartitionSequence { get; set; }

        /// <summary>
        /// Checks to see if the DatePartitionSequence property is set.
        /// </summary>
        internal bool IsSetDatePartitionSequence() => this.DatePartitionSequence != null;

        /// <summary>
        /// Gets and sets the property DatePartitionTimezone. 
        /// <para>
        /// When creating an S3 target endpoint, set <c>DatePartitionTimezone</c> to convert the
        /// current UTC time into a specified time zone. The conversion occurs when a date partition
        /// folder is created and a CDC filename is generated. The time zone format is Area/Location.
        /// Use this parameter when <c>DatePartitionedEnabled</c> is set to true, as shown in
        /// the following example:
        /// </para>
        ///  
        /// <para>
        ///  <c>s3-settings='{"DatePartitionEnabled": true, "DatePartitionSequence": "YYYYMMDDHH",
        /// "DatePartitionDelimiter": "SLASH", "DatePartitionTimezone":"Asia/Seoul", "BucketName":
        /// "dms-nattarat-test"}'</c> 
        /// </para>
        /// </summary>
        public string DatePartitionTimezone { get; set; }

        /// <summary>
        /// Checks to see if the DatePartitionTimezone property is set.
        /// </summary>
        internal bool IsSetDatePartitionTimezone() => this.DatePartitionTimezone != null;

        /// <summary>
        /// Gets and sets the property DictPageSizeLimit. 
        /// <para>
        /// The maximum size of an encoded dictionary page of a column. If the dictionary page
        /// exceeds this, this column is stored using an encoding type of <c>PLAIN</c>. This parameter
        /// defaults to 1024 * 1024 bytes (1 MiB), the maximum size of a dictionary page before
        /// it reverts to <c>PLAIN</c> encoding. This size is used for .parquet file format only.
        /// 
        /// </para>
        /// </summary>
        public int? DictPageSizeLimit { get; set; }

        /// <summary>
        /// Checks to see if the DictPageSizeLimit property is set.
        /// </summary>
        internal bool IsSetDictPageSizeLimit() => this.DictPageSizeLimit.HasValue;

        /// <summary>
        /// Gets and sets the property EnableStatistics. 
        /// <para>
        /// A value that enables statistics for Parquet pages and row groups. Choose <c>true</c>
        /// to enable statistics, <c>false</c> to disable. Statistics include <c>NULL</c>, <c>DISTINCT</c>,
        /// <c>MAX</c>, and <c>MIN</c> values. This parameter defaults to <c>true</c>. This value
        /// is used for .parquet file format only.
        /// </para>
        /// </summary>
        public bool? EnableStatistics { get; set; }

        /// <summary>
        /// Checks to see if the EnableStatistics property is set.
        /// </summary>
        internal bool IsSetEnableStatistics() => this.EnableStatistics.HasValue;

        /// <summary>
        /// Gets and sets the property EncodingType. 
        /// <para>
        /// The type of encoding you are using: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RLE_DICTIONARY</c> uses a combination of bit-packing and run-length encoding to
        /// store repeated values more efficiently. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLAIN</c> doesn't use encoding at all. Values are stored as they are.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLAIN_DICTIONARY</c> builds a dictionary of the values encountered in a given
        /// column. The dictionary is stored in a dictionary page for each column chunk.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncodingTypeValue EncodingType { get; set; }

        /// <summary>
        /// Checks to see if the EncodingType property is set.
        /// </summary>
        internal bool IsSetEncodingType() => this.EncodingType != null;

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
        /// To use <c>SSE_S3</c>, you need an Identity and Access Management (IAM) role with permission
        /// to allow <c>"arn:aws:s3:::dms-*"</c> to use the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3:CreateBucket</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:ListBucket</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:DeleteBucket</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:GetBucketLocation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:GetObject</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:PutObject</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:DeleteObject</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:GetObjectVersion</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:GetBucketPolicy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:PutBucketPolicy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:DeleteBucketPolicy</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncryptionModeValue EncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMode property is set.
        /// </summary>
        internal bool IsSetEncryptionMode() => this.EncryptionMode != null;

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// To specify a bucket owner and prevent sniping, you can use the <c>ExpectedBucketOwner</c>
        /// endpoint setting. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>--s3-settings='{"ExpectedBucketOwner": "<i>AWS_Account_ID</i>"}'</c> 
        /// </para>
        ///  
        /// <para>
        /// When you make a request to test a connection or perform a migration, S3 checks the
        /// account ID of the bucket owner against the specified parameter.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedBucketOwner() => this.ExpectedBucketOwner != null;

        /// <summary>
        /// Gets and sets the property ExternalTableDefinition. 
        /// <para>
        ///  Specifies how tables are defined in the S3 source files only. 
        /// </para>
        /// </summary>
        public string ExternalTableDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ExternalTableDefinition property is set.
        /// </summary>
        internal bool IsSetExternalTableDefinition() => this.ExternalTableDefinition != null;

        /// <summary>
        /// Gets and sets the property GlueCatalogGeneration. 
        /// <para>
        /// When true, allows Glue to catalog your S3 bucket. Creating an Glue catalog lets you
        /// use Athena to query your data.
        /// </para>
        /// </summary>
        public bool? GlueCatalogGeneration { get; set; }

        /// <summary>
        /// Checks to see if the GlueCatalogGeneration property is set.
        /// </summary>
        internal bool IsSetGlueCatalogGeneration() => this.GlueCatalogGeneration.HasValue;

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
        public int? IgnoreHeaderRows { get; set; }

        /// <summary>
        /// Checks to see if the IgnoreHeaderRows property is set.
        /// </summary>
        internal bool IsSetIgnoreHeaderRows() => this.IgnoreHeaderRows.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeOpForFullLoad. 
        /// <para>
        /// A value that enables a full load to write INSERT operations to the comma-separated
        /// value (.csv) or .parquet output files only to indicate how the rows were added to
        /// the source database.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <c>IncludeOpForFullLoad</c> parameter in versions 3.1.4 and later.
        /// </para>
        ///  
        /// <para>
        /// DMS supports the use of the .parquet files with the <c>IncludeOpForFullLoad</c> parameter
        /// in versions 3.4.7 and later.
        /// </para>
        ///  </note> 
        /// <para>
        /// For full load, records can only be inserted. By default (the <c>false</c> setting),
        /// no information is recorded in these output files for a full load to indicate that
        /// the rows were inserted at the source database. If <c>IncludeOpForFullLoad</c> is set
        /// to <c>true</c> or <c>y</c>, the INSERT is recorded as an I annotation in the first
        /// field of the .csv file. This allows the format of your target records from a full
        /// load to be consistent with the target records from a CDC load.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting works together with the <c>CdcInsertsOnly</c> and the <c>CdcInsertsAndUpdates</c>
        /// parameters for output to .csv files only. For more information about how these settings
        /// work together, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring.InsertOps">Indicating
        /// Source DB Operations in Migrated S3 Data</a> in the <i>Database Migration Service
        /// User Guide.</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? IncludeOpForFullLoad { get; set; }

        /// <summary>
        /// Checks to see if the IncludeOpForFullLoad property is set.
        /// </summary>
        internal bool IsSetIncludeOpForFullLoad() => this.IncludeOpForFullLoad.HasValue;

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
        public int? MaxFileSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxFileSize property is set.
        /// </summary>
        internal bool IsSetMaxFileSize() => this.MaxFileSize.HasValue;

        /// <summary>
        /// Gets and sets the property ParquetTimestampInMillisecond. 
        /// <para>
        /// A value that specifies the precision of any <c>TIMESTAMP</c> column values that are
        /// written to an Amazon S3 object file in .parquet format.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <c>ParquetTimestampInMillisecond</c> parameter in versions 3.1.4
        /// and later.
        /// </para>
        ///  </note> 
        /// <para>
        /// When <c>ParquetTimestampInMillisecond</c> is set to <c>true</c> or <c>y</c>, DMS writes
        /// all <c>TIMESTAMP</c> columns in a .parquet formatted file with millisecond precision.
        /// Otherwise, DMS writes them with microsecond precision.
        /// </para>
        ///  
        /// <para>
        /// Currently, Amazon Athena and Glue can handle only millisecond precision for <c>TIMESTAMP</c>
        /// values. Set this parameter to <c>true</c> for S3 endpoint object files that are .parquet
        /// formatted only if you plan to query or process the data with Athena or Glue.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS writes any <c>TIMESTAMP</c> column values written to an S3 file in .csv format
        /// with microsecond precision.
        /// </para>
        ///  
        /// <para>
        /// Setting <c>ParquetTimestampInMillisecond</c> has no effect on the string format of
        /// the timestamp column value that is inserted by setting the <c>TimestampColumnName</c>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ParquetTimestampInMillisecond { get; set; }

        /// <summary>
        /// Checks to see if the ParquetTimestampInMillisecond property is set.
        /// </summary>
        internal bool IsSetParquetTimestampInMillisecond() => this.ParquetTimestampInMillisecond.HasValue;

        /// <summary>
        /// Gets and sets the property ParquetVersion. 
        /// <para>
        /// The version of the Apache Parquet format that you want to use: <c>parquet_1_0</c>
        /// (the default) or <c>parquet_2_0</c>.
        /// </para>
        /// </summary>
        public ParquetVersionValue ParquetVersion { get; set; }

        /// <summary>
        /// Checks to see if the ParquetVersion property is set.
        /// </summary>
        internal bool IsSetParquetVersion() => this.ParquetVersion != null;

        /// <summary>
        /// Gets and sets the property PreserveTransactions. 
        /// <para>
        /// If set to <c>true</c>, DMS saves the transaction order for a change data capture (CDC)
        /// load on the Amazon S3 target specified by <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-CdcPath">
        /// <c>CdcPath</c> </a>. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.EndpointSettings.CdcPath">Capturing
        /// data changes (CDC) including transaction order on the S3 target</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is supported in DMS versions 3.4.2 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? PreserveTransactions { get; set; }

        /// <summary>
        /// Checks to see if the PreserveTransactions property is set.
        /// </summary>
        internal bool IsSetPreserveTransactions() => this.PreserveTransactions.HasValue;

        /// <summary>
        /// Gets and sets the property Rfc4180. 
        /// <para>
        /// For an S3 source, when this value is set to <c>true</c> or <c>y</c>, each leading
        /// double quotation mark has to be followed by an ending double quotation mark. This
        /// formatting complies with RFC 4180. When this value is set to <c>false</c> or <c>n</c>,
        /// string literals are copied to the target as is. In this case, a delimiter (row or
        /// column) signals the end of the field. Thus, you can't use a delimiter as part of the
        /// string, because it signals the end of the value.
        /// </para>
        ///  
        /// <para>
        /// For an S3 target, an optional parameter used to set behavior to comply with RFC 4180
        /// for data migrated to Amazon S3 using .csv file format only. When this value is set
        /// to <c>true</c> or <c>y</c> using Amazon S3 as a target, if the data has quotation
        /// marks or newline characters in it, DMS encloses the entire column with an additional
        /// pair of double quotation marks ("). Every quotation mark within the data is repeated
        /// twice.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>. Valid values include <c>true</c>, <c>false</c>,
        /// <c>y</c>, and <c>n</c>.
        /// </para>
        /// </summary>
        public bool? Rfc4180 { get; set; }

        /// <summary>
        /// Checks to see if the Rfc4180 property is set.
        /// </summary>
        internal bool IsSetRfc4180() => this.Rfc4180.HasValue;

        /// <summary>
        /// Gets and sets the property RowGroupLength. 
        /// <para>
        /// The number of rows in a row group. A smaller row group size provides faster reads.
        /// But as the number of row groups grows, the slower writes become. This parameter defaults
        /// to 10,000 rows. This number is used for .parquet file format only. 
        /// </para>
        ///  
        /// <para>
        /// If you choose a value larger than the maximum, <c>RowGroupLength</c> is set to the
        /// max row group length in bytes (64 * 1024 * 1024). 
        /// </para>
        /// </summary>
        public int? RowGroupLength { get; set; }

        /// <summary>
        /// Checks to see if the RowGroupLength property is set.
        /// </summary>
        internal bool IsSetRowGroupLength() => this.RowGroupLength.HasValue;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKmsKeyId. 
        /// <para>
        /// If you are using <c>SSE_KMS</c> for the <c>EncryptionMode</c>, provide the KMS key
        /// ID. The key that you use needs an attached policy that enables Identity and Access
        /// Management (IAM) user permissions and allows use of the key.
        /// </para>
        ///  
        /// <para>
        /// Here is a CLI example: <c>aws dms create-endpoint --endpoint-identifier <i>value</i>
        /// --endpoint-type target --engine-name s3 --s3-settings ServiceAccessRoleArn=<i>value</i>,BucketFolder=<i>value</i>,BucketName=<i>value</i>,EncryptionMode=SSE_KMS,ServerSideEncryptionKmsKeyId=<i>value</i>
        /// </c> 
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
        ///  The Amazon Resource Name (ARN) used by the service to access the IAM role. The role
        /// must allow the <c>iam:PassRole</c> action. It is a required parameter that enables
        /// DMS to write and read objects from an S3 bucket.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property TimestampColumnName. 
        /// <para>
        /// A value that when nonblank causes DMS to add a column with timestamp information to
        /// the endpoint data for an Amazon S3 target.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <c>TimestampColumnName</c> parameter in versions 3.1.4 and later.
        /// </para>
        ///  </note> 
        /// <para>
        /// DMS includes an additional <c>STRING</c> column in the .csv or .parquet object files
        /// of your migrated data when you set <c>TimestampColumnName</c> to a nonblank value.
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
        /// The string format for this timestamp column value is <c>yyyy-MM-dd HH:mm:ss.SSSSSS</c>.
        /// By default, the precision of this value is in microseconds. For a CDC load, the rounding
        /// of the precision depends on the commit timestamp supported by DMS for the source database.
        /// </para>
        ///  
        /// <para>
        /// When the <c>AddColumnName</c> parameter is set to <c>true</c>, DMS also includes a
        /// name for the timestamp column that you set with <c>TimestampColumnName</c>.
        /// </para>
        /// </summary>
        public string TimestampColumnName { get; set; }

        /// <summary>
        /// Checks to see if the TimestampColumnName property is set.
        /// </summary>
        internal bool IsSetTimestampColumnName() => this.TimestampColumnName != null;

        /// <summary>
        /// Gets and sets the property UseCsvNoSupValue. 
        /// <para>
        /// This setting applies if the S3 output files during a change data capture (CDC) load
        /// are written in .csv format. If set to <c>true</c> for columns not included in the
        /// supplemental log, DMS uses the value specified by <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_S3Settings.html#DMS-Type-S3Settings-CsvNoSupValue">
        /// <c>CsvNoSupValue</c> </a>. If not set or set to <c>false</c>, DMS uses the null value
        /// for these columns.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is supported in DMS versions 3.4.1 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? UseCsvNoSupValue { get; set; }

        /// <summary>
        /// Checks to see if the UseCsvNoSupValue property is set.
        /// </summary>
        internal bool IsSetUseCsvNoSupValue() => this.UseCsvNoSupValue.HasValue;

        /// <summary>
        /// Gets and sets the property UseTaskStartTimeForFullLoadTimestamp. 
        /// <para>
        /// When set to true, this parameter uses the task start time as the timestamp column
        /// value instead of the time data is written to target. For full load, when <c>useTaskStartTimeForFullLoadTimestamp</c>
        /// is set to <c>true</c>, each row of the timestamp column contains the task start time.
        /// For CDC loads, each row of the timestamp column contains the transaction commit time.
        /// </para>
        ///  
        /// <para>
        /// When <c>useTaskStartTimeForFullLoadTimestamp</c> is set to <c>false</c>, the full
        /// load timestamp in the timestamp column increments with the time data arrives at the
        /// target. 
        /// </para>
        /// </summary>
        public bool? UseTaskStartTimeForFullLoadTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UseTaskStartTimeForFullLoadTimestamp property is set.
        /// </summary>
        internal bool IsSetUseTaskStartTimeForFullLoadTimestamp() => this.UseTaskStartTimeForFullLoadTimestamp.HasValue;
    }
}
