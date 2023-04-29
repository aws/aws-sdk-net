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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLongTermPricing operation.
    /// Creates a job with the long-term usage option for a device. The long-term usage is
    /// a 1-year or 3-year long-term pricing type for the device. You are billed upfront,
    /// and Amazon Web Services provides discounts for long-term pricing.
    /// </summary>
    public partial class CreateLongTermPricingRequest : AmazonSnowballRequest
    {
        private bool? _isLongTermPricingAutoRenew;
        private LongTermPricingType _longTermPricingType;
        private SnowballType _snowballType;

        /// <summary>
        /// Gets and sets the property IsLongTermPricingAutoRenew. 
        /// <para>
        /// Specifies whether the current long-term pricing type for the device should be renewed.
        /// </para>
        /// </summary>
        public bool IsLongTermPricingAutoRenew
        {
            get { return this._isLongTermPricingAutoRenew.GetValueOrDefault(); }
            set { this._isLongTermPricingAutoRenew = value; }
        }

        // Check to see if IsLongTermPricingAutoRenew property is set
        internal bool IsSetIsLongTermPricingAutoRenew()
        {
            return this._isLongTermPricingAutoRenew.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LongTermPricingType. 
        /// <para>
        /// The type of long-term pricing option you want for the device, either 1-year or 3-year
        /// long-term pricing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LongTermPricingType LongTermPricingType
        {
            get { return this._longTermPricingType; }
            set { this._longTermPricingType = value; }
        }

        // Check to see if LongTermPricingType property is set
        internal bool IsSetLongTermPricingType()
        {
            return this._longTermPricingType != null;
        }

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of Snow Family devices to use for the long-term pricing job.
        /// </para>
        /// </summary>
        public SnowballType SnowballType
        {
            get { return this._snowballType; }
            set { this._snowballType = value; }
        }

        // Check to see if SnowballType property is set
        internal bool IsSetSnowballType()
        {
            return this._snowballType != null;
        }

    }
}