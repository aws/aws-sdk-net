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
    /// Provides summary information about a monitor alert.
    /// </summary>
    public partial class MonitoringAlertSummary
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of alert actions taken in response to an alert going into <c>InAlert</c> status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringAlertActions Actions { get; set; }

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null;

        /// <summary>
        /// Gets and sets the property AlertStatus. 
        /// <para>
        /// The current status of an alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringAlertStatus AlertStatus { get; set; }

        /// <summary>
        /// Checks to see if the AlertStatus property is set.
        /// </summary>
        internal bool IsSetAlertStatus() => this.AlertStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when a monitor alert was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatapointsToAlert. 
        /// <para>
        /// Within <c>EvaluationPeriod</c>, how many execution failures will raise an alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public int? DatapointsToAlert { get; set; }

        /// <summary>
        /// Checks to see if the DatapointsToAlert property is set.
        /// </summary>
        internal bool IsSetDatapointsToAlert() => this.DatapointsToAlert.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationPeriod. 
        /// <para>
        /// The number of most recent monitoring executions to consider when evaluating alert
        /// status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public int? EvaluationPeriod { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationPeriod property is set.
        /// </summary>
        internal bool IsSetEvaluationPeriod() => this.EvaluationPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that indicates when a monitor alert was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringAlertName. 
        /// <para>
        /// The name of a monitoring alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string MonitoringAlertName { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringAlertName property is set.
        /// </summary>
        internal bool IsSetMonitoringAlertName() => this.MonitoringAlertName != null;
    }
}
