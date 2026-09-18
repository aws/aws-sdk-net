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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChannel operation. Create a channel to start
    /// receiving content streams. The channel represents the input to MediaPackage for incoming
    /// live content from an encoder such as AWS Elemental MediaLive. The channel receives
    /// content, and after packaging it, outputs it through an origin endpoint to downstream
    /// devices (such as video players or CDNs) that request the content. You can create only
    /// one channel with each request. We recommend that you spread out channels between channel
    /// groups, such as putting redundant channels in the same AWS Region in different channel
    /// groups.
    /// </summary>
    public partial class CreateChannelRequest : AmazonMediaPackageV2Request
    {
        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelGroupName property is set.
        /// </summary>
        internal bool IsSetChannelGroupName() => this.ChannelGroupName != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name that describes the channel. The name is the primary identifier for the channel,
        /// and must be unique for your account in the AWS Region and channel group. You can't
        /// change the name after you create the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Enter any descriptive text that helps you to identify the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InputSwitchConfiguration. 
        /// <para>
        /// The configuration for input switching based on the media quality confidence score
        /// (MQCS) as provided from AWS Elemental MediaLive. This setting is valid only when <c>InputType</c>
        /// is <c>CMAF</c>.
        /// </para>
        /// </summary>
        public InputSwitchConfiguration InputSwitchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputSwitchConfiguration property is set.
        /// </summary>
        internal bool IsSetInputSwitchConfiguration() => this.InputSwitchConfiguration != null;

        /// <summary>
        /// Gets and sets the property InputType. 
        /// <para>
        /// The input type is an immutable field. It defines whether the channel allows CMAF ingest,
        /// HLS ingest, or server-side multiview output. Multiview channels receive no ingest
        /// of their own. If unprovided, the value defaults to HLS.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HLS</c> - The HLS streaming specification (which defines M3U8 manifests and TS
        /// segments).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CMAF</c> - The DASH-IF CMAF Ingest specification (which defines CMAF segments
        /// with optional DASH manifests).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTIVIEW</c> – Server-side multiview. The channel receives no ingest of its own.
        /// Instead, it composites video from the source channels in its <c>MultiviewConfiguration</c>
        /// into a single tiled output stream.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InputType InputType { get; set; }

        /// <summary>
        /// Checks to see if the InputType property is set.
        /// </summary>
        internal bool IsSetInputType() => this.InputType != null;

        /// <summary>
        /// Gets and sets the property MultiviewConfiguration. 
        /// <para>
        /// The multiview configuration for the channel. This setting is required when <c>InputType</c>
        /// is <c>MULTIVIEW</c>, and can't be set for any other input type.
        /// </para>
        /// </summary>
        public MultiviewConfiguration MultiviewConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MultiviewConfiguration property is set.
        /// </summary>
        internal bool IsSetMultiviewConfiguration() => this.MultiviewConfiguration != null;

        /// <summary>
        /// Gets and sets the property OutputHeaderConfiguration. 
        /// <para>
        /// The settings for what common media server data (CMSD) headers AWS Elemental MediaPackage
        /// includes in responses to the CDN. This setting is valid only when <c>InputType</c>
        /// is <c>CMAF</c>.
        /// </para>
        /// </summary>
        public OutputHeaderConfiguration OutputHeaderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputHeaderConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputHeaderConfiguration() => this.OutputHeaderConfiguration != null;

        /// <summary>
        /// Gets and sets the property OutputLockingMode. 
        /// <para>
        /// The output locking mode for the channel. This setting is only valid when <c>InputType</c>
        /// is <c>CMAF</c>. This value is immutable after channel creation. If you don't specify
        /// a value, the default is <c>EPOCH_LOCKED</c>.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EPOCH_LOCKED</c> - The channel uses epoch-locked behavior with deterministic sequence
        /// numbering and fixed segment boundaries aligned to epoch time. This mode supports cross-region
        /// synchronization and failover.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_EPOCH_LOCKED</c> - The channel uses non-epoch-locked behavior with duration-based
        /// segment combining and monotonically increasing sequence numbers starting from 0. This
        /// mode does not support cross-region synchronization or failover.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OutputLockingMode OutputLockingMode { get; set; }

        /// <summary>
        /// Checks to see if the OutputLockingMode property is set.
        /// </summary>
        internal bool IsSetOutputLockingMode() => this.OutputLockingMode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A comma-separated list of tag key:value pairs that you define. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"Key1": "Value1",</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"Key2": "Value2"</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
