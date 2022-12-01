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
    /// <b>This data type is used with the GameLift FleetIQ and game server groups.</b> 
    /// 
    ///  
    /// <para>
    /// An allowed instance type for a game server group. All game server groups must have
    /// at least two instance types defined for it. GameLift FleetIQ periodically evaluates
    /// each defined instance type for viability. It then updates the Auto Scaling group with
    /// the list of viable instance types.
    /// </para>
    /// </summary>
    public partial class InstanceDefinition
    {
        private GameServerGroupInstanceType _instanceType;
        private string _weightedCapacity;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// An Amazon EC2 instance type designation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GameServerGroupInstanceType InstanceType
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
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// Instance weighting that indicates how much this instance type contributes to the total
        /// capacity of a game server group. Instance weights are used by GameLift FleetIQ to
        /// calculate the instance type's cost per unit hour and better identify the most cost-effective
        /// options. For detailed information on weighting instance capacity, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-weighting.html">Instance
        /// Weighting</a> in the <i>Amazon Elastic Compute Cloud Auto Scaling User Guide</i>.
        /// Default value is "1".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public string WeightedCapacity
        {
            get { return this._weightedCapacity; }
            set { this._weightedCapacity = value; }
        }

        // Check to see if WeightedCapacity property is set
        internal bool IsSetWeightedCapacity()
        {
            return this._weightedCapacity != null;
        }

    }
}