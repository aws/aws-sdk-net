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
    /// Maximum number of instances allowed based on the Amazon Elastic Compute Cloud (Amazon
    /// EC2) instance type. Instance limits can be retrieved by calling <a>DescribeEC2InstanceLimits</a>.
    /// </summary>
    public partial class EC2InstanceLimit
    {
        private int? _currentInstances;
        private EC2InstanceType _ec2InstanceType;
        private int? _instanceLimit;

        /// <summary>
        /// Gets and sets the property CurrentInstances. 
        /// <para>
        /// Number of instances of the specified type that are currently in use by this AWS account.
        /// </para>
        /// </summary>
        public int CurrentInstances
        {
            get { return this._currentInstances.GetValueOrDefault(); }
            set { this._currentInstances = value; }
        }

        // Check to see if CurrentInstances property is set
        internal bool IsSetCurrentInstances()
        {
            return this._currentInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EC2InstanceType. 
        /// <para>
        /// Name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance
        /// type determines the computing resources of each instance in the fleet, including CPU,
        /// memory, storage, and networking capacity. Amazon GameLift supports the following EC2
        /// instance types. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2
        /// Instance Types</a> for detailed descriptions.
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

        /// <summary>
        /// Gets and sets the property InstanceLimit. 
        /// <para>
        /// Number of instances allowed.
        /// </para>
        /// </summary>
        public int InstanceLimit
        {
            get { return this._instanceLimit.GetValueOrDefault(); }
            set { this._instanceLimit = value; }
        }

        // Check to see if InstanceLimit property is set
        internal bool IsSetInstanceLimit()
        {
            return this._instanceLimit.HasValue; 
        }

    }
}