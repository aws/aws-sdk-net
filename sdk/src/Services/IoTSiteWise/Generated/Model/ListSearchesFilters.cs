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
    /// Optional filters for ListSearches. When multiple filters are set, a search must match
    /// all of them.
    /// </summary>
    public partial class ListSearchesFilters
    {
        private List<string> _groupIdFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _searchTypeFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startedAfter;
        private DateTime? _startedBefore;
        private List<string> _statusFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GroupIdFilter. 
        /// <para>
        /// Returns only searches whose <c>groupId</c> is one of the listed values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> GroupIdFilter
        {
            get { return this._groupIdFilter; }
            set { this._groupIdFilter = value; }
        }

        // Check to see if GroupIdFilter property is set
        internal bool IsSetGroupIdFilter()
        {
            return this._groupIdFilter != null && (this._groupIdFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SearchTypeFilter. 
        /// <para>
        /// Returns only searches whose <c>searchType</c> is one of the listed values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> SearchTypeFilter
        {
            get { return this._searchTypeFilter; }
            set { this._searchTypeFilter = value; }
        }

        // Check to see if SearchTypeFilter property is set
        internal bool IsSetSearchTypeFilter()
        {
            return this._searchTypeFilter != null && (this._searchTypeFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// Returns only searches started at or after this time.
        /// </para>
        /// </summary>
        public DateTime? StartedAfter
        {
            get { return this._startedAfter; }
            set { this._startedAfter = value; }
        }

        // Check to see if StartedAfter property is set
        internal bool IsSetStartedAfter()
        {
            return this._startedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// Returns only searches started at or before this time.
        /// </para>
        /// </summary>
        public DateTime? StartedBefore
        {
            get { return this._startedBefore; }
            set { this._startedBefore = value; }
        }

        // Check to see if StartedBefore property is set
        internal bool IsSetStartedBefore()
        {
            return this._startedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Returns only searches whose status is one of the listed values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> StatusFilter
        {
            get { return this._statusFilter; }
            set { this._statusFilter = value; }
        }

        // Check to see if StatusFilter property is set
        internal bool IsSetStatusFilter()
        {
            return this._statusFilter != null && (this._statusFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}