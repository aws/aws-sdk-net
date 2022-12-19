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
    /// The configuration details that consist of the credentials required (<code>MediaUriSecretArn</code>
    /// and <code>MediaUriType</code>) to access the media files that are streamed to the
    /// camera.
    /// </summary>
    public partial class MediaSourceConfig
    {
        private string _mediaUriSecretArn;
        private MediaUriType _mediaUriType;

        /// <summary>
        /// Gets and sets the property MediaUriSecretArn. 
        /// <para>
        /// The AWS Secrets Manager ARN for the username and password of the camera, or a local
        /// media file location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string MediaUriSecretArn
        {
            get { return this._mediaUriSecretArn; }
            set { this._mediaUriSecretArn = value; }
        }

        // Check to see if MediaUriSecretArn property is set
        internal bool IsSetMediaUriSecretArn()
        {
            return this._mediaUriSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaUriType. 
        /// <para>
        /// The Uniform Resource Identifier (URI) type. The <code>FILE_URI</code> value can be
        /// used to stream local media files.
        /// </para>
        ///  <note> 
        /// <para>
        /// Preview only supports the <code>RTSP_URI</code> media source URI format .
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaUriType MediaUriType
        {
            get { return this._mediaUriType; }
            set { this._mediaUriType = value; }
        }

        // Check to see if MediaUriType property is set
        internal bool IsSetMediaUriType()
        {
            return this._mediaUriType != null;
        }

    }
}