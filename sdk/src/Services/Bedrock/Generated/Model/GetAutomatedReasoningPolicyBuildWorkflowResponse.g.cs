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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetAutomatedReasoningPolicyBuildWorkflow operation.
    /// </summary>
    public partial class GetAutomatedReasoningPolicyBuildWorkflowResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The unique identifier of the build workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 36)]
        public string BuildWorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the BuildWorkflowId property is set.
        /// </summary>
        internal bool IsSetBuildWorkflowId() => this.BuildWorkflowId != null;

        /// <summary>
        /// Gets and sets the property BuildWorkflowType. 
        /// <para>
        /// The type of build workflow being executed (e.g., DOCUMENT_INGESTION, POLICY_REPAIR).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyBuildWorkflowType BuildWorkflowType { get; set; }

        /// <summary>
        /// Checks to see if the BuildWorkflowType property is set.
        /// </summary>
        internal bool IsSetBuildWorkflowType() => this.BuildWorkflowType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the build workflow was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentContentType. 
        /// <para>
        /// The content type of the source document (e.g., text/plain, application/pdf).
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyBuildDocumentContentType DocumentContentType { get; set; }

        /// <summary>
        /// Checks to see if the DocumentContentType property is set.
        /// </summary>
        internal bool IsSetDocumentContentType() => this.DocumentContentType != null;

        /// <summary>
        /// Gets and sets the property DocumentDescription. 
        /// <para>
        /// A detailed description of the document's content and how it should be used in the
        /// policy generation process.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 4000)]
        public string DocumentDescription { get; set; }

        /// <summary>
        /// Checks to see if the DocumentDescription property is set.
        /// </summary>
        internal bool IsSetDocumentDescription() => this.DocumentDescription != null;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the source document used in the build workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 256)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the build workflow (e.g., RUNNING, COMPLETED, FAILED, CANCELLED).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyBuildWorkflowStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the build workflow was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
