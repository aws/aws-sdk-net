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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the ListTimelineEvents operation.
    /// Lists timeline events for the specified incident record.
    /// </summary>
    public partial class ListTimelineEventsRequest : AmazonSSMIncidentsRequest
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _incidentRecordArn;
        private int? _maxResults;
        private string _nextToken;
        private TimelineEventSort _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the timeline events based on the provided conditional values. You can filter
        /// timeline events with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>eventReference</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eventTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eventType</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following when deciding how to use Filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify a Filter, the response includes all timeline events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify more than one filter in a single request, the response returns timeline
        /// events that match all filters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a filter with more than one value, the response returns timeline events
        /// that match any of the values provided.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident that includes the timeline event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string IncidentRecordArn
        {
            get { return this._incidentRecordArn; }
            set { this._incidentRecordArn = value; }
        }

        // Check to see if IncidentRecordArn property is set
        internal bool IsSetIncidentRecordArn()
        {
            return this._incidentRecordArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next set of items to return. (You received this token
        /// from a previous call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
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
        /// Sort timeline events by the specified key value pair.
        /// </para>
        /// </summary>
        public TimelineEventSort SortBy
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
        /// Sorts the order of timeline events by the value specified in the <c>sortBy</c> field.
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