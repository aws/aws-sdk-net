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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListSimulationApplications operation.
    /// Returns a list of simulation applications. You can optionally provide filters to retrieve
    /// specific simulation applications.
    /// </summary>
    public partial class ListSimulationApplicationsRequest : AmazonRoboMakerRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private string _versionQualifier;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional list of filters to limit results.
        /// </para>
        ///  
        /// <para>
        /// The filter name <code>name</code> is supported. When filtering, you must use the complete
        /// value of the filtered item. You can use up to three filters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// When this parameter is used, <code>ListSimulationApplications</code> only returns
        /// <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>ListSimulationApplications</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 100. If this parameter is not used, then <code>ListSimulationApplications</code>
        /// returns up to 100 results and a <code>nextToken</code> value if applicable. 
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If the previous paginated request did not return all of the remaining results, the
        /// response object's <code>nextToken</code> parameter value is set to a token. To retrieve
        /// the next set of results, call <code>ListSimulationApplications</code> again and assign
        /// that token to the request object's <code>nextToken</code> parameter. If there are
        /// no remaining results, the previous response object's NextToken parameter is set to
        /// null. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property VersionQualifier. 
        /// <para>
        /// The version qualifier of the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string VersionQualifier
        {
            get { return this._versionQualifier; }
            set { this._versionQualifier = value; }
        }

        // Check to see if VersionQualifier property is set
        internal bool IsSetVersionQualifier()
        {
            return this._versionQualifier != null;
        }

    }
}