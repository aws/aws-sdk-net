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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Currency-specific price information.
    /// </summary>
    public partial class PriceWithCurrency
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency specifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The price of a domain, in a specific currency.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public double? Price { get; set; }

        /// <summary>
        /// Checks to see if the Price property is set.
        /// </summary>
        internal bool IsSetPrice() => this.Price.HasValue;

        /// <summary>
        /// Gets and sets the property PriceType. 
        /// <para>
        /// Indicates whether the domain has standard or premium pricing. A value of <c>STANDARD</c>
        /// means the domain is priced at the regular rate for its TLD. A value of <c>REGISTRY_PREMIUM</c>
        /// means the domain has registry premium pricing, which may be different than the standard
        /// rate.
        /// </para>
        /// </summary>
        public PriceType PriceType { get; set; }

        /// <summary>
        /// Checks to see if the PriceType property is set.
        /// </summary>
        internal bool IsSetPriceType() => this.PriceType != null;
    }
}
