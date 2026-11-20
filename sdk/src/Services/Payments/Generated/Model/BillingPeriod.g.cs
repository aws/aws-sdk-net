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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// A billing period, as a half-open date range: <c>startDate</c> is inclusive and <c>endDate</c>
    /// is exclusive. Both members are calendar dates, carried as the timestamp of 00:00:00
    /// UTC on that day.
    /// </summary>
    public partial class BillingPeriod
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The day after the last day of the billing period, exclusive, as the timestamp of 00:00:00
        /// UTC on that day. A calendar month runs from the first of the month to the first of
        /// the next month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The first day of the billing period, inclusive, as the timestamp of 00:00:00 UTC on
        /// that day.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;
    }
}
