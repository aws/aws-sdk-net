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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the timeout settings for a pool of WorkSpaces.
    /// </summary>
    public partial class TimeoutSettings
    {
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
        [AWSProperty(Min = 60, Max = 36000)]
        public int? DisconnectTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetDisconnectTimeoutInSeconds() => this.DisconnectTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property IdleDisconnectTimeoutInSeconds. 
        /// <para>
        /// The amount of time in seconds a connection will stay active while idle.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36000)]
        public int? IdleDisconnectTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleDisconnectTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleDisconnectTimeoutInSeconds() => this.IdleDisconnectTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MaxUserDurationInSeconds. 
        /// <para>
        /// Specifies the maximum amount of time, in seconds, that a streaming session can remain
        /// active. If users are still connected to a streaming instance five minutes before this
        /// limit is reached, they are prompted to save any open documents before being disconnected.
        /// After this time elapses, the instance is terminated and replaced by a new instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 600, Max = 432000)]
        public int? MaxUserDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxUserDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetMaxUserDurationInSeconds() => this.MaxUserDurationInSeconds.HasValue;
    }
}
