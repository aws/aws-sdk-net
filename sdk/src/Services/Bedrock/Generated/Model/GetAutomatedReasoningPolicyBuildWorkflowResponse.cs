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
    /// This is the response object from the GetAutomatedReasoningPolicyBuildWorkflow operation.
    /// </summary>
    public partial class GetAutomatedReasoningPolicyBuildWorkflowResponse : AmazonWebServiceResponse
    {
        private string _buildWorkflowId;
        private AutomatedReasoningPolicyBuildWorkflowType _buildWorkflowType;
        private DateTime? _createdAt;
        private AutomatedReasoningPolicyBuildDocumentContentType _documentContentType;
        private string _documentDescription;
        private string _documentName;
        private string _policyArn;
        private AutomatedReasoningPolicyBuildWorkflowStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The unique identifier of the build workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=36)]
        public string BuildWorkflowId
        {
            get { return this._buildWorkflowId; }
            set { this._buildWorkflowId = value; }
        }

        // Check to see if BuildWorkflowId property is set
        internal bool IsSetBuildWorkflowId()
        {
            return this._buildWorkflowId != null;
        }

        /// <summary>
        /// Gets and sets the property BuildWorkflowType. 
        /// <para>
        /// The type of build workflow being executed (e.g., DOCUMENT_INGESTION, POLICY_REPAIR).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningPolicyBuildWorkflowType BuildWorkflowType
        {
            get { return this._buildWorkflowType; }
            set { this._buildWorkflowType = value; }
        }

        // Check to see if BuildWorkflowType property is set
        internal bool IsSetBuildWorkflowType()
        {
            return this._buildWorkflowType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the build workflow was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentContentType. 
        /// <para>
        /// The content type of the source document (e.g., text/plain, application/pdf).
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyBuildDocumentContentType DocumentContentType
        {
            get { return this._documentContentType; }
            set { this._documentContentType = value; }
        }

        // Check to see if DocumentContentType property is set
        internal bool IsSetDocumentContentType()
        {
            return this._documentContentType != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentDescription. 
        /// <para>
        /// A detailed description of the document's content and how it should be used in the
        /// policy generation process.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2000)]
        public string DocumentDescription
        {
            get { return this._documentDescription; }
            set { this._documentDescription = value; }
        }

        // Check to see if DocumentDescription property is set
        internal bool IsSetDocumentDescription()
        {
            return this._documentDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the source document used in the build workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the build workflow (e.g., RUNNING, COMPLETED, FAILED, CANCELLED).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningPolicyBuildWorkflowStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the build workflow was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}