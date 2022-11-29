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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ListSecurityPolicies operation.
    /// Returns information about configured OpenSearch Serverless security policies.
    /// </summary>
    public partial class ListSecurityPoliciesRequest : AmazonOpenSearchServerlessRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resource = new List<string>();
        private SecurityPolicyType _type;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional parameter that specifies the maximum number of results to return. You
        /// can use <code>nextToken</code> to get the next page of results. The default is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// If your initial <code>ListSecurityPolicies</code> operation returns a <code>nextToken</code>,
        /// you can include the returned <code>nextToken</code> in subsequent <code>ListSecurityPolicies</code>
        /// operations, which returns results in the next page. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Resource. 
        /// <para>
        /// Resource filters (can be collection or indexes) that policies can apply to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<string> Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null && this._resource.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SecurityPolicyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}