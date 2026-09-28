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
    /// Container for the parameters to the ListModels operation. Lists the models available
    /// to an Amazon Q in Connect assistant in the assistant's Amazon Web Services Region.
    /// The available models are determined by the region of the specified assistant.
    /// </summary>
    public partial class ListModelsRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AiPromptType. 
        /// <para>
        /// The type of the AI Prompt to filter models by. When specified, only models that support
        /// the given AI Prompt type are returned.
        /// </para>
        /// </summary>
        public AIPromptType AiPromptType { get; set; }

        /// <summary>
        /// Checks to see if the AiPromptType property is set.
        /// </summary>
        internal bool IsSetAiPromptType() => this.AiPromptType != null;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN. The assistant's region determines which models are available.
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
        /// Gets and sets the property ModelLifecycle. 
        /// <para>
        /// The lifecycle status of models to filter by. When specified, only models with the
        /// given lifecycle status are returned.
        /// </para>
        /// </summary>
        public ModelLifecycle ModelLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the ModelLifecycle property is set.
        /// </summary>
        internal bool IsSetModelLifecycle() => this.ModelLifecycle != null;

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
    }
}
