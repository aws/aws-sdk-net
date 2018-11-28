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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The data repository configuration object for Lustre file systems returned in the response
    /// of the <code>CreateFileSystem</code> operation.
    /// </summary>
    public partial class DataRepositoryConfiguration
    {
        private string _exportPath;
        private int? _importedFileChunkSize;
        private string _importPath;

        /// <summary>
        /// Gets and sets the property ExportPath. 
        /// <para>
        /// The Amazon S3 commit path to use for storing new and changed Lustre file system files
        /// as part of the archive operation from the file system to Amazon S3. The value is <code>s3://import-bucket/FSxLustre[creationtimestamp]</code>.
        /// The timestamp is presented in UTC format, for example <code>s3://import-bucket/FSxLustre20181105T222312Z</code>.
        /// Files are archived to a different prefix in the Amazon S3 bucket, preventing input
        /// data from being overwritten.
        /// </para>
        /// </summary>
        public string ExportPath
        {
            get { return this._exportPath; }
            set { this._exportPath = value; }
        }

        // Check to see if ExportPath property is set
        internal bool IsSetExportPath()
        {
            return this._exportPath != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedFileChunkSize. 
        /// <para>
        /// For files imported from a data repository, this value determines the stripe count
        /// and maximum amount of data per file (in MiB) stored on a single physical disk. The
        /// maximum number of disks that a single file can be striped across is limited by the
        /// total number of disks that make up the file system.
        /// </para>
        ///  
        /// <para>
        /// The default chunk size is 1,024 MiB (1 GiB) and can go as high as 512,000 MiB (500
        /// GiB). Amazon S3 objects have a maximum size of 5 TB.
        /// </para>
        /// </summary>
        public int ImportedFileChunkSize
        {
            get { return this._importedFileChunkSize.GetValueOrDefault(); }
            set { this._importedFileChunkSize = value; }
        }

        // Check to see if ImportedFileChunkSize property is set
        internal bool IsSetImportedFileChunkSize()
        {
            return this._importedFileChunkSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportPath. 
        /// <para>
        /// The import path to the Amazon S3 bucket (and optional prefix) that you're using as
        /// the data repository for your FSx for Lustre file system, for example <code>s3://import-bucket/optional-prefix</code>.
        /// If a prefix is specified after the Amazon S3 bucket name, only object keys with that
        /// prefix are loaded into the file system.
        /// </para>
        /// </summary>
        public string ImportPath
        {
            get { return this._importPath; }
            set { this._importPath = value; }
        }

        // Check to see if ImportPath property is set
        internal bool IsSetImportPath()
        {
            return this._importPath != null;
        }

    }
}