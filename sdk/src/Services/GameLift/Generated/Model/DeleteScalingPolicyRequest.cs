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
    /// Container for the parameters to the DeleteScalingPolicy operation.
    /// Deletes a fleet scaling policy. Once deleted, the policy is no longer in force and
    /// GameLift removes all record of it. To delete a scaling policy, specify both the scaling
    /// policy name and the fleet ID it is associated with.
    /// 
    ///  
    /// <para>
    /// To temporarily suspend scaling policies, call <a>StopFleetActions</a>. This operation
    /// suspends all policies for the fleet.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEC2InstanceLimits</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Manage scaling policies:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>PutScalingPolicy</a> (auto-scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScalingPolicies</a> (auto-scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScalingPolicy</a> (auto-scaling)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Manage fleet actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopFleetActions</a> 
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class DeleteScalingPolicyRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private string _name;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for a fleet to be deleted. You can use either the fleet ID or
        /// ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a scaling policy. Policy names do not
        /// need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}