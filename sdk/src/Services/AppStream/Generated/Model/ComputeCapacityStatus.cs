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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
        private int? _activeUserSessions;
        private int? _actualUserSessions;
        private int? _available;
        private int? _availableUserSessions;
        private int? _desired;
        private int? _desiredUserSessions;
        private int? _inUse;
        private int? _running;

        /// <summary>
        /// Gets and sets the property ActiveUserSessions. 
        /// <para>
        /// The number of user sessions currently being used for streaming sessions. This only
        /// applies to multi-session fleets.
        /// </para>
        /// </summary>
        public int? ActiveUserSessions
        {
            get { return this._activeUserSessions; }
            set { this._activeUserSessions = value; }
        }

        // Check to see if ActiveUserSessions property is set
        internal bool IsSetActiveUserSessions()
        {
            return this._activeUserSessions.HasValue; 
        }

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
        public int? ActualUserSessions
        {
            get { return this._actualUserSessions; }
            set { this._actualUserSessions = value; }
        }

        // Check to see if ActualUserSessions property is set
        internal bool IsSetActualUserSessions()
        {
            return this._actualUserSessions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Available. 
        /// <para>
        /// The number of currently available instances that can be used to stream sessions.
        /// </para>
        /// </summary>
        public int? Available
        {
            get { return this._available; }
            set { this._available = value; }
        }

        // Check to see if Available property is set
        internal bool IsSetAvailable()
        {
            return this._available.HasValue; 
        }

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
        public int? AvailableUserSessions
        {
            get { return this._availableUserSessions; }
            set { this._availableUserSessions = value; }
        }

        // Check to see if AvailableUserSessions property is set
        internal bool IsSetAvailableUserSessions()
        {
            return this._availableUserSessions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Desired. 
        /// <para>
        /// The desired number of streaming instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Desired
        {
            get { return this._desired; }
            set { this._desired = value; }
        }

        // Check to see if Desired property is set
        internal bool IsSetDesired()
        {
            return this._desired.HasValue; 
        }

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
        public int? DesiredUserSessions
        {
            get { return this._desiredUserSessions; }
            set { this._desiredUserSessions = value; }
        }

        // Check to see if DesiredUserSessions property is set
        internal bool IsSetDesiredUserSessions()
        {
            return this._desiredUserSessions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// The number of instances in use for streaming.
        /// </para>
        /// </summary>
        public int? InUse
        {
            get { return this._inUse; }
            set { this._inUse = value; }
        }

        // Check to see if InUse property is set
        internal bool IsSetInUse()
        {
            return this._inUse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Running. 
        /// <para>
        /// The total number of simultaneous streaming instances that are running.
        /// </para>
        /// </summary>
        public int? Running
        {
            get { return this._running; }
            set { this._running = value; }
        }

        // Check to see if Running property is set
        internal bool IsSetRunning()
        {
            return this._running.HasValue; 
        }

    }
}