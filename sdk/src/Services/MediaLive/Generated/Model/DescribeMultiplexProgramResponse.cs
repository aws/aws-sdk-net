/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for DescribeMultiplexProgramResponse
    /// </summary>
    public partial class DescribeMultiplexProgramResponse : AmazonWebServiceResponse
    {
        private string _channelId;
        private MultiplexProgramSettings _multiplexProgramSettings;
        private MultiplexProgramPacketIdentifiersMap _packetIdentifiersMap;
        private string _programName;

        /// <summary>
        /// Gets and sets the property ChannelId. The MediaLive channel associated with the program.
        /// </summary>
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property MultiplexProgramSettings. The settings for this multiplex
        /// program.
        /// </summary>
        public MultiplexProgramSettings MultiplexProgramSettings
        {
            get { return this._multiplexProgramSettings; }
            set { this._multiplexProgramSettings = value; }
        }

        // Check to see if MultiplexProgramSettings property is set
        internal bool IsSetMultiplexProgramSettings()
        {
            return this._multiplexProgramSettings != null;
        }

        /// <summary>
        /// Gets and sets the property PacketIdentifiersMap. The packet identifier map for this
        /// multiplex program.
        /// </summary>
        public MultiplexProgramPacketIdentifiersMap PacketIdentifiersMap
        {
            get { return this._packetIdentifiersMap; }
            set { this._packetIdentifiersMap = value; }
        }

        // Check to see if PacketIdentifiersMap property is set
        internal bool IsSetPacketIdentifiersMap()
        {
            return this._packetIdentifiersMap != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramName. The name of the multiplex program.
        /// </summary>
        public string ProgramName
        {
            get { return this._programName; }
            set { this._programName = value; }
        }

        // Check to see if ProgramName property is set
        internal bool IsSetProgramName()
        {
            return this._programName != null;
        }

    }
}