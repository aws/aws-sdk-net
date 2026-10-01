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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the QueryAssistant operation. <important> <para> This
    /// API will be discontinued starting June 1, 2024. To receive generative responses after
    /// March 1, 2024, you will need to create a new Assistant in the Connect Customer console
    /// and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into
    /// your applications. </para> </important> <para> Performs a manual search against the
    /// specified assistant. To retrieve recommendations for an assistant, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>.
    /// </para>
    /// </summary>
    public partial class QueryAssistantRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantId { get; set; }

        /// <summary>
        /// Checks to see if the AssistantId property is set.
        /// </summary>
        internal bool IsSetAssistantId() => this.AssistantId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OverrideKnowledgeBaseSearchType. 
        /// <para>
        /// The search type to be used against the Knowledge Base for this request. The values
        /// can be <c>SEMANTIC</c> which uses vector embeddings or <c>HYBRID</c> which use vector
        /// embeddings and raw text.
        /// </para>
        /// </summary>
        public KnowledgeBaseSearchType OverrideKnowledgeBaseSearchType { get; set; }

        /// <summary>
        /// Checks to see if the OverrideKnowledgeBaseSearchType property is set.
        /// </summary>
        internal bool IsSetOverrideKnowledgeBaseSearchType() => this.OverrideKnowledgeBaseSearchType != null;

        /// <summary>
        /// Gets and sets the property QueryCondition. 
        /// <para>
        /// Information about how to query content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<QueryCondition> QueryCondition { get; set; } = AWSConfigs.InitializeCollections ? new List<QueryCondition>() : null;

        /// <summary>
        /// Checks to see if the QueryCondition property is set.
        /// </summary>
        internal bool IsSetQueryCondition() => this.QueryCondition != null && (this.QueryCondition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryInputData. 
        /// <para>
        /// Information about the query.
        /// </para>
        /// </summary>
        public QueryInputData QueryInputData { get; set; }

        /// <summary>
        /// Checks to see if the QueryInputData property is set.
        /// </summary>
        internal bool IsSetQueryInputData() => this.QueryInputData != null;

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The text to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 512)]
        public string QueryText { get; set; }

        /// <summary>
        /// Checks to see if the QueryText property is set.
        /// </summary>
        internal bool IsSetQueryText() => this.QueryText != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect session. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
