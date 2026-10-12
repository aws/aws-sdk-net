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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The amount charged after taxes, in the preferred currency.
    /// </summary>
    public partial class InvoiceCurrencyAmount
    {
        /// <summary>
        /// Gets and sets the property AmountBreakdown. 
        /// <para>
        ///  Details about the invoice currency amount. 
        /// </para>
        /// </summary>
        public AmountBreakdown AmountBreakdown { get; set; }

        /// <summary>
        /// Checks to see if the AmountBreakdown property is set.
        /// </summary>
        internal bool IsSetAmountBreakdown() => this.AmountBreakdown != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency dominion of the invoice document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property CurrencyExchangeDetails. 
        /// <para>
        ///  The details of currency exchange. 
        /// </para>
        /// </summary>
        public CurrencyExchangeDetails CurrencyExchangeDetails { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyExchangeDetails property is set.
        /// </summary>
        internal bool IsSetCurrencyExchangeDetails() => this.CurrencyExchangeDetails != null;

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        ///  The invoice currency amount. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Checks to see if the TotalAmount property is set.
        /// </summary>
        internal bool IsSetTotalAmount() => this.TotalAmount != null;

        /// <summary>
        /// Gets and sets the property TotalAmountBeforeTax. 
        /// <para>
        ///  Details about the invoice total amount before tax. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalAmountBeforeTax { get; set; }

        /// <summary>
        /// Checks to see if the TotalAmountBeforeTax property is set.
        /// </summary>
        internal bool IsSetTotalAmountBeforeTax() => this.TotalAmountBeforeTax != null;
    }
}
