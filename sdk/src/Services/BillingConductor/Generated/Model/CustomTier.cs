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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
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
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A custom tier for the pricing rule. Each custom tier applies a rate to the usage
    /// that falls within the tier's range.
    /// </summary>
    public partial class CustomTier
    {
        private double? _beginRangeInclusive;
        private double? _endRangeExclusive;
        private double? _rateValue;

        /// <summary>
        /// Gets and sets the property BeginRangeInclusive. 
        /// <para>
        ///  The inclusive start of the usage range that this tier applies to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double? BeginRangeInclusive
        {
            get { return this._beginRangeInclusive; }
            set { this._beginRangeInclusive = value; }
        }

        // Check to see if BeginRangeInclusive property is set
        internal bool IsSetBeginRangeInclusive()
        {
            return this._beginRangeInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndRangeExclusive. 
        /// <para>
        ///  The exclusive end of the usage range that this tier applies to. If you don't specify
        /// a value, this tier applies to all usage that is greater than or equal to <c>BeginRangeInclusive</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? EndRangeExclusive
        {
            get { return this._endRangeExclusive; }
            set { this._endRangeExclusive = value; }
        }

        // Check to see if EndRangeExclusive property is set
        internal bool IsSetEndRangeExclusive()
        {
            return this._endRangeExclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RateValue. 
        /// <para>
        ///  The rate that's applied to the usage that falls within this tier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double? RateValue
        {
            get { return this._rateValue; }
            set { this._rateValue = value; }
        }

        // Check to see if RateValue property is set
        internal bool IsSetRateValue()
        {
            return this._rateValue.HasValue; 
        }

    }
}