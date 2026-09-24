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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
        private DateTime? _availableFromTime;
        private string _fulfillmentOptionDisplayName;
        private string _fulfillmentOptionId;
        private FulfillmentOptionType _fulfillmentOptionType;
        private string _fulfillmentUrl;
        private string _launchUrl;
        private SaasQuickLaunchStatus _quickLaunch;
        private string _usageInstructions;

        /// <summary>
        /// Gets and sets the property AvailableFromTime. 
        /// <para>
        /// The date and time when the SaaS product became available for fulfillment.
        /// </para>
        /// </summary>
        public DateTime? AvailableFromTime
        {
            get { return this._availableFromTime; }
            set { this._availableFromTime = value; }
        }

        // Check to see if AvailableFromTime property is set
        internal bool IsSetAvailableFromTime()
        {
            return this._availableFromTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionDisplayName. 
        /// <para>
        /// A human-readable name for the fulfillment option type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FulfillmentOptionDisplayName
        {
            get { return this._fulfillmentOptionDisplayName; }
            set { this._fulfillmentOptionDisplayName = value; }
        }

        // Check to see if FulfillmentOptionDisplayName property is set
        internal bool IsSetFulfillmentOptionDisplayName()
        {
            return this._fulfillmentOptionDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionId. 
        /// <para>
        /// The unique identifier of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FulfillmentOptionId
        {
            get { return this._fulfillmentOptionId; }
            set { this._fulfillmentOptionId = value; }
        }

        // Check to see if FulfillmentOptionId property is set
        internal bool IsSetFulfillmentOptionId()
        {
            return this._fulfillmentOptionId != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionType. 
        /// <para>
        /// The category of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FulfillmentOptionType FulfillmentOptionType
        {
            get { return this._fulfillmentOptionType; }
            set { this._fulfillmentOptionType = value; }
        }

        // Check to see if FulfillmentOptionType property is set
        internal bool IsSetFulfillmentOptionType()
        {
            return this._fulfillmentOptionType != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentUrl. 
        /// <para>
        /// The URL of the seller's software registration landing page.
        /// </para>
        /// </summary>
        public string FulfillmentUrl
        {
            get { return this._fulfillmentUrl; }
            set { this._fulfillmentUrl = value; }
        }

        // Check to see if FulfillmentUrl property is set
        internal bool IsSetFulfillmentUrl()
        {
            return this._fulfillmentUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchUrl. 
        /// <para>
        /// The URL that a buyer uses to launch the seller's SaaS product. This URL is distinct
        /// from <c>fulfillmentUrl</c>, which is the seller's software registration landing page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LaunchUrl
        {
            get { return this._launchUrl; }
            set { this._launchUrl = value; }
        }

        // Check to see if LaunchUrl property is set
        internal bool IsSetLaunchUrl()
        {
            return this._launchUrl != null;
        }

        /// <summary>
        /// Gets and sets the property QuickLaunch. 
        /// <para>
        /// Specifies whether the SaaS product supports quick-launch deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SaasQuickLaunchStatus QuickLaunch
        {
            get { return this._quickLaunch; }
            set { this._quickLaunch = value; }
        }

        // Check to see if QuickLaunch property is set
        internal bool IsSetQuickLaunch()
        {
            return this._quickLaunch != null;
        }

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Instructions on how to access and use this SaaS product.
        /// </para>
        /// </summary>
        public string UsageInstructions
        {
            get { return this._usageInstructions; }
            set { this._usageInstructions = value; }
        }

        // Check to see if UsageInstructions property is set
        internal bool IsSetUsageInstructions()
        {
            return this._usageInstructions != null;
        }

    }
}