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
    /// Container for the parameters to the CreateDataRepositoryTask operation.
    /// Creates an Amazon FSx for Lustre data repository task. You use data repository tasks
    /// to perform bulk operations between your Amazon FSx file system and its linked data
    /// repositories. An example of a data repository task is exporting any data and metadata
    /// changes, including POSIX metadata, to files, directories, and symbolic links (symlinks)
    /// from your FSx file system to a linked data repository. A <code>CreateDataRepositoryTask</code>
    /// operation will fail if a data repository is not linked to the FSx file system. To
    /// learn more about data repository tasks, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-repository-tasks.html">Data
    /// Repository Tasks</a>. To learn more about linking a data repository to your file system,
    /// see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/create-dra-linked-data-repo.html">Linking
    /// your file system to an S3 bucket</a>.
    /// </summary>
    public partial class CreateDataRepositoryTaskRequest : AmazonFSxRequest
    {
        private long? _capacityToRelease;
        private string _clientRequestToken;
        private string _fileSystemId;
        private List<string> _paths = new List<string>();
        private CompletionReport _report;
        private List<Tag> _tags = new List<Tag>();
        private DataRepositoryTaskType _type;

        /// <summary>
        /// Gets and sets the property CapacityToRelease. 
        /// <para>
        /// Specifies the amount of data to release, in GiB, by an Amazon File Cache <code>AUTO_RELEASE_DATA</code>
        /// task that automatically releases files from the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public long CapacityToRelease
        {
            get { return this._capacityToRelease.GetValueOrDefault(); }
            set { this._capacityToRelease = value; }
        }

        // Check to see if CapacityToRelease property is set
        internal bool IsSetCapacityToRelease()
        {
            return this._capacityToRelease.HasValue; 
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
        /// Gets and sets the property Paths. 
        /// <para>
        /// A list of paths for the data repository task to use when the task is processed. If
        /// a path that you provide isn't valid, the task fails.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For export tasks, the list contains paths on the Amazon FSx file system from which
        /// the files are exported to the Amazon S3 bucket. The default path is the file system
        /// root directory. The paths you provide need to be relative to the mount point of the
        /// file system. If the mount point is <code>/mnt/fsx</code> and <code>/mnt/fsx/path1</code>
        /// is a directory or file on the file system you want to export, then the path to provide
        /// is <code>path1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For import tasks, the list contains paths in the Amazon S3 bucket from which POSIX
        /// metadata changes are imported to the Amazon FSx file system. The path can be an S3
        /// bucket or prefix in the format <code>s3://myBucket/myPrefix</code> (where <code>myPrefix</code>
        /// is optional).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> Paths
        {
            get { return this._paths; }
            set { this._paths = value; }
        }

        // Check to see if Paths property is set
        internal bool IsSetPaths()
        {
            return this._paths != null && this._paths.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Report. 
        /// <para>
        /// Defines whether or not Amazon FSx provides a CompletionReport once the task has completed.
        /// A CompletionReport provides a detailed report on the files that Amazon FSx processed
        /// that meet the criteria specified by the <code>Scope</code> parameter. For more information,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/task-completion-report.html">Working
        /// with Task Completion Reports</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CompletionReport Report
        {
            get { return this._report; }
            set { this._report = value; }
        }

        // Check to see if Report property is set
        internal bool IsSetReport()
        {
            return this._report != null;
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of data repository task to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataRepositoryTaskType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}