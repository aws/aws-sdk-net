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
    /// MediaPackage Output Destination Settings
    /// </summary>
    public partial class MediaPackageOutputDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property ChannelEndpointId. Endpoint 1 or 2 of the channel in MediaPackageV2.
        /// Only use if you are sending CMAF Ingest output to a CMAF ingest endpoint on a MediaPackage
        /// channel that uses MediaPackage v2.
        /// </summary>
        public string ChannelEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelEndpointId property is set.
        /// </summary>
        internal bool IsSetChannelEndpointId() => this.ChannelEndpointId != null;

        /// <summary>
        /// Gets and sets the property ChannelGroup. Name of the channel group in MediaPackageV2.
        /// Only use if you are sending CMAF Ingest output to a CMAF ingest endpoint on a MediaPackage
        /// channel that uses MediaPackage v2.
        /// </summary>
        public string ChannelGroup { get; set; }

        /// <summary>
        /// Checks to see if the ChannelGroup property is set.
        /// </summary>
        internal bool IsSetChannelGroup() => this.ChannelGroup != null;

        /// <summary>
        /// Gets and sets the property ChannelId. ID of the channel in MediaPackage that is the
        /// destination for this output group. You do not need to specify the individual inputs
        /// in MediaPackage; MediaLive will handle the connection of the two MediaLive pipelines
        /// to the two MediaPackage inputs. The MediaPackage channel and MediaLive channel must
        /// be in the same region.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property ChannelName. Name of the channel in MediaPackageV2. Only
        /// use if you are sending CMAF Ingest output to a CMAF ingest endpoint on a MediaPackage
        /// channel that uses MediaPackage v2.
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property MediaPackageRegionName. Region the channel group and channel
        /// are located in for MediaPackageV2. Only use if you are sending CMAF Ingest output
        /// to a CMAF ingest endpoint on a MediaPackage channel that uses MediaPackage v2.
        /// </summary>
        public string MediaPackageRegionName { get; set; }

        /// <summary>
        /// Checks to see if the MediaPackageRegionName property is set.
        /// </summary>
        internal bool IsSetMediaPackageRegionName() => this.MediaPackageRegionName != null;
    }
}
