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
    /// Container for the parameters to the ListIncidentRecords operation.
    /// Lists all incident records in your account. Use this command to retrieve the Amazon
    /// Resource Name (ARN) of the incident record you want to update.
    /// </summary>
    public partial class ListIncidentRecordsRequest : AmazonSSMIncidentsRequest
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the list of incident records you want to search through. You can filter on
        /// the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>creationTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>impact</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>createdBy</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following when when you use Filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify a Filter, the response includes all incident records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify more than one filter in a single request, the response returns incident
        /// records that match all filters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a filter with more than one value, the response returns incident records
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

    }
}