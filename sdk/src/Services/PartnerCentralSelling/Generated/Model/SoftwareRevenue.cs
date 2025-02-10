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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
    /// Specifies a customer's procurement terms details. Required only for partners in eligible
    /// programs.
    /// </summary>
    public partial class SoftwareRevenue
    {
        private RevenueModel _deliveryModel;
        private string _effectiveDate;
        private string _expirationDate;
        private MonetaryValue _value;

        /// <summary>
        /// Gets and sets the property DeliveryModel. 
        /// <para>
        /// Specifies the customer's intended payment type agreement or procurement method to
        /// acquire the solution or service outlined in the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public RevenueModel DeliveryModel
        {
            get { return this._deliveryModel; }
            set { this._deliveryModel = value; }
        }

        // Check to see if DeliveryModel property is set
        internal bool IsSetDeliveryModel()
        {
            return this._deliveryModel != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// Specifies the <c>Opportunity</c>'s customer engagement start date for the contract's
        /// effectiveness.
        /// </para>
        /// </summary>
        public string EffectiveDate
        {
            get { return this._effectiveDate; }
            set { this._effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this._effectiveDate != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// Specifies the expiration date for the contract between the customer and Amazon Web
        /// Services partner. It signifies the termination date of the agreed-upon engagement
        /// period between both parties.
        /// </para>
        /// </summary>
        public string ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specifies the payment value (amount and currency).
        /// </para>
        /// </summary>
        public MonetaryValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}