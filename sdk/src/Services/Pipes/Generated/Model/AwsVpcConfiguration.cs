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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// This structure specifies the VPC subnets and security groups for the task, and whether
    /// a public IP address is to be used. This structure is relevant only for ECS tasks that
    /// use the <code>awsvpc</code> network mode.
    /// </summary>
    public partial class AwsVpcConfiguration
    {
        private AssignPublicIp _assignPublicIp;
        private List<string> _securityGroups = new List<string>();
        private List<string> _subnets = new List<string>();

        /// <summary>
        /// Gets and sets the property AssignPublicIp. 
        /// <para>
        /// Specifies whether the task's elastic network interface receives a public IP address.
        /// You can specify <code>ENABLED</code> only when <code>LaunchType</code> in <code>EcsParameters</code>
        /// is set to <code>FARGATE</code>.
        /// </para>
        /// </summary>
        public AssignPublicIp AssignPublicIp
        {
            get { return this._assignPublicIp; }
            set { this._assignPublicIp = value; }
        }

        // Check to see if AssignPublicIp property is set
        internal bool IsSetAssignPublicIp()
        {
            return this._assignPublicIp != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// Specifies the security groups associated with the task. These security groups must
        /// all be in the same VPC. You can specify as many as five security groups. If you do
        /// not specify a security group, the default security group for the VPC is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// Specifies the subnets associated with the task. These subnets must all be in the same
        /// VPC. You can specify as many as 16 subnets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=16)]
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

    }
}