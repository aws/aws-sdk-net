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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The messaging limits that apply to an origination identity, such as a phone number,
    /// sender ID, or RCS agent. Includes the per-capability send rates and, for supported
    /// origination identities, advisory per-provider daily message caps.
    /// </summary>
    public partial class MessagingLimits
    {
        /// <summary>
        /// Gets and sets the property DailyMessageCaps. 
        /// <para>
        /// The advisory maximum number of messages that can be sent per day, keyed by provider
        /// (for example, <c>T-MOBILE</c>). Applies to 10DLC phone numbers and is omitted when
        /// no daily cap applies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> DailyMessageCaps { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Checks to see if the DailyMessageCaps property is set.
        /// </summary>
        internal bool IsSetDailyMessageCaps() => this.DailyMessageCaps != null && (this.DailyMessageCaps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RateLimits. 
        /// <para>
        /// The maximum send rate for each supported capability, in messages per second. The map
        /// is keyed by capability, such as <c>SMS</c>, <c>MMS</c>, <c>VOICE</c>, or <c>RCS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> RateLimits { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Checks to see if the RateLimits property is set.
        /// </summary>
        internal bool IsSetRateLimits() => this.RateLimits != null && (this.RateLimits.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
