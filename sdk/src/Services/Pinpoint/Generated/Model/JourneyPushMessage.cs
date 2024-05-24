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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the message configuration for a push notification that's sent to participants
    /// in a journey.
    /// </summary>
    public partial class JourneyPushMessage
    {
        private string _timeToLive;

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// The number of seconds that the push notification service should keep the message,
        /// if the service is unable to deliver the notification the first time. This value is
        /// converted to an expiration value when it's sent to a push-notification service. If
        /// this value is 0, the service treats the notification as if it expires immediately
        /// and the service doesn't store or try to deliver the notification again.
        /// </para>
        ///  
        /// <para>
        /// This value doesn't apply to messages that are sent through the Amazon Device Messaging
        /// (ADM) service.
        /// </para>
        /// </summary>
        public string TimeToLive
        {
            get { return this._timeToLive; }
            set { this._timeToLive = value; }
        }

        // Check to see if TimeToLive property is set
        internal bool IsSetTimeToLive()
        {
            return this._timeToLive != null;
        }

    }
}