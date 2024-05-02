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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the ListAccountPermissions operation.
    /// Lists the permissions an account has to configure Amazon Inspector.
    /// </summary>
    public partial class ListAccountPermissionsRequest : AmazonInspector2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private Service _service;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results the response can return. If your request would return
        /// more than the maximum the response will return a <c>nextToken</c> value, use this
        /// value when you call the action again to get the remaining results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request to a list action. If your response
        /// returns more than the <c>maxResults</c> maximum value it will also return a <c>nextToken</c>
        /// value. For subsequent calls, use the NextToken value returned from the previous request
        /// to continue listing results after the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
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
        /// Gets and sets the property Service. 
        /// <para>
        /// The service scan type to check permissions for.
        /// </para>
        /// </summary>
        public Service Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}