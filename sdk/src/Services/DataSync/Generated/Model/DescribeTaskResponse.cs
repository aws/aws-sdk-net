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
    /// DescribeTaskResponse
    /// </summary>
    public partial class DescribeTaskResponse : AmazonWebServiceResponse
    {
        private string _cloudWatchLogGroupArn;
        private DateTime? _creationTime;
        private string _currentTaskExecutionArn;
        private string _destinationLocationArn;
        private List<string> _destinationNetworkInterfaceArns = new List<string>();
        private string _errorCode;
        private string _errorDetail;
        private List<FilterRule> _excludes = new List<FilterRule>();
        private string _name;
        private Options _options;
        private TaskSchedule _schedule;
        private string _sourceLocationArn;
        private List<string> _sourceNetworkInterfaceArns = new List<string>();
        private TaskStatus _status;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group that was used to
        /// monitor and log events in the task.
        /// </para>
        ///  
        /// <para>
        /// For more information on these groups, see Working with Log Groups and Log Streams
        /// in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=562)]
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
        [AWSProperty(Max=128)]
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
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property DestinationNetworkInterfaceArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination ENIs (Elastic Network Interface)
        /// that was created for your subnet.
        /// </para>
        /// </summary>
        public List<string> DestinationNetworkInterfaceArns
        {
            get { return this._destinationNetworkInterfaceArns; }
            set { this._destinationNetworkInterfaceArns = value; }
        }

        // Check to see if DestinationNetworkInterfaceArns property is set
        internal bool IsSetDestinationNetworkInterfaceArns()
        {
            return this._destinationNetworkInterfaceArns != null && this._destinationNetworkInterfaceArns.Count > 0; 
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
        /// Gets and sets the property Excludes. 
        /// <para>
        /// A list of filter rules that determines which files to exclude from a task. The list
        /// should contain a single filter string that consists of the patterns to exclude. The
        /// patterns are delimited by "|" (that is, a pipe), for example: <code>"/folder1|/folder2"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the task that was described.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule used to periodically transfer files from a source to a destination location.
        /// </para>
        /// </summary>
        public TaskSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source file system's location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property SourceNetworkInterfaceArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source ENIs (Elastic Network Interface) that
        /// was created for your subnet.
        /// </para>
        /// </summary>
        public List<string> SourceNetworkInterfaceArns
        {
            get { return this._sourceNetworkInterfaceArns; }
            set { this._sourceNetworkInterfaceArns = value; }
        }

        // Check to see if SourceNetworkInterfaceArns property is set
        internal bool IsSetSourceNetworkInterfaceArns()
        {
            return this._sourceNetworkInterfaceArns != null && this._sourceNetworkInterfaceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task that was described.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about task execution statuses, see Understanding Task Statuses
        /// in the <i>AWS DataSync User Guide</i>.
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
        [AWSProperty(Max=128)]
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