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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
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
namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// This is the response object from the GetRequestAuthorizationDetails operation.
    /// </summary>
    public partial class GetRequestAuthorizationDetailsResponse : AmazonWebServiceResponse
    {
        private List<Evaluation> _evaluations = AWSConfigs.InitializeCollections ? new List<Evaluation>() : null;
        private string _nextToken;
        private List<PolicyInfo> _policies = AWSConfigs.InitializeCollections ? new List<PolicyInfo>() : null;
        private Dictionary<string, Amazon.Runtime.Documents.Document> _requestContext = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Gets and sets the property Evaluations. 
        /// <para>
        /// The list of evaluations for this request. Each evaluation shows how a single action
        /// and resource pair was evaluated. This includes the context, the effect, and any policies
        /// that matched.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Evaluation> Evaluations
        {
            get { return this._evaluations; }
            set { this._evaluations = value; }
        }

        // Check to see if Evaluations property is set
        internal bool IsSetEvaluations()
        {
            return this._evaluations != null && (this._evaluations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for retrieving the next page of evaluations. This value is absent
        /// when there are no more results.
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
        /// Gets and sets the property Policies. 
        /// <para>
        /// The list of policies that were evaluated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PolicyInfo> Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null && (this._policies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestContext. 
        /// <para>
        /// The request context is the set of context keys and values that apply to the entire
        /// request and are shared by all evaluations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, Amazon.Runtime.Documents.Document> RequestContext
        {
            get { return this._requestContext; }
            set { this._requestContext = value; }
        }

        // Check to see if RequestContext property is set
        internal bool IsSetRequestContext()
        {
            return this._requestContext != null && (this._requestContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}