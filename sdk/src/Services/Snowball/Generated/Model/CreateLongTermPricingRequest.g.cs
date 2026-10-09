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
    /// Container for the parameters to the CreateLongTermPricing operation. Creates a job
    /// with the long-term usage option for a device. The long-term usage is a 1-year or 3-year
    /// long-term pricing type for the device. You are billed upfront, and Amazon Web Services
    /// provides discounts for long-term pricing.
    /// </summary>
    public partial class CreateLongTermPricingRequest : AmazonSnowballRequest
    {
        /// <summary>
        /// Gets and sets the property IsLongTermPricingAutoRenew. 
        /// <para>
        /// Specifies whether the current long-term pricing type for the device should be renewed.
        /// </para>
        /// </summary>
        public bool? IsLongTermPricingAutoRenew { get; set; }

        /// <summary>
        /// Checks to see if the IsLongTermPricingAutoRenew property is set.
        /// </summary>
        internal bool IsSetIsLongTermPricingAutoRenew() => this.IsLongTermPricingAutoRenew.HasValue;

        /// <summary>
        /// Gets and sets the property LongTermPricingType. 
        /// <para>
        /// The type of long-term pricing option you want for the device, either 1-year or 3-year
        /// long-term pricing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LongTermPricingType LongTermPricingType { get; set; }

        /// <summary>
        /// Checks to see if the LongTermPricingType property is set.
        /// </summary>
        internal bool IsSetLongTermPricingType() => this.LongTermPricingType != null;

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of Snow Family devices to use for the long-term pricing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnowballType SnowballType { get; set; }

        /// <summary>
        /// Checks to see if the SnowballType property is set.
        /// </summary>
        internal bool IsSetSnowballType() => this.SnowballType != null;
    }
}
