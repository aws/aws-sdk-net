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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetCostAndUsage operation.
    /// </summary>
    public partial class GetCostAndUsageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DimensionValueAttributes. 
        /// <para>
        /// The attributes that apply to a specific dimension value. For example, if the value
        /// is a linked account, the attribute is that account name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DimensionValuesWithAttributes> DimensionValueAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionValuesWithAttributes>() : null;

        /// <summary>
        /// Checks to see if the DimensionValueAttributes property is set.
        /// </summary>
        internal bool IsSetDimensionValueAttributes() => this.DimensionValueAttributes != null && (this.DimensionValueAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupDefinitions. 
        /// <para>
        /// The groups that are specified by the <c>Filter</c> or <c>GroupBy</c> parameters in
        /// the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupDefinition> GroupDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupDefinition>() : null;

        /// <summary>
        /// Checks to see if the GroupDefinitions property is set.
        /// </summary>
        internal bool IsSetGroupDefinitions() => this.GroupDefinitions != null && (this.GroupDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token for the next set of retrievable results. Amazon Web Services provides the
        /// token when the response from a previous call has more results than the maximum page
        /// size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property ResultsByTime. 
        /// <para>
        /// The time period that's covered by the results in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResultByTime> ResultsByTime { get; set; } = AWSConfigs.InitializeCollections ? new List<ResultByTime>() : null;

        /// <summary>
        /// Checks to see if the ResultsByTime property is set.
        /// </summary>
        internal bool IsSetResultsByTime() => this.ResultsByTime != null && (this.ResultsByTime.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
