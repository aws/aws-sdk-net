/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Settings for exporting data to Amazon S3.
    /// </summary>
    public partial class S3Settings
    {
        private string _bucketFolder;
        private string _bucketName;
        private bool? _cdcInsertsOnly;
        private CompressionTypeValue _compressionType;
        private string _csvDelimiter;
        private string _csvRowDelimiter;
        private DataFormatValue _dataFormat;
        private int? _dataPageSize;
        private int? _dictPageSizeLimit;
        private bool? _enableStatistics;
        private EncodingTypeValue _encodingType;
        private EncryptionModeValue _encryptionMode;
        private string _externalTableDefinition;
        private bool? _includeOpForFullLoad;
        private bool? _parquetTimestampInMillisecond;
        private ParquetVersionValue _parquetVersion;
        private int? _rowGroupLength;
        private string _serverSideEncryptionKmsKeyId;
        private string _serviceAccessRoleArn;
        private string _timestampColumnName;

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        ///  An optional parameter to set a folder name in the S3 bucket. If provided, tables
        /// are created in the path <code> <i>bucketFolder</i>/<i>schema_name</i>/<i>table_name</i>/</code>.
        /// If this parameter is not specified, then the path used is <code> <i>schema_name</i>/<i>table_name</i>/</code>.
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
        /// Source DB Operations in Migrated S3 Data</a> in the <i>AWS Database Migration Service
        /// User Guide.</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS DMS supports this interaction between the <code>CdcInsertsOnly</code> and <code>IncludeOpForFullLoad</code>
        /// parameters in versions 3.1.4 and later. 
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
        /// Gets and sets the property CompressionType. 
        /// <para>
        ///  An optional parameter to use GZIP to compress the target files. Set to GZIP to compress
        /// the target files. Set to NONE (the default) or do not use to leave the files uncompressed.
        /// Applies to both .csv and .parquet file formats. 
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
        ///  The delimiter used to separate columns in the source files. The default is a comma.
        /// 
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
        /// Gets and sets the property CsvRowDelimiter. 
        /// <para>
        ///  The delimiter used to separate rows in the source files. The default is a carriage
        /// return (<code>\n</code>). 
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
        /// To use <code>SSE_S3</code>, you need an AWS Identity and Access Management (IAM) role
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
        /// Gets and sets the property ExternalTableDefinition. 
        /// <para>
        ///  The external table definition. 
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
        /// Gets and sets the property IncludeOpForFullLoad. 
        /// <para>
        /// A value that enables a full load to write INSERT operations to the comma-separated
        /// value (.csv) output files only to indicate how the rows were added to the source database.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS DMS supports the <code>IncludeOpForFullLoad</code> parameter in versions 3.1.4
        /// and later.
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
        /// This setting works together with the <code>CdcInsertsOnly</code> parameter for output
        /// to .csv files only. For more information about how these settings work together, see
        /// <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring.InsertOps">Indicating
        /// Source DB Operations in Migrated S3 Data</a> in the <i>AWS Database Migration Service
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
        /// Gets and sets the property ParquetTimestampInMillisecond. 
        /// <para>
        /// A value that specifies the precision of any <code>TIMESTAMP</code> column values that
        /// are written to an Amazon S3 object file in .parquet format.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS DMS supports the <code>ParquetTimestampInMillisecond</code> parameter in versions
        /// 3.1.4 and later.
        /// </para>
        ///  </note> 
        /// <para>
        /// When <code>ParquetTimestampInMillisecond</code> is set to <code>true</code> or <code>y</code>,
        /// AWS DMS writes all <code>TIMESTAMP</code> columns in a .parquet formatted file with
        /// millisecond precision. Otherwise, DMS writes them with microsecond precision.
        /// </para>
        ///  
        /// <para>
        /// Currently, Amazon Athena and AWS Glue can handle only millisecond precision for <code>TIMESTAMP</code>
        /// values. Set this parameter to <code>true</code> for S3 endpoint object files that
        /// are .parquet formatted only if you plan to query or process the data with Athena or
        /// AWS Glue.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS DMS writes any <code>TIMESTAMP</code> column values written to an S3 file in .csv
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
        /// the AWS KMS key ID. The key that you use needs an attached policy that enables AWS
        /// Identity and Access Management (IAM) user permissions and allows use of the key.
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
        ///  The Amazon Resource Name (ARN) used by the service access IAM role. 
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
        /// A value that when nonblank causes AWS DMS to add a column with timestamp information
        /// to the endpoint data for an Amazon S3 target.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS DMS supports the <code>TimestampColumnName</code> parameter in versions 3.1.4
        /// and later.
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

    }
}