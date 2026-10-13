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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Used as a response element in the <a>PreviewAgents</a> action.
    /// </summary>
    public partial class AgentPreview
    {
        /// <summary>
        /// Gets and sets the property AgentHealth. 
        /// <para>
        /// The health status of the Amazon Inspector Agent.
        /// </para>
        /// </summary>
        public AgentHealth AgentHealth { get; set; }

        /// <summary>
        /// Checks to see if the AgentHealth property is set.
        /// </summary>
        internal bool IsSetAgentHealth() => this.AgentHealth != null;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The ID of the EC2 instance where the agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the Amazon Inspector Agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property AutoScalingGroup. 
        /// <para>
        /// The Auto Scaling group for the EC2 instance where the agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AutoScalingGroup { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroup property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroup() => this.AutoScalingGroup != null;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname of the EC2 instance on which the Amazon Inspector Agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// The IP address of the EC2 instance on which the Amazon Inspector Agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 15)]
        public string Ipv4Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4Address property is set.
        /// </summary>
        internal bool IsSetIpv4Address() => this.Ipv4Address != null;

        /// <summary>
        /// Gets and sets the property KernelVersion. 
        /// <para>
        /// The kernel version of the operating system running on the EC2 instance on which the
        /// Amazon Inspector Agent is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string KernelVersion { get; set; }

        /// <summary>
        /// Checks to see if the KernelVersion property is set.
        /// </summary>
        internal bool IsSetKernelVersion() => this.KernelVersion != null;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system running on the EC2 instance on which the Amazon Inspector Agent
        /// is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;
    }
}
