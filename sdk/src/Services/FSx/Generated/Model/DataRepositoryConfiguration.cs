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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The data repository configuration object for Lustre file systems returned in the response
    /// of the <c>CreateFileSystem</c> operation.
    /// 
    ///  
    /// <para>
    /// This data type is not supported on file systems with a data repository association.
    /// For file systems with a data repository association, see .
    /// </para>
    /// </summary>
    public partial class DataRepositoryConfiguration
    {
        private AutoImportPolicyType _autoImportPolicy;
        private string _exportPath;
        private DataRepositoryFailureDetails _failureDetails;
        private int? _importedFileChunkSize;
        private string _importPath;
        private DataRepositoryLifecycle _lifecycle;

        /// <summary>
        /// Gets and sets the property AutoImportPolicy. 
        /// <para>
        /// Describes the file system's linked S3 data repository's <c>AutoImportPolicy</c>. The
        /// AutoImportPolicy configures how Amazon FSx keeps your file and directory listings
        /// up to date as you add or modify objects in your linked S3 bucket. <c>AutoImportPolicy</c>
        /// can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> - (Default) AutoImport is off. Amazon FSx only updates file and directory
        /// listings from the linked S3 bucket when the file system is created. FSx does not update
        /// file and directory listings for any new or changed objects after choosing this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW</c> - AutoImport is on. Amazon FSx automatically imports directory listings
        /// of any new objects added to the linked S3 bucket that do not currently exist in the
        /// FSx file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_CHANGED</c> - AutoImport is on. Amazon FSx automatically imports file and
        /// directory listings of any new objects added to the S3 bucket and any existing objects
        /// that are changed in the S3 bucket after you choose this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_CHANGED_DELETED</c> - AutoImport is on. Amazon FSx automatically imports file
        /// and directory listings of any new objects added to the S3 bucket, any existing objects
        /// that are changed in the S3 bucket, and any objects that were deleted in the S3 bucket.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AutoImportPolicyType AutoImportPolicy
        {
            get { return this._autoImportPolicy; }
            set { this._autoImportPolicy = value; }
        }

        // Check to see if AutoImportPolicy property is set
        internal bool IsSetAutoImportPolicy()
        {
            return this._autoImportPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ExportPath. 
        /// <para>
        /// The export path to the Amazon S3 bucket (and prefix) that you are using to store new
        /// and changed Lustre file system files in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=4357)]
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
        /// Gets and sets the property FailureDetails.
        /// </summary>
        public DataRepositoryFailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
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
        [AWSProperty(Min=1, Max=512000)]
        public int? ImportedFileChunkSize
        {
            get { return this._importedFileChunkSize; }
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
        /// the data repository for your FSx for Lustre file system, for example <c>s3://import-bucket/optional-prefix</c>.
        /// If a prefix is specified after the Amazon S3 bucket name, only object keys with that
        /// prefix are loaded into the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=4357)]
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
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Describes the state of the file system's S3 durable data repository, if it is configured
        /// with an S3 repository. The lifecycle can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The data repository configuration between the FSx file system and
        /// the linked S3 data repository is being created. The data repository is unavailable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The data repository is available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURED</c> - Amazon FSx cannot automatically import updates from the S3
        /// bucket until the data repository configuration is corrected. For more information,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/troubleshooting.html#troubleshooting-misconfigured-data-repository">Troubleshooting
        /// a Misconfigured linked S3 bucket</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The data repository is undergoing a customer initiated update and
        /// availability may be impacted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The data repository is in a terminal state that cannot be recovered.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataRepositoryLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

    }
}