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
    /// Container for the parameters to the UpdateMultiplex operation.
    /// Updates a multiplex.
    /// </summary>
    public partial class UpdateMultiplexRequest : AmazonMediaLiveRequest
    {
        private string _multiplexId;
        private MultiplexSettings _multiplexSettings;
        private string _name;
        private Dictionary<string, MultiplexProgramPacketIdentifiersMap> _packetIdentifiersMapping = AWSConfigs.InitializeCollections ? new Dictionary<string, MultiplexProgramPacketIdentifiersMap>() : null;

        /// <summary>
        /// Gets and sets the property MultiplexId. ID of the multiplex to update.
        /// </summary>
        [AWSProperty(Required=true)]
        public string MultiplexId
        {
            get { return this._multiplexId; }
            set { this._multiplexId = value; }
        }

        // Check to see if MultiplexId property is set
        internal bool IsSetMultiplexId()
        {
            return this._multiplexId != null;
        }

        /// <summary>
        /// Gets and sets the property MultiplexSettings. The new settings for a multiplex.
        /// </summary>
        public MultiplexSettings MultiplexSettings
        {
            get { return this._multiplexSettings; }
            set { this._multiplexSettings = value; }
        }

        // Check to see if MultiplexSettings property is set
        internal bool IsSetMultiplexSettings()
        {
            return this._multiplexSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Name. Name of the multiplex.
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
        /// Gets and sets the property PacketIdentifiersMapping.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MultiplexProgramPacketIdentifiersMap> PacketIdentifiersMapping
        {
            get { return this._packetIdentifiersMapping; }
            set { this._packetIdentifiersMapping = value; }
        }

        // Check to see if PacketIdentifiersMapping property is set
        internal bool IsSetPacketIdentifiersMapping()
        {
            return this._packetIdentifiersMapping != null && (this._packetIdentifiersMapping.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}