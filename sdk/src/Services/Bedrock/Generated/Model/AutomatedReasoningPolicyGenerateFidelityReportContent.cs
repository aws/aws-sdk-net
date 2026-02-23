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
    /// Configuration for generating a fidelity report, which can either analyze new documents
    /// or update an existing fidelity report with a new policy definition.
    /// </summary>
    public partial class AutomatedReasoningPolicyGenerateFidelityReportContent
    {
        private List<AutomatedReasoningPolicyBuildWorkflowDocument> _documents = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyBuildWorkflowDocument>() : null;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// Source documents to analyze for generating a new fidelity report. The documents will
        /// be processed to create atomic statements and grounding information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<AutomatedReasoningPolicyBuildWorkflowDocument> Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null && (this._documents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}