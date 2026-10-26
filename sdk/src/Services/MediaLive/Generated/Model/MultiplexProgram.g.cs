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
    /// The multiplex program object.
    /// </summary>
    public partial class MultiplexProgram
    {
        /// <summary>
        /// Gets and sets the property ChannelId. The MediaLive channel associated with the program.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property MultiplexProgramSettings. The settings for this multiplex
        /// program.
        /// </summary>
        public MultiplexProgramSettings MultiplexProgramSettings { get; set; }

        /// <summary>
        /// Checks to see if the MultiplexProgramSettings property is set.
        /// </summary>
        internal bool IsSetMultiplexProgramSettings() => this.MultiplexProgramSettings != null;

        /// <summary>
        /// Gets and sets the property PacketIdentifiersMap. The packet identifier map for this
        /// multiplex program.
        /// </summary>
        public MultiplexProgramPacketIdentifiersMap PacketIdentifiersMap { get; set; }

        /// <summary>
        /// Checks to see if the PacketIdentifiersMap property is set.
        /// </summary>
        internal bool IsSetPacketIdentifiersMap() => this.PacketIdentifiersMap != null;

        /// <summary>
        /// Gets and sets the property PipelineDetails. Contains information about the current
        /// sources for the specified program in the specified multiplex. Keep in mind that each
        /// multiplex pipeline connects to both pipelines in a given source channel (the channel
        /// identified by the program). But only one of those channel pipelines is ever active
        /// at one time.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MultiplexProgramPipelineDetail> PipelineDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<MultiplexProgramPipelineDetail>() : null;

        /// <summary>
        /// Checks to see if the PipelineDetails property is set.
        /// </summary>
        internal bool IsSetPipelineDetails() => this.PipelineDetails != null && (this.PipelineDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProgramName. The name of the multiplex program.
        /// </summary>
        public string ProgramName { get; set; }

        /// <summary>
        /// Checks to see if the ProgramName property is set.
        /// </summary>
        internal bool IsSetProgramName() => this.ProgramName != null;
    }
}
