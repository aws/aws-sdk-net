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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A schedule for a model monitoring job. For information about model monitor, see <a
    /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon SageMaker
    /// Model Monitor</a>.
    /// </summary>
    public partial class MonitoringSchedule
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the monitoring schedule was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The endpoint that hosts the model being monitored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the monitoring schedule failed, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the monitoring schedule was changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastMonitoringExecutionSummary.
        /// </summary>
        public MonitoringExecutionSummary LastMonitoringExecutionSummary { get; set; }

        /// <summary>
        /// Checks to see if the LastMonitoringExecutionSummary property is set.
        /// </summary>
        internal bool IsSetLastMonitoringExecutionSummary() => this.LastMonitoringExecutionSummary != null;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MonitoringScheduleArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleArn property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleArn() => this.MonitoringScheduleArn != null;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleConfig.
        /// </summary>
        public MonitoringScheduleConfig MonitoringScheduleConfig { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleConfig property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleConfig() => this.MonitoringScheduleConfig != null;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// The name of the monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string MonitoringScheduleName { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleName property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleName() => this.MonitoringScheduleName != null;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleStatus. 
        /// <para>
        /// The status of the monitoring schedule. This can be one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The schedule is pending being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The schedule failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCHEDULED</c> - The schedule was successfully created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> - The schedule was stopped.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScheduleStatus MonitoringScheduleStatus { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleStatus property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleStatus() => this.MonitoringScheduleStatus != null;

        /// <summary>
        /// Gets and sets the property MonitoringType. 
        /// <para>
        /// The type of the monitoring job definition to schedule.
        /// </para>
        /// </summary>
        public MonitoringType MonitoringType { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringType property is set.
        /// </summary>
        internal bool IsSetMonitoringType() => this.MonitoringType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tags associated with the monitoring schedlue. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
