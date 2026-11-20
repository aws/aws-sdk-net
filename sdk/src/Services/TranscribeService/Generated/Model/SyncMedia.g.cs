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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// The audio to transcribe. Specify exactly one of <c>MediaBytes</c> or <c>MediaFileUri</c>.
    /// 
    ///  
    /// <para>
    /// Audio sent in the request (<c>MediaBytes</c>) can be up to 25 MB. Audio in Amazon
    /// S3 (<c>MediaFileUri</c>) can be up to 500 MB.
    /// </para>
    /// </summary>
    public partial class SyncMedia
    {
        /// <summary>
        /// Gets and sets the property MediaBytes. 
        /// <para>
        /// Your audio file, provided inline in the request. The maximum size is 25 MB (26,214,400
        /// bytes) of audio, measured before base64 encoding.
        /// </para>
        ///  
        /// <para>
        /// If you use an Amazon Web Services SDK, the SDK base64-encodes the bytes for you. If
        /// you call the API directly, base64-encode the bytes yourself.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 26214400)]
        public MemoryStream MediaBytes { get; set; }

        /// <summary>
        /// Checks to see if the MediaBytes property is set.
        /// </summary>
        internal bool IsSetMediaBytes() => this.MediaBytes != null;

        /// <summary>
        /// Gets and sets the property MediaFileUri. 
        /// <para>
        /// The Amazon S3 location of the media file you want to transcribe. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3://amzn-s3-demo-bucket/my-media-file.flac</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3://amzn-s3-demo-bucket/media-files/my-media-file.flac</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum file size is 500 MB. You must have read permission for the file.
        /// </para>
        ///  
        /// <para>
        /// The Amazon S3 bucket that contains your input media must be located in the same Amazon
        /// Web Services Region where you're making your transcription request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string MediaFileUri { get; set; }

        /// <summary>
        /// Checks to see if the MediaFileUri property is set.
        /// </summary>
        internal bool IsSetMediaFileUri() => this.MediaFileUri != null;
    }
}
