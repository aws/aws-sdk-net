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
    /// This is the response object from the GetCostAndUsageWithResources operation.
    /// </summary>
    public partial class GetCostAndUsageWithResourcesResponse : AmazonWebServiceResponse
    {
        private List<DimensionValuesWithAttributes> _dimensionValueAttributes = AWSConfigs.InitializeCollections ? new List<DimensionValuesWithAttributes>() : null;
        private List<GroupDefinition> _groupDefinitions = AWSConfigs.InitializeCollections ? new List<GroupDefinition>() : null;
        private string _nextPageToken;
        private List<ResultByTime> _resultsByTime = AWSConfigs.InitializeCollections ? new List<ResultByTime>() : null;

        /// <summary>
        /// Gets and sets the property DimensionValueAttributes. 
        /// <para>
        /// The attributes that apply to a specific dimension value. For example, if the value
        /// is a linked account, the attribute is that account name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DimensionValuesWithAttributes> DimensionValueAttributes
        {
            get { return this._dimensionValueAttributes; }
            set { this._dimensionValueAttributes = value; }
        }

        // Check to see if DimensionValueAttributes property is set
        internal bool IsSetDimensionValueAttributes()
        {
            return this._dimensionValueAttributes != null && (this._dimensionValueAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupDefinitions. 
        /// <para>
        /// The groups that are specified by the <c>Filter</c> or <c>GroupBy</c> parameters in
        /// the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupDefinition> GroupDefinitions
        {
            get { return this._groupDefinitions; }
            set { this._groupDefinitions = value; }
        }

        // Check to see if GroupDefinitions property is set
        internal bool IsSetGroupDefinitions()
        {
            return this._groupDefinitions != null && (this._groupDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token for the next set of retrievable results. Amazon Web Services provides the
        /// token when the response from a previous call has more results than the maximum page
        /// size.
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

        /// <summary>
        /// Gets and sets the property ResultsByTime. 
        /// <para>
        /// The time period that's covered by the results in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResultByTime> ResultsByTime
        {
            get { return this._resultsByTime; }
            set { this._resultsByTime = value; }
        }

        // Check to see if ResultsByTime property is set
        internal bool IsSetResultsByTime()
        {
            return this._resultsByTime != null && (this._resultsByTime.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}