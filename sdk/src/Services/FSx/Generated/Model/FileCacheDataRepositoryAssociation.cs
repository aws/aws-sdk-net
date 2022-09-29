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
    /// The configuration for a data repository association (DRA) to be created during the
    /// Amazon File Cache resource creation. The DRA links the cache to either an Amazon S3
    /// bucket or prefix, or a Network File System (NFS) data repository that supports the
    /// NFSv3 protocol.
    /// 
    ///  
    /// <para>
    /// The DRA does not support automatic import or automatic export.
    /// </para>
    /// </summary>
    public partial class FileCacheDataRepositoryAssociation
    {
        private string _dataRepositoryPath;
        private List<string> _dataRepositorySubdirectories = new List<string>();
        private string _fileCachePath;
        private FileCacheNFSConfiguration _nfs;

        /// <summary>
        /// Gets and sets the property DataRepositoryPath. 
        /// <para>
        /// The path to the S3 or NFS data repository that links to the cache. You must provide
        /// one of the following paths:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The path can be an NFS data repository that links to the cache. The path can be in
        /// one of two formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are not using the <code>DataRepositorySubdirectories</code> parameter, the
        /// path is to an NFS Export directory (or one of its subdirectories) in the format <code>nsf://nfs-domain-name/exportpath</code>.
        /// You can therefore link a single NFS Export to a single data repository association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using the <code>DataRepositorySubdirectories</code> parameter, the path
        /// is the domain name of the NFS file system in the format <code>nfs://filer-domain-name</code>,
        /// which indicates the root of the subdirectories specified with the <code>DataRepositorySubdirectories</code>
        /// parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The path can be an S3 bucket or prefix in the format <code>s3://myBucket/myPrefix/</code>.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property DataRepositorySubdirectories. 
        /// <para>
        /// A list of NFS Exports that will be linked with this data repository association. The
        /// Export paths are in the format <code>/exportpath1</code>. To use this parameter, you
        /// must configure <code>DataRepositoryPath</code> as the domain name of the NFS file
        /// system. The NFS file system domain name in effect is the root of the subdirectories.
        /// Note that <code>DataRepositorySubdirectories</code> is not supported for S3 data repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public List<string> DataRepositorySubdirectories
        {
            get { return this._dataRepositorySubdirectories; }
            set { this._dataRepositorySubdirectories = value; }
        }

        // Check to see if DataRepositorySubdirectories property is set
        internal bool IsSetDataRepositorySubdirectories()
        {
            return this._dataRepositorySubdirectories != null && this._dataRepositorySubdirectories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FileCachePath. 
        /// <para>
        /// A path on the cache that points to a high-level directory (such as <code>/ns1/</code>)
        /// or subdirectory (such as <code>/ns1/subdir/</code>) that will be mapped 1-1 with <code>DataRepositoryPath</code>.
        /// The leading forward slash in the name is required. Two data repository associations
        /// cannot have overlapping cache paths. For example, if a data repository is associated
        /// with cache path <code>/ns1/</code>, then you cannot link another data repository with
        /// cache path <code>/ns1/ns2</code>.
        /// </para>
        ///  
        /// <para>
        /// This path specifies where in your cache files will be exported from. This cache directory
        /// can be linked to only one data repository, and no data repository other can be linked
        /// to the directory.
        /// </para>
        ///  <note> 
        /// <para>
        /// The cache path can only be set to root (/) on an NFS DRA when <code>DataRepositorySubdirectories</code>
        /// is specified. If you specify root (/) as the cache path, you can create only one DRA
        /// on the cache.
        /// </para>
        ///  
        /// <para>
        /// The cache path cannot be set to root (/) for an S3 DRA.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string FileCachePath
        {
            get { return this._fileCachePath; }
            set { this._fileCachePath = value; }
        }

        // Check to see if FileCachePath property is set
        internal bool IsSetFileCachePath()
        {
            return this._fileCachePath != null;
        }

        /// <summary>
        /// Gets and sets the property NFS. 
        /// <para>
        /// The configuration for a data repository association that links an Amazon File Cache
        /// resource to an NFS data repository.
        /// </para>
        /// </summary>
        public FileCacheNFSConfiguration NFS
        {
            get { return this._nfs; }
            set { this._nfs = value; }
        }

        // Check to see if NFS property is set
        internal bool IsSetNFS()
        {
            return this._nfs != null;
        }

    }
}