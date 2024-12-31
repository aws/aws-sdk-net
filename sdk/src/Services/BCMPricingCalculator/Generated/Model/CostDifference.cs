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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents the difference between historical and estimated costs.
    /// </summary>
    public partial class CostDifference
    {
        private CostAmount _estimatedCost;
        private CostAmount _historicalCost;

        /// <summary>
        /// Gets and sets the property EstimatedCost. 
        /// <para>
        ///  The estimated cost amount. 
        /// </para>
        /// </summary>
        public CostAmount EstimatedCost
        {
            get { return this._estimatedCost; }
            set { this._estimatedCost = value; }
        }

        // Check to see if EstimatedCost property is set
        internal bool IsSetEstimatedCost()
        {
            return this._estimatedCost != null;
        }

        /// <summary>
        /// Gets and sets the property HistoricalCost. 
        /// <para>
        ///  The historical cost amount. 
        /// </para>
        /// </summary>
        public CostAmount HistoricalCost
        {
            get { return this._historicalCost; }
            set { this._historicalCost = value; }
        }

        // Check to see if HistoricalCost property is set
        internal bool IsSetHistoricalCost()
        {
            return this._historicalCost != null;
        }

    }
}