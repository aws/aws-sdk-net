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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Contains information about a step in an automation event.
    /// </summary>
    public partial class AutomationEventStep
    {
        /// <summary>
        /// Gets and sets the property CompletedTimestamp. 
        /// <para>
        /// The timestamp when this automation event step completed execution.
        /// </para>
        /// </summary>
        public DateTime? CompletedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CompletedTimestamp property is set.
        /// </summary>
        internal bool IsSetCompletedTimestamp() => this.CompletedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings.
        /// </summary>
        public EstimatedMonthlySavings EstimatedMonthlySavings { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavings property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavings() => this.EstimatedMonthlySavings != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        ///  The ID of the automation event this step belongs to. 
        /// </para>
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier of the resource being acted upon in this step.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The timestamp when this automation event step started execution.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StepId. 
        /// <para>
        ///  The unique identifier for this step. 
        /// </para>
        /// </summary>
        public string StepId { get; set; }

        /// <summary>
        /// Checks to see if the StepId property is set.
        /// </summary>
        internal bool IsSetStepId() => this.StepId != null;

        /// <summary>
        /// Gets and sets the property StepStatus. 
        /// <para>
        ///  The current status of the step. 
        /// </para>
        /// </summary>
        public StepStatus StepStatus { get; set; }

        /// <summary>
        /// Checks to see if the StepStatus property is set.
        /// </summary>
        internal bool IsSetStepStatus() => this.StepStatus != null;

        /// <summary>
        /// Gets and sets the property StepType. 
        /// <para>
        ///  The type of step. 
        /// </para>
        /// </summary>
        public StepType StepType { get; set; }

        /// <summary>
        /// Checks to see if the StepType property is set.
        /// </summary>
        internal bool IsSetStepType() => this.StepType != null;
    }
}
