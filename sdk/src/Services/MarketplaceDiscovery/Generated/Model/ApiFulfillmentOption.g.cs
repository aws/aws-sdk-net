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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Describes an API-based fulfillment option, where the product is accessed through an
    /// API integration.
    /// </summary>
    public partial class ApiFulfillmentOption
    {
        /// <summary>
        /// Gets and sets the property AwsSupportedServices. 
        /// <para>
        /// The AWS services supported by this API integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AwsSupportedService> AwsSupportedServices { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsSupportedService>() : null;

        /// <summary>
        /// Checks to see if the AwsSupportedServices property is set.
        /// </summary>
        internal bool IsSetAwsSupportedServices() => this.AwsSupportedServices != null && (this.AwsSupportedServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FulfillmentOptionDisplayName. 
        /// <para>
        /// A human-readable name for the fulfillment option type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FulfillmentOptionDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentOptionDisplayName property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionDisplayName() => this.FulfillmentOptionDisplayName != null;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionId. 
        /// <para>
        /// The unique identifier of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FulfillmentOptionId { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentOptionId property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionId() => this.FulfillmentOptionId != null;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionType. 
        /// <para>
        /// The category of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FulfillmentOptionType FulfillmentOptionType { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentOptionType property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionType() => this.FulfillmentOptionType != null;

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Instructions on how to integrate with and use this API.
        /// </para>
        /// </summary>
        public string UsageInstructions { get; set; }

        /// <summary>
        /// Checks to see if the UsageInstructions property is set.
        /// </summary>
        internal bool IsSetUsageInstructions() => this.UsageInstructions != null;
    }
}
