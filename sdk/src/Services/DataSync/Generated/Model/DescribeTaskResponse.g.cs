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
    /// This is the response object from the DescribeTask operation.
    /// </summary>
    public partial class DescribeTaskResponse : AmazonWebServiceResponse
    {
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
        [AWSProperty(Min = 0, Max = 562)]
        public string CloudWatchLogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogGroupArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogGroupArn() => this.CloudWatchLogGroupArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentTaskExecutionArn. 
        /// <para>
        /// The ARN of the most recent task execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string CurrentTaskExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the CurrentTaskExecutionArn property is set.
        /// </summary>
        internal bool IsSetCurrentTaskExecutionArn() => this.CurrentTaskExecutionArn != null;

        /// <summary>
        /// Gets and sets the property DestinationLocationArn. 
        /// <para>
        /// The ARN of your transfer's destination location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string DestinationLocationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationLocationArn property is set.
        /// </summary>
        internal bool IsSetDestinationLocationArn() => this.DestinationLocationArn != null;

        /// <summary>
        /// Gets and sets the property DestinationNetworkInterfaceArns. 
        /// <para>
        /// The ARNs of the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/datasync-network.html#required-network-interfaces">network
        /// interfaces</a> that DataSync created for your destination location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DestinationNetworkInterfaceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DestinationNetworkInterfaceArns property is set.
        /// </summary>
        internal bool IsSetDestinationNetworkInterfaceArns() => this.DestinationNetworkInterfaceArns != null && (this.DestinationNetworkInterfaceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// If there's an issue with your task, you can use the error code to help you troubleshoot
        /// the problem. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">Troubleshooting
        /// issues with DataSync transfers</a>.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// If there's an issue with your task, you can use the error details to help you troubleshoot
        /// the problem. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">Troubleshooting
        /// issues with DataSync transfers</a>.
        /// </para>
        /// </summary>
        public string ErrorDetail { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetail property is set.
        /// </summary>
        internal bool IsSetErrorDetail() => this.ErrorDetail != null;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// The exclude filters that define the files, objects, and folders in your source location
        /// that you don't want DataSync to transfer. For more information and examples, see <a
        /// href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
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
        /// Gets and sets the property Includes. 
        /// <para>
        /// The include filters that define the files, objects, and folders in your source location
        /// that you want DataSync to transfer. For more information and examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/filtering.html">Specifying
        /// what DataSync transfers by using filters</a>.
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
        /// Gets and sets the property ManifestConfig. 
        /// <para>
        /// The configuration of the manifest that lists the files or objects that you want DataSync
        /// to transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">Specifying
        /// what DataSync transfers by using a manifest</a>.
        /// </para>
        /// </summary>
        public ManifestConfig ManifestConfig { get; set; }

        /// <summary>
        /// Checks to see if the ManifestConfig property is set.
        /// </summary>
        internal bool IsSetManifestConfig() => this.ManifestConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The task's settings. For example, what file metadata gets preserved, how data integrity
        /// gets verified at the end of your transfer, bandwidth limits, among other options.
        /// </para>
        /// </summary>
        public Options Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule for when you want your task to run. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-scheduling.html">Scheduling
        /// your task</a>.
        /// </para>
        /// </summary>
        public TaskSchedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property ScheduleDetails. 
        /// <para>
        /// The details about your <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-scheduling.html">task
        /// schedule</a>.
        /// </para>
        /// </summary>
        public TaskScheduleDetails ScheduleDetails { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleDetails property is set.
        /// </summary>
        internal bool IsSetScheduleDetails() => this.ScheduleDetails != null;

        /// <summary>
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// The ARN of your transfer's source location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string SourceLocationArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationArn property is set.
        /// </summary>
        internal bool IsSetSourceLocationArn() => this.SourceLocationArn != null;

        /// <summary>
        /// Gets and sets the property SourceNetworkInterfaceArns. 
        /// <para>
        /// The ARNs of the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/datasync-network.html#required-network-interfaces">network
        /// interfaces</a> that DataSync created for your source location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceNetworkInterfaceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceNetworkInterfaceArns property is set.
        /// </summary>
        internal bool IsSetSourceNetworkInterfaceArns() => this.SourceNetworkInterfaceArns != null && (this.SourceNetworkInterfaceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your task. For information about what each status means, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-task-how-to.html#understand-task-creation-statuses">Task
        /// statuses</a>.
        /// </para>
        /// </summary>
        public TaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of your task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

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
        /// The configuration of your task report, which provides detailed information about your
        /// DataSync transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">Monitoring
        /// your DataSync transfers with task reports</a>.
        /// </para>
        /// </summary>
        public TaskReportConfig TaskReportConfig { get; set; }

        /// <summary>
        /// Checks to see if the TaskReportConfig property is set.
        /// </summary>
        internal bool IsSetTaskReportConfig() => this.TaskReportConfig != null;
    }
}
