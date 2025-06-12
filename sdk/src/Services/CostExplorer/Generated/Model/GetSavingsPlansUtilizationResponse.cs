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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetSavingsPlansUtilization operation.
    /// </summary>
    public partial class GetSavingsPlansUtilizationResponse : AmazonWebServiceResponse
    {
        private List<SavingsPlansUtilizationByTime> _savingsPlansUtilizationsByTime = AWSConfigs.InitializeCollections ? new List<SavingsPlansUtilizationByTime>() : null;
        private SavingsPlansUtilizationAggregates _total;

        /// <summary>
        /// Gets and sets the property SavingsPlansUtilizationsByTime. 
        /// <para>
        /// The amount of cost/commitment that you used your Savings Plans. You can use it to
        /// specify date ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SavingsPlansUtilizationByTime> SavingsPlansUtilizationsByTime
        {
            get { return this._savingsPlansUtilizationsByTime; }
            set { this._savingsPlansUtilizationsByTime = value; }
        }

        // Check to see if SavingsPlansUtilizationsByTime property is set
        internal bool IsSetSavingsPlansUtilizationsByTime()
        {
            return this._savingsPlansUtilizationsByTime != null && (this._savingsPlansUtilizationsByTime.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total amount of cost/commitment that you used your Savings Plans, regardless of
        /// date ranges.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SavingsPlansUtilizationAggregates Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total != null;
        }

    }
}