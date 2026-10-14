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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A summary of metrics showing the total counts of processed rows and rules, including
    /// their pass/fail statistics based on row-level results.
    /// </summary>
    public partial class DataQualityAggregatedMetrics
    {
        /// <summary>
        /// Gets and sets the property TotalRowsFailed. 
        /// <para>
        /// The total number of rows that failed one or more data quality rules.
        /// </para>
        /// </summary>
        public double? TotalRowsFailed { get; set; }

        /// <summary>
        /// Checks to see if the TotalRowsFailed property is set.
        /// </summary>
        internal bool IsSetTotalRowsFailed() => this.TotalRowsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRowsPassed. 
        /// <para>
        /// The total number of rows that passed all applicable data quality rules.
        /// </para>
        /// </summary>
        public double? TotalRowsPassed { get; set; }

        /// <summary>
        /// Checks to see if the TotalRowsPassed property is set.
        /// </summary>
        internal bool IsSetTotalRowsPassed() => this.TotalRowsPassed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRowsProcessed. 
        /// <para>
        /// The total number of rows that were processed during the data quality evaluation.
        /// </para>
        /// </summary>
        public double? TotalRowsProcessed { get; set; }

        /// <summary>
        /// Checks to see if the TotalRowsProcessed property is set.
        /// </summary>
        internal bool IsSetTotalRowsProcessed() => this.TotalRowsProcessed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRulesFailed. 
        /// <para>
        /// The total number of data quality rules that failed their evaluation criteria.
        /// </para>
        /// </summary>
        public double? TotalRulesFailed { get; set; }

        /// <summary>
        /// Checks to see if the TotalRulesFailed property is set.
        /// </summary>
        internal bool IsSetTotalRulesFailed() => this.TotalRulesFailed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRulesPassed. 
        /// <para>
        /// The total number of data quality rules that passed their evaluation criteria.
        /// </para>
        /// </summary>
        public double? TotalRulesPassed { get; set; }

        /// <summary>
        /// Checks to see if the TotalRulesPassed property is set.
        /// </summary>
        internal bool IsSetTotalRulesPassed() => this.TotalRulesPassed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRulesProcessed. 
        /// <para>
        /// The total number of data quality rules that were evaluated.
        /// </para>
        /// </summary>
        public double? TotalRulesProcessed { get; set; }

        /// <summary>
        /// Checks to see if the TotalRulesProcessed property is set.
        /// </summary>
        internal bool IsSetTotalRulesProcessed() => this.TotalRulesProcessed.HasValue;
    }
}
