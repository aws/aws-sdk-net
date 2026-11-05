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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the SearchWorkers operation. Searches for workers.
    /// </summary>
    public partial class SearchWorkersRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property FarmId. The farm ID in the workers search.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property FilterExpressions. The search terms for a resource.
        /// </summary>
        public SearchGroupedFilterExpressions FilterExpressions { get; set; }

        /// <summary>
        /// Checks to see if the FilterExpressions property is set.
        /// </summary>
        internal bool IsSetFilterExpressions() => this.FilterExpressions != null;

        /// <summary>
        /// Gets and sets the property FleetIds. The fleet ID of the workers to search for.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> FleetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FleetIds property is set.
        /// </summary>
        internal bool IsSetFleetIds() => this.FleetIds != null && (this.FleetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ItemOffset. The offset for the search results.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public int? ItemOffset { get; set; }

        /// <summary>
        /// Checks to see if the ItemOffset property is set.
        /// </summary>
        internal bool IsSetItemOffset() => this.ItemOffset.HasValue;

        /// <summary>
        /// Gets and sets the property PageSize. Specifies the number of results to return.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property SortExpressions. The search terms for a resource.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<SearchSortExpression> SortExpressions { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchSortExpression>() : null;

        /// <summary>
        /// Checks to see if the SortExpressions property is set.
        /// </summary>
        internal bool IsSetSortExpressions() => this.SortExpressions != null && (this.SortExpressions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
