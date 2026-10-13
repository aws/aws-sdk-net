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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribeMonitor operation.
    /// </summary>
    public partial class DescribeMonitorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Baseline. 
        /// <para>
        /// Metrics you can use as a baseline for comparison purposes. Use these values you interpret
        /// monitoring results for an auto predictor.
        /// </para>
        /// </summary>
        public Baseline Baseline { get; set; }

        /// <summary>
        /// Checks to see if the Baseline property is set.
        /// </summary>
        internal bool IsSetBaseline() => this.Baseline != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp for when the monitor resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedEvaluationTimeRemainingInMinutes. 
        /// <para>
        /// The estimated number of minutes remaining before the monitor resource finishes its
        /// current evaluation.
        /// </para>
        /// </summary>
        public long? EstimatedEvaluationTimeRemainingInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedEvaluationTimeRemainingInMinutes property is set.
        /// </summary>
        internal bool IsSetEstimatedEvaluationTimeRemainingInMinutes() => this.EstimatedEvaluationTimeRemainingInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property LastEvaluationState. 
        /// <para>
        /// The state of the monitor's latest evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string LastEvaluationState { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluationState property is set.
        /// </summary>
        internal bool IsSetLastEvaluationState() => this.LastEvaluationState != null;

        /// <summary>
        /// Gets and sets the property LastEvaluationTime. 
        /// <para>
        /// The timestamp of the latest evaluation completed by the monitor.
        /// </para>
        /// </summary>
        public DateTime? LastEvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluationTime property is set.
        /// </summary>
        internal bool IsSetLastEvaluationTime() => this.LastEvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The timestamp of the latest modification to the monitor.
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An error message, if any, for the monitor.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitor resource described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MonitorArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitorArn property is set.
        /// </summary>
        internal bool IsSetMonitorArn() => this.MonitorArn != null;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string MonitorName { get; set; }

        /// <summary>
        /// Checks to see if the MonitorName property is set.
        /// </summary>
        internal bool IsSetMonitorName() => this.MonitorName != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the auto predictor being monitored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the monitor resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
