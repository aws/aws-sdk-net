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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Optional filters for ListSearches. When multiple filters are set, a search must match
    /// all of them.
    /// </summary>
    public partial class ListSearchesFilters
    {
        /// <summary>
        /// Gets and sets the property GroupIdFilter. 
        /// <para>
        /// Returns only searches whose <c>groupId</c> is one of the listed values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> GroupIdFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GroupIdFilter property is set.
        /// </summary>
        internal bool IsSetGroupIdFilter() => this.GroupIdFilter != null && (this.GroupIdFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchTypeFilter. 
        /// <para>
        /// Returns only searches whose <c>searchType</c> is one of the listed values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> SearchTypeFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SearchTypeFilter property is set.
        /// </summary>
        internal bool IsSetSearchTypeFilter() => this.SearchTypeFilter != null && (this.SearchTypeFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// Returns only searches started at or after this time.
        /// </para>
        /// </summary>
        public DateTime? StartedAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartedAfter property is set.
        /// </summary>
        internal bool IsSetStartedAfter() => this.StartedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// Returns only searches started at or before this time.
        /// </para>
        /// </summary>
        public DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Checks to see if the StartedBefore property is set.
        /// </summary>
        internal bool IsSetStartedBefore() => this.StartedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Returns only searches whose status is one of the listed values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> StatusFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusFilter property is set.
        /// </summary>
        internal bool IsSetStatusFilter() => this.StatusFilter != null && (this.StatusFilter.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
