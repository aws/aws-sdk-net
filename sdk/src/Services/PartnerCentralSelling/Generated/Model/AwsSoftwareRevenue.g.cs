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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Seller-provided PARC deal terms for the opportunity, including commitment value, discount
    /// percentage, and contract dates.
    /// </summary>
    public partial class AwsSoftwareRevenue
    {
        /// <summary>
        /// Gets and sets the property Discount. 
        /// <para>
        /// Discount percentage offered on the software revenue. Percent convention: 15.00 means
        /// 15%.
        /// </para>
        /// </summary>
        public string Discount { get; set; }

        /// <summary>
        /// Checks to see if the Discount property is set.
        /// </summary>
        internal bool IsSetDiscount() => this.Discount != null;

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// Contract effective (start) date in YYYY-MM-DD format.
        /// </para>
        /// </summary>
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDate property is set.
        /// </summary>
        internal bool IsSetEffectiveDate() => this.EffectiveDate != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// Contract expiration (end) date in YYYY-MM-DD format.
        /// </para>
        /// </summary>
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate != null;

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        public MonetaryValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
