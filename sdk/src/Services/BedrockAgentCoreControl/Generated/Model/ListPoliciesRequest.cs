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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the ListPolicies operation.
    /// Retrieves a list of policies within the AgentCore Policy engine. This operation supports
    /// pagination and filtering to help administrators manage and discover policies across
    /// policy engines. Results can be filtered by policy engine or resource associations.
    /// </summary>
    public partial class ListPoliciesRequest : AmazonBedrockAgentCoreControlRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _policyEngineId;
        private string _targetResourceScope;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of policies to return in a single response. If not specified, the
        /// default is 10 policies per page, with a maximum of 100 per page.
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
        /// A pagination token returned from a previous <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_ListPolicies.html">ListPolicies</a>
        /// call. Use this token to retrieve the next page of results when the response is paginated.
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
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine whose policies to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyEngineId
        {
            get { return this._policyEngineId; }
            set { this._policyEngineId = value; }
        }

        // Check to see if PolicyEngineId property is set
        internal bool IsSetPolicyEngineId()
        {
            return this._policyEngineId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResourceScope. 
        /// <para>
        /// Optional filter to list policies that apply to a specific resource scope or resource
        /// type. This helps narrow down policy results to those relevant for particular Amazon
        /// Web Services resources, agent tools, or operational contexts within the policy engine
        /// ecosystem.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1011)]
        public string TargetResourceScope
        {
            get { return this._targetResourceScope; }
            set { this._targetResourceScope = value; }
        }

        // Check to see if TargetResourceScope property is set
        internal bool IsSetTargetResourceScope()
        {
            return this._targetResourceScope != null;
        }

    }
}