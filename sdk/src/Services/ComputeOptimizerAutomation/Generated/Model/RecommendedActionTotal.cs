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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Aggregate totals for a group of recommended actions, including count and estimated
    /// monthly savings.
    /// </summary>
    public partial class RecommendedActionTotal
    {
        private EstimatedMonthlySavings _estimatedMonthlySavings;
        private int? _recommendedActionCount;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings.
        /// </summary>
        [AWSProperty(Required=true)]
        public EstimatedMonthlySavings EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActionCount. 
        /// <para>
        /// The total number of recommended actions in this group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? RecommendedActionCount
        {
            get { return this._recommendedActionCount; }
            set { this._recommendedActionCount = value; }
        }

        // Check to see if RecommendedActionCount property is set
        internal bool IsSetRecommendedActionCount()
        {
            return this._recommendedActionCount.HasValue; 
        }

    }
}