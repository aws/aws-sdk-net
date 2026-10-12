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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDecoderManifest operation. Updates a decoder
    /// manifest. <para> A decoder manifest can only be updated when the status is <c>DRAFT</c>.
    /// Only <c>ACTIVE</c> decoder manifests can be associated with vehicles. </para>
    /// </summary>
    public partial class UpdateDecoderManifestRequest : AmazonIoTFleetWiseRequest
    {
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
        public DefaultForUnmappedSignalsType DefaultForUnmappedSignals { get; set; }

        /// <summary>
        /// Checks to see if the DefaultForUnmappedSignals property is set.
        /// </summary>
        internal bool IsSetDefaultForUnmappedSignals() => this.DefaultForUnmappedSignals != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A brief description of the decoder manifest to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the decoder manifest to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfacesToAdd. 
        /// <para>
        ///  A list of information about the network interfaces to add to the decoder manifest.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<NetworkInterface> NetworkInterfacesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfacesToAdd property is set.
        /// </summary>
        internal bool IsSetNetworkInterfacesToAdd() => this.NetworkInterfacesToAdd != null && (this.NetworkInterfacesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkInterfacesToRemove. 
        /// <para>
        ///  A list of network interfaces to remove from the decoder manifest.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<string> NetworkInterfacesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfacesToRemove property is set.
        /// </summary>
        internal bool IsSetNetworkInterfacesToRemove() => this.NetworkInterfacesToRemove != null && (this.NetworkInterfacesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkInterfacesToUpdate. 
        /// <para>
        ///  A list of information about the network interfaces to update in the decoder manifest.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<NetworkInterface> NetworkInterfacesToUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfacesToUpdate property is set.
        /// </summary>
        internal bool IsSetNetworkInterfacesToUpdate() => this.NetworkInterfacesToUpdate != null && (this.NetworkInterfacesToUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SignalDecodersToAdd. 
        /// <para>
        ///  A list of information about decoding additional signals to add to the decoder manifest.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<SignalDecoder> SignalDecodersToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<SignalDecoder>() : null;

        /// <summary>
        /// Checks to see if the SignalDecodersToAdd property is set.
        /// </summary>
        internal bool IsSetSignalDecodersToAdd() => this.SignalDecodersToAdd != null && (this.SignalDecodersToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SignalDecodersToRemove. 
        /// <para>
        ///  A list of signal decoders to remove from the decoder manifest. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<string> SignalDecodersToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SignalDecodersToRemove property is set.
        /// </summary>
        internal bool IsSetSignalDecodersToRemove() => this.SignalDecodersToRemove != null && (this.SignalDecodersToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SignalDecodersToUpdate. 
        /// <para>
        ///  A list of updated information about decoding signals to update in the decoder manifest.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<SignalDecoder> SignalDecodersToUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<SignalDecoder>() : null;

        /// <summary>
        /// Checks to see if the SignalDecodersToUpdate property is set.
        /// </summary>
        internal bool IsSetSignalDecodersToUpdate() => this.SignalDecodersToUpdate != null && (this.SignalDecodersToUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The state of the decoder manifest. If the status is <c>ACTIVE</c>, the decoder manifest
        /// can't be edited. If the status is <c>DRAFT</c>, you can edit the decoder manifest.
        /// 
        /// </para>
        /// </summary>
        public ManifestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
