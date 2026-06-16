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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A pricing unit that defines the billing dimension for a listing, such as users, hosts,
    /// bandwidth, or data.
    /// </summary>
    public partial class PricingUnit
    {
        private string _displayName;
        private PricingUnitType _pricingUnitType;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable name of the pricing unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property PricingUnitType. 
        /// <para>
        /// The machine-readable type of the pricing unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingUnitType PricingUnitType
        {
            get { return this._pricingUnitType; }
            set { this._pricingUnitType = value; }
        }

        // Check to see if PricingUnitType property is set
        internal bool IsSetPricingUnitType()
        {
            return this._pricingUnitType != null;
        }

    }
}