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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
    /// Container for the parameters to the ResetOriginEndpointState operation.
    /// Resetting the origin endpoint can help to resolve unexpected behavior and other content
    /// packaging issues. It also helps to preserve special events when you don't want the
    /// previous content to be available for viewing. A reset clears out all previous content
    /// from the origin endpoint.
    /// 
    ///  
    /// <para>
    /// MediaPackage might return old content from this endpoint in the first 30 seconds after
    /// the endpoint reset. For best results, when possible, wait 30 seconds from endpoint
    /// reset to send playback requests to this endpoint. 
    /// </para>
    /// </summary>
    public partial class ResetOriginEndpointStateRequest : AmazonMediaPackageV2Request
    {
        private string _channelGroupName;
        private string _channelName;
        private string _originEndpointName;

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name of the channel group that contains the channel with the origin endpoint that
        /// you are resetting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ChannelGroupName
        {
            get { return this._channelGroupName; }
            set { this._channelGroupName = value; }
        }

        // Check to see if ChannelGroupName property is set
        internal bool IsSetChannelGroupName()
        {
            return this._channelGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel with the origin endpoint that you are resetting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name of the origin endpoint that you are resetting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OriginEndpointName
        {
            get { return this._originEndpointName; }
            set { this._originEndpointName = value; }
        }

        // Check to see if OriginEndpointName property is set
        internal bool IsSetOriginEndpointName()
        {
            return this._originEndpointName != null;
        }

    }
}