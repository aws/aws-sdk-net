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
    /// DescribeTaskResponse
    /// </summary>
    public partial class DescribeTaskResponse : AmazonWebServiceResponse
    {
        private string _cloudWatchLogGroupArn;
        private DateTime? _creationTime;
        private string _currentTaskExecutionArn;
        private string _destinationLocationArn;
        private List<string> _destinationNetworkInterfaceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _errorCode;
        private string _errorDetail;
        private List<FilterRule> _excludes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private List<FilterRule> _includes = AWSConfigs.InitializeCollections ? new List<FilterRule>() : null;
        private ManifestConfig _manifestConfig;
        private string _name;
        private Options _options;
        private TaskSchedule _schedule;
        private TaskScheduleDetails _scheduleDetails;
        private string _sourceLocationArn;
        private List<string> _sourceNetworkInterfaceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TaskStatus _status;
        private string _taskArn;
        private TaskMode _taskMode;
        private TaskReportConfig _taskReportConfig;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon CloudWatch log group for monitoring your
        /// task.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-logging.html">Monitoring
        /// data transfers with CloudWatch Logs</a>.
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
        /// Gets and sets the property CurrentTaskExecutionArn. 
        /// <para>
        /// The ARN of the most recent task execution.
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
        /// The ARN of your transfer's destination location.
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
        /// The ARNs of the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/datasync-network.html#required-network-interfaces">network
        /// interfaces</a> that DataSync created for your destination location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DestinationNetworkInterfaceArns
        {
            get { return this._destinationNetworkInterfaceArns; }
            set { this._destinationNetworkInterfaceArns = value; }
        }

        // Check to see if DestinationNetworkInterfaceArns property is set
        internal bool IsSetDestinationNetworkInterfaceArns()
        {
            return this._destinationNetworkInterfaceArns != null && (this._destinationNetworkInterfaceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// If there's an issue with your task, you can use the error code to help you troubleshoot
        /// the problem. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">Troubleshooting
        /// issues with DataSync transfers</a>.
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
        /// If there's an issue with your task, you can use the error details to help you troubleshoot
        /// the problem. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">Troubleshooting
        /// issues with DataSync transfers</a>.
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
        /// The exclude filters that define the files, objects, and folders in your source location
        /// that you don't want DataSync to transfer. For more information and examples, see <a
        /// href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
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
        /// Gets and sets the property Includes. 
        /// <para>
        /// The include filters that define the files, objects, and folders in your source location
        /// that you want DataSync to transfer. For more information and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
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
        /// Gets and sets the property ManifestConfig. 
        /// <para>
        /// The configuration of the manifest that lists the files or objects that you want DataSync
        /// to transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">Specifying
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// The task's settings. For example, what file metadata gets preserved, how data integrity
        /// gets verified at the end of your transfer, bandwidth limits, among other options.
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
        /// The schedule for when you want your task to run. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-scheduling.html">Scheduling
        /// your task</a>.
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
        /// Gets and sets the property ScheduleDetails. 
        /// <para>
        /// The details about your <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-scheduling.html">task
        /// schedule</a>.
        /// </para>
        /// </summary>
        public TaskScheduleDetails ScheduleDetails
        {
            get { return this._scheduleDetails; }
            set { this._scheduleDetails = value; }
        }

        // Check to see if ScheduleDetails property is set
        internal bool IsSetScheduleDetails()
        {
            return this._scheduleDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// The ARN of your transfer's source location.
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
        /// The ARNs of the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/datasync-network.html#required-network-interfaces">network
        /// interfaces</a> that DataSync created for your source location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceNetworkInterfaceArns
        {
            get { return this._sourceNetworkInterfaceArns; }
            set { this._sourceNetworkInterfaceArns = value; }
        }

        // Check to see if SourceNetworkInterfaceArns property is set
        internal bool IsSetSourceNetworkInterfaceArns()
        {
            return this._sourceNetworkInterfaceArns != null && (this._sourceNetworkInterfaceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your task. For information about what each status means, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/understand-task-statuses.html#understand-task-creation-statuses">Task
        /// statuses</a>.
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
        /// The ARN of your task.
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
        /// The configuration of your task report, which provides detailed information about your
        /// DataSync transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">Monitoring
        /// your DataSync transfers with task reports</a>.
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