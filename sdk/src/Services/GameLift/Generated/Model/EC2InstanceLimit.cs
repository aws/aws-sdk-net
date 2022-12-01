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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// The GameLift service limits for an Amazon EC2 instance type and current utilization.
    /// GameLift allows Amazon Web Services accounts a maximum number of instances, per instance
    /// type, per Amazon Web Services Region or location, for use with GameLift. You can request
    /// an limit increase for your account by using the <b>Service limits</b> page in the
    /// GameLift console.
    /// </summary>
    public partial class EC2InstanceLimit
    {
        private int? _currentInstances;
        private EC2InstanceType _ec2InstanceType;
        private int? _instanceLimit;
        private string _location;

        /// <summary>
        /// Gets and sets the property CurrentInstances. 
        /// <para>
        /// The number of instances for the specified type and location that are currently being
        /// used by the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// The name of an Amazon EC2 instance type. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// Elastic Compute Cloud Instance Types</a> for detailed descriptions. 
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
        /// The number of instances that is allowed for the specified instance type and location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An Amazon Web Services Region code, such as <code>us-west-2</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}