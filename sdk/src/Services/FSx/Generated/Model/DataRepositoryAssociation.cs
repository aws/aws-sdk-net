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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration of a data repository association that links an Amazon FSx for Lustre
    /// file system to an Amazon S3 bucket. The data repository association configuration
    /// object is returned in the response of the following operations:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>CreateDataRepositoryAssociation</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateDataRepositoryAssociation</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeDataRepositoryAssociations</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Data repository associations are supported only for file systems with the <code>Persistent_2</code>
    /// deployment type.
    /// </para>
    /// </summary>
    public partial class DataRepositoryAssociation
    {
        private string _associationId;
        private bool? _batchImportMetaDataOnCreate;
        private DateTime? _creationTime;
        private string _dataRepositoryPath;
        private DataRepositoryFailureDetails _failureDetails;
        private string _fileSystemId;
        private string _fileSystemPath;
        private int? _importedFileChunkSize;
        private DataRepositoryLifecycle _lifecycle;
        private string _resourceARN;
        private S3DataRepositoryConfiguration _s3;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The system-generated, unique ID of the data repository association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=23)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property BatchImportMetaDataOnCreate. 
        /// <para>
        /// A boolean flag indicating whether an import data repository task to import metadata
        /// should run after the data repository association is created. The task runs if this
        /// flag is set to <code>true</code>.
        /// </para>
        /// </summary>
        public bool BatchImportMetaDataOnCreate
        {
            get { return this._batchImportMetaDataOnCreate.GetValueOrDefault(); }
            set { this._batchImportMetaDataOnCreate = value; }
        }

        // Check to see if BatchImportMetaDataOnCreate property is set
        internal bool IsSetBatchImportMetaDataOnCreate()
        {
            return this._batchImportMetaDataOnCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataRepositoryPath. 
        /// <para>
        /// The path to the Amazon S3 data repository that will be linked to the file system.
        /// The path can be an S3 bucket or prefix in the format <code>s3://myBucket/myPrefix/</code>.
        /// This path specifies where in the S3 data repository files will be imported from or
        /// exported to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=4357)]
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
        /// Gets and sets the property FileSystemId.
        /// </summary>
        [AWSProperty(Min=11, Max=21)]
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
        /// A path on the file system that points to a high-level directory (such as <code>/ns1/</code>)
        /// or subdirectory (such as <code>/ns1/subdir/</code>) that will be mapped 1-1 with <code>DataRepositoryPath</code>.
        /// The leading forward slash in the name is required. Two data repository associations
        /// cannot have overlapping file system paths. For example, if a data repository is associated
        /// with file system path <code>/ns1/</code>, then you cannot link another data repository
        /// with file system path <code>/ns1/ns2</code>.
        /// </para>
        ///  
        /// <para>
        /// This path specifies where in your file system files will be exported from or imported
        /// to. This file system directory can be linked to only one Amazon S3 bucket, and no
        /// other S3 bucket can be linked to the directory.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify only a forward slash (<code>/</code>) as the file system path, you
        /// can link only 1 data repository to the file system. You can only specify "/" as the
        /// file system path for the first data repository associated with a file system.
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
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Describes the state of a data repository association. The lifecycle can have the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATING</code> - The data repository association between the FSx file system
        /// and the S3 data repository is being created. The data repository is unavailable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - The data repository association is available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MISCONFIGURED</code> - Amazon FSx cannot automatically import updates from
        /// the S3 bucket or automatically export updates to the S3 bucket until the data repository
        /// association configuration is corrected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATING</code> - The data repository association is undergoing a customer
        /// initiated update that might affect its availability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - The data repository association is undergoing a customer
        /// initiated deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - The data repository association is in a terminal state that
        /// cannot be recovered.
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

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min=8, Max=512)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}