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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLongTermPricing operation. Updates the long-term
    /// pricing type.
    /// </summary>
    public partial class UpdateLongTermPricingRequest : AmazonSnowballRequest
    {
        /// <summary>
        /// Gets and sets the property IsLongTermPricingAutoRenew. 
        /// <para>
        /// If set to <c>true</c>, specifies that the current long-term pricing type for the device
        /// should be automatically renewed before the long-term pricing contract expires.
        /// </para>
        /// </summary>
        public bool? IsLongTermPricingAutoRenew { get; set; }

        /// <summary>
        /// Checks to see if the IsLongTermPricingAutoRenew property is set.
        /// </summary>
        internal bool IsSetIsLongTermPricingAutoRenew() => this.IsLongTermPricingAutoRenew.HasValue;

        /// <summary>
        /// Gets and sets the property LongTermPricingId. 
        /// <para>
        /// The ID of the long-term pricing type for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 41, Max = 41)]
        public string LongTermPricingId { get; set; }

        /// <summary>
        /// Checks to see if the LongTermPricingId property is set.
        /// </summary>
        internal bool IsSetLongTermPricingId() => this.LongTermPricingId != null;

        /// <summary>
        /// Gets and sets the property ReplacementJob. 
        /// <para>
        /// Specifies that a device that is ordered with long-term pricing should be replaced
        /// with a new device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 39, Max = 39)]
        public string ReplacementJob { get; set; }

        /// <summary>
        /// Checks to see if the ReplacementJob property is set.
        /// </summary>
        internal bool IsSetReplacementJob() => this.ReplacementJob != null;
    }
}
