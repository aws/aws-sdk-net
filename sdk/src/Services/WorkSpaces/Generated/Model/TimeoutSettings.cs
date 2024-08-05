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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the timeout settings for a pool of WorkSpaces.
    /// </summary>
    public partial class TimeoutSettings
    {
        private int? _disconnectTimeoutInSeconds;
        private int? _idleDisconnectTimeoutInSeconds;
        private int? _maxUserDurationInSeconds;

        /// <summary>
        /// Gets and sets the property DisconnectTimeoutInSeconds. 
        /// <para>
        /// Specifies the amount of time, in seconds, that a streaming session remains active
        /// after users disconnect. If users try to reconnect to the streaming session after a
        /// disconnection or network interruption within the time set, they are connected to their
        /// previous session. Otherwise, they are connected to a new session with a new streaming
        /// instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=36000)]
        public int? DisconnectTimeoutInSeconds
        {
            get { return this._disconnectTimeoutInSeconds; }
            set { this._disconnectTimeoutInSeconds = value; }
        }

        // Check to see if DisconnectTimeoutInSeconds property is set
        internal bool IsSetDisconnectTimeoutInSeconds()
        {
            return this._disconnectTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdleDisconnectTimeoutInSeconds. 
        /// <para>
        /// The amount of time in seconds a connection will stay active while idle.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=36000)]
        public int? IdleDisconnectTimeoutInSeconds
        {
            get { return this._idleDisconnectTimeoutInSeconds; }
            set { this._idleDisconnectTimeoutInSeconds = value; }
        }

        // Check to see if IdleDisconnectTimeoutInSeconds property is set
        internal bool IsSetIdleDisconnectTimeoutInSeconds()
        {
            return this._idleDisconnectTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxUserDurationInSeconds. 
        /// <para>
        /// Specifies the maximum amount of time, in seconds, that a streaming session can remain
        /// active. If users are still connected to a streaming instance five minutes before this
        /// limit is reached, they are prompted to save any open documents before being disconnected.
        /// After this time elapses, the instance is terminated and replaced by a new instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=600, Max=432000)]
        public int? MaxUserDurationInSeconds
        {
            get { return this._maxUserDurationInSeconds; }
            set { this._maxUserDurationInSeconds = value; }
        }

        // Check to see if MaxUserDurationInSeconds property is set
        internal bool IsSetMaxUserDurationInSeconds()
        {
            return this._maxUserDurationInSeconds.HasValue; 
        }

    }
}