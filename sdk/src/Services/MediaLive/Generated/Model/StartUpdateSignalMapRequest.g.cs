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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the StartUpdateSignalMap operation. Initiates an update
    /// for the specified signal map. Will discover a new signal map if a changed discoveryEntryPointArn
    /// is provided.
    /// </summary>
    public partial class StartUpdateSignalMapRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property CloudWatchAlarmTemplateGroupIdentifiers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CloudWatchAlarmTemplateGroupIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CloudWatchAlarmTemplateGroupIdentifiers property is set.
        /// </summary>
        internal bool IsSetCloudWatchAlarmTemplateGroupIdentifiers() => this.CloudWatchAlarmTemplateGroupIdentifiers != null && (this.CloudWatchAlarmTemplateGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. A resource's optional description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiscoveryEntryPointArn. A top-level supported AWS resource
        /// ARN to discovery a signal map from.
        /// </summary>
        public string DiscoveryEntryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryEntryPointArn property is set.
        /// </summary>
        internal bool IsSetDiscoveryEntryPointArn() => this.DiscoveryEntryPointArn != null;

        /// <summary>
        /// Gets and sets the property EventBridgeRuleTemplateGroupIdentifiers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventBridgeRuleTemplateGroupIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EventBridgeRuleTemplateGroupIdentifiers property is set.
        /// </summary>
        internal bool IsSetEventBridgeRuleTemplateGroupIdentifiers() => this.EventBridgeRuleTemplateGroupIdentifiers != null && (this.EventBridgeRuleTemplateGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ForceRediscovery. If true, will force a rediscovery of
        /// a signal map if an unchanged discoveryEntryPointArn is provided.
        /// </summary>
        public bool? ForceRediscovery { get; set; }

        /// <summary>
        /// Checks to see if the ForceRediscovery property is set.
        /// </summary>
        internal bool IsSetForceRediscovery() => this.ForceRediscovery.HasValue;

        /// <summary>
        /// Gets and sets the property Identifier. A signal map's identifier. Can be either be
        /// its id or current name.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Name. A resource's name. Names must be unique within the
        /// scope of a resource type in a specific region.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
