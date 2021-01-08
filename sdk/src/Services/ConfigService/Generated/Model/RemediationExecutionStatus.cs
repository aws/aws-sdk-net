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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides details of the current status of the invoked remediation action for that
    /// resource.
    /// </summary>
    public partial class RemediationExecutionStatus
    {
        private DateTime? _invocationTime;
        private DateTime? _lastUpdatedTime;
        private ResourceKey _resourceKey;
        private RemediationExecutionState _state;
        private List<RemediationExecutionStep> _stepDetails = new List<RemediationExecutionStep>();

        /// <summary>
        /// Gets and sets the property InvocationTime. 
        /// <para>
        /// Start time when the remediation was executed.
        /// </para>
        /// </summary>
        public DateTime InvocationTime
        {
            get { return this._invocationTime.GetValueOrDefault(); }
            set { this._invocationTime = value; }
        }

        // Check to see if InvocationTime property is set
        internal bool IsSetInvocationTime()
        {
            return this._invocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the remediation execution was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceKey.
        /// </summary>
        public ResourceKey ResourceKey
        {
            get { return this._resourceKey; }
            set { this._resourceKey = value; }
        }

        // Check to see if ResourceKey property is set
        internal bool IsSetResourceKey()
        {
            return this._resourceKey != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// ENUM of the values.
        /// </para>
        /// </summary>
        public RemediationExecutionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StepDetails. 
        /// <para>
        /// Details of every step.
        /// </para>
        /// </summary>
        public List<RemediationExecutionStep> StepDetails
        {
            get { return this._stepDetails; }
            set { this._stepDetails = value; }
        }

        // Check to see if StepDetails property is set
        internal bool IsSetStepDetails()
        {
            return this._stepDetails != null && this._stepDetails.Count > 0; 
        }

    }
}