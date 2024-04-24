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
    /// Used as a response element in the <a>PreviewAgents</a> action.
    /// </summary>
    public partial class AgentPreview
    {
        private AgentHealth _agentHealth;
        private string _agentId;
        private string _agentVersion;
        private string _autoScalingGroup;
        private string _hostname;
        private string _ipv4Address;
        private string _kernelVersion;
        private string _operatingSystem;

        /// <summary>
        /// Gets and sets the property AgentHealth. 
        /// <para>
        /// The health status of the Amazon Inspector Agent.
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
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The ID of the EC2 instance where the agent is installed.
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
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the Amazon Inspector Agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroup. 
        /// <para>
        /// The Auto Scaling group for the EC2 instance where the agent is installed.
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
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname of the EC2 instance on which the Amazon Inspector Agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// The IP address of the EC2 instance on which the Amazon Inspector Agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=15)]
        public string Ipv4Address
        {
            get { return this._ipv4Address; }
            set { this._ipv4Address = value; }
        }

        // Check to see if Ipv4Address property is set
        internal bool IsSetIpv4Address()
        {
            return this._ipv4Address != null;
        }

        /// <summary>
        /// Gets and sets the property KernelVersion. 
        /// <para>
        /// The kernel version of the operating system running on the EC2 instance on which the
        /// Amazon Inspector Agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string KernelVersion
        {
            get { return this._kernelVersion; }
            set { this._kernelVersion = value; }
        }

        // Check to see if KernelVersion property is set
        internal bool IsSetKernelVersion()
        {
            return this._kernelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system running on the EC2 instance on which the Amazon Inspector Agent
        /// is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

    }
}