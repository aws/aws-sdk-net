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
    /// Price Schedule
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class PriceSchedule
    {
        private Decimal? termField;
        private Decimal? priceField;
        private string currencyCodeField;
        private bool? activeField;

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
        /// Checks if the Price property is set.
        /// </summary>
        /// <returns>True if the property is set.</returns>
        public bool IsSetPrice()
        {
            return this.priceField != null;
        }

        /// <summary>
        /// The currency for transacting the Reserved Instance resale.
        /// </summary>
        /// <remarks>Possible values - "USD"</remarks>
        [XmlElementAttribute(ElementName = "CurrencyCode")]
        public string CurrencyCode
        {
            get { return this.currencyCodeField; }
            set { this.currencyCodeField = value; }
        }

        /// <summary>
        /// Checks if the CurrencyCode property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetCurrencyCode()
        {
            return !string.IsNullOrEmpty(this.currencyCodeField);
        }

        /// <summary>
        /// Whether the current price schedule is active.
        /// </summary>
        /// <remarks>
        /// A specific price schedule is always in effect, but only one price
        /// schedule can be active at any time. For example, you have a
        /// Reserved Instance listing that has five months remaining in its term.
        /// When you specify price schedules for five months and two months,
        /// this means that schedule 5 will be active during months 5, 4, and 3,
        /// then schedule 2 will be active for months 2 and 1.        
        /// </remarks>
        [XmlElementAttribute(ElementName = "Active")]
        public bool Active
        {
            get { return this.activeField.GetValueOrDefault(); }
            set { this.activeField = value; }
        }

        /// <summary>
        /// Checks if the Active property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetActive()
        {
            return this.activeField != null;
        }
    }
}
