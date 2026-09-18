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
    /// Container for the parameters to the CreatePromptRouter operation. Creates a prompt
    /// router that manages the routing of requests between multiple foundation models based
    /// on the routing criteria.
    /// </summary>
    public partial class CreatePromptRouterRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure idempotency of your
        /// requests. If not specified, the Amazon Web Services SDK automatically generates one
        /// for you.
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
        /// An optional description of the prompt router to help identify its purpose.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FallbackModel. 
        /// <para>
        /// The default model to use when the routing criteria is not met.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PromptRouterTargetModel FallbackModel { get; set; }

        /// <summary>
        /// Checks to see if the FallbackModel property is set.
        /// </summary>
        internal bool IsSetFallbackModel() => this.FallbackModel != null;

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// A list of foundation models that the prompt router can route requests to. At least
        /// one model must be specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PromptRouterTargetModel> Models { get; set; } = AWSConfigs.InitializeCollections ? new List<PromptRouterTargetModel>() : null;

        /// <summary>
        /// Checks to see if the Models property is set.
        /// </summary>
        internal bool IsSetModels() => this.Models != null && (this.Models.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PromptRouterName. 
        /// <para>
        /// The name of the prompt router. The name must be unique within your Amazon Web Services
        /// account in the current region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PromptRouterName { get; set; }

        /// <summary>
        /// Checks to see if the PromptRouterName property is set.
        /// </summary>
        internal bool IsSetPromptRouterName() => this.PromptRouterName != null;

        /// <summary>
        /// Gets and sets the property RoutingCriteria. 
        /// <para>
        /// The criteria, which is the response quality difference, used to determine how incoming
        /// requests are routed to different models.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RoutingCriteria RoutingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the RoutingCriteria property is set.
        /// </summary>
        internal bool IsSetRoutingCriteria() => this.RoutingCriteria != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply to this resource as tags. You can use tags to
        /// categorize and manage your Amazon Web Services resources.
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
