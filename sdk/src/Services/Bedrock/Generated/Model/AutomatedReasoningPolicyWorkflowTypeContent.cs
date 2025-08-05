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
    /// Defines the content and configuration for different types of policy build workflows.
    /// </summary>
    public partial class AutomatedReasoningPolicyWorkflowTypeContent
    {
        private List<AutomatedReasoningPolicyBuildWorkflowDocument> _documents = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyBuildWorkflowDocument>() : null;
        private AutomatedReasoningPolicyBuildWorkflowRepairContent _policyRepairAssets;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The list of documents to be processed in a document ingestion workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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

        /// <summary>
        /// Gets and sets the property PolicyRepairAssets. 
        /// <para>
        /// The assets and instructions needed for a policy repair workflow, including repair
        /// annotations and guidance.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyBuildWorkflowRepairContent PolicyRepairAssets
        {
            get { return this._policyRepairAssets; }
            set { this._policyRepairAssets = value; }
        }

        // Check to see if PolicyRepairAssets property is set
        internal bool IsSetPolicyRepairAssets()
        {
            return this._policyRepairAssets != null;
        }

    }
}