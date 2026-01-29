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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Use ManagedCapacityConfiguration with the "SCALE_TO_AND_FROM_ZERO" ZeroCapacityStrategy
    /// to enable Amazon GameLift Servers to fully manage the MinSize value, switching between
    /// 0 and 1 based on game session activity. This is ideal for eliminating compute costs
    /// during periods of no game activity. It is particularly beneficial during development
    /// when you're away from your desk, iterating on builds for extended periods, in production
    /// environments serving low-traffic locations, or for games with long, predictable downtime
    /// windows. By automatically managing capacity between 0 and 1 instances, you avoid paying
    /// for idle instances while maintaining the ability to serve game sessions when demand
    /// arrives. Note that while scale-out is triggered immediately upon receiving a game
    /// session request, actual game session availability depends on your server process startup
    /// time, so this approach works best with multi-location Fleets where cold-start latency
    /// is tolerable. With a "MANUAL" ZeroCapacityStrategy Amazon GameLift Servers will not
    /// modify Fleet MinSize values automatically and will not scale out from zero instances
    /// in response to game sessions.
    /// </summary>
    public partial class ManagedCapacityConfiguration
    {
        private int? _scaleInAfterInactivityMinutes;
        private ZeroCapacityStrategy _zeroCapacityStrategy;

        /// <summary>
        /// Gets and sets the property ScaleInAfterInactivityMinutes. 
        /// <para>
        /// Length of time, in minutes, that Amazon GameLift Servers will wait before scaling
        /// in your MinSize and DesiredInstances to 0 after a period with no game session activity.
        /// Default: 30 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1440)]
        public int ScaleInAfterInactivityMinutes
        {
            get { return this._scaleInAfterInactivityMinutes.GetValueOrDefault(); }
            set { this._scaleInAfterInactivityMinutes = value; }
        }

        // Check to see if ScaleInAfterInactivityMinutes property is set
        internal bool IsSetScaleInAfterInactivityMinutes()
        {
            return this._scaleInAfterInactivityMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZeroCapacityStrategy. 
        /// <para>
        /// The strategy Amazon GameLift Servers will use to automatically scale your capacity
        /// to and from zero instances in response to game session activity. Game session activity
        /// refers to any active running sessions or game session requests.
        /// </para>
        ///  
        /// <para>
        /// Possible ZeroCapacityStrategy types include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>MANUAL</b> -- (default value) Amazon GameLift Servers will not update capacity
        /// to and from zero on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SCALE_TO_AND_FROM_ZERO</b> -- Amazon GameLift Servers will automatically scale
        /// out MinSize and DesiredInstances from 0 to 1 in response to a game session request,
        /// and will scale in MinSize and DesiredInstances to 0 after a period with no game session
        /// activity. The duration of this scale in period can be configured using ScaleInAfterInactivityMinutes.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ZeroCapacityStrategy ZeroCapacityStrategy
        {
            get { return this._zeroCapacityStrategy; }
            set { this._zeroCapacityStrategy = value; }
        }

        // Check to see if ZeroCapacityStrategy property is set
        internal bool IsSetZeroCapacityStrategy()
        {
            return this._zeroCapacityStrategy != null;
        }

    }
}