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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the ListLinuxSubscriptionInstances operation.
    /// Lists the running Amazon EC2 instances that were discovered with commercial Linux
    /// subscriptions.
    /// </summary>
    public partial class ListLinuxSubscriptionInstancesRequest : AmazonLicenseManagerLinuxSubscriptionsRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of structures that you can use to filter the results to those that match
        /// one or more sets of key-value pairs that you specify. For example, you can filter
        /// by the name of <code>AmiID</code> with an optional operator to see subscriptions that
        /// match, partially match, or don't match a certain Amazon Machine Image (AMI) ID.
        /// </para>
        ///  
        /// <para>
        /// The valid names for this filter are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AmiID</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InstanceID</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccountID</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Region</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UsageOperation</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ProductCode</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InstanceType</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The valid Operators for this filter are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>contains</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>equals</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Notequal</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Maximum number of results to return in a single call.
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
        /// Token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
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