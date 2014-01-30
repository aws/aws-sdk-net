/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes the price for a Reserved Instance.</para>
    /// </summary>
    public class PriceSchedule
    {
        
        private long? term;
        private double? price;
        private CurrencyCodeValues currencyCode;
        private bool? active;


        /// <summary>
        /// The number of months remaining in the reservation. For example, 2 is the second to the last month before the capacity reservation expires.
        ///  
        /// </summary>
        public long Term
        {
            get { return this.term ?? default(long); }
            set { this.term = value; }
        }

        // Check to see if Term property is set
        internal bool IsSetTerm()
        {
            return this.term.HasValue;
        }

        /// <summary>
        /// The fixed price for the term.
        ///  
        /// </summary>
        public double Price
        {
            get { return this.price ?? default(double); }
            set { this.price = value; }
        }

        // Check to see if Price property is set
        internal bool IsSetPrice()
        {
            return this.price.HasValue;
        }

        /// <summary>
        /// The currency for transacting the Reserved Instance resale. At this time, the only supported currency is <c>USD</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>USD</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public CurrencyCodeValues CurrencyCode
        {
            get { return this.currencyCode; }
            set { this.currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this.currencyCode != null;
        }

        /// <summary>
        /// The current price schedule, as determined by the term remaining for the Reserved Instance in the listing. A specific price schedule is
        /// always in effect, but only one price schedule can be active at any time. Take, for example, a Reserved Instance listing that has five months
        /// remaining in its term. When you specify price schedules for five months and two months, this means that schedule 1, covering the first three
        /// months of the remaining term, will be active during months 5, 4, and 3. Then schedule 2, covering the last two months of the term, will be
        /// active for months 2 and 1.
        ///  
        /// </summary>
        public bool Active
        {
            get { return this.active ?? default(bool); }
            set { this.active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this.active.HasValue;
        }
    }
}
