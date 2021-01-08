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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the ListAppsLists operation.
    /// Returns an array of <code>AppsListDataSummary</code> objects.
    /// </summary>
    public partial class ListAppsListsRequest : AmazonFMSRequest
    {
        private bool? _defaultLists;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DefaultLists. 
        /// <para>
        /// Specifies whether the lists to retrieve are default lists owned by AWS Firewall Manager.
        /// </para>
        /// </summary>
        public bool DefaultLists
        {
            get { return this._defaultLists.GetValueOrDefault(); }
            set { this._defaultLists = value; }
        }

        // Check to see if DefaultLists property is set
        internal bool IsSetDefaultLists()
        {
            return this._defaultLists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you want AWS Firewall Manager to return for this
        /// request. If more objects are available, in the response, AWS Firewall Manager provides
        /// a <code>NextToken</code> value that you can use in a subsequent call to get the next
        /// batch of objects.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this, AWS Firewall Manager returns all available objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// If you specify a value for <code>MaxResults</code> in your list request, and you have
        /// more objects than the maximum, AWS Firewall Manager returns this token in the response.
        /// For all but the first request, you provide the token returned by the prior request
        /// in the request parameters, to retrieve the next batch of objects.
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

    }
}