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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A pricing option for the specified Outpost.
    /// </summary>
    public partial class PricingOption
    {
        private QuotePricingType _pricingType;
        private SubscriptionPricingDetails _subscriptionPricingDetails;

        /// <summary>
        /// Gets and sets the property PricingType. 
        /// <para>
        /// The type of pricing model.
        /// </para>
        /// </summary>
        public QuotePricingType PricingType
        {
            get { return this._pricingType; }
            set { this._pricingType = value; }
        }

        // Check to see if PricingType property is set
        internal bool IsSetPricingType()
        {
            return this._pricingType != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionPricingDetails. 
        /// <para>
        /// The subscription pricing details for this pricing option.
        /// </para>
        /// </summary>
        public SubscriptionPricingDetails SubscriptionPricingDetails
        {
            get { return this._subscriptionPricingDetails; }
            set { this._subscriptionPricingDetails = value; }
        }

        // Check to see if SubscriptionPricingDetails property is set
        internal bool IsSetSubscriptionPricingDetails()
        {
            return this._subscriptionPricingDetails != null;
        }

    }
}