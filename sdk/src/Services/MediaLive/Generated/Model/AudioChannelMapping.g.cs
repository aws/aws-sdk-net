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
    /// Audio Channel Mapping
    /// </summary>
    public partial class AudioChannelMapping
    {
        /// <summary>
        /// Gets and sets the property InputChannelLevels. Indices and gain values for each input
        /// channel that should be remixed into this output channel.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<InputChannelLevel> InputChannelLevels { get; set; } = AWSConfigs.InitializeCollections ? new List<InputChannelLevel>() : null;

        /// <summary>
        /// Checks to see if the InputChannelLevels property is set.
        /// </summary>
        internal bool IsSetInputChannelLevels() => this.InputChannelLevels != null && (this.InputChannelLevels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputChannel. The index of the output channel being produced.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? OutputChannel { get; set; }

        /// <summary>
        /// Checks to see if the OutputChannel property is set.
        /// </summary>
        internal bool IsSetOutputChannel() => this.OutputChannel.HasValue;
    }
}
