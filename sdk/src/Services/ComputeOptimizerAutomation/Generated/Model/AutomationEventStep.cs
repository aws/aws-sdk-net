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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
        private DateTime? _completedTimestamp;
        private EstimatedMonthlySavings _estimatedMonthlySavings;
        private string _eventId;
        private string _resourceId;
        private DateTime? _startTimestamp;
        private string _stepId;
        private StepStatus _stepStatus;
        private StepType _stepType;

        /// <summary>
        /// Gets and sets the property CompletedTimestamp. 
        /// <para>
        /// The timestamp when this automation event step completed execution.
        /// </para>
        /// </summary>
        public DateTime CompletedTimestamp
        {
            get { return this._completedTimestamp.GetValueOrDefault(); }
            set { this._completedTimestamp = value; }
        }

        // Check to see if CompletedTimestamp property is set
        internal bool IsSetCompletedTimestamp()
        {
            return this._completedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings.
        /// </summary>
        public EstimatedMonthlySavings EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        ///  The ID of the automation event this step belongs to. 
        /// </para>
        /// </summary>
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier of the resource being acted upon in this step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The timestamp when this automation event step started execution.
        /// </para>
        /// </summary>
        public DateTime StartTimestamp
        {
            get { return this._startTimestamp.GetValueOrDefault(); }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepId. 
        /// <para>
        ///  The unique identifier for this step. 
        /// </para>
        /// </summary>
        public string StepId
        {
            get { return this._stepId; }
            set { this._stepId = value; }
        }

        // Check to see if StepId property is set
        internal bool IsSetStepId()
        {
            return this._stepId != null;
        }

        /// <summary>
        /// Gets and sets the property StepStatus. 
        /// <para>
        ///  The current status of the step. 
        /// </para>
        /// </summary>
        public StepStatus StepStatus
        {
            get { return this._stepStatus; }
            set { this._stepStatus = value; }
        }

        // Check to see if StepStatus property is set
        internal bool IsSetStepStatus()
        {
            return this._stepStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StepType. 
        /// <para>
        ///  The type of step. 
        /// </para>
        /// </summary>
        public StepType StepType
        {
            get { return this._stepType; }
            set { this._stepType = value; }
        }

        // Check to see if StepType property is set
        internal bool IsSetStepType()
        {
            return this._stepType != null;
        }

    }
}