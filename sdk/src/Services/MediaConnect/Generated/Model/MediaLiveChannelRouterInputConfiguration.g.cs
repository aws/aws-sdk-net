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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Configuration settings for connecting a router input to a MediaLive channel output.
    /// 
    ///  
    /// <para>
    /// To connect the router input to the MediaLive channel output, provide all three of
    /// <c>mediaLiveChannelArn</c>, <c>mediaLivePipelineId</c>, and <c>mediaLiveChannelOutputName</c>.
    /// To disconnect it, call the update operation and omit all three fields while keeping
    /// this configuration object.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't change <c>sourceTransitDecryption</c> while the router input is connected
    /// to a MediaLive channel output. To change it, first disconnect the router input, then
    /// update the decryption.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class MediaLiveChannelRouterInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property MediaLiveChannelArn. 
        /// <para>
        /// The ARN of the MediaLive channel to connect to this router input.
        /// </para>
        /// </summary>
        public string MediaLiveChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaLiveChannelArn property is set.
        /// </summary>
        internal bool IsSetMediaLiveChannelArn() => this.MediaLiveChannelArn != null;

        /// <summary>
        /// Gets and sets the property MediaLiveChannelOutputName. 
        /// <para>
        /// The name of the MediaLive channel output to connect to this router input.
        /// </para>
        /// </summary>
        public string MediaLiveChannelOutputName { get; set; }

        /// <summary>
        /// Checks to see if the MediaLiveChannelOutputName property is set.
        /// </summary>
        internal bool IsSetMediaLiveChannelOutputName() => this.MediaLiveChannelOutputName != null;

        /// <summary>
        /// Gets and sets the property MediaLivePipelineId. 
        /// <para>
        /// The index of the MediaLive pipeline to connect to this router input.
        /// </para>
        /// </summary>
        public MediaLiveChannelPipelineId MediaLivePipelineId { get; set; }

        /// <summary>
        /// Checks to see if the MediaLivePipelineId property is set.
        /// </summary>
        internal bool IsSetMediaLivePipelineId() => this.MediaLivePipelineId != null;

        /// <summary>
        /// Gets and sets the property SourceTransitDecryption.
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaLiveTransitEncryption SourceTransitDecryption { get; set; }

        /// <summary>
        /// Checks to see if the SourceTransitDecryption property is set.
        /// </summary>
        internal bool IsSetSourceTransitDecryption() => this.SourceTransitDecryption != null;
    }
}
