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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Defines a payment model where sellers can submit variable payment requests up to a
    /// maximum charge amount, with configurable approval strategies and expiration timelines.
    /// </summary>
    public partial class VariablePaymentTerm
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Additional parameters specified by the acceptor while accepting the term.
        /// </para>
        /// </summary>
        public VariablePaymentTermConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// Defines the currency for the prices mentioned in the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MaxTotalChargeAmount. 
        /// <para>
        /// The maximum total amount that can be charged to the customer through variable payment
        /// requests under this term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string MaxTotalChargeAmount { get; set; }

        /// <summary>
        /// Checks to see if the MaxTotalChargeAmount property is set.
        /// </summary>
        internal bool IsSetMaxTotalChargeAmount() => this.MaxTotalChargeAmount != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
