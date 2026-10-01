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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// An action taken during agentic retrieval.
    /// </summary>
    public partial class AgenticRetrieveAction
    {
        /// <summary>
        /// Gets and sets the property FullDocumentExpansion. 
        /// <para>
        /// Details of a full document expansion action.
        /// </para>
        /// </summary>
        public AgenticRetrieveFullDocExpansionDetails FullDocumentExpansion { get; set; }

        /// <summary>
        /// Checks to see if the FullDocumentExpansion property is set.
        /// </summary>
        internal bool IsSetFullDocumentExpansion() => this.FullDocumentExpansion != null;

        /// <summary>
        /// Gets and sets the property MemoryRetrieve. 
        /// <para>
        /// The details of a long-term memory retrieval that the agent chose to perform.
        /// </para>
        /// </summary>
        public AgenticRetrieveMemoryRetrieveDetails MemoryRetrieve { get; set; }

        /// <summary>
        /// Checks to see if the MemoryRetrieve property is set.
        /// </summary>
        internal bool IsSetMemoryRetrieve() => this.MemoryRetrieve != null;

        /// <summary>
        /// Gets and sets the property Retrieve. 
        /// <para>
        /// Details of the retrieve action.
        /// </para>
        /// </summary>
        public AgenticRetrieveActionDetails Retrieve { get; set; }

        /// <summary>
        /// Checks to see if the Retrieve property is set.
        /// </summary>
        internal bool IsSetRetrieve() => this.Retrieve != null;
    }
}
