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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The media pipeline's configuration object.
    /// </summary>
    public partial class ChimeSdkMeetingLiveConnectorConfiguration
    {
        private string _arn;
        private CompositedVideoArtifactsConfiguration _compositedVideo;
        private LiveConnectorMuxType _muxType;
        private SourceConfiguration _sourceConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The configuration object's Chime SDK meeting ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CompositedVideo. 
        /// <para>
        /// The media pipeline's composited video.
        /// </para>
        /// </summary>
        public CompositedVideoArtifactsConfiguration CompositedVideo
        {
            get { return this._compositedVideo; }
            set { this._compositedVideo = value; }
        }

        // Check to see if CompositedVideo property is set
        internal bool IsSetCompositedVideo()
        {
            return this._compositedVideo != null;
        }

        /// <summary>
        /// Gets and sets the property MuxType. 
        /// <para>
        /// The configuration object's multiplex type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LiveConnectorMuxType MuxType
        {
            get { return this._muxType; }
            set { this._muxType = value; }
        }

        // Check to see if MuxType property is set
        internal bool IsSetMuxType()
        {
            return this._muxType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source configuration settings of the media pipeline's configuration object.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
        }

    }
}