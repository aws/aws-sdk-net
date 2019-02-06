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
    /// The configuration object for Lustre file systems used in the <code>CreateFileSystem</code>
    /// operation.
    /// </summary>
    public partial class CreateFileSystemLustreConfiguration
    {
        private string _exportPath;
        private int? _importedFileChunkSize;
        private string _importPath;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property ExportPath. 
        /// <para>
        /// (Optional) The path in Amazon S3 where the root of your Amazon FSx file system is
        /// exported. The path must use the same Amazon S3 bucket as specified in ImportPath.
        /// You can provide an optional prefix to which new and changed data is to be exported
        /// from your Amazon FSx for Lustre file system. If an <code>ExportPath</code> value is
        /// not provided, Amazon FSx sets a default export path, <code>s3://import-bucket/FSxLustre[creation-timestamp]</code>.
        /// The timestamp is in UTC format, for example <code>s3://import-bucket/FSxLustre20181105T222312Z</code>.
        /// </para>
        ///  
        /// <para>
        /// The Amazon S3 export bucket must be the same as the import bucket specified by <code>ImportPath</code>.
        /// If you only specify a bucket name, such as <code>s3://import-bucket</code>, you get
        /// a 1:1 mapping of file system objects to S3 bucket objects. This mapping means that
        /// the input data in S3 is overwritten on export. If you provide a custom prefix in the
        /// export path, such as <code>s3://import-bucket/[custom-optional-prefix]</code>, Amazon
        /// FSx exports the contents of your file system to that export prefix in the Amazon S3
        /// bucket.
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
        /// (Optional) For files imported from a data repository, this value determines the stripe
        /// count and maximum amount of data per file (in MiB) stored on a single physical disk.
        /// The maximum number of disks that a single file can be striped across is limited by
        /// the total number of disks that make up the file system.
        /// </para>
        ///  
        /// <para>
        /// The chunk size default is 1,024 MiB (1 GiB) and can go as high as 512,000 MiB (500
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
        /// (Optional) The path to the Amazon S3 bucket (including the optional prefix) that you're
        /// using as the data repository for your Amazon FSx for Lustre file system. The root
        /// of your FSx for Lustre file system will be mapped to the root of the Amazon S3 bucket
        /// you select. An example is <code>s3://import-bucket/optional-prefix</code>. If you
        /// specify a prefix after the Amazon S3 bucket name, only object keys with that prefix
        /// are loaded into the file system.
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

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The preferred time to perform weekly maintenance, in the UTC time zone.
        /// </para>
        /// </summary>
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}