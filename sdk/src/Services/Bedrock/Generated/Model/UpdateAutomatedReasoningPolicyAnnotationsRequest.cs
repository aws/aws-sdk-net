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
    /// Container for the parameters to the UpdateAutomatedReasoningPolicyAnnotations operation.
    /// Updates the annotations for an Automated Reasoning policy build workflow. This allows
    /// you to modify extracted rules, variables, and types before finalizing the policy.
    /// </summary>
    public partial class UpdateAutomatedReasoningPolicyAnnotationsRequest : AmazonBedrockRequest
    {
        private List<AutomatedReasoningPolicyAnnotation> _annotations = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyAnnotation>() : null;
        private string _buildWorkflowId;
        private string _lastUpdatedAnnotationSetHash;
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// The updated annotations containing modified rules, variables, and types for the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<AutomatedReasoningPolicyAnnotation> Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null && (this._annotations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The unique identifier of the build workflow whose annotations you want to update.
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
        /// Gets and sets the property LastUpdatedAnnotationSetHash. 
        /// <para>
        /// The hash value of the annotation set that you're updating. This is used for optimistic
        /// concurrency control to prevent conflicting updates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=128, Max=128)]
        public string LastUpdatedAnnotationSetHash
        {
            get { return this._lastUpdatedAnnotationSetHash; }
            set { this._lastUpdatedAnnotationSetHash = value; }
        }

        // Check to see if LastUpdatedAnnotationSetHash property is set
        internal bool IsSetLastUpdatedAnnotationSetHash()
        {
            return this._lastUpdatedAnnotationSetHash != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy whose annotations
        /// you want to update.
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

    }
}