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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the ListComputationModelDataBindingUsages operation.
    /// </summary>
    public partial class ListComputationModelDataBindingUsagesResponse : AmazonWebServiceResponse
    {
        private List<ComputationModelDataBindingUsageSummary> _dataBindingUsageSummaries = AWSConfigs.InitializeCollections ? new List<ComputationModelDataBindingUsageSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DataBindingUsageSummaries. 
        /// <para>
        /// A list of summaries describing the data binding usages across computation models.
        /// Each summary includes the computation model IDs and the matched data binding details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ComputationModelDataBindingUsageSummary> DataBindingUsageSummaries
        {
            get { return this._dataBindingUsageSummaries; }
            set { this._dataBindingUsageSummaries = value; }
        }

        // Check to see if DataBindingUsageSummaries property is set
        internal bool IsSetDataBindingUsageSummaries()
        {
            return this._dataBindingUsageSummaries != null && (this._dataBindingUsageSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of paginated results, or null if there are no additional
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}