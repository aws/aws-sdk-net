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
    /// 
    /// </summary>
    public partial class S3Settings
    {
        private string _bucketFolder;
        private string _bucketName;
        private CompressionTypeValue _compressionType;
        private string _csvDelimiter;
        private string _csvRowDelimiter;
        private string _externalTableDefinition;
        private string _serviceAccessRoleArn;

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        ///  An optional parameter to set a folder name in the S3 bucket. If provided, tables
        /// are created in the path &lt;bucketFolder&gt;/&lt;schema_name&gt;/&lt;table_name&gt;/.
        /// If this parameter is not specified, then the path used is &lt;schema_name&gt;/&lt;table_name&gt;/.
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
        /// Gets and sets the property CompressionType. 
        /// <para>
        ///  An optional parameter to use GZIP to compress the target files. Set to GZIP to compress
        /// the target files. Set to NONE (the default) or do not use to leave the files uncompressed.
        /// 
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
        /// return (\n). 
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