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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A representation of the new charge details that are associated with a flat custom
    /// line item.
    /// </summary>
    public partial class UpdateCustomLineItemFlatChargeDetails
    {
        private double? _chargeValue;

        /// <summary>
        /// Gets and sets the property ChargeValue. 
        /// <para>
        ///  The custom line item's new fixed charge value in USD. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000000)]
        public double ChargeValue
        {
            get { return this._chargeValue.GetValueOrDefault(); }
            set { this._chargeValue = value; }
        }

        // Check to see if ChargeValue property is set
        internal bool IsSetChargeValue()
        {
            return this._chargeValue.HasValue; 
        }

    }
}