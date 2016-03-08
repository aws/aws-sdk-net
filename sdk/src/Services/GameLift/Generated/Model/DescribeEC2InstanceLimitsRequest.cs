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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEC2InstanceLimits operation.
    /// Retrieves the maximum number of instances allowed, per AWS account, for each specified
    /// EC2 instance type. The current usage level for the AWS account is also retrieved.
    /// </summary>
    public partial class DescribeEC2InstanceLimitsRequest : AmazonGameLiftRequest
    {
        private EC2InstanceType _ec2InstanceType;

        /// <summary>
        /// Gets and sets the property EC2InstanceType. 
        /// <para>
        /// Type of EC2 instances used in the fleet. EC2 instance types define the CPU, memory,
        /// storage, and networking capacity of the fleetaposs hosts. Amazon GameLift supports
        /// the EC2 instance types listed below. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a> for detailed descriptions of each. Leave this parameter blank
        /// to retrieve limits for all types.
        /// </para>
        /// </summary>
        public EC2InstanceType EC2InstanceType
        {
            get { return this._ec2InstanceType; }
            set { this._ec2InstanceType = value; }
        }

        // Check to see if EC2InstanceType property is set
        internal bool IsSetEC2InstanceType()
        {
            return this._ec2InstanceType != null;
        }

    }
}