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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private double? _totalRowsFailed;
        private double? _totalRowsPassed;
        private double? _totalRowsProcessed;
        private double? _totalRulesFailed;
        private double? _totalRulesPassed;
        private double? _totalRulesProcessed;

        /// <summary>
        /// Gets and sets the property TotalRowsFailed. 
        /// <para>
        /// The total number of rows that failed one or more data quality rules.
        /// </para>
        /// </summary>
        public double? TotalRowsFailed
        {
            get { return this._totalRowsFailed; }
            set { this._totalRowsFailed = value; }
        }

        // Check to see if TotalRowsFailed property is set
        internal bool IsSetTotalRowsFailed()
        {
            return this._totalRowsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRowsPassed. 
        /// <para>
        /// The total number of rows that passed all applicable data quality rules.
        /// </para>
        /// </summary>
        public double? TotalRowsPassed
        {
            get { return this._totalRowsPassed; }
            set { this._totalRowsPassed = value; }
        }

        // Check to see if TotalRowsPassed property is set
        internal bool IsSetTotalRowsPassed()
        {
            return this._totalRowsPassed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRowsProcessed. 
        /// <para>
        /// The total number of rows that were processed during the data quality evaluation.
        /// </para>
        /// </summary>
        public double? TotalRowsProcessed
        {
            get { return this._totalRowsProcessed; }
            set { this._totalRowsProcessed = value; }
        }

        // Check to see if TotalRowsProcessed property is set
        internal bool IsSetTotalRowsProcessed()
        {
            return this._totalRowsProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRulesFailed. 
        /// <para>
        /// The total number of data quality rules that failed their evaluation criteria.
        /// </para>
        /// </summary>
        public double? TotalRulesFailed
        {
            get { return this._totalRulesFailed; }
            set { this._totalRulesFailed = value; }
        }

        // Check to see if TotalRulesFailed property is set
        internal bool IsSetTotalRulesFailed()
        {
            return this._totalRulesFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRulesPassed. 
        /// <para>
        /// The total number of data quality rules that passed their evaluation criteria.
        /// </para>
        /// </summary>
        public double? TotalRulesPassed
        {
            get { return this._totalRulesPassed; }
            set { this._totalRulesPassed = value; }
        }

        // Check to see if TotalRulesPassed property is set
        internal bool IsSetTotalRulesPassed()
        {
            return this._totalRulesPassed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRulesProcessed. 
        /// <para>
        /// The total number of data quality rules that were evaluated.
        /// </para>
        /// </summary>
        public double? TotalRulesProcessed
        {
            get { return this._totalRulesProcessed; }
            set { this._totalRulesProcessed = value; }
        }

        // Check to see if TotalRulesProcessed property is set
        internal bool IsSetTotalRulesProcessed()
        {
            return this._totalRulesProcessed.HasValue; 
        }

    }
}