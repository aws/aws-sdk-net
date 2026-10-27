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
    /// Container for the parameters to the CreateInput operation. Create an input
    /// </summary>
    public partial class CreateInputRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property Destinations. Destination settings for PUSH type inputs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDestinationRequest> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<InputDestinationRequest>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputDevices. Settings for the devices.
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
        /// Gets and sets the property InputSecurityGroups. A list of security groups referenced
        /// by IDs to attach to the input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InputSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InputSecurityGroups property is set.
        /// </summary>
        internal bool IsSetInputSecurityGroups() => this.InputSecurityGroups != null && (this.InputSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MediaConnectFlows. A list of the MediaConnect Flows that
        /// you want to use in this input. You can specify as few as one Flow and presently, as
        /// many as two. The only requirement is when you have more than one is that each Flow
        /// is in a separate Availability Zone as this ensures your EML input is redundant to
        /// AZ issues.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaConnectFlowRequest> MediaConnectFlows { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaConnectFlowRequest>() : null;

        /// <summary>
        /// Checks to see if the MediaConnectFlows property is set.
        /// </summary>
        internal bool IsSetMediaConnectFlows() => this.MediaConnectFlows != null && (this.MediaConnectFlows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MulticastSettings. Multicast Input settings.
        /// </summary>
        public MulticastSettingsCreateRequest MulticastSettings { get; set; }

        /// <summary>
        /// Checks to see if the MulticastSettings property is set.
        /// </summary>
        internal bool IsSetMulticastSettings() => this.MulticastSettings != null;

        /// <summary>
        /// Gets and sets the property Name. Name of the input.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestId. Unique identifier of the request to ensure the
        /// request is handled exactly once in case of retries.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

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
        /// Gets and sets the property RouterSettings.
        /// </summary>
        public RouterSettings RouterSettings { get; set; }

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
        /// Gets and sets the property Smpte2110ReceiverGroupSettings. Include this parameter
        /// if the input is a SMPTE 2110 input, to identify the stream sources for this input.
        /// </summary>
        public Smpte2110ReceiverGroupSettings Smpte2110ReceiverGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the Smpte2110ReceiverGroupSettings property is set.
        /// </summary>
        internal bool IsSetSmpte2110ReceiverGroupSettings() => this.Smpte2110ReceiverGroupSettings != null;

        /// <summary>
        /// Gets and sets the property Sources. The source URLs for a PULL-type input. Every PULL
        /// type input needs exactly two source URLs for redundancy. Only specify sources for
        /// PULL type Inputs. Leave Destinations empty.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputSourceRequest> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<InputSourceRequest>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SrtSettings. The settings associated with an SRT input.
        /// </summary>
        public SrtSettingsRequest SrtSettings { get; set; }

        /// <summary>
        /// Checks to see if the SrtSettings property is set.
        /// </summary>
        internal bool IsSetSrtSettings() => this.SrtSettings != null;

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

        /// <summary>
        /// Gets and sets the property Vpc.
        /// </summary>
        public InputVpcRequest Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Vpc property is set.
        /// </summary>
        internal bool IsSetVpc() => this.Vpc != null;
    }
}
