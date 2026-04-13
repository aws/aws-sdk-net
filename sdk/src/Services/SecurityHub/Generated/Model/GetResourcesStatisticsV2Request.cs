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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourcesStatisticsV2 operation.
    /// Retrieves statistical information about Amazon Web Services resources and their associated
    /// security findings.
    /// 
    ///  
    /// <para>
    /// You can use the <c>Scopes</c> parameter to define the data boundary for the query.
    /// Currently, <c>Scopes</c> supports <c>AwsOrganizations</c>, which lets you aggregate
    /// resources from your entire organization or from specific organizational units. Only
    /// the delegated administrator account can use <c>Scopes</c>.
    /// </para>
    /// </summary>
    public partial class GetResourcesStatisticsV2Request : AmazonSecurityHubRequest
    {
        private List<ResourceGroupByRule> _groupByRules = AWSConfigs.InitializeCollections ? new List<ResourceGroupByRule>() : null;
        private int? _maxStatisticResults;
        private ResourceScopes _scopes;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property GroupByRules. 
        /// <para>
        /// How resource statistics should be aggregated and organized in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceGroupByRule> GroupByRules
        {
            get { return this._groupByRules; }
            set { this._groupByRules = value; }
        }

        // Check to see if GroupByRules property is set
        internal bool IsSetGroupByRules()
        {
            return this._groupByRules != null && (this._groupByRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxStatisticResults. 
        /// <para>
        /// The maximum number of results to be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
        public int? MaxStatisticResults
        {
            get { return this._maxStatisticResults; }
            set { this._maxStatisticResults = value; }
        }

        // Check to see if MaxStatisticResults property is set
        internal bool IsSetMaxStatisticResults()
        {
            return this._maxStatisticResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// Limits the results to resources from specific organizational units or from the delegated
        /// administrator's organization. Only the delegated administrator account can use this
        /// parameter. Other accounts receive an <c>AccessDeniedException</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you omit it, the delegated administrator sees statistics
        /// from all accounts across the entire organization. Other accounts see only statistics
        /// for their own resources.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 10 entries in <c>Scopes.AwsOrganizations</c>. If multiple entries
        /// are specified, the entries are combined using OR logic.
        /// </para>
        /// </summary>
        public ResourceScopes Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Sorts aggregated statistics.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}