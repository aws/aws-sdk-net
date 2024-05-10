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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private AgentDetails _agentDetails;
        private string _clusterArn;
        private string _instanceId;
        private string _instanceType;
        private ManagementType _managementType;

        /// <summary>
        /// Gets and sets the property AgentDetails. 
        /// <para>
        /// Information about the installed security agent.
        /// </para>
        /// </summary>
        public AgentDetails AgentDetails
        {
            get { return this._agentDetails; }
            set { this._agentDetails = value; }
        }

        // Check to see if AgentDetails property is set
        internal bool IsSetAgentDetails()
        {
            return this._agentDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The cluster ARN of the Amazon ECS cluster running on the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon EC2 instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

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
        public ManagementType ManagementType
        {
            get { return this._managementType; }
            set { this._managementType = value; }
        }

        // Check to see if ManagementType property is set
        internal bool IsSetManagementType()
        {
            return this._managementType != null;
        }

    }
}