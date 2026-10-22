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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the capacity status for a fleet.
    /// </summary>
    public partial class ComputeCapacityStatus
    {
        /// <summary>
        /// Gets and sets the property ActiveUserSessions. 
        /// <para>
        /// The number of user sessions currently being used for streaming sessions. This only
        /// applies to multi-session fleets.
        /// </para>
        /// </summary>
        public int? ActiveUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the ActiveUserSessions property is set.
        /// </summary>
        internal bool IsSetActiveUserSessions() => this.ActiveUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property ActualUserSessions. 
        /// <para>
        /// The total number of session slots that are available for streaming or are currently
        /// streaming.
        /// </para>
        ///  
        /// <para>
        /// ActualUserSessionCapacity = AvailableUserSessionCapacity + ActiveUserSessions
        /// </para>
        ///  
        /// <para>
        /// This only applies to multi-session fleets.
        /// </para>
        /// </summary>
        public int? ActualUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the ActualUserSessions property is set.
        /// </summary>
        internal bool IsSetActualUserSessions() => this.ActualUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property Available. 
        /// <para>
        /// The number of currently available instances that can be used to stream sessions.
        /// </para>
        /// </summary>
        public int? Available { get; set; }

        /// <summary>
        /// Checks to see if the Available property is set.
        /// </summary>
        internal bool IsSetAvailable() => this.Available.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableUserSessions. 
        /// <para>
        /// The number of idle session slots currently available for user sessions.
        /// </para>
        ///  
        /// <para>
        /// AvailableUserSessionCapacity = ActualUserSessionCapacity - ActiveUserSessions
        /// </para>
        ///  
        /// <para>
        /// This only applies to multi-session fleets.
        /// </para>
        /// </summary>
        public int? AvailableUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the AvailableUserSessions property is set.
        /// </summary>
        internal bool IsSetAvailableUserSessions() => this.AvailableUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property Desired. 
        /// <para>
        /// The desired number of streaming instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Desired { get; set; }

        /// <summary>
        /// Checks to see if the Desired property is set.
        /// </summary>
        internal bool IsSetDesired() => this.Desired.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredUserSessions. 
        /// <para>
        /// The total number of sessions slots that are either running or pending. This represents
        /// the total number of concurrent streaming sessions your fleet can support in a steady
        /// state.
        /// </para>
        ///  
        /// <para>
        /// DesiredUserSessionCapacity = ActualUserSessionCapacity + PendingUserSessionCapacity
        /// </para>
        ///  
        /// <para>
        /// This only applies to multi-session fleets.
        /// </para>
        /// </summary>
        public int? DesiredUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the DesiredUserSessions property is set.
        /// </summary>
        internal bool IsSetDesiredUserSessions() => this.DesiredUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property DrainModeActiveUserSessions. 
        /// <para>
        /// The number of active user sessions on instances in drain mode. This only applies to
        /// multi-session fleets.
        /// </para>
        /// </summary>
        public int? DrainModeActiveUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the DrainModeActiveUserSessions property is set.
        /// </summary>
        internal bool IsSetDrainModeActiveUserSessions() => this.DrainModeActiveUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property DrainModeUnusedUserSessions. 
        /// <para>
        /// The number of unused session slots on instances in drain mode that cannot be used
        /// for user session provisioning. This only applies to multi-session fleets.
        /// </para>
        /// </summary>
        public int? DrainModeUnusedUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the DrainModeUnusedUserSessions property is set.
        /// </summary>
        internal bool IsSetDrainModeUnusedUserSessions() => this.DrainModeUnusedUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property Draining. 
        /// <para>
        /// The number of instances in drain mode. This only applies to multi-session fleets.
        /// </para>
        /// </summary>
        public int? Draining { get; set; }

        /// <summary>
        /// Checks to see if the Draining property is set.
        /// </summary>
        internal bool IsSetDraining() => this.Draining.HasValue;

        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// The number of instances in use for streaming.
        /// </para>
        /// </summary>
        public int? InUse { get; set; }

        /// <summary>
        /// Checks to see if the InUse property is set.
        /// </summary>
        internal bool IsSetInUse() => this.InUse.HasValue;

        /// <summary>
        /// Gets and sets the property Running. 
        /// <para>
        /// The total number of simultaneous streaming instances that are running.
        /// </para>
        /// </summary>
        public int? Running { get; set; }

        /// <summary>
        /// Checks to see if the Running property is set.
        /// </summary>
        internal bool IsSetRunning() => this.Running.HasValue;
    }
}
