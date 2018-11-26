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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// DescribeTaskResponse
    /// </summary>
    public partial class DescribeTaskResponse : AmazonWebServiceResponse
    {
        private string _cloudWatchLogGroupArn;
        private DateTime? _creationTime;
        private string _currentTaskExecutionArn;
        private string _destinationLocationArn;
        private string _errorCode;
        private string _errorDetail;
        private string _name;
        private Options _options;
        private string _sourceLocationArn;
        private TaskStatus _status;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group that was used to
        /// monitor and log events in the task. For more information on these groups, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Working-with-log-groups-and-streams.html">Working
        /// with Log Groups and Log Streams</a> in the <i>Amazon CloudWatch User Guide.</i> 
        /// </para>
        /// </summary>
        public string CloudWatchLogGroupArn
        {
            get { return this._cloudWatchLogGroupArn; }
            set { this._cloudWatchLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogGroupArn property is set
        internal bool IsSetCloudWatchLogGroupArn()
        {
            return this._cloudWatchLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the task was created.
        /// </para>
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
        /// Gets and sets the property CurrentTaskExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution that is syncing files.
        /// </para>
        /// </summary>
        public string CurrentTaskExecutionArn
        {
            get { return this._currentTaskExecutionArn; }
            set { this._currentTaskExecutionArn = value; }
        }

        // Check to see if CurrentTaskExecutionArn property is set
        internal bool IsSetCurrentTaskExecutionArn()
        {
            return this._currentTaskExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationLocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS storage resource's location.
        /// </para>
        /// </summary>
        public string DestinationLocationArn
        {
            get { return this._destinationLocationArn; }
            set { this._destinationLocationArn = value; }
        }

        // Check to see if DestinationLocationArn property is set
        internal bool IsSetDestinationLocationArn()
        {
            return this._destinationLocationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Errors that AWS DataSync encountered during execution of the task. You can use this
        /// error code to help troubleshoot issues.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// Detailed description of an error that was encountered during the task execution. You
        /// can use this information to help troubleshoot issues. 
        /// </para>
        /// </summary>
        public string ErrorDetail
        {
            get { return this._errorDetail; }
            set { this._errorDetail = value; }
        }

        // Check to see if ErrorDetail property is set
        internal bool IsSetErrorDetail()
        {
            return this._errorDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the task that was described.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The set of configuration options that control the behavior of a single execution of
        /// the task that occurs when you call <code>StartTaskExecution</code>. You can configure
        /// these options to preserve metadata such as user ID (UID) and group (GID), file permissions,
        /// data integrity verification, and so on.
        /// </para>
        ///  
        /// <para>
        /// For each individual task execution, you can override these options by specifying the
        /// overriding <code>OverrideOptions</code> value to operation. 
        /// </para>
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
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source file system's location.
        /// </para>
        /// </summary>
        public string SourceLocationArn
        {
            get { return this._sourceLocationArn; }
            set { this._sourceLocationArn = value; }
        }

        // Check to see if SourceLocationArn property is set
        internal bool IsSetSourceLocationArn()
        {
            return this._sourceLocationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task that was described. For detailed information about sync statuses,
        /// see <a href="https://docs.aws.amazon.com/sync-service/latest/userguide/understand-sync-task-statuses.html">Understanding
        /// Sync Task Statuses</a>.
        /// </para>
        /// </summary>
        public TaskStatus Status
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task that was described.
        /// </para>
        /// </summary>
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

    }
}