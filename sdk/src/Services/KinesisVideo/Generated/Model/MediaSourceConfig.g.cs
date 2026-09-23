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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The configuration details that consist of the credentials required (<c>MediaUriSecretArn</c>
    /// and <c>MediaUriType</c>) to access the media files that are streamed to the camera.
    /// </summary>
    public partial class MediaSourceConfig
    {
        /// <summary>
        /// Gets and sets the property MediaUriSecretArn. 
        /// <para>
        /// The Amazon Web Services Secrets Manager ARN for the username and password of the camera,
        /// or a local media file location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 20, Max = 2048)]
        public string MediaUriSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaUriSecretArn property is set.
        /// </summary>
        internal bool IsSetMediaUriSecretArn() => this.MediaUriSecretArn != null;

        /// <summary>
        /// Gets and sets the property MediaUriType. 
        /// <para>
        /// The Uniform Resource Identifier (URI) type. The <c>FILE_URI</c> value can be used
        /// to stream local media files.
        /// </para>
        ///  <note> 
        /// <para>
        /// Preview only supports the <c>RTSP_URI</c> media source URI format .
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaUriType MediaUriType { get; set; }

        /// <summary>
        /// Checks to see if the MediaUriType property is set.
        /// </summary>
        internal bool IsSetMediaUriType() => this.MediaUriType != null;
    }
}
