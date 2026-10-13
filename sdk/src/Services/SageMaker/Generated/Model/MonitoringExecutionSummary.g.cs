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
    /// Summary of information about the last monitoring job to run.
    /// </summary>
    public partial class MonitoringExecutionSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the monitoring job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint used to run the monitoring job.
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
        /// Contains the reason a monitoring job failed, if it failed.
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
        /// A timestamp that indicates the last time the monitoring job was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringExecutionStatus. 
        /// <para>
        /// The status of the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionStatus MonitoringExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringExecutionStatus property is set.
        /// </summary>
        internal bool IsSetMonitoringExecutionStatus() => this.MonitoringExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property MonitoringJobDefinitionName. 
        /// <para>
        /// The name of the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string MonitoringJobDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringJobDefinitionName property is set.
        /// </summary>
        internal bool IsSetMonitoringJobDefinitionName() => this.MonitoringJobDefinitionName != null;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// The name of the monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string MonitoringScheduleName { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleName property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleName() => this.MonitoringScheduleName != null;

        /// <summary>
        /// Gets and sets the property MonitoringType. 
        /// <para>
        /// The type of the monitoring job.
        /// </para>
        /// </summary>
        public MonitoringType MonitoringType { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringType property is set.
        /// </summary>
        internal bool IsSetMonitoringType() => this.MonitoringType != null;

        /// <summary>
        /// Gets and sets the property ProcessingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ProcessingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJobArn property is set.
        /// </summary>
        internal bool IsSetProcessingJobArn() => this.ProcessingJobArn != null;

        /// <summary>
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The time the monitoring job was scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ScheduledTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledTime property is set.
        /// </summary>
        internal bool IsSetScheduledTime() => this.ScheduledTime.HasValue;
    }
}
