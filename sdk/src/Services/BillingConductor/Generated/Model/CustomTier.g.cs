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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A custom tier for the pricing rule. Each custom tier applies a rate to the usage
    /// that falls within the tier's range.
    /// </summary>
    public partial class CustomTier
    {
        /// <summary>
        /// Gets and sets the property BeginRangeInclusive. 
        /// <para>
        ///  The inclusive start of the usage range that this tier applies to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public double? BeginRangeInclusive { get; set; }

        /// <summary>
        /// Checks to see if the BeginRangeInclusive property is set.
        /// </summary>
        internal bool IsSetBeginRangeInclusive() => this.BeginRangeInclusive.HasValue;

        /// <summary>
        /// Gets and sets the property EndRangeExclusive. 
        /// <para>
        ///  The exclusive end of the usage range that this tier applies to. If you don't specify
        /// a value, this tier applies to all usage that is greater than or equal to <c>BeginRangeInclusive</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? EndRangeExclusive { get; set; }

        /// <summary>
        /// Checks to see if the EndRangeExclusive property is set.
        /// </summary>
        internal bool IsSetEndRangeExclusive() => this.EndRangeExclusive.HasValue;

        /// <summary>
        /// Gets and sets the property RateValue. 
        /// <para>
        ///  The rate that's applied to the usage that falls within this tier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public double? RateValue { get; set; }

        /// <summary>
        /// Checks to see if the RateValue property is set.
        /// </summary>
        internal bool IsSetRateValue() => this.RateValue.HasValue;
    }
}
