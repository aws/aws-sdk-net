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
    /// This is the response object from the DescribeMonitoringSchedule operation.
    /// </summary>
    public partial class DescribeMonitoringScheduleResponse : AmazonWebServiceResponse
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
        ///  The name of the endpoint for the monitoring job.
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
        /// A string, up to one KB in size, that contains the reason a monitoring job failed,
        /// if it failed.
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
        /// The time at which the monitoring job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastMonitoringExecutionSummary. 
        /// <para>
        /// Describes metadata on the last execution to run, if there was one.
        /// </para>
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
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string MonitoringScheduleArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleArn property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleArn() => this.MonitoringScheduleArn != null;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleConfig. 
        /// <para>
        /// The configuration object that specifies the monitoring schedule and defines the monitoring
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringScheduleConfig MonitoringScheduleConfig { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleConfig property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleConfig() => this.MonitoringScheduleConfig != null;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// Name of the monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string MonitoringScheduleName { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleName property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleName() => this.MonitoringScheduleName != null;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleStatus. 
        /// <para>
        /// The status of an monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleStatus MonitoringScheduleStatus { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleStatus property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleStatus() => this.MonitoringScheduleStatus != null;

        /// <summary>
        /// Gets and sets the property MonitoringType. 
        /// <para>
        /// The type of the monitoring job that this schedule runs. This is one of the following
        /// values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DATA_QUALITY</c> - The schedule is for a data quality monitoring job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODEL_QUALITY</c> - The schedule is for a model quality monitoring job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODEL_BIAS</c> - The schedule is for a bias monitoring job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODEL_EXPLAINABILITY</c> - The schedule is for an explainability monitoring job.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MonitoringType MonitoringType { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringType property is set.
        /// </summary>
        internal bool IsSetMonitoringType() => this.MonitoringType != null;
    }
}
