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
    /// Reserved Instance Limit Price
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ReservedInstanceLimitPrice
    {
        private Decimal? amountField;
        private string currencyCodeField;

        /// <summary>
        /// The limit price on the total order (instanceCount * price) 
        /// for Reserved Instance Marketplace offerings.
        /// </summary>
        [XmlElementAttribute(ElementName = "Amount")]
        public Decimal Amount
        {
            get { return this.amountField.GetValueOrDefault(); }
            set { this.amountField = value; }
        }

        /// <summary>
        /// Sets the limit price on the total order (instanceCount * price) 
        /// for Reserved Instance Marketplace offerings.
        /// </summary>
        /// <param name="amount">Limit price</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedInstanceLimitPrice WithAmount(Decimal amount)
        {
            this.amountField = amount;
            return this;
        }

        /// <summary>
        /// Checks if the Amount property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetAmount()
        {
            return this.amountField != null;
        }

        /// <summary>
        /// The currency in which the limitPrice amount is specified. 
        /// </summary>
        /// <remarks>
        /// At this time, the only supported currency is USD.
        /// </remarks>
        [XmlElementAttribute(ElementName = "CurrencyCode")]
        public string CurrencyCode
        {
            get { return this.currencyCodeField; }
            set { this.currencyCodeField = value; }
        }

        /// <summary>
        /// Sets the currency in which the limitPrice amount is specified. 
        /// </summary>
        /// <param name="currencyCode">Currency Code</param>
        /// <returns>this instance</returns>
        /// <remarks>
        /// At this time, the only supported currency is USD.
        /// </remarks>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedInstanceLimitPrice WithCurrencyCode(string currencyCode)
        {
            this.currencyCodeField = currencyCode;
            return this;
        }

        /// <summary>
        /// Checks if the CurrencyCode property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetCurrencyCode()
        {
            return !string.IsNullOrEmpty(this.currencyCodeField);
        }
    }
}
