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
    /// Revenue statistics for a single content path, including the path, revenue amount,
    /// and request count.
    /// </summary>
    public partial class RevenuePathStatistics
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The total revenue amount from this path in the specified currency.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The URI path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The percentage of total revenue from this path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public double? Percentage { get; set; }

        /// <summary>
        /// Checks to see if the Percentage property is set.
        /// </summary>
        internal bool IsSetPercentage() => this.Percentage.HasValue;

        /// <summary>
        /// Gets and sets the property RequestCount. 
        /// <para>
        /// The number of monetized requests to this path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? RequestCount { get; set; }

        /// <summary>
        /// Checks to see if the RequestCount property is set.
        /// </summary>
        internal bool IsSetRequestCount() => this.RequestCount.HasValue;
    }
}
