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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the ListResiliencyPolicies operation.
    /// </summary>
    public partial class ListResiliencyPoliciesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResiliencyPolicy> _resiliencyPolicies = AWSConfigs.InitializeCollections ? new List<ResiliencyPolicy>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results, or null if there are no more results.
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
        /// Gets and sets the property ResiliencyPolicies. 
        /// <para>
        /// The resiliency policies for the Resilience Hub applications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResiliencyPolicy> ResiliencyPolicies
        {
            get { return this._resiliencyPolicies; }
            set { this._resiliencyPolicies = value; }
        }

        // Check to see if ResiliencyPolicies property is set
        internal bool IsSetResiliencyPolicies()
        {
            return this._resiliencyPolicies != null && (this._resiliencyPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}