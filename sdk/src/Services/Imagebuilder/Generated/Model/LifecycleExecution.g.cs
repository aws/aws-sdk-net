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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains metadata from a runtime instance of a lifecycle policy.
    /// </summary>
    public partial class LifecycleExecution
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the lifecycle runtime instance completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleExecutionId. 
        /// <para>
        /// Identifies the lifecycle policy runtime instance.
        /// </para>
        /// </summary>
        public string LifecycleExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleExecutionId property is set.
        /// </summary>
        internal bool IsSetLifecycleExecutionId() => this.LifecycleExecutionId != null;

        /// <summary>
        /// Gets and sets the property LifecyclePolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle policy that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LifecyclePolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the LifecyclePolicyArn property is set.
        /// </summary>
        internal bool IsSetLifecyclePolicyArn() => this.LifecyclePolicyArn != null;

        /// <summary>
        /// Gets and sets the property ResourcesImpactedSummary. 
        /// <para>
        /// A summary flag that indicates whether the lifecycle execution identified any resources
        /// to take lifecycle actions on.
        /// </para>
        /// </summary>
        public LifecycleExecutionResourcesImpactedSummary ResourcesImpactedSummary { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesImpactedSummary property is set.
        /// </summary>
        internal bool IsSetResourcesImpactedSummary() => this.ResourcesImpactedSummary != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the lifecycle runtime instance started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Runtime state that reports whether the lifecycle execution is in progress, succeeded,
        /// or failed.
        /// </para>
        /// </summary>
        public LifecycleExecutionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
