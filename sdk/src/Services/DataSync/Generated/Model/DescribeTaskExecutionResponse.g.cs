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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the DescribeTaskExecution operation.
    /// </summary>
    public partial class DescribeTaskExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BytesCompressed. 
        /// <para>
        /// The number of physical bytes that DataSync transfers over the network after compression
        /// (if compression is possible). This number is typically less than <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-BytesTransferred">BytesTransferred</a>
        /// unless the data isn't compressible.
        /// </para>
        /// </summary>
        public long? BytesCompressed { get; set; }

        /// <summary>
        /// Checks to see if the BytesCompressed property is set.
        /// </summary>
        internal bool IsSetBytesCompressed() => this.BytesCompressed.HasValue;

        /// <summary>
        /// Gets and sets the property BytesTransferred. 
        /// <para>
        /// The number of bytes that DataSync sends to the network before compression (if compression
        /// is possible). For the number of bytes transferred over the network, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-BytesCompressed">BytesCompressed</a>.
        /// 
        /// </para>
        /// </summary>
        public long? BytesTransferred { get; set; }

        /// <summary>
        /// Checks to see if the BytesTransferred property is set.
        /// </summary>
        internal bool IsSetBytesTransferred() => this.BytesTransferred.HasValue;

        /// <summary>
        /// Gets and sets the property BytesWritten. 
        /// <para>
        /// The number of logical bytes that DataSync actually writes to the destination location.
        /// </para>
        /// </summary>
        public long? BytesWritten { get; set; }

        /// <summary>
        /// Checks to see if the BytesWritten property is set.
        /// </summary>
        internal bool IsSetBytesWritten() => this.BytesWritten.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the transfer task ends.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedBytesToTransfer. 
        /// <para>
        /// The number of logical bytes that DataSync expects to write to the destination location.
        /// </para>
        /// </summary>
        public long? EstimatedBytesToTransfer { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedBytesToTransfer property is set.
        /// </summary>
        internal bool IsSetEstimatedBytesToTransfer() => this.EstimatedBytesToTransfer.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedFilesToDelete. 
        /// <para>
        /// The number of files, objects, and directories that DataSync expects to delete in your
        /// destination location. If you don't configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html">delete
        /// data in the destination that isn't in the source</a>, the value is always <c>0</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>, this counter only includes files or objects. Directories are counted
        /// in <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-EstimatedFoldersToDelete">EstimatedFoldersToDelete</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public long? EstimatedFilesToDelete { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedFilesToDelete property is set.
        /// </summary>
        internal bool IsSetEstimatedFilesToDelete() => this.EstimatedFilesToDelete.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedFilesToTransfer. 
        /// <para>
        /// The number of files, objects, and directories that DataSync expects to transfer over
        /// the network. This value is calculated while DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">prepares</a>
        /// the transfer.
        /// </para>
        ///  
        /// <para>
        /// How this gets calculated depends primarily on your task’s <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-TransferMode">transfer
        /// mode</a> configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>TranserMode</c> is set to <c>CHANGED</c> - The calculation is based on comparing
        /// the content of the source and destination locations and determining the difference
        /// that needs to be transferred. The difference can include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Anything that's added or modified at the source location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Anything that's in both locations and modified at the destination after an initial
        /// transfer (unless <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-OverwriteMode">OverwriteMode</a>
        /// is set to <c>NEVER</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>(Basic task mode only)</b> The number of items that DataSync expects to delete
        /// (if <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-PreserveDeletedFiles">PreserveDeletedFiles</a>
        /// is set to <c>REMOVE</c>).
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If <c>TranserMode</c> is set to <c>ALL</c> - The calculation is based only on the
        /// items that DataSync finds at the source location.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>, this counter only includes files or objects. Directories are counted
        /// in <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-EstimatedFoldersToTransfer">EstimatedFoldersToTransfer</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public long? EstimatedFilesToTransfer { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedFilesToTransfer property is set.
        /// </summary>
        internal bool IsSetEstimatedFilesToTransfer() => this.EstimatedFilesToTransfer.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedFoldersToDelete. 
        /// <para>
        /// The number of directories that DataSync expects to delete in your destination location.
        /// If you don't configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html">delete
        /// data in the destination that isn't in the source</a>, the value is always <c>0</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public long? EstimatedFoldersToDelete { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedFoldersToDelete property is set.
        /// </summary>
        internal bool IsSetEstimatedFoldersToDelete() => this.EstimatedFoldersToDelete.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedFoldersToTransfer. 
        /// <para>
        /// The number of directories that DataSync expects to transfer over the network. This
        /// value is calculated as DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">prepares</a>
        /// directories to transfer.
        /// </para>
        ///  
        /// <para>
        /// How this gets calculated depends primarily on your task’s <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-TransferMode">transfer
        /// mode</a> configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>TranserMode</c> is set to <c>CHANGED</c> - The calculation is based on comparing
        /// the content of the source and destination locations and determining the difference
        /// that needs to be transferred. The difference can include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Anything that's added or modified at the source location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Anything that's in both locations and modified at the destination after an initial
        /// transfer (unless <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-OverwriteMode">OverwriteMode</a>
        /// is set to <c>NEVER</c>).
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If <c>TranserMode</c> is set to <c>ALL</c> - The calculation is based only on the
        /// items that DataSync finds at the source location.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public long? EstimatedFoldersToTransfer { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedFoldersToTransfer property is set.
        /// </summary>
        internal bool IsSetEstimatedFoldersToTransfer() => this.EstimatedFoldersToTransfer.HasValue;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// A list of filter rules that exclude specific data during your transfer. For more information
        /// and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Filtering
        /// data transferred by DataSync</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<FilterRule> Excludes { get; set; } = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;

        /// <summary>
        /// Checks to see if the Excludes property is set.
        /// </summary>
        internal bool IsSetExcludes() => this.Excludes != null && (this.Excludes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilesDeleted. 
        /// <para>
        /// The number of files, objects, and directories that DataSync actually deletes in your
        /// destination location. If you don't configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html">delete
        /// data in the destination that isn't in the source</a>, the value is always <c>0</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>, this counter only includes files or objects. Directories are counted
        /// in <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-FoldersDeleted">FoldersDeleted</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public long? FilesDeleted { get; set; }

        /// <summary>
        /// Checks to see if the FilesDeleted property is set.
        /// </summary>
        internal bool IsSetFilesDeleted() => this.FilesDeleted.HasValue;

        /// <summary>
        /// Gets and sets the property FilesFailed. 
        /// <para>
        /// The number of files or objects that DataSync fails to prepare, transfer, verify, and
        /// delete during your task execution.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public TaskExecutionFilesFailedDetail FilesFailed { get; set; }

        /// <summary>
        /// Checks to see if the FilesFailed property is set.
        /// </summary>
        internal bool IsSetFilesFailed() => this.FilesFailed != null;

        /// <summary>
        /// Gets and sets the property FilesListed. 
        /// <para>
        /// The number of files or objects that DataSync finds at your locations.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public TaskExecutionFilesListedDetail FilesListed { get; set; }

        /// <summary>
        /// Checks to see if the FilesListed property is set.
        /// </summary>
        internal bool IsSetFilesListed() => this.FilesListed != null;

        /// <summary>
        /// Gets and sets the property FilesPrepared. 
        /// <para>
        /// The number of files or objects that DataSync will attempt to transfer after comparing
        /// your source and destination locations.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This counter isn't applicable if you configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html#task-option-transfer-mode">transfer
        /// all data</a>. In that scenario, DataSync copies everything from the source to the
        /// destination without comparing differences between the locations.
        /// </para>
        /// </summary>
        public long? FilesPrepared { get; set; }

        /// <summary>
        /// Checks to see if the FilesPrepared property is set.
        /// </summary>
        internal bool IsSetFilesPrepared() => this.FilesPrepared.HasValue;

        /// <summary>
        /// Gets and sets the property FilesSkipped. 
        /// <para>
        /// The number of files, objects, and directories that DataSync skips during your transfer.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>, this counter only includes files or objects. Directories are counted
        /// in <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-FoldersSkipped">FoldersSkipped</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public long? FilesSkipped { get; set; }

        /// <summary>
        /// Checks to see if the FilesSkipped property is set.
        /// </summary>
        internal bool IsSetFilesSkipped() => this.FilesSkipped.HasValue;

        /// <summary>
        /// Gets and sets the property FilesTransferred. 
        /// <para>
        /// The number of files, objects, and directories that DataSync actually transfers over
        /// the network. This value is updated periodically during your task execution when something
        /// is read from the source and sent over the network.
        /// </para>
        ///  
        /// <para>
        /// If DataSync fails to transfer something, this value can be less than <c>EstimatedFilesToTransfer</c>.
        /// In some cases, this value can also be greater than <c>EstimatedFilesToTransfer</c>.
        /// This element is implementation-specific for some location types, so don't use it as
        /// an exact indication of what's transferring or to monitor your task execution.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>, this counter only includes files or objects. Directories are counted
        /// in <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-FoldersTransferred">FoldersTransferred</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public long? FilesTransferred { get; set; }

        /// <summary>
        /// Checks to see if the FilesTransferred property is set.
        /// </summary>
        internal bool IsSetFilesTransferred() => this.FilesTransferred.HasValue;

        /// <summary>
        /// Gets and sets the property FilesVerified. 
        /// <para>
        /// The number of files, objects, and directories that DataSync verifies during your transfer.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-data-verification-options.html">verify
        /// only the data that's transferred</a>, DataSync doesn't verify directories in some
        /// situations or files that fail to transfer.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>, this counter only includes files or objects. Directories are counted
        /// in <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-FoldersVerified">FoldersVerified</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public long? FilesVerified { get; set; }

        /// <summary>
        /// Checks to see if the FilesVerified property is set.
        /// </summary>
        internal bool IsSetFilesVerified() => this.FilesVerified.HasValue;

        /// <summary>
        /// Gets and sets the property FoldersDeleted. 
        /// <para>
        /// The number of directories that DataSync actually deletes in your destination location.
        /// If you don't configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html">delete
        /// data in the destination that isn't in the source</a>, the value is always <c>0</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public long? FoldersDeleted { get; set; }

        /// <summary>
        /// Checks to see if the FoldersDeleted property is set.
        /// </summary>
        internal bool IsSetFoldersDeleted() => this.FoldersDeleted.HasValue;

        /// <summary>
        /// Gets and sets the property FoldersFailed. 
        /// <para>
        /// The number of directories that DataSync fails to list, prepare, transfer, verify,
        /// and delete during your task execution.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public TaskExecutionFoldersFailedDetail FoldersFailed { get; set; }

        /// <summary>
        /// Checks to see if the FoldersFailed property is set.
        /// </summary>
        internal bool IsSetFoldersFailed() => this.FoldersFailed != null;

        /// <summary>
        /// Gets and sets the property FoldersListed. 
        /// <para>
        /// The number of directories that DataSync finds at your locations.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public TaskExecutionFoldersListedDetail FoldersListed { get; set; }

        /// <summary>
        /// Checks to see if the FoldersListed property is set.
        /// </summary>
        internal bool IsSetFoldersListed() => this.FoldersListed != null;

        /// <summary>
        /// Gets and sets the property FoldersPrepared. 
        /// <para>
        /// The number of directories that DataSync will attempt to transfer after comparing your
        /// source and destination locations.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This counter isn't applicable if you configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html#task-option-transfer-mode">transfer
        /// all data</a>. In that scenario, DataSync copies everything from the source to the
        /// destination without comparing differences between the locations.
        /// </para>
        /// </summary>
        public long? FoldersPrepared { get; set; }

        /// <summary>
        /// Checks to see if the FoldersPrepared property is set.
        /// </summary>
        internal bool IsSetFoldersPrepared() => this.FoldersPrepared.HasValue;

        /// <summary>
        /// Gets and sets the property FoldersSkipped. 
        /// <para>
        /// The number of directories that DataSync skips during your transfer.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public long? FoldersSkipped { get; set; }

        /// <summary>
        /// Checks to see if the FoldersSkipped property is set.
        /// </summary>
        internal bool IsSetFoldersSkipped() => this.FoldersSkipped.HasValue;

        /// <summary>
        /// Gets and sets the property FoldersTransferred. 
        /// <para>
        /// The number of directories that DataSync actually transfers over the network. This
        /// value is updated periodically during your task execution when something is read from
        /// the source and sent over the network.
        /// </para>
        ///  
        /// <para>
        /// If DataSync fails to transfer something, this value can be less than <c>EstimatedFoldersToTransfer</c>.
        /// In some cases, this value can also be greater than <c>EstimatedFoldersToTransfer</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public long? FoldersTransferred { get; set; }

        /// <summary>
        /// Checks to see if the FoldersTransferred property is set.
        /// </summary>
        internal bool IsSetFoldersTransferred() => this.FoldersTransferred.HasValue;

        /// <summary>
        /// Gets and sets the property FoldersVerified. 
        /// <para>
        /// The number of directories that DataSync verifies during your transfer.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public long? FoldersVerified { get; set; }

        /// <summary>
        /// Checks to see if the FoldersVerified property is set.
        /// </summary>
        internal bool IsSetFoldersVerified() => this.FoldersVerified.HasValue;

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// A list of filter rules that include specific data during your transfer. For more information
        /// and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Filtering
        /// data transferred by DataSync</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<FilterRule> Includes { get; set; } = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;

        /// <summary>
        /// Checks to see if the Includes property is set.
        /// </summary>
        internal bool IsSetIncludes() => this.Includes != null && (this.Includes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time that the task execution actually begins. For non-queued tasks, <c>LaunchTime</c>
        /// and <c>StartTime</c> are typically the same. For queued tasks, <c>LaunchTime</c> is
        /// typically later than <c>StartTime</c> because previously queued tasks must finish
        /// running before newer tasks can begin.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTime property is set.
        /// </summary>
        internal bool IsSetLaunchTime() => this.LaunchTime.HasValue;

        /// <summary>
        /// Gets and sets the property ManifestConfig. 
        /// <para>
        /// The configuration of the manifest that lists the files or objects to transfer. For
        /// more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">Specifying
        /// what DataSync transfers by using a manifest</a>.
        /// </para>
        /// </summary>
        public ManifestConfig ManifestConfig { get; set; }

        /// <summary>
        /// Checks to see if the ManifestConfig property is set.
        /// </summary>
        internal bool IsSetManifestConfig() => this.ManifestConfig != null;

        /// <summary>
        /// Gets and sets the property Options.
        /// </summary>
        public Options Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property ReportResult. 
        /// <para>
        /// Indicates whether DataSync generated a complete <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">task
        /// report</a> for your transfer.
        /// </para>
        /// </summary>
        public ReportResult ReportResult { get; set; }

        /// <summary>
        /// Checks to see if the ReportResult property is set.
        /// </summary>
        internal bool IsSetReportResult() => this.ReportResult != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result of the task execution.
        /// </para>
        /// </summary>
        public TaskExecutionResultDetail Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that DataSync sends the request to start the task execution. For non-queued
        /// tasks, <c>LaunchTime</c> and <c>StartTime</c> are typically the same. For queued tasks,
        /// <c>LaunchTime</c> is typically later than <c>StartTime</c> because previously queued
        /// tasks must finish running before newer tasks can begin.
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
        /// The status of the task execution. 
        /// </para>
        /// </summary>
        public TaskExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskExecutionArn. 
        /// <para>
        /// The ARN of the task execution that you wanted information about. <c>TaskExecutionArn</c>
        /// is hierarchical and includes <c>TaskArn</c> for the task that was executed. 
        /// </para>
        ///  
        /// <para>
        /// For example, a <c>TaskExecution</c> value with the ARN <c>arn:aws:datasync:us-east-1:111222333444:task/task-0208075f79cedf4a2/execution/exec-08ef1e88ec491019b</c>
        /// executed the task with the ARN <c>arn:aws:datasync:us-east-1:111222333444:task/task-0208075f79cedf4a2</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TaskExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskExecutionArn property is set.
        /// </summary>
        internal bool IsSetTaskExecutionArn() => this.TaskExecutionArn != null;

        /// <summary>
        /// Gets and sets the property TaskMode. 
        /// <para>
        /// The task mode that you're using. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Choosing
        /// a task mode for your data transfer</a>.
        /// </para>
        /// </summary>
        public TaskMode TaskMode { get; set; }

        /// <summary>
        /// Checks to see if the TaskMode property is set.
        /// </summary>
        internal bool IsSetTaskMode() => this.TaskMode != null;

        /// <summary>
        /// Gets and sets the property TaskReportConfig. 
        /// <para>
        /// The configuration of your task report, which provides detailed information about for
        /// your DataSync transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">Creating
        /// a task report</a>.
        /// </para>
        /// </summary>
        public TaskReportConfig TaskReportConfig { get; set; }

        /// <summary>
        /// Checks to see if the TaskReportConfig property is set.
        /// </summary>
        internal bool IsSetTaskReportConfig() => this.TaskReportConfig != null;
    }
}
