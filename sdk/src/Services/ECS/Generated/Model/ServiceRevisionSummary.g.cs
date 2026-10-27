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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The information about the number of requested, pending, and running tasks for a service
    /// revision.
    /// </summary>
    public partial class ServiceRevisionSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the service revision.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property PendingTaskCount. 
        /// <para>
        /// The number of pending tasks for the service revision.
        /// </para>
        /// </summary>
        public int? PendingTaskCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingTaskCount property is set.
        /// </summary>
        internal bool IsSetPendingTaskCount() => this.PendingTaskCount.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedProductionTrafficWeight. 
        /// <para>
        /// The percentage of production traffic that is directed to this service revision. This
        /// value represents a snapshot of the traffic distribution and may not reflect real-time
        /// changes during active deployments. Valid values are 0.0 to 100.0.
        /// </para>
        /// </summary>
        public double? RequestedProductionTrafficWeight { get; set; }

        /// <summary>
        /// Checks to see if the RequestedProductionTrafficWeight property is set.
        /// </summary>
        internal bool IsSetRequestedProductionTrafficWeight() => this.RequestedProductionTrafficWeight.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedTaskCount. 
        /// <para>
        /// The number of requested tasks for the service revision.
        /// </para>
        /// </summary>
        public int? RequestedTaskCount { get; set; }

        /// <summary>
        /// Checks to see if the RequestedTaskCount property is set.
        /// </summary>
        internal bool IsSetRequestedTaskCount() => this.RequestedTaskCount.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedTestTrafficWeight. 
        /// <para>
        /// The percentage of test traffic that is directed to this service revision. This value
        /// represents a snapshot of the traffic distribution and may not reflect real-time changes
        /// during active deployments. Valid values are 0.0 to 100.0.
        /// </para>
        /// </summary>
        public double? RequestedTestTrafficWeight { get; set; }

        /// <summary>
        /// Checks to see if the RequestedTestTrafficWeight property is set.
        /// </summary>
        internal bool IsSetRequestedTestTrafficWeight() => this.RequestedTestTrafficWeight.HasValue;

        /// <summary>
        /// Gets and sets the property RunningTaskCount. 
        /// <para>
        /// The number of running tasks for the service revision.
        /// </para>
        /// </summary>
        public int? RunningTaskCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningTaskCount property is set.
        /// </summary>
        internal bool IsSetRunningTaskCount() => this.RunningTaskCount.HasValue;
    }
}
