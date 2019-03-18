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
        private ParquetVersionValue _parquetVersion;
        private int? _rowGroupLength;
        private string _serverSideEncryptionKmsKeyId;
        private string _serviceAccessRoleArn;

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        ///  An optional parameter to set a folder name in the S3 bucket. If provided, tables
        /// are created in the path <code>&lt;bucketFolder&gt;/&lt;schema_name&gt;/&lt;table_name&gt;/</code>.
        /// If this parameter is not specified, then the path used is <code>&lt;schema_name&gt;/&lt;table_name&gt;/</code>.
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
        /// Option to write only <code>INSERT</code> operations to the comma-separated value (CSV)
        /// output files. By default, the first field in a CSV record contains the letter <code>I</code>
        /// (insert), <code>U</code> (update) or <code>D</code> (delete) to indicate whether the
        /// row was inserted, updated, or deleted at the source database. If <code>cdcInsertsOnly</code>
        /// is set to true, then only <code>INSERT</code>s are recorded in the CSV file, without
        /// the <code>I</code> annotation on each line. Valid values are <code>TRUE</code> and
        /// <code>FALSE</code>.
        /// </para>
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
        /// Applies to both CSV and PARQUET data formats. 
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
        /// The format of the data which you want to use for output. You can choose one of the
        /// following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CSV</code> : This is a row-based format with comma-separated values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PARQUET</code> : Apache Parquet is a columnar storage format that features
        /// efficient compression and provides faster query response. 
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
        /// The size of one data page in bytes. Defaults to 1024 * 1024 bytes (1MiB). For <code>PARQUET</code>
        /// format only. 
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
        /// Defaults to 1024 * 1024 bytes (1MiB), the maximum size of a dictionary page before
        /// it reverts to <code>PLAIN</code> encoding. For <code>PARQUET</code> format only. 
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
        /// Enables statistics for Parquet pages and rowGroups. Choose <code>TRUE</code> to enable
        /// statistics, choose <code>FALSE</code> to disable. Statistics include <code>NULL</code>,
        /// <code>DISTINCT</code>, <code>MAX</code>, and <code>MIN</code> values. Defaults to
        /// <code>TRUE</code>. For <code>PARQUET</code> format only.
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
        /// The type of encoding you are using: <code>RLE_DICTIONARY</code> (default), <code>PLAIN</code>,
        /// or <code>PLAIN_DICTIONARY</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RLE_DICTIONARY</code> uses a combination of bit-packing and run-length encoding
        /// to store repeated values more efficiently.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PLAIN</code> does not use encoding at all. Values are stored as they are.
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
        /// The type of server side encryption you want to use for your data. This is part of
        /// the endpoint settings or the extra connections attributes for Amazon S3. You can choose
        /// either <code>SSE_S3</code> (default) or <code>SSE_KMS</code>. To use <code>SSE_S3</code>,
        /// you need an IAM role with permission to allow <code>"arn:aws:s3:::dms-*"</code> to
        /// use the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// s3:CreateBucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:ListBucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:DeleteBucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:GetBucketLocation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:GetObject
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:PutObject
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:DeleteObject
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:GetObjectVersion
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:GetBucketPolicy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:PutBucketPolicy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:DeleteBucketPolicy
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
        /// Gets and sets the property ParquetVersion. 
        /// <para>
        /// The version of Apache Parquet format you want to use: <code>PARQUET_1_0</code> (default)
        /// or <code>PARQUET_2_0</code>.
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
        /// But as the number of row groups grows, the slower writes become. Defaults to 10,000
        /// (ten thousand) rows. For <code>PARQUET</code> format only. 
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
        /// If you are using SSE_KMS for the <code>EncryptionMode</code>, provide the KMS Key
        /// ID. The key you use needs an attached policy that enables IAM user permissions and
        /// allows use of the key.
        /// </para>
        ///  
        /// <para>
        /// Here is a CLI example: <code>aws dms create-endpoint --endpoint-identifier &lt;value&gt;
        /// --endpoint-type target --engine-name s3 --s3-settings ServiceAccessRoleArn=&lt;value&gt;,BucketFolder=&lt;value&gt;,BucketName=&lt;value&gt;,EncryptionMode=SSE_KMS,ServerSideEncryptionKmsKeyId=&lt;value&gt;
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

    }
}