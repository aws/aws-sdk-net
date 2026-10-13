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
    /// Container for the parameters to the ListCostCategoryDefinitions operation. Returns
    /// the name, Amazon Resource Name (ARN), <c>NumberOfRules</c> and effective dates of
    /// all cost categories defined in the account. You have the option to use <c>EffectiveOn</c>
    /// and <c>SupportedResourceTypes</c> to return a list of cost categories that were active
    /// on a specific date. If there is no <c>EffectiveOn</c> specified, you’ll see cost categories
    /// that are effective on the current date. If cost category is still effective, <c>EffectiveEnd</c>
    /// is omitted in the response. <c>ListCostCategoryDefinitions</c> supports pagination.
    /// The request can have a <c>MaxResults</c> range up to 100.
    /// </summary>
    public partial class ListCostCategoryDefinitionsRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property EffectiveOn. 
        /// <para>
        /// The date when the cost category was effective. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string EffectiveOn { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveOn property is set.
        /// </summary>
        internal bool IsSetEffectiveOn() => this.EffectiveOn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of entries a paginated response contains. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SupportedResourceTypes. 
        /// <para>
        ///  Filter cost category definitions that are supported by given resource types based
        /// on the latest version. If the filter is present, the result only includes Cost Categories
        /// that supports input resource type. If the filter isn't provided, no filtering is applied.
        /// The valid values are <c>billing:rispgroupsharing</c>, <c>billing:billingview</c>,
        /// and <c>billing:creditsharing</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> SupportedResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedResourceTypes property is set.
        /// </summary>
        internal bool IsSetSupportedResourceTypes() => this.SupportedResourceTypes != null && (this.SupportedResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
