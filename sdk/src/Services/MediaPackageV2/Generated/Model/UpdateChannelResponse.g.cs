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
    /// This is the response object from the UpdateChannel operation.
    /// </summary>
    public partial class UpdateChannelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AttachedMultiviewChannels. 
        /// <para>
        /// The multiview channels, in the same channel group, that list this channel as an available
        /// source. This is a read-only field. You can't delete a channel while any multiview
        /// channel still lists it as a source. Use this field to find the multiview channels
        /// that you need to update first.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttachedMultiviewChannels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttachedMultiviewChannels property is set.
        /// </summary>
        internal bool IsSetAttachedMultiviewChannels() => this.AttachedMultiviewChannels != null && (this.AttachedMultiviewChannels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelGroupName property is set.
        /// </summary>
        internal bool IsSetChannelGroupName() => this.ChannelGroupName != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name that describes the channel. The name is the primary identifier for the channel,
        /// and must be unique for your account in the AWS Region and channel group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for your channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current Entity Tag (ETag) associated with this resource. The entity tag can be
        /// used to safely make concurrent updates to the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property IngestEndpoints.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IngestEndpoint> IngestEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<IngestEndpoint>() : null;

        /// <summary>
        /// Checks to see if the IngestEndpoints property is set.
        /// </summary>
        internal bool IsSetIngestEndpoints() => this.IngestEndpoints != null && (this.IngestEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the channel was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MultiviewConfiguration. 
        /// <para>
        /// The multiview configuration for the channel. This is present only when <c>InputType</c>
        /// is <c>MULTIVIEW</c>.
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
        /// The output locking mode configured for the channel. This value is immutable after
        /// channel creation.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EPOCH_LOCKED</c> - The channel uses epoch-locked behavior with deterministic sequence
        /// numbering and fixed segment boundaries aligned to epoch time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_EPOCH_LOCKED</c> - The channel uses non-epoch-locked behavior with duration-based
        /// segment combining and monotonically increasing sequence numbers starting from 0.
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
        /// The comma-separated list of tag key:value pairs assigned to the channel.
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
