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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the Amazon EC2 instance runtime coverage details.
    /// </summary>
    public partial class CoverageEc2InstanceDetails
    {
        /// <summary>
        /// Gets and sets the property AgentDetails. 
        /// <para>
        /// Information about the installed security agent.
        /// </para>
        /// </summary>
        public AgentDetails AgentDetails { get; set; }

        /// <summary>
        /// Checks to see if the AgentDetails property is set.
        /// </summary>
        internal bool IsSetAgentDetails() => this.AgentDetails != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The cluster ARN of the Amazon ECS cluster running on the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon EC2 instance ID.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ManagementType. 
        /// <para>
        /// Indicates how the GuardDuty security agent is managed for this resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTO_MANAGED</c> indicates that GuardDuty deploys and manages updates for this
        /// resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MANUAL</c> indicates that you are responsible to deploy, update, and manage the
        /// GuardDuty security agent updates for this resource.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>DISABLED</c> status doesn't apply to Amazon EC2 instances and Amazon EKS clusters.
        /// </para>
        ///  </note>
        /// </summary>
        public ManagementType ManagementType { get; set; }

        /// <summary>
        /// Checks to see if the ManagementType property is set.
        /// </summary>
        internal bool IsSetManagementType() => this.ManagementType != null;
    }
}
