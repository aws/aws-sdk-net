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
    /// Container for the parameters to the GetDeploymentConfiguration operation. Returns
    /// the active deployment configuration for a product and delivery option. The active
    /// deployment configuration is the configuration from the most recent successful deployment
    /// configuration job. The seller that owns the product and buyers entitled to the product
    /// can call this operation. <para> If the product and delivery option have no active
    /// deployment configuration, the operation returns a <c>ResourceNotFoundException</c>.
    /// </para>
    /// </summary>
    public partial class GetDeploymentConfigurationRequest : AmazonMarketplaceDeploymentRequest
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
    }
}
