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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains the execution summary of the computation model.
    /// </summary>
    public partial class ExecutionSummary
    {
        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action exectued.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property ExecutionEndTime. 
        /// <para>
        /// The time the process ended.
        /// </para>
        /// </summary>
        public DateTime? ExecutionEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEndTime property is set.
        /// </summary>
        internal bool IsSetExecutionEndTime() => this.ExecutionEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionEntityVersion. 
        /// <para>
        /// The execution entity version associated with the summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string ExecutionEntityVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEntityVersion property is set.
        /// </summary>
        internal bool IsSetExecutionEntityVersion() => this.ExecutionEntityVersion != null;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The ID of the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property ExecutionStartTime. 
        /// <para>
        /// The time the process started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExecutionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartTime property is set.
        /// </summary>
        internal bool IsSetExecutionStartTime() => this.ExecutionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The status of the execution process.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property ResolveTo. 
        /// <para>
        /// The detailed resource this execution resolves to.
        /// </para>
        /// </summary>
        public ResolveTo ResolveTo { get; set; }

        /// <summary>
        /// Checks to see if the ResolveTo property is set.
        /// </summary>
        internal bool IsSetResolveTo() => this.ResolveTo != null;

        /// <summary>
        /// Gets and sets the property TargetResource.
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetResource TargetResource { get; set; }

        /// <summary>
        /// Checks to see if the TargetResource property is set.
        /// </summary>
        internal bool IsSetTargetResource() => this.TargetResource != null;

        /// <summary>
        /// Gets and sets the property TargetResourceVersion. 
        /// <para>
        /// The version of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string TargetResourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceVersion property is set.
        /// </summary>
        internal bool IsSetTargetResourceVersion() => this.TargetResourceVersion != null;
    }
}
