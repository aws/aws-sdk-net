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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMediaStorageConfiguration operation.
    /// <important> 
    /// <para>
    /// This API is related to <a href="https://docs.aws.amazon.com/kinesisvideostreams-webrtc-dg/latest/devguide/webrtc-ingestion.html">WebRTC
    /// Ingestion</a> and is only available in the <code>us-west-2</code> region.
    /// </para>
    ///  </important> 
    /// <para>
    /// Associates a <code>SignalingChannel</code> to a stream to store the media. There are
    /// two signaling modes that can specified :
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the <code>StorageStatus</code> is disabled, no data will be stored, and the <code>StreamARN</code>
    /// parameter will not be needed. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the <code>StorageStatus</code> is enabled, the data will be stored in the <code>StreamARN</code>
    /// provided. 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// If <code>StorageStatus</code> is enabled, direct peer-to-peer (master-viewer) connections
    /// no longer occur. Peers connect directly to the storage session. You must call the
    /// <code>JoinStorageSession</code> API to trigger an SDP offer send and establish a connection
    /// between a peer and the storage session. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateMediaStorageConfigurationRequest : AmazonKinesisVideoRequest
    {
        private string _channelARN;
        private MediaStorageConfiguration _mediaStorageConfiguration;

        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ChannelARN
        {
            get { return this._channelARN; }
            set { this._channelARN = value; }
        }

        // Check to see if ChannelARN property is set
        internal bool IsSetChannelARN()
        {
            return this._channelARN != null;
        }

        /// <summary>
        /// Gets and sets the property MediaStorageConfiguration. 
        /// <para>
        /// A structure that encapsulates, or contains, the media storage configuration properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaStorageConfiguration MediaStorageConfiguration
        {
            get { return this._mediaStorageConfiguration; }
            set { this._mediaStorageConfiguration = value; }
        }

        // Check to see if MediaStorageConfiguration property is set
        internal bool IsSetMediaStorageConfiguration()
        {
            return this._mediaStorageConfiguration != null;
        }

    }
}