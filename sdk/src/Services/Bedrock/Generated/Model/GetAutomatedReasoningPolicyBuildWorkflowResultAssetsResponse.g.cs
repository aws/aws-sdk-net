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
    /// This is the response object from the GetAutomatedReasoningPolicyBuildWorkflowResultAssets
    /// operation.
    /// </summary>
    public partial class GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BuildWorkflowAssets. 
        /// <para>
        /// The requested build workflow asset. This is a union type that returns only one of
        /// the available asset types (logs, reports, or generated artifacts) based on the specific
        /// asset type requested in the API call.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyBuildResultAssets BuildWorkflowAssets { get; set; }

        /// <summary>
        /// Checks to see if the BuildWorkflowAssets property is set.
        /// </summary>
        internal bool IsSetBuildWorkflowAssets() => this.BuildWorkflowAssets != null;

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
    }
}
