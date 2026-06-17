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
    /// An action taken during agentic retrieval.
    /// </summary>
    public partial class AgenticRetrieveAction
    {
        private AgenticRetrieveFullDocExpansionDetails _fullDocumentExpansion;
        private AgenticRetrieveActionDetails _retrieve;

        /// <summary>
        /// Gets and sets the property FullDocumentExpansion. 
        /// <para>
        /// Details of a full document expansion action.
        /// </para>
        /// </summary>
        public AgenticRetrieveFullDocExpansionDetails FullDocumentExpansion
        {
            get { return this._fullDocumentExpansion; }
            set { this._fullDocumentExpansion = value; }
        }

        // Check to see if FullDocumentExpansion property is set
        internal bool IsSetFullDocumentExpansion()
        {
            return this._fullDocumentExpansion != null;
        }

        /// <summary>
        /// Gets and sets the property Retrieve. 
        /// <para>
        /// Details of the retrieve action.
        /// </para>
        /// </summary>
        public AgenticRetrieveActionDetails Retrieve
        {
            get { return this._retrieve; }
            set { this._retrieve = value; }
        }

        // Check to see if Retrieve property is set
        internal bool IsSetRetrieve()
        {
            return this._retrieve != null;
        }

    }
}