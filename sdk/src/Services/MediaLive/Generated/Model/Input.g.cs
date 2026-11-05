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
    /// Placeholder documentation for Input
    /// </summary>
    public partial class Input
    {
        /// <summary>
        /// Gets and sets the property Arn. The Unique ARN of the input (generated, immutable).
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AttachedChannels. A list of channel IDs that that input
        /// is attached to (currently an input can only be attached to one channel).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttachedChannels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttachedChannels property is set.
        /// </summary>
        internal bool IsSetAttachedChannels() => this.AttachedChannels != null && (this.AttachedChannels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Destinations. A list of the destinations of the input (PUSH-type).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDestination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<InputDestination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. The generated ID of the input (unique for user account,
        /// immutable).
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InputClass. STANDARD - MediaLive expects two sources to
        /// be connected to this input. If the channel is also STANDARD, both sources will be
        /// ingested. If the channel is SINGLE_PIPELINE, only the first source will be ingested;
        /// the second source will always be ignored, even if the first source fails. SINGLE_PIPELINE
        /// - You can connect only one source to this input. If the ChannelClass is also SINGLE_PIPELINE,
        /// this value is valid. If the ChannelClass is STANDARD, this value is not valid because
        /// the channel requires two sources in the input.
        /// </summary>
        public InputClass InputClass { get; set; }

        /// <summary>
        /// Checks to see if the InputClass property is set.
        /// </summary>
        internal bool IsSetInputClass() => this.InputClass != null;

        /// <summary>
        /// Gets and sets the property InputDevices. Settings for the input devices.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDeviceSettings> InputDevices { get; set; } = AWSConfigs.InitializeCollections ? new List<InputDeviceSettings>() : null;

        /// <summary>
        /// Checks to see if the InputDevices property is set.
        /// </summary>
        internal bool IsSetInputDevices() => this.InputDevices != null && (this.InputDevices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputNetworkLocation. The location of this input. AWS,
        /// for an input existing in the AWS Cloud, On-Prem for an input in a customer network.
        /// </summary>
        public InputNetworkLocation InputNetworkLocation { get; set; }

        /// <summary>
        /// Checks to see if the InputNetworkLocation property is set.
        /// </summary>
        internal bool IsSetInputNetworkLocation() => this.InputNetworkLocation != null;

        /// <summary>
        /// Gets and sets the property InputPartnerIds. A list of IDs for all Inputs which are
        /// partners of this one.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InputPartnerIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InputPartnerIds property is set.
        /// </summary>
        internal bool IsSetInputPartnerIds() => this.InputPartnerIds != null && (this.InputPartnerIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputSourceType. Certain pull input sources can be dynamic,
        /// meaning that they can have their URL's dynamically changes during input switch actions.
        /// Presently, this functionality only works with MP4_FILE and TS_FILE inputs.
        /// </summary>
        public InputSourceType InputSourceType { get; set; }

        /// <summary>
        /// Checks to see if the InputSourceType property is set.
        /// </summary>
        internal bool IsSetInputSourceType() => this.InputSourceType != null;

        /// <summary>
        /// Gets and sets the property MediaConnectFlows. A list of MediaConnect Flows for this
        /// input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaConnectFlow> MediaConnectFlows { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaConnectFlow>() : null;

        /// <summary>
        /// Checks to see if the MediaConnectFlows property is set.
        /// </summary>
        internal bool IsSetMediaConnectFlows() => this.MediaConnectFlows != null && (this.MediaConnectFlows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MulticastSettings. Multicast Input settings.
        /// </summary>
        public MulticastSettings MulticastSettings { get; set; }

        /// <summary>
        /// Checks to see if the MulticastSettings property is set.
        /// </summary>
        internal bool IsSetMulticastSettings() => this.MulticastSettings != null;

        /// <summary>
        /// Gets and sets the property Name. The user-assigned name (This is a mutable value).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of the role this
        /// input assumes during and after creation.
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RouterSettings. Information about any MediaConnect router
        /// association with this input.
        /// </summary>
        public RouterInputSettings RouterSettings { get; set; }

        /// <summary>
        /// Checks to see if the RouterSettings property is set.
        /// </summary>
        internal bool IsSetRouterSettings() => this.RouterSettings != null;

        /// <summary>
        /// Gets and sets the property SdiSources.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SdiSources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SdiSources property is set.
        /// </summary>
        internal bool IsSetSdiSources() => this.SdiSources != null && (this.SdiSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroups. A list of IDs for all the Input Security
        /// Groups attached to the input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Smpte2110ReceiverGroupSettings. Include this parameter
        /// if the input is a SMPTE 2110 input, to identify the stream sources for this input.
        /// </summary>
        public Smpte2110ReceiverGroupSettings Smpte2110ReceiverGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the Smpte2110ReceiverGroupSettings property is set.
        /// </summary>
        internal bool IsSetSmpte2110ReceiverGroupSettings() => this.Smpte2110ReceiverGroupSettings != null;

        /// <summary>
        /// Gets and sets the property Sources. A list of the sources of the input (PULL-type).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputSource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<InputSource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SrtSettings. The settings associated with an SRT input.
        /// </summary>
        public SrtSettings SrtSettings { get; set; }

        /// <summary>
        /// Checks to see if the SrtSettings property is set.
        /// </summary>
        internal bool IsSetSrtSettings() => this.SrtSettings != null;

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public InputState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
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

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public InputType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
