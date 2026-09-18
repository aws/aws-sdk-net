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
    /// Container for the parameters to the CreateCustomModelDeployment operation. Deploys
    /// a custom model for on-demand inference in Amazon Bedrock. After you deploy your custom
    /// model, you use the deployment's Amazon Resource Name (ARN) as the <c>modelId</c> parameter
    /// when you submit prompts and generate responses with model inference. <para> For more
    /// information about setting up on-demand inference for custom models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-use.html">Set
    /// up inference for a custom model</a>. </para> <para> The following actions are related
    /// to the <c>CreateCustomModelDeployment</c> operation: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class CreateCustomModelDeploymentRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the custom model deployment to help you identify its purpose.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom model to deploy for on-demand inference.
        /// The custom model must be in the <c>Active</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelDeploymentName. 
        /// <para>
        /// The name for the custom model deployment. The name must be unique within your Amazon
        /// Web Services account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelDeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the ModelDeploymentName property is set.
        /// </summary>
        internal bool IsSetModelDeploymentName() => this.ModelDeploymentName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the custom model deployment. You can use tags to organize and track
        /// your Amazon Web Services resources for cost allocation and management purposes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
