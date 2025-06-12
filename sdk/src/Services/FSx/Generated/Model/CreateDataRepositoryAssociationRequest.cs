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
    /// Container for the parameters to the CreateDataRepositoryAssociation operation.
    /// Creates an Amazon FSx for Lustre data repository association (DRA). A data repository
    /// association is a link between a directory on the file system and an Amazon S3 bucket
    /// or prefix. You can have a maximum of 8 data repository associations on a file system.
    /// Data repository associations are supported on all FSx for Lustre 2.12 and 2.15 file
    /// systems, excluding <c>scratch_1</c> deployment type.
    /// 
    ///  
    /// <para>
    /// Each data repository association must have a unique Amazon FSx file system directory
    /// and a unique S3 bucket or prefix associated with it. You can configure a data repository
    /// association for automatic import only, for automatic export only, or for both. To
    /// learn more about linking a data repository to your file system, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/create-dra-linked-data-repo.html">Linking
    /// your file system to an S3 bucket</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>CreateDataRepositoryAssociation</c> isn't supported on Amazon File Cache resources.
    /// To create a DRA on Amazon File Cache, use the <c>CreateFileCache</c> operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDataRepositoryAssociationRequest : AmazonFSxRequest
    {
        private bool? _batchImportMetaDataOnCreate;
        private string _clientRequestToken;
        private string _dataRepositoryPath;
        private string _fileSystemId;
        private string _fileSystemPath;
        private int? _importedFileChunkSize;
        private S3DataRepositoryConfiguration _s3;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BatchImportMetaDataOnCreate. 
        /// <para>
        /// Set to <c>true</c> to run an import data repository task to import metadata from the
        /// data repository to the file system after the data repository association is created.
        /// Default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? BatchImportMetaDataOnCreate
        {
            get { return this._batchImportMetaDataOnCreate; }
            set { this._batchImportMetaDataOnCreate = value; }
        }

        // Check to see if BatchImportMetaDataOnCreate property is set
        internal bool IsSetBatchImportMetaDataOnCreate()
        {
            return this._batchImportMetaDataOnCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataRepositoryPath. 
        /// <para>
        /// The path to the Amazon S3 data repository that will be linked to the file system.
        /// The path can be an S3 bucket or prefix in the format <c>s3://bucket-name/prefix/</c>
        /// (where <c>prefix</c> is optional). This path specifies where in the S3 data repository
        /// files will be imported from or exported to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=4357)]
        public string DataRepositoryPath
        {
            get { return this._dataRepositoryPath; }
            set { this._dataRepositoryPath = value; }
        }

        // Check to see if DataRepositoryPath property is set
        internal bool IsSetDataRepositoryPath()
        {
            return this._dataRepositoryPath != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId.
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=21)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemPath. 
        /// <para>
        /// A path on the file system that points to a high-level directory (such as <c>/ns1/</c>)
        /// or subdirectory (such as <c>/ns1/subdir/</c>) that will be mapped 1-1 with <c>DataRepositoryPath</c>.
        /// The leading forward slash in the name is required. Two data repository associations
        /// cannot have overlapping file system paths. For example, if a data repository is associated
        /// with file system path <c>/ns1/</c>, then you cannot link another data repository with
        /// file system path <c>/ns1/ns2</c>.
        /// </para>
        ///  
        /// <para>
        /// This path specifies where in your file system files will be exported from or imported
        /// to. This file system directory can be linked to only one Amazon S3 bucket, and no
        /// other S3 bucket can be linked to the directory.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify only a forward slash (<c>/</c>) as the file system path, you can link
        /// only one data repository to the file system. You can only specify "/" as the file
        /// system path for the first data repository associated with a file system.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string FileSystemPath
        {
            get { return this._fileSystemPath; }
            set { this._fileSystemPath = value; }
        }

        // Check to see if FileSystemPath property is set
        internal bool IsSetFileSystemPath()
        {
            return this._fileSystemPath != null;
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
        /// Gets and sets the property S3. 
        /// <para>
        /// The configuration for an Amazon S3 data repository linked to an Amazon FSx Lustre
        /// file system with a data repository association. The configuration defines which file
        /// events (new, changed, or deleted files or directories) are automatically imported
        /// from the linked data repository to the file system or automatically exported from
        /// the file system to the data repository.
        /// </para>
        /// </summary>
        public S3DataRepositoryConfiguration S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}