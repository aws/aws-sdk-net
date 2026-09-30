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

namespace Amazon.ConnectCampaignService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCampaign operation. Creates a campaign for
    /// the specified Amazon Connect account. This API is idempotent.
    /// </summary>
    public partial class CreateCampaignRequest : AmazonConnectCampaignServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectInstanceId.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ConnectInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectInstanceId property is set.
        /// </summary>
        internal bool IsSetConnectInstanceId() => this.ConnectInstanceId != null;

        /// <summary>
        /// Gets and sets the property DialerConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public DialerConfig DialerConfig { get; set; }

        /// <summary>
        /// Checks to see if the DialerConfig property is set.
        /// </summary>
        internal bool IsSetDialerConfig() => this.DialerConfig != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutboundCallConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public OutboundCallConfig OutboundCallConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCallConfig property is set.
        /// </summary>
        internal bool IsSetOutboundCallConfig() => this.OutboundCallConfig != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
