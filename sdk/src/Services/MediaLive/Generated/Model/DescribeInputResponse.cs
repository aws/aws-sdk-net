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
    /// Placeholder documentation for DescribeInputResponse
    /// </summary>
    public partial class DescribeInputResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<string> _attachedChannels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<InputDestination> _destinations = AWSConfigs.InitializeCollections ? new List<InputDestination>() : null;
        private string _id;
        private InputClass _inputClass;
        private List<InputDeviceSettings> _inputDevices = AWSConfigs.InitializeCollections ? new List<InputDeviceSettings>() : null;
        private InputNetworkLocation _inputNetworkLocation;
        private List<string> _inputPartnerIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private InputSourceType _inputSourceType;
        private List<MediaConnectFlow> _mediaConnectFlows = AWSConfigs.InitializeCollections ? new List<MediaConnectFlow>() : null;
        private MulticastSettings _multicastSettings;
        private string _name;
        private string _roleArn;
        private List<string> _sdiSources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Smpte2110ReceiverGroupSettings _smpte2110ReceiverGroupSettings;
        private List<InputSource> _sources = AWSConfigs.InitializeCollections ? new List<InputSource>() : null;
        private SrtSettings _srtSettings;
        private InputState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private InputType _type;

        /// <summary>
        /// Gets and sets the property Arn. The Unique ARN of the input (generated, immutable).
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AttachedChannels. A list of channel IDs that that input
        /// is attached to (currently an input can only be attached to one channel).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttachedChannels
        {
            get { return this._attachedChannels; }
            set { this._attachedChannels = value; }
        }

        // Check to see if AttachedChannels property is set
        internal bool IsSetAttachedChannels()
        {
            return this._attachedChannels != null && (this._attachedChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Destinations. A list of the destinations of the input (PUSH-type).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. The generated ID of the input (unique for user account,
        /// immutable).
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InputClass. STANDARD - MediaLive expects two sources to
        /// be connected to this input. If the channel is also STANDARD, both sources will be
        /// ingested. If the channel is SINGLE_PIPELINE, only the first source will be ingested;
        /// the second source will always be ignored, even if the first source fails.SINGLE_PIPELINE
        /// - You can connect only one source to this input. If the ChannelClass is also SINGLE_PIPELINE,
        /// this value is valid. If the ChannelClass is STANDARD, this value is not valid because
        /// the channel requires two sources in the input.
        /// </summary>
        public InputClass InputClass
        {
            get { return this._inputClass; }
            set { this._inputClass = value; }
        }

        // Check to see if InputClass property is set
        internal bool IsSetInputClass()
        {
            return this._inputClass != null;
        }

        /// <summary>
        /// Gets and sets the property InputDevices. Settings for the input devices.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDeviceSettings> InputDevices
        {
            get { return this._inputDevices; }
            set { this._inputDevices = value; }
        }

        // Check to see if InputDevices property is set
        internal bool IsSetInputDevices()
        {
            return this._inputDevices != null && (this._inputDevices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputNetworkLocation. The location of this input. AWS,
        /// for an input existing in the AWS Cloud, On-Prem foran input in a customer network.
        /// </summary>
        public InputNetworkLocation InputNetworkLocation
        {
            get { return this._inputNetworkLocation; }
            set { this._inputNetworkLocation = value; }
        }

        // Check to see if InputNetworkLocation property is set
        internal bool IsSetInputNetworkLocation()
        {
            return this._inputNetworkLocation != null;
        }

        /// <summary>
        /// Gets and sets the property InputPartnerIds. A list of IDs for all Inputs which are
        /// partners of this one.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InputPartnerIds
        {
            get { return this._inputPartnerIds; }
            set { this._inputPartnerIds = value; }
        }

        // Check to see if InputPartnerIds property is set
        internal bool IsSetInputPartnerIds()
        {
            return this._inputPartnerIds != null && (this._inputPartnerIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputSourceType. Certain pull input sources can be dynamic,
        /// meaning that they can have their URL's dynamically changesduring input switch actions.
        /// Presently, this functionality only works with MP4_FILE and TS_FILE inputs.
        /// </summary>
        public InputSourceType InputSourceType
        {
            get { return this._inputSourceType; }
            set { this._inputSourceType = value; }
        }

        // Check to see if InputSourceType property is set
        internal bool IsSetInputSourceType()
        {
            return this._inputSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property MediaConnectFlows. A list of MediaConnect Flows for this
        /// input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaConnectFlow> MediaConnectFlows
        {
            get { return this._mediaConnectFlows; }
            set { this._mediaConnectFlows = value; }
        }

        // Check to see if MediaConnectFlows property is set
        internal bool IsSetMediaConnectFlows()
        {
            return this._mediaConnectFlows != null && (this._mediaConnectFlows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MulticastSettings. Multicast Input settings.
        /// </summary>
        public MulticastSettings MulticastSettings
        {
            get { return this._multicastSettings; }
            set { this._multicastSettings = value; }
        }

        // Check to see if MulticastSettings property is set
        internal bool IsSetMulticastSettings()
        {
            return this._multicastSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The user-assigned name (This is a mutable value).
        /// </summary>
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
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of the role this
        /// input assumes during and after creation.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SdiSources.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SdiSources
        {
            get { return this._sdiSources; }
            set { this._sdiSources = value; }
        }

        // Check to see if SdiSources property is set
        internal bool IsSetSdiSources()
        {
            return this._sdiSources != null && (this._sdiSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. A list of IDs for all the Input Security
        /// Groups attached to the input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Smpte2110ReceiverGroupSettings. Include this parameter
        /// if the input is a SMPTE 2110 input, to identify the stream sources for this input.
        /// </summary>
        public Smpte2110ReceiverGroupSettings Smpte2110ReceiverGroupSettings
        {
            get { return this._smpte2110ReceiverGroupSettings; }
            set { this._smpte2110ReceiverGroupSettings = value; }
        }

        // Check to see if Smpte2110ReceiverGroupSettings property is set
        internal bool IsSetSmpte2110ReceiverGroupSettings()
        {
            return this._smpte2110ReceiverGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. A list of the sources of the input (PULL-type).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SrtSettings. The settings associated with an SRT input.
        /// </summary>
        public SrtSettings SrtSettings
        {
            get { return this._srtSettings; }
            set { this._srtSettings = value; }
        }

        // Check to see if SrtSettings property is set
        internal bool IsSetSrtSettings()
        {
            return this._srtSettings != null;
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public InputState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
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

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public InputType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}