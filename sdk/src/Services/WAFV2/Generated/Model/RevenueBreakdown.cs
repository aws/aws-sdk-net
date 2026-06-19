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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A summary of AI bot monetization revenue, including total revenue, revenue by verification
    /// tier, and request counts.
    /// </summary>
    public partial class RevenueBreakdown
    {
        private Currency _currency;
        private string _totalAmount;
        private long? _totalMonetizeServed;
        private long? _totalSettled;
        private string _unverifiedAmount;
        private string _verifiedAmount;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency of the revenue amounts.
        /// </para>
        /// </summary>
        public Currency Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        /// The total revenue amount in the specified currency.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TotalMonetizeServed. 
        /// <para>
        /// The total number of HTTP 402 Payment Required responses served to AI agents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TotalMonetizeServed
        {
            get { return this._totalMonetizeServed; }
            set { this._totalMonetizeServed = value; }
        }

        // Check to see if TotalMonetizeServed property is set
        internal bool IsSetTotalMonetizeServed()
        {
            return this._totalMonetizeServed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSettled. 
        /// <para>
        /// The total number of successfully settled payment transactions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TotalSettled
        {
            get { return this._totalSettled; }
            set { this._totalSettled = value; }
        }

        // Check to see if TotalSettled property is set
        internal bool IsSetTotalSettled()
        {
            return this._totalSettled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnverifiedAmount. 
        /// <para>
        /// The revenue amount from unverified AI bots.
        /// </para>
        /// </summary>
        public string UnverifiedAmount
        {
            get { return this._unverifiedAmount; }
            set { this._unverifiedAmount = value; }
        }

        // Check to see if UnverifiedAmount property is set
        internal bool IsSetUnverifiedAmount()
        {
            return this._unverifiedAmount != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAmount. 
        /// <para>
        /// The revenue amount from verified AI bots.
        /// </para>
        /// </summary>
        public string VerifiedAmount
        {
            get { return this._verifiedAmount; }
            set { this._verifiedAmount = value; }
        }

        // Check to see if VerifiedAmount property is set
        internal bool IsSetVerifiedAmount()
        {
            return this._verifiedAmount != null;
        }

    }
}