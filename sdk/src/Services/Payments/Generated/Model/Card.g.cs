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
    /// The details of a card payment instrument.
    /// </summary>
    public partial class Card
    {
        /// <summary>
        /// Gets and sets the property Brand. 
        /// <para>
        /// The network the card runs on.
        /// </para>
        /// </summary>
        public CardBrand Brand { get; set; }

        /// <summary>
        /// Checks to see if the Brand property is set.
        /// </summary>
        internal bool IsSetBrand() => this.Brand != null;

        /// <summary>
        /// Gets and sets the property CardType. 
        /// <para>
        /// Whether the card is a credit card or a debit card.
        /// </para>
        /// </summary>
        public CardType CardType { get; set; }

        /// <summary>
        /// Checks to see if the CardType property is set.
        /// </summary>
        internal bool IsSetCardType() => this.CardType != null;

        /// <summary>
        /// Gets and sets the property ExpirationMonth. 
        /// <para>
        /// The calendar month that the card expires in.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 12)]
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationMonth property is set.
        /// </summary>
        internal bool IsSetExpirationMonth() => this.ExpirationMonth.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationYear. 
        /// <para>
        /// The calendar year that the card expires in.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2000, Max = 2300)]
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationYear property is set.
        /// </summary>
        internal bool IsSetExpirationYear() => this.ExpirationYear.HasValue;

        /// <summary>
        /// Gets and sets the property IssuerCountry. 
        /// <para>
        /// The country of the bank that issued the card.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// Checks to see if the IssuerCountry property is set.
        /// </summary>
        internal bool IsSetIssuerCountry() => this.IssuerCountry != null;

        /// <summary>
        /// Gets and sets the property IssuingBank. 
        /// <para>
        /// The bank that issued the card.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string IssuingBank { get; set; }

        /// <summary>
        /// Checks to see if the IssuingBank property is set.
        /// </summary>
        internal bool IsSetIssuingBank() => this.IssuingBank != null;

        /// <summary>
        /// Gets and sets the property Last4. 
        /// <para>
        /// The last four digits of the card number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 4, Max = 4)]
        public string Last4 { get; set; }

        /// <summary>
        /// Checks to see if the Last4 property is set.
        /// </summary>
        internal bool IsSetLast4() => this.Last4 != null;
    }
}
