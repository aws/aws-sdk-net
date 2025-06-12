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
    /// A description of the data repository task.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You use import and export data repository tasks to perform bulk transfer operations
    /// between an Amazon FSx for Lustre file system and a linked data repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You use release data repository tasks to release files that have been exported to
    /// a linked S3 bucket from your Amazon FSx for Lustre file system.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An Amazon File Cache resource uses a task to automatically release files from the
    /// cache.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To learn more about data repository tasks, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-repository-tasks.html">Data
    /// Repository Tasks</a>. 
    /// </para>
    /// </summary>
    public partial class DataRepositoryTask
    {
        private long? _capacityToRelease;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private DataRepositoryTaskFailureDetails _failureDetails;
        private string _fileCacheId;
        private string _fileSystemId;
        private DataRepositoryTaskLifecycle _lifecycle;
        private List<string> _paths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ReleaseConfiguration _releaseConfiguration;
        private CompletionReport _report;
        private string _resourceARN;
        private DateTime? _startTime;
        private DataRepositoryTaskStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _taskId;
        private DataRepositoryTaskType _type;

        /// <summary>
        /// Gets and sets the property CapacityToRelease. 
        /// <para>
        /// Specifies the amount of data to release, in GiB, by an Amazon File Cache AUTO_RELEASE_DATA
        /// task that automatically releases files from the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public long? CapacityToRelease
        {
            get { return this._capacityToRelease; }
            set { this._capacityToRelease = value; }
        }

        // Check to see if CapacityToRelease property is set
        internal bool IsSetCapacityToRelease()
        {
            return this._capacityToRelease.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the system completed processing the task, populated after the task is complete.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Failure message describing why the task failed, it is populated only when <c>Lifecycle</c>
        /// is set to <c>FAILED</c>.
        /// </para>
        /// </summary>
        public DataRepositoryTaskFailureDetails FailureDetails
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
        /// Gets and sets the property FileCacheId. 
        /// <para>
        /// The system-generated, unique ID of the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=21)]
        public string FileCacheId
        {
            get { return this._fileCacheId; }
            set { this._fileCacheId = value; }
        }

        // Check to see if FileCacheId property is set
        internal bool IsSetFileCacheId()
        {
            return this._fileCacheId != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The globally unique ID of the file system.
        /// </para>
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
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the data repository task, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The task has not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXECUTING</c> - The task is in process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The task was not able to be completed. For example, there may be
        /// files the task failed to process. The <a>DataRepositoryTaskFailureDetails</a> property
        /// provides more information about task failures.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> - The task has completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c> - The task was canceled and it did not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELING</c> - The task is in process of being canceled.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot delete an FSx for Lustre file system if there are data repository tasks
        /// for the file system in the <c>PENDING</c> or <c>EXECUTING</c> states. Please retry
        /// when the data repository task is finished (with a status of <c>CANCELED</c>, <c>SUCCEEDED</c>,
        /// or <c>FAILED</c>). You can use the DescribeDataRepositoryTask action to monitor the
        /// task status. Contact the FSx team if you need to delete your file system immediately.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataRepositoryTaskLifecycle Lifecycle
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
        /// Gets and sets the property Paths. 
        /// <para>
        /// An array of paths that specify the data for the data repository task to process. For
        /// example, in an EXPORT_TO_REPOSITORY task, the paths specify which data to export to
        /// the linked data repository.
        /// </para>
        ///  
        /// <para>
        /// (Default) If <c>Paths</c> is not specified, Amazon FSx uses the file system root directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._paths != null && (this._paths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReleaseConfiguration. 
        /// <para>
        /// The configuration that specifies the last accessed time criteria for files that will
        /// be released from an Amazon FSx for Lustre file system.
        /// </para>
        /// </summary>
        public ReleaseConfiguration ReleaseConfiguration
        {
            get { return this._releaseConfiguration; }
            set { this._releaseConfiguration = value; }
        }

        // Check to see if ReleaseConfiguration property is set
        internal bool IsSetReleaseConfiguration()
        {
            return this._releaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Report.
        /// </summary>
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the system began processing the task.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides the status of the number of files that the task has processed successfully
        /// and failed to process.
        /// </para>
        /// </summary>
        public DataRepositoryTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
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

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The system-generated, unique 17-digit ID of the data repository task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=128)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data repository task.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EXPORT_TO_REPOSITORY</c> tasks export from your Amazon FSx for Lustre file system
        /// to a linked data repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPORT_METADATA_FROM_REPOSITORY</c> tasks import metadata changes from a linked
        /// S3 bucket to your Amazon FSx for Lustre file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RELEASE_DATA_FROM_FILESYSTEM</c> tasks release files in your Amazon FSx for Lustre
        /// file system that have been exported to a linked S3 bucket and that meet your specified
        /// release criteria.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO_RELEASE_DATA</c> tasks automatically release files from an Amazon File Cache
        /// resource.
        /// </para>
        ///  </li> </ul>
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