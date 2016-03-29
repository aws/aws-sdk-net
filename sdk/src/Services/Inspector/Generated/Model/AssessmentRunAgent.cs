/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about an Inspector agent. This data type is used as a response
    /// element in the <a>ListAssessmentRunAgents</a> action.
    /// </summary>
    public partial class AssessmentRunAgent
    {
        private AgentHealth _agentHealth;
        private AgentHealthCode _agentHealthCode;
        private string _agentHealthDetails;
        private string _agentId;
        private string _assessmentRunArn;
        private string _autoScalingGroup;
        private List<TelemetryMetadata> _telemetryMetadata = new List<TelemetryMetadata>();

        /// <summary>
        /// Gets and sets the property AgentHealth. 
        /// <para>
        /// The current health state of the agent.
        /// </para>
        /// </summary>
        public AgentHealth AgentHealth
        {
            get { return this._agentHealth; }
            set { this._agentHealth = value; }
        }

        // Check to see if AgentHealth property is set
        internal bool IsSetAgentHealth()
        {
            return this._agentHealth != null;
        }

        /// <summary>
        /// Gets and sets the property AgentHealthCode. 
        /// <para>
        /// The detailed health state of the agent.
        /// </para>
        /// </summary>
        public AgentHealthCode AgentHealthCode
        {
            get { return this._agentHealthCode; }
            set { this._agentHealthCode = value; }
        }

        // Check to see if AgentHealthCode property is set
        internal bool IsSetAgentHealthCode()
        {
            return this._agentHealthCode != null;
        }

        /// <summary>
        /// Gets and sets the property AgentHealthDetails. 
        /// <para>
        /// The description for the agent health code.
        /// </para>
        /// </summary>
        public string AgentHealthDetails
        {
            get { return this._agentHealthDetails; }
            set { this._agentHealthDetails = value; }
        }

        // Check to see if AgentHealthDetails property is set
        internal bool IsSetAgentHealthDetails()
        {
            return this._agentHealthDetails != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// AWS account of the EC2 instance where the agent is installed.
        /// </para>
        /// </summary>
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentRunArn. 
        /// <para>
        /// The ARN of the assessment run that is associated with the agent.
        /// </para>
        /// </summary>
        public string AssessmentRunArn
        {
            get { return this._assessmentRunArn; }
            set { this._assessmentRunArn = value; }
        }

        // Check to see if AssessmentRunArn property is set
        internal bool IsSetAssessmentRunArn()
        {
            return this._assessmentRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroup. 
        /// <para>
        /// The auto-scaling group of the EC2 instance specified by the agent ID.
        /// </para>
        /// </summary>
        public string AutoScalingGroup
        {
            get { return this._autoScalingGroup; }
            set { this._autoScalingGroup = value; }
        }

        // Check to see if AutoScalingGroup property is set
        internal bool IsSetAutoScalingGroup()
        {
            return this._autoScalingGroup != null;
        }

        /// <summary>
        /// Gets and sets the property TelemetryMetadata. 
        /// <para>
        /// The Inspector application data metrics collected by the agent. 
        /// </para>
        /// </summary>
        public List<TelemetryMetadata> TelemetryMetadata
        {
            get { return this._telemetryMetadata; }
            set { this._telemetryMetadata = value; }
        }

        // Check to see if TelemetryMetadata property is set
        internal bool IsSetTelemetryMetadata()
        {
            return this._telemetryMetadata != null && this._telemetryMetadata.Count > 0; 
        }

    }
}