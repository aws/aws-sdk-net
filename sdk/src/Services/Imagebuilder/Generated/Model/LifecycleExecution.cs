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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
        private DateTime? _endTime;
        private string _lifecycleExecutionId;
        private string _lifecyclePolicyArn;
        private LifecycleExecutionResourcesImpactedSummary _resourcesImpactedSummary;
        private DateTime? _startTime;
        private LifecycleExecutionState _state;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the lifecycle runtime instance completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleExecutionId. 
        /// <para>
        /// Identifies the lifecycle policy runtime instance.
        /// </para>
        /// </summary>
        public string LifecycleExecutionId
        {
            get { return this._lifecycleExecutionId; }
            set { this._lifecycleExecutionId = value; }
        }

        // Check to see if LifecycleExecutionId property is set
        internal bool IsSetLifecycleExecutionId()
        {
            return this._lifecycleExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle policy that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string LifecyclePolicyArn
        {
            get { return this._lifecyclePolicyArn; }
            set { this._lifecyclePolicyArn = value; }
        }

        // Check to see if LifecyclePolicyArn property is set
        internal bool IsSetLifecyclePolicyArn()
        {
            return this._lifecyclePolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcesImpactedSummary. 
        /// <para>
        /// Contains information about associated resources that are identified for action by
        /// the runtime instance of the lifecycle policy.
        /// </para>
        /// </summary>
        public LifecycleExecutionResourcesImpactedSummary ResourcesImpactedSummary
        {
            get { return this._resourcesImpactedSummary; }
            set { this._resourcesImpactedSummary = value; }
        }

        // Check to see if ResourcesImpactedSummary property is set
        internal bool IsSetResourcesImpactedSummary()
        {
            return this._resourcesImpactedSummary != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the lifecycle runtime instance started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Runtime state that reports if the policy action ran successfully, failed, or was skipped.
        /// </para>
        /// </summary>
        public LifecycleExecutionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}