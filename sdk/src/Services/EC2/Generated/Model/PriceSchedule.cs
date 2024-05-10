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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the price for a Reserved Instance.
    /// </summary>
    public partial class PriceSchedule
    {
        private bool? _active;
        private CurrencyCodeValues _currencyCode;
        private double? _price;
        private long? _term;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// The current price schedule, as determined by the term remaining for the Reserved Instance
        /// in the listing.
        /// </para>
        ///  
        /// <para>
        /// A specific price schedule is always in effect, but only one price schedule can be
        /// active at any time. Take, for example, a Reserved Instance listing that has five months
        /// remaining in its term. When you specify price schedules for five months and two months,
        /// this means that schedule 1, covering the first three months of the remaining term,
        /// will be active during months 5, 4, and 3. Then schedule 2, covering the last two months
        /// of the term, will be active for months 2 and 1.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency for transacting the Reserved Instance resale. At this time, the only
        /// supported currency is <c>USD</c>.
        /// </para>
        /// </summary>
        public CurrencyCodeValues CurrencyCode
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
        /// Gets and sets the property Price. 
        /// <para>
        /// The fixed price for the term.
        /// </para>
        /// </summary>
        public double? Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        // Check to see if Price property is set
        internal bool IsSetPrice()
        {
            return this._price.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// The number of months remaining in the reservation. For example, 2 is the second to
        /// the last month before the capacity reservation expires.
        /// </para>
        /// </summary>
        public long? Term
        {
            get { return this._term; }
            set { this._term = value; }
        }

        // Check to see if Term property is set
        internal bool IsSetTerm()
        {
            return this._term.HasValue; 
        }

    }
}