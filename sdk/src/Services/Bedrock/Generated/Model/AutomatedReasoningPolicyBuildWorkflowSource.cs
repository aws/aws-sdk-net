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
    /// Defines the source content for a policy build workflow, which can include documents,
    /// repair instructions, or other input materials.
    /// </summary>
    public partial class AutomatedReasoningPolicyBuildWorkflowSource
    {
        private AutomatedReasoningPolicyDefinition _policyDefinition;
        private AutomatedReasoningPolicyWorkflowTypeContent _workflowContent;

        /// <summary>
        /// Gets and sets the property PolicyDefinition. 
        /// <para>
        /// An existing policy definition that serves as the starting point for the build workflow,
        /// typically used in policy repair or update scenarios.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDefinition PolicyDefinition
        {
            get { return this._policyDefinition; }
            set { this._policyDefinition = value; }
        }

        // Check to see if PolicyDefinition property is set
        internal bool IsSetPolicyDefinition()
        {
            return this._policyDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowContent. 
        /// <para>
        /// The actual content to be processed in the build workflow, such as documents to analyze
        /// or repair instructions to apply.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyWorkflowTypeContent WorkflowContent
        {
            get { return this._workflowContent; }
            set { this._workflowContent = value; }
        }

        // Check to see if WorkflowContent property is set
        internal bool IsSetWorkflowContent()
        {
            return this._workflowContent != null;
        }

    }
}