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
    /// Container for the parameters to the DeleteAutomatedReasoningPolicyBuildWorkflow operation.
    /// Deletes an Automated Reasoning policy build workflow and its associated artifacts.
    /// This permanently removes the workflow history and any generated assets.
    /// </summary>
    public partial class DeleteAutomatedReasoningPolicyBuildWorkflowRequest : AmazonBedrockRequest
    {
        private string _buildWorkflowId;
        private DateTime? _lastUpdatedAt;
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The unique identifier of the build workflow to delete.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the build workflow was last updated. This is used for optimistic
        /// concurrency control to prevent accidental deletion of workflows that have been modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy whose build workflow
        /// you want to delete.
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