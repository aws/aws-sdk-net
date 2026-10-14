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
        /// <summary>
        /// Gets and sets the property CapacityToRelease. 
        /// <para>
        /// Specifies the amount of data to release, in GiB, by an Amazon File Cache AUTO_RELEASE_DATA
        /// task that automatically releases files from the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public long? CapacityToRelease { get; set; }

        /// <summary>
        /// Checks to see if the CapacityToRelease property is set.
        /// </summary>
        internal bool IsSetCapacityToRelease() => this.CapacityToRelease.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the system completed processing the task, populated after the task is complete.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Failure message describing why the task failed, it is populated only when <c>Lifecycle</c>
        /// is set to <c>FAILED</c>.
        /// </para>
        /// </summary>
        public DataRepositoryTaskFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property FileCacheId. 
        /// <para>
        /// The system-generated, unique ID of the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileCacheId { get; set; }

        /// <summary>
        /// Checks to see if the FileCacheId property is set.
        /// </summary>
        internal bool IsSetFileCacheId() => this.FileCacheId != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The globally unique ID of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

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
        [AWSProperty(Required = true)]
        public DataRepositoryTaskLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> Paths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Paths property is set.
        /// </summary>
        internal bool IsSetPaths() => this.Paths != null && (this.Paths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReleaseConfiguration. 
        /// <para>
        /// The configuration that specifies the last accessed time criteria for files that will
        /// be released from an Amazon FSx for Lustre file system.
        /// </para>
        /// </summary>
        public ReleaseConfiguration ReleaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseConfiguration property is set.
        /// </summary>
        internal bool IsSetReleaseConfiguration() => this.ReleaseConfiguration != null;

        /// <summary>
        /// Gets and sets the property Report.
        /// </summary>
        public CompletionReport Report { get; set; }

        /// <summary>
        /// Checks to see if the Report property is set.
        /// </summary>
        internal bool IsSetReport() => this.Report != null;

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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the system began processing the task.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides the status of the number of files that the task has processed successfully
        /// and failed to process.
        /// </para>
        /// </summary>
        public DataRepositoryTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The system-generated, unique 17-digit ID of the data repository task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 128)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

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
        [AWSProperty(Required = true)]
        public DataRepositoryTaskType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
