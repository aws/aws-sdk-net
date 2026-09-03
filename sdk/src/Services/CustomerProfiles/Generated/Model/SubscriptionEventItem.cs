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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Represents a single segment membership event.
    /// </summary>
    public partial class SubscriptionEventItem
    {
        private SubscriptionEvent _event;
        private SubscriptionEventType _eventType;
        private string _profileId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// Whether the profile joined or left the segment. The following are valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>JOINED</b>: The profile joined the segment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>LEFT</b>: The profile left the segment. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SubscriptionEvent Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event that triggered the membership change. The following are valid values:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>LIVE</b>: Real-time event triggered by a profile or calculated attribute change
        /// (Classic segments only). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SCHEDULE</b>: Event generated during a scheduled execution. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SubscriptionEventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of a customer profile.
        /// </para>
        /// </summary>
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the membership change was detected. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}