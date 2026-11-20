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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// The Amazon Web Services business unit that issued a financial record. A business unit
    /// has two parts: the merchant of record, which is the Amazon Web Services entity that
    /// issued the record, and the line of business within that entity.
    /// </summary>
    public partial class BusinessUnit
    {
        /// <summary>
        /// Gets and sets the property LineOfBusiness. 
        /// <para>
        /// The line of business within the merchant of record that issued the record. This member
        /// is absent when the line of business isn't known for the record. The following values
        /// are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_CLOUD_SERVICES</c> – Your usage of Amazon Web Services services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROSERVE_MARKETING_AND_TRAINING</c> – Amazon Web Services Professional Services,
        /// marketing, and training: consulting, events, and training that Amazon Web Services
        /// sells.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_MARKETPLACE</c> – Products that you bought from sellers in Amazon Web Services
        /// Marketplace.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LineOfBusiness LineOfBusiness { get; set; }

        /// <summary>
        /// Checks to see if the LineOfBusiness property is set.
        /// </summary>
        internal bool IsSetLineOfBusiness() => this.LineOfBusiness != null;

        /// <summary>
        /// Gets and sets the property MerchantOfRecord. 
        /// <para>
        /// The Amazon Web Services entity that issued the invoice and collects payment for it,
        /// such as <c>Amazon Web Services, Inc.</c> or <c>Amazon Web Services EMEA SARL</c>.
        /// This is the invoicing entity shown in the Amazon Web Services Billing and Cost Management
        /// console. For Amazon Web Services Marketplace purchases, it can differ from the seller
        /// of record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MerchantOfRecord { get; set; }

        /// <summary>
        /// Checks to see if the MerchantOfRecord property is set.
        /// </summary>
        internal bool IsSetMerchantOfRecord() => this.MerchantOfRecord != null;
    }
}
