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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Container for the parameters to the ListDevices operation.
    /// Returns a list of devices.
    /// </summary>
    public partial class ListDevicesRequest : AmazonPanoramaRequest
    {
        private DeviceAggregatedStatus _deviceAggregatedStatusFilter;
        private int? _maxResults;
        private string _nameFilter;
        private string _nextToken;
        private ListDevicesSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property DeviceAggregatedStatusFilter. 
        /// <para>
        /// Filter based on a device's status.
        /// </para>
        /// </summary>
        public DeviceAggregatedStatus DeviceAggregatedStatusFilter
        {
            get { return this._deviceAggregatedStatusFilter; }
            set { this._deviceAggregatedStatusFilter = value; }
        }

        // Check to see if DeviceAggregatedStatusFilter property is set
        internal bool IsSetDeviceAggregatedStatusFilter()
        {
            return this._deviceAggregatedStatusFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of devices to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NameFilter. 
        /// <para>
        /// Filter based on device's name. Prefixes supported.
        /// </para>
        /// </summary>
        public string NameFilter
        {
            get { return this._nameFilter; }
            set { this._nameFilter = value; }
        }

        // Check to see if NameFilter property is set
        internal bool IsSetNameFilter()
        {
            return this._nameFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token from a previous request to retrieve the next page of
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

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The target column to be sorted on. Default column sort is CREATED_TIME.
        /// </para>
        /// </summary>
        public ListDevicesSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sorting order for the returned list. SortOrder is DESCENDING by default based
        /// on CREATED_TIME. Otherwise, SortOrder is ASCENDING.
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