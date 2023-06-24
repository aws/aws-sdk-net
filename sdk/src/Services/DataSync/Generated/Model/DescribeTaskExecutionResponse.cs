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
        private long? _estimatedBytesToTransfer;
        private long? _estimatedFilesToTransfer;
        private List<FilterRule> _excludes = new List<FilterRule>();
        private long? _filesTransferred;
        private List<FilterRule> _includes = new List<FilterRule>();
        private Options _options;
        private TaskExecutionResultDetail _result;
        private DateTime? _startTime;
        private TaskExecutionStatus _status;
        private string _taskExecutionArn;

        /// <summary>
        /// Gets and sets the property BytesCompressed. 
        /// <para>
        /// The physical number of bytes transferred over the network after compression was applied.
        /// In most cases, this number is less than <code>BytesTransferred</code> unless the data
        /// isn't compressible.
        /// </para>
        /// </summary>
        public long BytesCompressed
        {
            get { return this._bytesCompressed.GetValueOrDefault(); }
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
        /// The total number of bytes that are involved in the transfer. For the number of bytes
        /// sent over the network, see <code>BytesCompressed</code>. 
        /// </para>
        /// </summary>
        public long BytesTransferred
        {
            get { return this._bytesTransferred.GetValueOrDefault(); }
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
        /// The number of logical bytes written to the destination Amazon Web Services storage
        /// resource.
        /// </para>
        /// </summary>
        public long BytesWritten
        {
            get { return this._bytesWritten.GetValueOrDefault(); }
            set { this._bytesWritten = value; }
        }

        // Check to see if BytesWritten property is set
        internal bool IsSetBytesWritten()
        {
            return this._bytesWritten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedBytesToTransfer. 
        /// <para>
        /// The estimated physical number of bytes that is to be transferred over the network.
        /// </para>
        /// </summary>
        public long EstimatedBytesToTransfer
        {
            get { return this._estimatedBytesToTransfer.GetValueOrDefault(); }
            set { this._estimatedBytesToTransfer = value; }
        }

        // Check to see if EstimatedBytesToTransfer property is set
        internal bool IsSetEstimatedBytesToTransfer()
        {
            return this._estimatedBytesToTransfer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedFilesToTransfer. 
        /// <para>
        /// The expected number of files that is to be transferred over the network. This value
        /// is calculated during the <code>PREPARING</code> phase before the <code>TRANSFERRING</code>
        /// phase of the task execution. This value is the expected number of files to be transferred.
        /// It's calculated based on comparing the content of the source and destination locations
        /// and finding the delta that needs to be transferred. 
        /// </para>
        /// </summary>
        public long EstimatedFilesToTransfer
        {
            get { return this._estimatedFilesToTransfer.GetValueOrDefault(); }
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
            return this._excludes != null && this._excludes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilesTransferred. 
        /// <para>
        /// The actual number of files that was transferred over the network. This value is calculated
        /// and updated on an ongoing basis during the <code>TRANSFERRING</code> phase of the
        /// task execution. It's updated periodically when each file is read from the source and
        /// sent over the network. 
        /// </para>
        ///  
        /// <para>
        /// If failures occur during a transfer, this value can be less than <code>EstimatedFilesToTransfer</code>.
        /// In some cases, this value can also be greater than <code>EstimatedFilesToTransfer</code>.
        /// This element is implementation-specific for some location types, so don't use it as
        /// an indicator for a correct file number or to monitor your task execution.
        /// </para>
        /// </summary>
        public long FilesTransferred
        {
            get { return this._filesTransferred.GetValueOrDefault(); }
            set { this._filesTransferred = value; }
        }

        // Check to see if FilesTransferred property is set
        internal bool IsSetFilesTransferred()
        {
            return this._filesTransferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// A list of filter rules that include specific data during your transfer. For more information
        /// and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Filtering
        /// data transferred by DataSync</a>.
        /// </para>
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
            return this._includes != null && this._includes.Count > 0; 
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
        /// The time that the task execution was started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        ///  
        /// <para>
        /// For detailed information about task execution statuses, see Understanding Task Statuses
        /// in the <i>DataSync User Guide.</i> 
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
        /// The Amazon Resource Name (ARN) of the task execution that was described. <code>TaskExecutionArn</code>
        /// is hierarchical and includes <code>TaskArn</code> for the task that was executed.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, a <code>TaskExecution</code> value with the ARN <code>arn:aws:datasync:us-east-1:111222333444:task/task-0208075f79cedf4a2/execution/exec-08ef1e88ec491019b</code>
        /// executed the task with the ARN <code>arn:aws:datasync:us-east-1:111222333444:task/task-0208075f79cedf4a2</code>.
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

    }
}