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

namespace Amazon.MarketplaceDeployment.Model
{
    /// <summary>
    /// Container for the parameters to the StartDeploymentConfigurationJob operation. Starts
    /// a job that publishes a deployment configuration for a product and delivery option.
    /// The job runs asynchronously. Use <c>GetDeploymentConfigurationJob</c> to track its
    /// status. When the job reaches the <c>SUCCEEDED</c> status, its configuration becomes
    /// the active deployment configuration for the product and delivery option. <para> The
    /// populated member of <c>configuration</c> must match the <c>deliveryOptionType</c>
    /// in the request path. </para>
    /// </summary>
    public partial class StartDeploymentConfigurationJobRequest : AmazonMarketplaceDeploymentRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <c>AWSMarketplace</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you retry a request with the same token and the
        /// same input, the service returns the original job instead of starting a new one. If
        /// you reuse a token with different input, the request fails with a <c>ConflictException</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is not required if you're calling using an AWS SDK. Otherwise, a <c>clientToken</c>
        /// must be provided with the request.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 32, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The deployment configuration to publish.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentConfigurationDetail Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DeliveryOptionType. 
        /// <para>
        /// The delivery option type of the deployment configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeliveryOptionType DeliveryOptionType { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryOptionType property is set.
        /// </summary>
        internal bool IsSetDeliveryOptionType() => this.DeliveryOptionType != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The ID of the AWS Marketplace product, for example <c>prod-1234567890abc</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs, where each pair represents a tag to apply to the deployment
        /// configuration. Only the request that creates the deployment configuration can apply
        /// tags. If the deployment configuration already exists, a request that includes one
        /// or more tags fails with a <c>ValidationException</c>. To change tags on an existing
        /// deployment configuration, use <c>TagResource</c> and <c>UntagResource</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
