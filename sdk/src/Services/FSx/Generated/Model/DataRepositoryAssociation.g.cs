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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration of a data repository association that links an Amazon FSx for Lustre
    /// file system to an Amazon S3 bucket or an Amazon File Cache resource to an Amazon S3
    /// bucket or an NFS file system. The data repository association configuration object
    /// is returned in the response of the following operations:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateDataRepositoryAssociation</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdateDataRepositoryAssociation</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeDataRepositoryAssociations</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Data repository associations are supported on Amazon File Cache resources and all
    /// FSx for Lustre 2.12 and 2.15 file systems, excluding Intelligent-Tiering and <c>scratch_1</c>
    /// file systems.
    /// </para>
    /// </summary>
    public partial class DataRepositoryAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The system-generated, unique ID of the data repository association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 13, Max = 23)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property BatchImportMetaDataOnCreate. 
        /// <para>
        /// A boolean flag indicating whether an import data repository task to import metadata
        /// should run after the data repository association is created. The task runs if this
        /// flag is set to <c>true</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>BatchImportMetaDataOnCreate</c> is not supported for data repositories linked
        /// to an Amazon File Cache resource.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? BatchImportMetaDataOnCreate { get; set; }

        /// <summary>
        /// Checks to see if the BatchImportMetaDataOnCreate property is set.
        /// </summary>
        internal bool IsSetBatchImportMetaDataOnCreate() => this.BatchImportMetaDataOnCreate.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataRepositoryPath. 
        /// <para>
        /// The path to the data repository that will be linked to the cache or file system.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Amazon File Cache, the path can be an NFS data repository that will be linked
        /// to the cache. The path can be in one of two formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are not using the <c>DataRepositorySubdirectories</c> parameter, the path is
        /// to an NFS Export directory (or one of its subdirectories) in the format <c>nsf://nfs-domain-name/exportpath</c>.
        /// You can therefore link a single NFS Export to a single data repository association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using the <c>DataRepositorySubdirectories</c> parameter, the path is the
        /// domain name of the NFS file system in the format <c>nfs://filer-domain-name</c>, which
        /// indicates the root of the subdirectories specified with the <c>DataRepositorySubdirectories</c>
        /// parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For Amazon File Cache, the path can be an S3 bucket or prefix in the format <c>s3://bucket-name/prefix/</c>
        /// (where <c>prefix</c> is optional).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon FSx for Lustre, the path can be an S3 bucket or prefix in the format <c>s3://bucket-name/prefix/</c>
        /// (where <c>prefix</c> is optional).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 3, Max = 4357)]
        public string DataRepositoryPath { get; set; }

        /// <summary>
        /// Checks to see if the DataRepositoryPath property is set.
        /// </summary>
        internal bool IsSetDataRepositoryPath() => this.DataRepositoryPath != null;

        /// <summary>
        /// Gets and sets the property DataRepositorySubdirectories. 
        /// <para>
        /// For Amazon File Cache, a list of NFS Exports that will be linked with an NFS data
        /// repository association. All the subdirectories must be on a single NFS file system.
        /// The Export paths are in the format <c>/exportpath1</c>. To use this parameter, you
        /// must configure <c>DataRepositoryPath</c> as the domain name of the NFS file system.
        /// The NFS file system domain name in effect is the root of the subdirectories. Note
        /// that <c>DataRepositorySubdirectories</c> is not supported for S3 data repositories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<string> DataRepositorySubdirectories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataRepositorySubdirectories property is set.
        /// </summary>
        internal bool IsSetDataRepositorySubdirectories() => this.DataRepositorySubdirectories != null && (this.DataRepositorySubdirectories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureDetails.
        /// </summary>
        public DataRepositoryFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property FileCacheId. 
        /// <para>
        /// The globally unique ID of the Amazon File Cache resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileCacheId { get; set; }

        /// <summary>
        /// Checks to see if the FileCacheId property is set.
        /// </summary>
        internal bool IsSetFileCacheId() => this.FileCacheId != null;

        /// <summary>
        /// Gets and sets the property FileCachePath. 
        /// <para>
        /// A path on the Amazon File Cache that points to a high-level directory (such as <c>/ns1/</c>)
        /// or subdirectory (such as <c>/ns1/subdir/</c>) that will be mapped 1-1 with <c>DataRepositoryPath</c>.
        /// The leading forward slash in the path is required. Two data repository associations
        /// cannot have overlapping cache paths. For example, if a data repository is associated
        /// with cache path <c>/ns1/</c>, then you cannot link another data repository with cache
        /// path <c>/ns1/ns2</c>.
        /// </para>
        ///  
        /// <para>
        /// This path specifies the directory in your cache where files will be exported from.
        /// This cache directory can be linked to only one data repository (S3 or NFS) and no
        /// other data repository can be linked to the directory.
        /// </para>
        ///  <note> 
        /// <para>
        /// The cache path can only be set to root (/) on an NFS DRA when <c>DataRepositorySubdirectories</c>
        /// is specified. If you specify root (/) as the cache path, you can create only one DRA
        /// on the cache.
        /// </para>
        ///  
        /// <para>
        /// The cache path cannot be set to root (/) for an S3 DRA.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string FileCachePath { get; set; }

        /// <summary>
        /// Checks to see if the FileCachePath property is set.
        /// </summary>
        internal bool IsSetFileCachePath() => this.FileCachePath != null;

        /// <summary>
        /// Gets and sets the property FileSystemId.
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property FileSystemPath. 
        /// <para>
        /// A path on the Amazon FSx for Lustre file system that points to a high-level directory
        /// (such as <c>/ns1/</c>) or subdirectory (such as <c>/ns1/subdir/</c>) that will be
        /// mapped 1-1 with <c>DataRepositoryPath</c>. The leading forward slash in the name is
        /// required. Two data repository associations cannot have overlapping file system paths.
        /// For example, if a data repository is associated with file system path <c>/ns1/</c>,
        /// then you cannot link another data repository with file system path <c>/ns1/ns2</c>.
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
        [AWSProperty(Min = 1, Max = 4096)]
        public string FileSystemPath { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemPath property is set.
        /// </summary>
        internal bool IsSetFileSystemPath() => this.FileSystemPath != null;

        /// <summary>
        /// Gets and sets the property ImportedFileChunkSize. 
        /// <para>
        /// For files imported from a data repository, this value determines the stripe count
        /// and maximum amount of data per file (in MiB) stored on a single physical disk. The
        /// maximum number of disks that a single file can be striped across is limited by the
        /// total number of disks that make up the file system or cache.
        /// </para>
        ///  
        /// <para>
        /// The default chunk size is 1,024 MiB (1 GiB) and can go as high as 512,000 MiB (500
        /// GiB). Amazon S3 objects have a maximum size of 5 TB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512000)]
        public int? ImportedFileChunkSize { get; set; }

        /// <summary>
        /// Checks to see if the ImportedFileChunkSize property is set.
        /// </summary>
        internal bool IsSetImportedFileChunkSize() => this.ImportedFileChunkSize.HasValue;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Describes the state of a data repository association. The lifecycle can have the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The data repository association between the file system or cache
        /// and the data repository is being created. The data repository is unavailable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The data repository association is available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURED</c> - The data repository association is misconfigured. Until the
        /// configuration is corrected, automatic import and automatic export will not work (only
        /// for Amazon FSx for Lustre).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The data repository association is undergoing a customer initiated
        /// update that might affect its availability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The data repository association is undergoing a customer initiated
        /// deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The data repository association is in a terminal state that cannot
        /// be recovered.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataRepositoryLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property NFS. 
        /// <para>
        /// The configuration for an NFS data repository linked to an Amazon File Cache resource
        /// with a data repository association.
        /// </para>
        /// </summary>
        public NFSDataRepositoryConfiguration NFS { get; set; }

        /// <summary>
        /// Checks to see if the NFS property is set.
        /// </summary>
        internal bool IsSetNFS() => this.NFS != null;

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min = 8, Max = 512)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The configuration for an Amazon S3 data repository linked to an Amazon FSx for Lustre
        /// file system with a data repository association.
        /// </para>
        /// </summary>
        public S3DataRepositoryConfiguration S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
