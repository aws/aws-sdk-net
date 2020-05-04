/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// A description of the data repository task. You use data repository tasks to perform
    /// bulk transfer operations between your Amazon FSx file system and its linked data repository.
    /// </summary>
    public partial class DataRepositoryTask
    {
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private DataRepositoryTaskFailureDetails _failureDetails;
        private string _fileSystemId;
        private DataRepositoryTaskLifecycle _lifecycle;
        private List<string> _paths = new List<string>();
        private CompletionReport _report;
        private string _resourceARN;
        private DateTime? _startTime;
        private DataRepositoryTaskStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private string _taskId;
        private DataRepositoryTaskType _type;

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that Amazon FSx completed processing the task, populated after the task is
        /// complete.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
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
        /// Failure message describing why the task failed, it is populated only when <code>Lifecycle</code>
        /// is set to <code>FAILED</code>.
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
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the data repository task, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> - Amazon FSx has not started the task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXECUTING</code> - Amazon FSx is processing the task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - Amazon FSx was not able to complete the task. For example,
        /// there may be files the task failed to process. The <a>DataRepositoryTaskFailureDetails</a>
        /// property provides more information about task failures.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCEEDED</code> - FSx completed the task successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCELED</code> - Amazon FSx canceled the task and it did not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCELING</code> - FSx is in process of canceling the task.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot delete an FSx for Lustre file system if there are data repository tasks
        /// for the file system in the <code>PENDING</code> or <code>EXECUTING</code> states.
        /// Please retry when the data repository task is finished (with a status of <code>CANCELED</code>,
        /// <code>SUCCEEDED</code>, or <code>FAILED</code>). You can use the DescribeDataRepositoryTask
        /// action to monitor the task status. Contact the FSx team if you need to delete your
        /// file system immediately.
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
        /// An array of paths on the Amazon FSx for Lustre file system that specify the data for
        /// the data repository task to process. For example, in an EXPORT_TO_REPOSITORY task,
        /// the paths specify which data to export to the linked data repository.
        /// </para>
        ///  
        /// <para>
        /// (Default) If <code>Paths</code> is not specified, Amazon FSx uses the file system
        /// root directory.
        /// </para>
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
        /// The time that Amazon FSx began processing the task.
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
        /// The type of data repository task; EXPORT_TO_REPOSITORY is the only type currently
        /// supported.
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