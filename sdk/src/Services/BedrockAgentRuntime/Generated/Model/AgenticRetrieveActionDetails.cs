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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Details of a retrieve action including the query and target retrievers.
    /// </summary>
    public partial class AgenticRetrieveActionDetails
    {
        private AgenticRetrieveMessageContent _inputQuery;
        private List<AgenticRetrieveSourceRetriever> _sourceRetrievers = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveSourceRetriever>() : null;

        /// <summary>
        /// Gets and sets the property InputQuery. 
        /// <para>
        /// The input query used for retrieval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public AgenticRetrieveMessageContent InputQuery
        {
            get { return this._inputQuery; }
            set { this._inputQuery = value; }
        }

        // Check to see if InputQuery property is set
        internal bool IsSetInputQuery()
        {
            return this._inputQuery != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRetrievers. 
        /// <para>
        /// The list of source retrievers targeted by this action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AgenticRetrieveSourceRetriever> SourceRetrievers
        {
            get { return this._sourceRetrievers; }
            set { this._sourceRetrievers = value; }
        }

        // Check to see if SourceRetrievers property is set
        internal bool IsSetSourceRetrievers()
        {
            return this._sourceRetrievers != null && (this._sourceRetrievers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}