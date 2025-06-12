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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
    /// Container for the parameters to the CreateSignalMap operation.
    /// Initiates the creation of a new signal map. Will discover a new mediaResourceMap based
    /// on the provided discoveryEntryPointArn.
    /// </summary>
    public partial class CreateSignalMapRequest : AmazonMediaLiveRequest
    {
        private List<string> _cloudWatchAlarmTemplateGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _discoveryEntryPointArn;
        private List<string> _eventBridgeRuleTemplateGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _requestId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CloudWatchAlarmTemplateGroupIdentifiers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CloudWatchAlarmTemplateGroupIdentifiers
        {
            get { return this._cloudWatchAlarmTemplateGroupIdentifiers; }
            set { this._cloudWatchAlarmTemplateGroupIdentifiers = value; }
        }

        // Check to see if CloudWatchAlarmTemplateGroupIdentifiers property is set
        internal bool IsSetCloudWatchAlarmTemplateGroupIdentifiers()
        {
            return this._cloudWatchAlarmTemplateGroupIdentifiers != null && (this._cloudWatchAlarmTemplateGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. A resource's optional description.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DiscoveryEntryPointArn. A top-level supported AWS resource
        /// ARN to discovery a signal map from.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DiscoveryEntryPointArn
        {
            get { return this._discoveryEntryPointArn; }
            set { this._discoveryEntryPointArn = value; }
        }

        // Check to see if DiscoveryEntryPointArn property is set
        internal bool IsSetDiscoveryEntryPointArn()
        {
            return this._discoveryEntryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventBridgeRuleTemplateGroupIdentifiers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventBridgeRuleTemplateGroupIdentifiers
        {
            get { return this._eventBridgeRuleTemplateGroupIdentifiers; }
            set { this._eventBridgeRuleTemplateGroupIdentifiers = value; }
        }

        // Check to see if EventBridgeRuleTemplateGroupIdentifiers property is set
        internal bool IsSetEventBridgeRuleTemplateGroupIdentifiers()
        {
            return this._eventBridgeRuleTemplateGroupIdentifiers != null && (this._eventBridgeRuleTemplateGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. A resource's name. Names must be unique within the
        /// scope of a resource type in a specific region.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. An ID that you assign to a create request. This
        /// ID ensures idempotency when creating resources.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}