/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Pricing Schedule
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class PricingSchedule
    {
        private Decimal? termField;
        private Decimal? priceField;
        private string currencyCodeField;

        /// <summary>
        /// The number of months remaining in the reservation.
        /// </summary>
        /// <remarks>
        /// For example, 2 is the second to the last month before the capacity reservation expires.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Term")]
        public Decimal Term
        {
            get { return this.termField.GetValueOrDefault(); }
            set { this.termField = value; }
        }

        /// <summary>
        /// Sets the number of months remaining in the reservation.
        /// </summary>
        /// <param name="term">Number of months remaining</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PricingSchedule WithTerm(Decimal term)
        {
            this.termField = term;
            return this;
        }

        /// <summary>
        /// Checks if the Term property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetTerm()
        {
            return this.termField != null;
        }

        /// <summary>
        /// The fixed price for the term.
        /// </summary>
        [XmlElementAttribute(ElementName = "Price")]
        public Decimal Price
        {
            get { return this.priceField.GetValueOrDefault(); }
            set { this.priceField = value; }
        }

        /// <summary>
        /// Sets the fixed price for the term.
        /// </summary>
        /// <param name="price">Fixed price, up to 3 decimal position</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PricingSchedule WithPrice(Decimal price)
        {
            this.priceField = price;
            return this;
        }

        /// <summary>
        /// Checks if the Price property is set.
        /// </summary>
        /// <returns>True if the property is set.</returns>
        public bool IsSetPrice()
        {
            return this.priceField != null;
        }

        /// <summary>
        /// Currency code for the Price property. 
        /// </summary>
        /// <remarks>Possible values - "USD"</remarks>
        [XmlElementAttribute(ElementName = "CurrencyCode")]
        public string CurrencyCode
        {
            get { return this.currencyCodeField; }
            set { this.currencyCodeField = value; }
        }

        /// <summary>
        /// Sets the currency code for the Price property. 
        /// </summary>
        /// <param name="currencyCode">Currency code</param>
        /// <returns>this instance</returns>
        /// <remarks>Possible values "USD"</remarks>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PricingSchedule WithCurrencyCode(string currencyCode)
        {
            this.currencyCodeField = currencyCode;
            return this;
        }

        /// <summary>
        /// Checks if the CurrencyCode property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetCurrencyCode()
        {
            return !string.IsNullOrEmpty(this.currencyCodeField);
        }
    }
}
