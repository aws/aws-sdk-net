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
    /// Settings for a target-based scaling policy as part of a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerGroupAutoScalingPolicy.html">GameServerGroupAutoScalingPolicy</a>
    /// . These settings are used to create a target-based policy that tracks the GameLift
    /// FleetIQ metric <code>"PercentUtilizedGameServers"</code> and specifies a target value
    /// for the metric. As player usage changes, the policy triggers to adjust the game server
    /// group capacity so that the metric returns to the target value. 
    /// </para>
    /// </summary>
    public partial class TargetTrackingConfiguration
    {
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// Desired value to use with a game server group target-based scaling policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double TargetValue
        {
            get { return this._targetValue.GetValueOrDefault(); }
            set { this._targetValue = value; }
        }

        // Check to see if TargetValue property is set
        internal bool IsSetTargetValue()
        {
            return this._targetValue.HasValue; 
        }

    }
}