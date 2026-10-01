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
    /// Container for the parameters to the CancelAutomatedReasoningPolicyBuildWorkflow operation.
    /// Cancels a running Automated Reasoning policy build workflow. This stops the policy
    /// generation process and prevents further processing of the source documents.
    /// </summary>
    public partial class CancelAutomatedReasoningPolicyBuildWorkflowRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The unique identifier of the build workflow to cancel. You can get this ID from the
        /// StartAutomatedReasoningPolicyBuildWorkflow response or by listing build workflows.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 36)]
        public string BuildWorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the BuildWorkflowId property is set.
        /// </summary>
        internal bool IsSetBuildWorkflowId() => this.BuildWorkflowId != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy whose build workflow
        /// you want to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;
    }
}
