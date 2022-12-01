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
    /// Settings for a target-based scaling policy. A target-based policy tracks a particular
    /// fleet metric specifies a target value for the metric. As player usage changes, the
    /// policy triggers Amazon GameLift to adjust capacity so that the metric returns to the
    /// target value. The target configuration specifies settings as needed for the target
    /// based policy, including the target value.
    /// </summary>
    public partial class TargetConfiguration
    {
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// Desired value to use with a target-based scaling policy. The value must be relevant
        /// for whatever metric the scaling policy is using. For example, in a policy using the
        /// metric PercentAvailableGameSessions, the target value should be the preferred size
        /// of the fleet's buffer (the percent of capacity that should be idle and ready for new
        /// game sessions).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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