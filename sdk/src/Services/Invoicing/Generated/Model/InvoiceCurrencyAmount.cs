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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The amount charged after taxes, in the preferred currency.
    /// </summary>
    public partial class InvoiceCurrencyAmount
    {
        private AmountBreakdown _amountBreakdown;
        private string _currencyCode;
        private CurrencyExchangeDetails _currencyExchangeDetails;
        private string _totalAmount;
        private string _totalAmountBeforeTax;

        /// <summary>
        /// Gets and sets the property AmountBreakdown. 
        /// <para>
        ///  Details about the invoice currency amount. 
        /// </para>
        /// </summary>
        public AmountBreakdown AmountBreakdown
        {
            get { return this._amountBreakdown; }
            set { this._amountBreakdown = value; }
        }

        // Check to see if AmountBreakdown property is set
        internal bool IsSetAmountBreakdown()
        {
            return this._amountBreakdown != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency dominion of the invoice document.
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
        /// Gets and sets the property CurrencyExchangeDetails. 
        /// <para>
        ///  The details of currency exchange. 
        /// </para>
        /// </summary>
        public CurrencyExchangeDetails CurrencyExchangeDetails
        {
            get { return this._currencyExchangeDetails; }
            set { this._currencyExchangeDetails = value; }
        }

        // Check to see if CurrencyExchangeDetails property is set
        internal bool IsSetCurrencyExchangeDetails()
        {
            return this._currencyExchangeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        ///  The invoice currency amount. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalAmount
        {
            get { return this._totalAmount; }
            set { this._totalAmount = value; }
        }

        // Check to see if TotalAmount property is set
        internal bool IsSetTotalAmount()
        {
            return this._totalAmount != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAmountBeforeTax. 
        /// <para>
        ///  Details about the invoice total amount before tax. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalAmountBeforeTax
        {
            get { return this._totalAmountBeforeTax; }
            set { this._totalAmountBeforeTax = value; }
        }

        // Check to see if TotalAmountBeforeTax property is set
        internal bool IsSetTotalAmountBeforeTax()
        {
            return this._totalAmountBeforeTax != null;
        }

    }
}