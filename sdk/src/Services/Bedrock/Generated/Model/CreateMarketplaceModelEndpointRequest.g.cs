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
    /// Container for the parameters to the CreateMarketplaceModelEndpoint operation. Creates
    /// an endpoint for a model from Amazon Bedrock Marketplace. The endpoint is hosted by
    /// Amazon SageMaker.
    /// </summary>
    public partial class CreateMarketplaceModelEndpointRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptEula. 
        /// <para>
        /// Indicates whether you accept the end-user license agreement (EULA) for the model.
        /// Set to <c>true</c> to accept the EULA.
        /// </para>
        /// </summary>
        public bool? AcceptEula { get; set; }

        /// <summary>
        /// Checks to see if the AcceptEula property is set.
        /// </summary>
        internal bool IsSetAcceptEula() => this.AcceptEula.HasValue;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This token is listed as not required because Amazon Web Services SDKs
        /// automatically generate it for you and set this parameter. If you're not using the
        /// Amazon Web Services SDK or the CLI, you must provide this token or the action will
        /// fail.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property EndpointConfig. 
        /// <para>
        /// The configuration for the endpoint, including the number and type of instances to
        /// use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointConfig EndpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfig property is set.
        /// </summary>
        internal bool IsSetEndpointConfig() => this.EndpointConfig != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint. This name must be unique within your Amazon Web Services
        /// account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property ModelSourceIdentifier. 
        /// <para>
        /// The ARN of the model from Amazon Bedrock Marketplace that you want to deploy to the
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ModelSourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ModelSourceIdentifier property is set.
        /// </summary>
        internal bool IsSetModelSourceIdentifier() => this.ModelSourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply to the underlying Amazon SageMaker endpoint.
        /// You can use these tags to organize and identify your Amazon Web Services resources.
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
