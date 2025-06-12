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
    /// Provides a summary of cost-related information for a bill estimate.
    /// </summary>
    public partial class BillEstimateCostSummary
    {
        private Dictionary<string, CostDifference> _serviceCostDifferences = AWSConfigs.InitializeCollections ? new Dictionary<string, CostDifference>() : null;
        private CostDifference _totalCostDifference;

        /// <summary>
        /// Gets and sets the property ServiceCostDifferences. 
        /// <para>
        ///  A breakdown of cost differences by Amazon Web Services service. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CostDifference> ServiceCostDifferences
        {
            get { return this._serviceCostDifferences; }
            set { this._serviceCostDifferences = value; }
        }

        // Check to see if ServiceCostDifferences property is set
        internal bool IsSetServiceCostDifferences()
        {
            return this._serviceCostDifferences != null && (this._serviceCostDifferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalCostDifference. 
        /// <para>
        ///  The total difference in cost between the estimated and historical costs. 
        /// </para>
        /// </summary>
        public CostDifference TotalCostDifference
        {
            get { return this._totalCostDifference; }
            set { this._totalCostDifference = value; }
        }

        // Check to see if TotalCostDifference property is set
        internal bool IsSetTotalCostDifference()
        {
            return this._totalCostDifference != null;
        }

    }
}