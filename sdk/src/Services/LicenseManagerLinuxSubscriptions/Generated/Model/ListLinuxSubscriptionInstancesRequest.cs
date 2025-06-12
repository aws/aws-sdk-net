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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the ListLinuxSubscriptionInstances operation.
    /// Lists the running Amazon EC2 instances that were discovered with commercial Linux
    /// subscriptions.
    /// </summary>
    public partial class ListLinuxSubscriptionInstancesRequest : AmazonLicenseManagerLinuxSubscriptionsRequest
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of structures that you can use to filter the results by your specified criteria.
        /// For example, you can specify <c>Region</c> in the <c>Name</c>, with the <c>contains</c>
        /// operator to list all subscriptions that match a partial string in the <c>Value</c>,
        /// such as <c>us-west</c>.
        /// </para>
        ///  
        /// <para>
        /// For each filter, you can specify one of the following values for the <c>Name</c> key
        /// to streamline results:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AccountID</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AmiID</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DualSubscription</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceID</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceType</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProductCode</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Region</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UsageOperation</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For each filter, you can use one of the following <c>Operator</c> values to define
        /// the behavior of the filter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>contains</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>equals</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Notequal</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// The maximum items to return in a request.
        /// </para>
        /// </summary>
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
        /// A token to specify where to start paginating. This is the nextToken from a previously
        /// truncated response.
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