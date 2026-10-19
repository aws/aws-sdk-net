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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A single data point in a revenue time series, representing aggregated monetization
    /// metrics for a specific time interval.
    /// </summary>
    public partial class DataPointEntry
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The bot category for this data point, when grouped by category.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The timestamp for this data point.
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property GroupByValue. 
        /// <para>
        /// The group-by dimension value for this data point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string GroupByValue { get; set; }

        /// <summary>
        /// Checks to see if the GroupByValue property is set.
        /// </summary>
        internal bool IsSetGroupByValue() => this.GroupByValue != null;

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The intent classification for this data point, when grouped by intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Intent { get; set; }

        /// <summary>
        /// Checks to see if the Intent property is set.
        /// </summary>
        internal bool IsSetIntent() => this.Intent != null;

        /// <summary>
        /// Gets and sets the property MonetizeServedCount. 
        /// <para>
        /// The number of HTTP 402 Payment Required responses served during this interval.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? MonetizeServedCount { get; set; }

        /// <summary>
        /// Checks to see if the MonetizeServedCount property is set.
        /// </summary>
        internal bool IsSetMonetizeServedCount() => this.MonetizeServedCount.HasValue;

        /// <summary>
        /// Gets and sets the property SettledCount. 
        /// <para>
        /// The number of successfully settled payments during this interval.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SettledCount { get; set; }

        /// <summary>
        /// Checks to see if the SettledCount property is set.
        /// </summary>
        internal bool IsSetSettledCount() => this.SettledCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        /// The total revenue amount during this interval in the specified currency.
        /// </para>
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        /// Checks to see if the TotalAmount property is set.
        /// </summary>
        internal bool IsSetTotalAmount() => this.TotalAmount != null;
    }
}
