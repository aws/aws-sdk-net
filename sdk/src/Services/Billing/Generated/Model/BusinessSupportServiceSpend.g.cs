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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// A service-level spend entry contributing to Business Support eligible spend.
    /// </summary>
    public partial class BusinessSupportServiceSpend
    {
        /// <summary>
        /// Gets and sets the property ChargeAmount. 
        /// <para>
        /// The Support-eligible spend amount for this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChargeAmount { get; set; }

        /// <summary>
        /// Checks to see if the ChargeAmount property is set.
        /// </summary>
        internal bool IsSetChargeAmount() => this.ChargeAmount != null;

        /// <summary>
        /// Gets and sets the property ContributingService. 
        /// <para>
        /// The name of the Amazon Web Services service contributing to the Support-eligible spend.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContributingService { get; set; }

        /// <summary>
        /// Checks to see if the ContributingService property is set.
        /// </summary>
        internal bool IsSetContributingService() => this.ContributingService != null;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The ISO 4217 currency code for the charge amount (for example, <c>USD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the service spend entry.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ItemType. 
        /// <para>
        /// The type of the line item. Valid values: <c>Usage</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ItemType { get; set; }

        /// <summary>
        /// Checks to see if the ItemType property is set.
        /// </summary>
        internal bool IsSetItemType() => this.ItemType != null;
    }
}
