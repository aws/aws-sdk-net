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
    /// <para>Describes the limit price of a Reserved Instance offering.</para>
    /// </summary>
    public class ReservedInstanceLimitPrice
    {
        
        private double? amount;
        private CurrencyCodeValues currencyCode;


        /// <summary>
        /// Used for Reserved Instance Marketplace offerings. Specifies the limit price on the total order (instanceCount * price).
        ///  
        /// </summary>
        public double Amount
        {
            get { return this.amount ?? default(double); }
            set { this.amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this.amount.HasValue;
        }

        /// <summary>
        /// The currency in which the <c>limitPrice</c> amount is specified. At this time, the only supported currency is <c>USD</c>.
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
    }
}
