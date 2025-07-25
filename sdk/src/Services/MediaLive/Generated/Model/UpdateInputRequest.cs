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
    /// Container for the parameters to the UpdateInput operation.
    /// Updates an input.
    /// </summary>
    public partial class UpdateInputRequest : AmazonMediaLiveRequest
    {
        private List<InputDestinationRequest> _destinations = AWSConfigs.InitializeCollections ? new List<InputDestinationRequest>() : null;
        private List<InputDeviceRequest> _inputDevices = AWSConfigs.InitializeCollections ? new List<InputDeviceRequest>() : null;
        private string _inputId;
        private List<string> _inputSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<MediaConnectFlowRequest> _mediaConnectFlows = AWSConfigs.InitializeCollections ? new List<MediaConnectFlowRequest>() : null;
        private MulticastSettingsUpdateRequest _multicastSettings;
        private string _name;
        private string _roleArn;
        private List<string> _sdiSources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Smpte2110ReceiverGroupSettings _smpte2110ReceiverGroupSettings;
        private List<InputSourceRequest> _sources = AWSConfigs.InitializeCollections ? new List<InputSourceRequest>() : null;
        private SrtSettingsRequest _srtSettings;

        /// <summary>
        /// Gets and sets the property Destinations. Destination settings for PUSH type inputs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDestinationRequest> Destinations
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
        /// Gets and sets the property InputDevices. Settings for the devices.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDeviceRequest> InputDevices
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
        /// Gets and sets the property InputId. Unique ID of the input.
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputId
        {
            get { return this._inputId; }
            set { this._inputId = value; }
        }

        // Check to see if InputId property is set
        internal bool IsSetInputId()
        {
            return this._inputId != null;
        }

        /// <summary>
        /// Gets and sets the property InputSecurityGroups. A list of security groups referenced
        /// by IDs to attach to the input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InputSecurityGroups
        {
            get { return this._inputSecurityGroups; }
            set { this._inputSecurityGroups = value; }
        }

        // Check to see if InputSecurityGroups property is set
        internal bool IsSetInputSecurityGroups()
        {
            return this._inputSecurityGroups != null && (this._inputSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MediaConnectFlows. A list of the MediaConnect Flow ARNs
        /// that you want to use as the source of the input. You can specify as few as oneFlow
        /// and presently, as many as two. The only requirement is when you have more than one
        /// is that each Flow is in aseparate Availability Zone as this ensures your EML input
        /// is redundant to AZ issues.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaConnectFlowRequest> MediaConnectFlows
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
        public MulticastSettingsUpdateRequest MulticastSettings
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
        /// Gets and sets the property Name. Name of the input.
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
        /// Gets and sets the property Sources. The source URLs for a PULL-type input. Every PULL
        /// type input needsexactly two source URLs for redundancy.Only specify sources for PULL
        /// type Inputs. Leave Destinations empty.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputSourceRequest> Sources
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
        public SrtSettingsRequest SrtSettings
        {
            get { return this._srtSettings; }
            set { this._srtSettings = value; }
        }

        // Check to see if SrtSettings property is set
        internal bool IsSetSrtSettings()
        {
            return this._srtSettings != null;
        }

    }
}