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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A representation of the charge details that are associated with a percentage custom
    /// line item.
    /// </summary>
    public partial class ListCustomLineItemPercentageChargeDetails
    {
        private double? _percentageValue;

        /// <summary>
        /// Gets and sets the property PercentageValue. 
        /// <para>
        ///  The custom line item's percentage value. This will be multiplied against the combined
        /// value of its associated resources to determine its charge value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public double? PercentageValue
        {
            get { return this._percentageValue; }
            set { this._percentageValue = value; }
        }

        // Check to see if PercentageValue property is set
        internal bool IsSetPercentageValue()
        {
            return this._percentageValue.HasValue; 
        }

    }
}