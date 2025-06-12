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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
    /// DescribeTaskExecutionResponse
    /// </summary>
    public partial class DescribeTaskExecutionResponse : AmazonWebServiceResponse
    {
        private long? _bytesCompressed;
        private long? _bytesTransferred;
        private long? _bytesWritten;
        private DateTime? _endTime;
        private long? _estimatedBytesToTransfer;
        private long? _estimatedFilesToDelete;
        private long? _estimatedFilesToTransfer;
        private List<FilterRule> _excludes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private long? _filesDeleted;
        private TaskExecutionFilesFailedDetail _filesFailed;
        private TaskExecutionFilesListedDetail _filesListed;
        private long? _filesPrepared;
        private long? _filesSkipped;
        private long? _filesTransferred;
        private long? _filesVerified;
        private List<FilterRule> _includes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private DateTime? _launchTime;
        private ManifestConfig _manifestConfig;
        private Options _options;
        private ReportResult _reportResult;
        private TaskExecutionResultDetail _result;
        private DateTime? _startTime;
        private TaskExecutionStatus _status;
        private string _taskExecutionArn;
        private TaskMode _taskMode;
        private TaskReportConfig _taskReportConfig;

        /// <summary>
        /// Gets and sets the property BytesCompressed. 
        /// <para>
        /// The number of physical bytes that DataSync transfers over the network after compression
        /// (if compression is possible). This number is typically less than <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-BytesTransferred">BytesTransferred</a>
        /// unless the data isn't compressible.
        /// </para>
        /// </summary>
        public long? BytesCompressed
        {
            get { return this._bytesCompressed; }
            set { this._bytesCompressed = value; }
        }

        // Check to see if BytesCompressed property is set
        internal bool IsSetBytesCompressed()
        {
            return this._bytesCompressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BytesTransferred. 
        /// <para>
        /// The number of bytes that DataSync sends to the network before compression (if compression
        /// is possible). For the number of bytes transferred over the network, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeTaskExecution.html#DataSync-DescribeTaskExecution-response-BytesCompressed">BytesCompressed</a>.
        /// 
        /// </para>
        /// </summary>
        public long? BytesTransferred
        {
            get { return this._bytesTransferred; }
            set { this._bytesTransferred = value; }
        }

        // Check to see if BytesTransferred property is set
        internal bool IsSetBytesTransferred()
        {
            return this._bytesTransferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BytesWritten. 
        /// <para>
        /// The number of logical bytes that DataSync actually writes to the destination location.
        /// </para>
        /// </summary>
        public long? BytesWritten
        {
            get { return this._bytesWritten; }
            set { this._bytesWritten = value; }
        }

        // Check to see if BytesWritten property is set
        internal bool IsSetBytesWritten()
        {
            return this._bytesWritten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the transfer task ends.
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
        /// Gets and sets the property EstimatedBytesToTransfer. 
        /// <para>
        /// The number of logical bytes that DataSync expects to write to the destination location.
        /// </para>
        /// </summary>
        public long? EstimatedBytesToTransfer
        {
            get { return this._estimatedBytesToTransfer; }
            set { this._estimatedBytesToTransfer = value; }
        }

        // Check to see if EstimatedBytesToTransfer property is set
        internal bool IsSetEstimatedBytesToTransfer()
        {
            return this._estimatedBytesToTransfer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedFilesToDelete. 
        /// <para>
        /// The number of files, objects, and directories that DataSync expects to delete in your
        /// destination location. If you don't configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html">delete
        /// data in the destination that isn't in the source</a>, the value is always <c>0</c>.
        /// </para>
        /// </summary>
        public long? EstimatedFilesToDelete
        {
            get { return this._estimatedFilesToDelete; }
            set { this._estimatedFilesToDelete = value; }
        }

        // Check to see if EstimatedFilesToDelete property is set
        internal bool IsSetEstimatedFilesToDelete()
        {
            return this._estimatedFilesToDelete.HasValue; 
        }

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
        ///  </li> </ul>
        /// </summary>
        public long? EstimatedFilesToTransfer
        {
            get { return this._estimatedFilesToTransfer; }
            set { this._estimatedFilesToTransfer = value; }
        }

        // Check to see if EstimatedFilesToTransfer property is set
        internal bool IsSetEstimatedFilesToTransfer()
        {
            return this._estimatedFilesToTransfer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// A list of filter rules that exclude specific data during your transfer. For more information
        /// and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Filtering
        /// data transferred by DataSync</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<FilterRule> Excludes
        {
            get { return this._excludes; }
            set { this._excludes = value; }
        }

        // Check to see if Excludes property is set
        internal bool IsSetExcludes()
        {
            return this._excludes != null && (this._excludes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilesDeleted. 
        /// <para>
        /// The number of files, objects, and directories that DataSync actually deletes in your
        /// destination location. If you don't configure your task to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-metadata.html">delete
        /// data in the destination that isn't in the source</a>, the value is always <c>0</c>.
        /// </para>
        /// </summary>
        public long? FilesDeleted
        {
            get { return this._filesDeleted; }
            set { this._filesDeleted = value; }
        }

        // Check to see if FilesDeleted property is set
        internal bool IsSetFilesDeleted()
        {
            return this._filesDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilesFailed. 
        /// <para>
        /// The number of objects that DataSync fails to prepare, transfer, verify, and delete
        /// during your task execution.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public TaskExecutionFilesFailedDetail FilesFailed
        {
            get { return this._filesFailed; }
            set { this._filesFailed = value; }
        }

        // Check to see if FilesFailed property is set
        internal bool IsSetFilesFailed()
        {
            return this._filesFailed != null;
        }

        /// <summary>
        /// Gets and sets the property FilesListed. 
        /// <para>
        /// The number of objects that DataSync finds at your locations.
        /// </para>
        ///  <note> 
        /// <para>
        /// Applies only to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Enhanced
        /// mode tasks</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public TaskExecutionFilesListedDetail FilesListed
        {
            get { return this._filesListed; }
            set { this._filesListed = value; }
        }

        // Check to see if FilesListed property is set
        internal bool IsSetFilesListed()
        {
            return this._filesListed != null;
        }

        /// <summary>
        /// Gets and sets the property FilesPrepared. 
        /// <para>
        /// The number of objects that DataSync will attempt to transfer after comparing your
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
        public long? FilesPrepared
        {
            get { return this._filesPrepared; }
            set { this._filesPrepared = value; }
        }

        // Check to see if FilesPrepared property is set
        internal bool IsSetFilesPrepared()
        {
            return this._filesPrepared.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilesSkipped. 
        /// <para>
        /// The number of files, objects, and directories that DataSync skips during your transfer.
        /// </para>
        /// </summary>
        public long? FilesSkipped
        {
            get { return this._filesSkipped; }
            set { this._filesSkipped = value; }
        }

        // Check to see if FilesSkipped property is set
        internal bool IsSetFilesSkipped()
        {
            return this._filesSkipped.HasValue; 
        }

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
        /// </summary>
        public long? FilesTransferred
        {
            get { return this._filesTransferred; }
            set { this._filesTransferred = value; }
        }

        // Check to see if FilesTransferred property is set
        internal bool IsSetFilesTransferred()
        {
            return this._filesTransferred.HasValue; 
        }

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
        ///  </note>
        /// </summary>
        public long? FilesVerified
        {
            get { return this._filesVerified; }
            set { this._filesVerified = value; }
        }

        // Check to see if FilesVerified property is set
        internal bool IsSetFilesVerified()
        {
            return this._filesVerified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// A list of filter rules that include specific data during your transfer. For more information
        /// and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Filtering
        /// data transferred by DataSync</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<FilterRule> Includes
        {
            get { return this._includes; }
            set { this._includes = value; }
        }

        // Check to see if Includes property is set
        internal bool IsSetIncludes()
        {
            return this._includes != null && (this._includes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time that the task execution actually begins. For non-queued tasks, <c>LaunchTime</c>
        /// and <c>StartTime</c> are typically the same. For queued tasks, <c>LaunchTime</c> is
        /// typically later than <c>StartTime</c> because previously queued tasks must finish
        /// running before newer tasks can begin.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime
        {
            get { return this._launchTime; }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManifestConfig. 
        /// <para>
        /// The configuration of the manifest that lists the files or objects to transfer. For
        /// more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">Specifying
        /// what DataSync transfers by using a manifest</a>.
        /// </para>
        /// </summary>
        public ManifestConfig ManifestConfig
        {
            get { return this._manifestConfig; }
            set { this._manifestConfig = value; }
        }

        // Check to see if ManifestConfig property is set
        internal bool IsSetManifestConfig()
        {
            return this._manifestConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Options.
        /// </summary>
        public Options Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property ReportResult. 
        /// <para>
        /// Indicates whether DataSync generated a complete <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">task
        /// report</a> for your transfer.
        /// </para>
        /// </summary>
        public ReportResult ReportResult
        {
            get { return this._reportResult; }
            set { this._reportResult = value; }
        }

        // Check to see if ReportResult property is set
        internal bool IsSetReportResult()
        {
            return this._reportResult != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result of the task execution.
        /// </para>
        /// </summary>
        public TaskExecutionResultDetail Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that DataSync sends the request to start the task execution. For non-queued
        /// tasks, <c>LaunchTime</c> and <c>StartTime</c> are typically the same. For queued tasks,
        /// <c>LaunchTime</c> is typically later than <c>StartTime</c> because previously queued
        /// tasks must finish running before newer tasks can begin.
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
        /// The status of the task execution. 
        /// </para>
        /// </summary>
        public TaskExecutionStatus Status
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
        [AWSProperty(Max=128)]
        public string TaskExecutionArn
        {
            get { return this._taskExecutionArn; }
            set { this._taskExecutionArn = value; }
        }

        // Check to see if TaskExecutionArn property is set
        internal bool IsSetTaskExecutionArn()
        {
            return this._taskExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskMode. 
        /// <para>
        /// The task mode that you're using. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Choosing
        /// a task mode for your data transfer</a>.
        /// </para>
        /// </summary>
        public TaskMode TaskMode
        {
            get { return this._taskMode; }
            set { this._taskMode = value; }
        }

        // Check to see if TaskMode property is set
        internal bool IsSetTaskMode()
        {
            return this._taskMode != null;
        }

        /// <summary>
        /// Gets and sets the property TaskReportConfig. 
        /// <para>
        /// The configuration of your task report, which provides detailed information about for
        /// your DataSync transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">Creating
        /// a task report</a>.
        /// </para>
        /// </summary>
        public TaskReportConfig TaskReportConfig
        {
            get { return this._taskReportConfig; }
            set { this._taskReportConfig = value; }
        }

        // Check to see if TaskReportConfig property is set
        internal bool IsSetTaskReportConfig()
        {
            return this._taskReportConfig != null;
        }

    }
}