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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
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
namespace Amazon.Scheduler.Model
{
    /// <summary>
    /// This structure specifies the VPC subnets and security groups for the task, and whether
    /// a public IP address is to be used. This structure is relevant only for ECS tasks that
    /// use the awsvpc network mode.
    /// </summary>
    public partial class AwsVpcConfiguration
    {
        private AssignPublicIp _assignPublicIp;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AssignPublicIp. 
        /// <para>
        /// Specifies whether the task's elastic network interface receives a public IP address.
        /// You can specify <c>ENABLED</c> only when <c>LaunchType</c> in <c>EcsParameters</c>
        /// is set to <c>FARGATE</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// Specifies the subnets associated with the task. These subnets must all be in the same
        /// VPC. You can specify as many as 16 subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}