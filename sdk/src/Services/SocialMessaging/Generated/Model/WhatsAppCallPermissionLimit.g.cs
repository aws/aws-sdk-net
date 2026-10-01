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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// A time-bound restriction on a calling action, such as the number of calls allowed
    /// within a time period.
    /// </summary>
    public partial class WhatsAppCallPermissionLimit
    {
        /// <summary>
        /// Gets and sets the property CurrentUsage. 
        /// <para>
        /// The number of times the action has been used within the current time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? CurrentUsage { get; set; }

        /// <summary>
        /// Checks to see if the CurrentUsage property is set.
        /// </summary>
        internal bool IsSetCurrentUsage() => this.CurrentUsage.HasValue;

        /// <summary>
        /// Gets and sets the property LimitExpirationTime. 
        /// <para>
        /// The time when the limit resets. This value is present only when the current usage
        /// has reached the maximum allowed.
        /// </para>
        /// </summary>
        public DateTime? LimitExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the LimitExpirationTime property is set.
        /// </summary>
        internal bool IsSetLimitExpirationTime() => this.LimitExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAllowed. 
        /// <para>
        /// The maximum number of times the action is allowed within the time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxAllowed { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllowed property is set.
        /// </summary>
        internal bool IsSetMaxAllowed() => this.MaxAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period over which the limit applies, as an ISO 8601 duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;
    }
}
