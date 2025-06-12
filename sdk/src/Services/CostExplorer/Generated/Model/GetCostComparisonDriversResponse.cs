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
    /// This is the response object from the GetCostComparisonDrivers operation.
    /// </summary>
    public partial class GetCostComparisonDriversResponse : AmazonWebServiceResponse
    {
        private List<CostComparisonDriver> _costComparisonDrivers = AWSConfigs.InitializeCollections ? new List<CostComparisonDriver>() : null;
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property CostComparisonDrivers. 
        /// <para>
        /// An array of comparison results showing factors that drive significant cost differences
        /// between <c>BaselineTimePeriod</c> and <c>ComparisonTimePeriod</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CostComparisonDriver> CostComparisonDrivers
        {
            get { return this._costComparisonDrivers; }
            set { this._costComparisonDrivers = value; }
        }

        // Check to see if CostComparisonDrivers property is set
        internal bool IsSetCostComparisonDrivers()
        {
            return this._costComparisonDrivers != null && (this._costComparisonDrivers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}