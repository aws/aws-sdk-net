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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
        private VariablePaymentTermConfiguration _configuration;
        private string _currencyCode;
        private string _maxTotalChargeAmount;
        private string _type;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Additional parameters specified by the acceptor while accepting the term.
        /// </para>
        /// </summary>
        public VariablePaymentTermConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// Defines the currency for the prices mentioned in the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTotalChargeAmount. 
        /// <para>
        /// The maximum total amount that can be charged to the customer through variable payment
        /// requests under this term.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string MaxTotalChargeAmount
        {
            get { return this._maxTotalChargeAmount; }
            set { this._maxTotalChargeAmount = value; }
        }

        // Check to see if MaxTotalChargeAmount property is set
        internal bool IsSetMaxTotalChargeAmount()
        {
            return this._maxTotalChargeAmount != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}