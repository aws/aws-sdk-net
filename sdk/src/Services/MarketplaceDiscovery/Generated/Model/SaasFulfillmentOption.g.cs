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
    /// Describes a Software as a Service (SaaS) fulfillment option.
    /// </summary>
    public partial class SaasFulfillmentOption
    {
        /// <summary>
        /// Gets and sets the property AvailableFromTime. 
        /// <para>
        /// The date and time when the SaaS product became available for fulfillment.
        /// </para>
        /// </summary>
        public DateTime? AvailableFromTime { get; set; }

        /// <summary>
        /// Checks to see if the AvailableFromTime property is set.
        /// </summary>
        internal bool IsSetAvailableFromTime() => this.AvailableFromTime.HasValue;

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
        /// Gets and sets the property FulfillmentUrl. 
        /// <para>
        /// The URL of the seller's software registration landing page.
        /// </para>
        /// </summary>
        public string FulfillmentUrl { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentUrl property is set.
        /// </summary>
        internal bool IsSetFulfillmentUrl() => this.FulfillmentUrl != null;

        /// <summary>
        /// Gets and sets the property LaunchUrl. 
        /// <para>
        /// The URL that a buyer uses to launch the seller's SaaS product. This URL is distinct
        /// from <c>fulfillmentUrl</c>, which is the seller's software registration landing page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LaunchUrl { get; set; }

        /// <summary>
        /// Checks to see if the LaunchUrl property is set.
        /// </summary>
        internal bool IsSetLaunchUrl() => this.LaunchUrl != null;

        /// <summary>
        /// Gets and sets the property QuickLaunch. 
        /// <para>
        /// Specifies whether the SaaS product supports quick-launch deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SaasQuickLaunchStatus QuickLaunch { get; set; }

        /// <summary>
        /// Checks to see if the QuickLaunch property is set.
        /// </summary>
        internal bool IsSetQuickLaunch() => this.QuickLaunch != null;

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Instructions on how to access and use this SaaS product.
        /// </para>
        /// </summary>
        public string UsageInstructions { get; set; }

        /// <summary>
        /// Checks to see if the UsageInstructions property is set.
        /// </summary>
        internal bool IsSetUsageInstructions() => this.UsageInstructions != null;
    }
}
