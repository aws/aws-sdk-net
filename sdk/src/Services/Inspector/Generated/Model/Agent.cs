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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
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
    /// element in the <a>ListAssessmentAgents</a> action.
    /// </summary>
    public partial class Agent
    {
        private string _accountId;
        private string _agentHealth;
        private string _agentHealthCode;
        private string _agentHealthDetails;
        private string _agentId;
        private string _assessmentArn;
        private string _autoScalingGroup;
        private List<Telemetry> _telemetry = new List<Telemetry>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// AWS account of the EC2 instance where the agent is installed.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentHealth. 
        /// <para>
        /// The current health state of the agent. Values can be set to <i>HEALTHY</i> or <i>UNHEALTHY</i>.
        /// </para>
        /// </summary>
        public string AgentHealth
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
        /// The detailed health state of the agent. Values can be set to <i>RUNNING</i>, <i>HEALTHY</i>,
        /// <i>UNHEALTHY</i>, <i>UNKNOWN</i>, <i>BLACKLISTED</i>, <i>SHUTDOWN</i>, <i>THROTTLED</i>.
        /// 
        /// </para>
        /// </summary>
        public string AgentHealthCode
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
        /// The EC2 instance ID where the agent is installed.
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
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The ARN of the assessment that is associated with the agent.
        /// </para>
        /// </summary>
        public string AssessmentArn
        {
            get { return this._assessmentArn; }
            set { this._assessmentArn = value; }
        }

        // Check to see if AssessmentArn property is set
        internal bool IsSetAssessmentArn()
        {
            return this._assessmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroup. 
        /// <para>
        /// This data type property is currently not used.
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
        /// Gets and sets the property Telemetry. 
        /// <para>
        /// The Inspector application data metrics collected by the agent. 
        /// </para>
        /// </summary>
        public List<Telemetry> Telemetry
        {
            get { return this._telemetry; }
            set { this._telemetry = value; }
        }

        // Check to see if Telemetry property is set
        internal bool IsSetTelemetry()
        {
            return this._telemetry != null && this._telemetry.Count > 0; 
        }

    }
}