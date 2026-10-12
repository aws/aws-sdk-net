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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// Specifies a time range with an inclusive begin date and an exclusive end date.
    /// </summary>
    public partial class BillingViewSegmentTimeRange
    {
        /// <summary>
        /// Gets and sets the property BeginDateInclusive. 
        /// <para>
        ///  The inclusive start of the time range. This value can't be in the future. 
        /// </para>
        /// </summary>
        public DateTime? BeginDateInclusive { get; set; }

        /// <summary>
        /// Checks to see if the BeginDateInclusive property is set.
        /// </summary>
        internal bool IsSetBeginDateInclusive() => this.BeginDateInclusive.HasValue;

        /// <summary>
        /// Gets and sets the property EndDateExclusive. 
        /// <para>
        ///  The exclusive end of the time range. This value must be after <c>beginDateInclusive</c>.
        /// 
        /// </para>
        /// </summary>
        public DateTime? EndDateExclusive { get; set; }

        /// <summary>
        /// Checks to see if the EndDateExclusive property is set.
        /// </summary>
        internal bool IsSetEndDateExclusive() => this.EndDateExclusive.HasValue;
    }
}
