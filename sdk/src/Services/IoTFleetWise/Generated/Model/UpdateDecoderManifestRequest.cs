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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDecoderManifest operation.
    /// Updates a decoder manifest.
    /// 
    ///  
    /// <para>
    /// A decoder manifest can only be updated when the status is <c>DRAFT</c>. Only <c>ACTIVE</c>
    /// decoder manifests can be associated with vehicles.
    /// </para>
    /// </summary>
    public partial class UpdateDecoderManifestRequest : AmazonIoTFleetWiseRequest
    {
        private DefaultForUnmappedSignalsType _defaultForUnmappedSignals;
        private string _description;
        private string _name;
        private List<NetworkInterface> _networkInterfacesToAdd = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private List<string> _networkInterfacesToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<NetworkInterface> _networkInterfacesToUpdate = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private List<SignalDecoder> _signalDecodersToAdd = AWSConfigs.InitializeCollections ? new List<SignalDecoder>() : null;
        private List<string> _signalDecodersToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<SignalDecoder> _signalDecodersToUpdate = AWSConfigs.InitializeCollections ? new List<SignalDecoder>() : null;
        private ManifestStatus _status;

        /// <summary>
        /// Gets and sets the property DefaultForUnmappedSignals. 
        /// <para>
        /// Use default decoders for all unmapped signals in the model. You don't need to provide
        /// any detailed decoding information.
        /// </para>
        ///  <important> 
        /// <para>
        /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
        /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
        /// FleetWise Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public DefaultForUnmappedSignalsType DefaultForUnmappedSignals
        {
            get { return this._defaultForUnmappedSignals; }
            set { this._defaultForUnmappedSignals = value; }
        }

        // Check to see if DefaultForUnmappedSignals property is set
        internal bool IsSetDefaultForUnmappedSignals()
        {
            return this._defaultForUnmappedSignals != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A brief description of the decoder manifest to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the decoder manifest to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property NetworkInterfacesToAdd. 
        /// <para>
        ///  A list of information about the network interfaces to add to the decoder manifest.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<NetworkInterface> NetworkInterfacesToAdd
        {
            get { return this._networkInterfacesToAdd; }
            set { this._networkInterfacesToAdd = value; }
        }

        // Check to see if NetworkInterfacesToAdd property is set
        internal bool IsSetNetworkInterfacesToAdd()
        {
            return this._networkInterfacesToAdd != null && (this._networkInterfacesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfacesToRemove. 
        /// <para>
        ///  A list of network interfaces to remove from the decoder manifest.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<string> NetworkInterfacesToRemove
        {
            get { return this._networkInterfacesToRemove; }
            set { this._networkInterfacesToRemove = value; }
        }

        // Check to see if NetworkInterfacesToRemove property is set
        internal bool IsSetNetworkInterfacesToRemove()
        {
            return this._networkInterfacesToRemove != null && (this._networkInterfacesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfacesToUpdate. 
        /// <para>
        ///  A list of information about the network interfaces to update in the decoder manifest.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<NetworkInterface> NetworkInterfacesToUpdate
        {
            get { return this._networkInterfacesToUpdate; }
            set { this._networkInterfacesToUpdate = value; }
        }

        // Check to see if NetworkInterfacesToUpdate property is set
        internal bool IsSetNetworkInterfacesToUpdate()
        {
            return this._networkInterfacesToUpdate != null && (this._networkInterfacesToUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SignalDecodersToAdd. 
        /// <para>
        ///  A list of information about decoding additional signals to add to the decoder manifest.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<SignalDecoder> SignalDecodersToAdd
        {
            get { return this._signalDecodersToAdd; }
            set { this._signalDecodersToAdd = value; }
        }

        // Check to see if SignalDecodersToAdd property is set
        internal bool IsSetSignalDecodersToAdd()
        {
            return this._signalDecodersToAdd != null && (this._signalDecodersToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SignalDecodersToRemove. 
        /// <para>
        ///  A list of signal decoders to remove from the decoder manifest. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<string> SignalDecodersToRemove
        {
            get { return this._signalDecodersToRemove; }
            set { this._signalDecodersToRemove = value; }
        }

        // Check to see if SignalDecodersToRemove property is set
        internal bool IsSetSignalDecodersToRemove()
        {
            return this._signalDecodersToRemove != null && (this._signalDecodersToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SignalDecodersToUpdate. 
        /// <para>
        ///  A list of updated information about decoding signals to update in the decoder manifest.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<SignalDecoder> SignalDecodersToUpdate
        {
            get { return this._signalDecodersToUpdate; }
            set { this._signalDecodersToUpdate = value; }
        }

        // Check to see if SignalDecodersToUpdate property is set
        internal bool IsSetSignalDecodersToUpdate()
        {
            return this._signalDecodersToUpdate != null && (this._signalDecodersToUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The state of the decoder manifest. If the status is <c>ACTIVE</c>, the decoder manifest
        /// can't be edited. If the status is <c>DRAFT</c>, you can edit the decoder manifest.
        /// 
        /// </para>
        /// </summary>
        public ManifestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}