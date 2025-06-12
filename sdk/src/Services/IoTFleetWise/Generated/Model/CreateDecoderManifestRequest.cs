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
    /// Container for the parameters to the CreateDecoderManifest operation.
    /// Creates the decoder manifest associated with a model manifest. To create a decoder
    /// manifest, the following must be true:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Every signal decoder has a unique name.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each signal decoder is associated with a network interface.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each network interface has a unique ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The signal decoders are specified in the model manifest.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDecoderManifestRequest : AmazonIoTFleetWiseRequest
    {
        private DefaultForUnmappedSignalsType _defaultForUnmappedSignals;
        private string _description;
        private string _modelManifestArn;
        private string _name;
        private List<NetworkInterface> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private List<SignalDecoder> _signalDecoders = AWSConfigs.InitializeCollections ? new List<SignalDecoder>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// A brief description of the decoder manifest. 
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
        /// Gets and sets the property ModelManifestArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the vehicle model (model manifest). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelManifestArn
        {
            get { return this._modelManifestArn; }
            set { this._modelManifestArn = value; }
        }

        // Check to see if ModelManifestArn property is set
        internal bool IsSetModelManifestArn()
        {
            return this._modelManifestArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The unique name of the decoder manifest to create.
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
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        ///  A list of information about available network interfaces. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SignalDecoders. 
        /// <para>
        ///  A list of information about signal decoders. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<SignalDecoder> SignalDecoders
        {
            get { return this._signalDecoders; }
            set { this._signalDecoders = value; }
        }

        // Check to see if SignalDecoders property is set
        internal bool IsSetSignalDecoders()
        {
            return this._signalDecoders != null && (this._signalDecoders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the decoder manifest.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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