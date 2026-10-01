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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Represents a single segment membership event.
    /// </summary>
    public partial class SubscriptionEventItem
    {
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
        public SubscriptionEvent Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;

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
        public SubscriptionEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of a customer profile.
        /// </para>
        /// </summary>
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the membership change was detected. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
