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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Information about the total number of aggregations, as well as the remaining aggregations.
    /// </summary>
    public partial class DifferentialPrivacyPrivacyBudgetAggregation
    {
        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// The maximum number of aggregation functions that you can perform with the given privacy
        /// budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxCount property is set.
        /// </summary>
        internal bool IsSetMaxCount() => this.MaxCount.HasValue;

        /// <summary>
        /// Gets and sets the property RemainingCount. 
        /// <para>
        /// The remaining number of aggregation functions that can be run with the available privacy
        /// budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? RemainingCount { get; set; }

        /// <summary>
        /// Checks to see if the RemainingCount property is set.
        /// </summary>
        internal bool IsSetRemainingCount() => this.RemainingCount.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The different types of aggregation functions that you can perform.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DifferentialPrivacyAggregationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
