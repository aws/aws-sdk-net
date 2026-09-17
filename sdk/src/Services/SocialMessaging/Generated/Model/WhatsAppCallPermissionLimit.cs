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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// A time-bound restriction on a calling action, such as the number of calls allowed
    /// within a time period.
    /// </summary>
    public partial class WhatsAppCallPermissionLimit
    {
        private int? _currentUsage;
        private DateTime? _limitExpirationTime;
        private int? _maxAllowed;
        private string _timePeriod;

        /// <summary>
        /// Gets and sets the property CurrentUsage. 
        /// <para>
        /// The number of times the action has been used within the current time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? CurrentUsage
        {
            get { return this._currentUsage; }
            set { this._currentUsage = value; }
        }

        // Check to see if CurrentUsage property is set
        internal bool IsSetCurrentUsage()
        {
            return this._currentUsage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LimitExpirationTime. 
        /// <para>
        /// The time when the limit resets. This value is present only when the current usage
        /// has reached the maximum allowed.
        /// </para>
        /// </summary>
        public DateTime? LimitExpirationTime
        {
            get { return this._limitExpirationTime; }
            set { this._limitExpirationTime = value; }
        }

        // Check to see if LimitExpirationTime property is set
        internal bool IsSetLimitExpirationTime()
        {
            return this._limitExpirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAllowed. 
        /// <para>
        /// The maximum number of times the action is allowed within the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxAllowed
        {
            get { return this._maxAllowed; }
            set { this._maxAllowed = value; }
        }

        // Check to see if MaxAllowed property is set
        internal bool IsSetMaxAllowed()
        {
            return this._maxAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period over which the limit applies, as an ISO 8601 duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}