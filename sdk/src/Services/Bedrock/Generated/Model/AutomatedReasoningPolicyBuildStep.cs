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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a single step in the policy build process, containing context about what
    /// was being processed and any messages or results.
    /// </summary>
    public partial class AutomatedReasoningPolicyBuildStep
    {
        private AutomatedReasoningPolicyBuildStepContext _context;
        private List<AutomatedReasoningPolicyBuildStepMessage> _messages = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyBuildStepMessage>() : null;
        private AutomatedReasoningPolicyDefinitionElement _priorElement;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Contextual information about what was being processed during this build step, such
        /// as the type of operation or the source material being analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningPolicyBuildStepContext Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// A list of messages generated during this build step, including informational messages,
        /// warnings, and error details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutomatedReasoningPolicyBuildStepMessage> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PriorElement. 
        /// <para>
        /// Reference to the previous element or step in the build process, helping to trace the
        /// sequence of operations.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinitionElement PriorElement
        {
            get { return this._priorElement; }
            set { this._priorElement = value; }
        }

        // Check to see if PriorElement property is set
        internal bool IsSetPriorElement()
        {
            return this._priorElement != null;
        }

    }
}