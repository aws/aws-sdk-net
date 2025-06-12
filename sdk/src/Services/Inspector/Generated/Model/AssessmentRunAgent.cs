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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about an Amazon Inspector agent. This data type is used as a
    /// response element in the <a>ListAssessmentRunAgents</a> action.
    /// </summary>
    public partial class AssessmentRunAgent
    {
        private AgentHealth _agentHealth;
        private AgentHealthCode _agentHealthCode;
        private string _agentHealthDetails;
        private string _agentId;
        private string _assessmentRunArn;
        private string _autoScalingGroup;
        private List<TelemetryMetadata> _telemetryMetadata = AWSConfigs.InitializeCollections ? new List<TelemetryMetadata>() : null;

        /// <summary>
        /// Gets and sets the property AgentHealth. 
        /// <para>
        /// The current health state of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Min=0, Max=1000)]
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
        /// The AWS account of the EC2 instance where the agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        [AWSProperty(Required=true, Min=1, Max=300)]
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
        /// The Auto Scaling group of the EC2 instance that is specified by the agent ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// The Amazon Inspector application data metrics that are collected by the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5000)]
        public List<TelemetryMetadata> TelemetryMetadata
        {
            get { return this._telemetryMetadata; }
            set { this._telemetryMetadata = value; }
        }

        // Check to see if TelemetryMetadata property is set
        internal bool IsSetTelemetryMetadata()
        {
            return this._telemetryMetadata != null && (this._telemetryMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}