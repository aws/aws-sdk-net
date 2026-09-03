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
    /// Comprehensive information about the NDI® source that's associated with a flow. This
    /// includes the currently active NDI source, a list of all discovered NDI senders, metadata
    /// about the media streams, and any relevant status messages.
    /// </summary>
    public partial class NdiSourceMetadataInfo
    {
        /// <summary>
        /// Gets and sets the property ActiveSource. 
        /// <para>
        ///  The connected NDI sender that's currently sending source content to the flow's NDI
        /// source. 
        /// </para>
        /// </summary>
        public NdiSourceInfo ActiveSource { get; set; }

        /// <summary>
        /// Checks to see if the ActiveSource property is set.
        /// </summary>
        internal bool IsSetActiveSource() => this.ActiveSource != null;

        /// <summary>
        /// Gets and sets the property DiscoveredSources. 
        /// <para>
        ///  A list of the available upstream NDI senders aggregated from all of your configured
        /// discovery servers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<NdiSourceInfo> DiscoveredSources { get; set; } = AWSConfigs.InitializeCollections ? new List<NdiSourceInfo>() : null;

        /// <summary>
        /// Checks to see if the DiscoveredSources property is set.
        /// </summary>
        internal bool IsSetDiscoveredSources() => this.DiscoveredSources != null && (this.DiscoveredSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MediaInfo. 
        /// <para>
        ///  Detailed information about the media streams (video, audio, and so on) that are part
        /// of the active NDI source. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NdiMediaInfo MediaInfo { get; set; }

        /// <summary>
        /// Checks to see if the MediaInfo property is set.
        /// </summary>
        internal bool IsSetMediaInfo() => this.MediaInfo != null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        ///  Any status messages or error codes related to the NDI source and its metadata. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<MessageDetail> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageDetail>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
