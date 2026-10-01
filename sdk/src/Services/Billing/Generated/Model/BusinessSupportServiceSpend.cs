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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
        private string _chargeAmount;
        private string _contributingService;
        private string _currency;
        private string _description;
        private string _itemType;

        /// <summary>
        /// Gets and sets the property ChargeAmount. 
        /// <para>
        /// The Support-eligible spend amount for this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChargeAmount
        {
            get { return this._chargeAmount; }
            set { this._chargeAmount = value; }
        }

        // Check to see if ChargeAmount property is set
        internal bool IsSetChargeAmount()
        {
            return this._chargeAmount != null;
        }

        /// <summary>
        /// Gets and sets the property ContributingService. 
        /// <para>
        /// The name of the Amazon Web Services service contributing to the Support-eligible spend.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContributingService
        {
            get { return this._contributingService; }
            set { this._contributingService = value; }
        }

        // Check to see if ContributingService property is set
        internal bool IsSetContributingService()
        {
            return this._contributingService != null;
        }

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The ISO 4217 currency code for the charge amount (for example, <c>USD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the service spend entry.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ItemType. 
        /// <para>
        /// The type of the line item. Valid values: <c>Usage</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ItemType
        {
            get { return this._itemType; }
            set { this._itemType = value; }
        }

        // Check to see if ItemType property is set
        internal bool IsSetItemType()
        {
            return this._itemType != null;
        }

    }
}