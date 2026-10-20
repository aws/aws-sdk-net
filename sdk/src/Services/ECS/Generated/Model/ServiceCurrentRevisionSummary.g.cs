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
    /// The summary of the current service revision configuration
    /// </summary>
    public partial class ServiceCurrentRevisionSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the current service revision.
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
        /// The number of pending tasks in the current service revision
        /// </para>
        /// </summary>
        public int? PendingTaskCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingTaskCount property is set.
        /// </summary>
        internal bool IsSetPendingTaskCount() => this.PendingTaskCount.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedTaskCount. 
        /// <para>
        /// The number of requested tasks in the current service revision
        /// </para>
        /// </summary>
        public int? RequestedTaskCount { get; set; }

        /// <summary>
        /// Checks to see if the RequestedTaskCount property is set.
        /// </summary>
        internal bool IsSetRequestedTaskCount() => this.RequestedTaskCount.HasValue;

        /// <summary>
        /// Gets and sets the property RunningTaskCount. 
        /// <para>
        /// The number of running tasks of the current service revision
        /// </para>
        /// </summary>
        public int? RunningTaskCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningTaskCount property is set.
        /// </summary>
        internal bool IsSetRunningTaskCount() => this.RunningTaskCount.HasValue;
    }
}
