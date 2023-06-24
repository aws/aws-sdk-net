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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Describes the Amazon S3 location of the media file you want to use in your request.
    /// 
    ///  
    /// <para>
    /// For information on supported media formats, refer to the <a href="https://docs.aws.amazon.com/APIReference/API_StartTranscriptionJob.html#transcribe-StartTranscriptionJob-request-MediaFormat">MediaFormat</a>
    /// parameter or the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-input.html#how-input-audio">Media
    /// formats</a> section in the Amazon S3 Developer Guide.
    /// </para>
    /// </summary>
    public partial class Media
    {
        private string _mediaFileUri;
        private string _redactedMediaFileUri;

        /// <summary>
        /// Gets and sets the property MediaFileUri. 
        /// <para>
        /// The Amazon S3 location of the media file you want to transcribe. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>s3://DOC-EXAMPLE-BUCKET/my-media-file.flac</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3://DOC-EXAMPLE-BUCKET/media-files/my-media-file.flac</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the Amazon S3 bucket that contains your input media must be located in the
        /// same Amazon Web Services Region where you're making your transcription request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string MediaFileUri
        {
            get { return this._mediaFileUri; }
            set { this._mediaFileUri = value; }
        }

        // Check to see if MediaFileUri property is set
        internal bool IsSetMediaFileUri()
        {
            return this._mediaFileUri != null;
        }

        /// <summary>
        /// Gets and sets the property RedactedMediaFileUri. 
        /// <para>
        /// The Amazon S3 location of the media file you want to redact. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>s3://DOC-EXAMPLE-BUCKET/my-media-file.flac</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3://DOC-EXAMPLE-BUCKET/media-files/my-media-file.flac</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the Amazon S3 bucket that contains your input media must be located in the
        /// same Amazon Web Services Region where you're making your transcription request.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <code>RedactedMediaFileUri</code> produces a redacted audio file in addition to a
        /// redacted transcript. It is only supported for Call Analytics (<code>StartCallAnalyticsJob</code>)
        /// transcription requests.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string RedactedMediaFileUri
        {
            get { return this._redactedMediaFileUri; }
            set { this._redactedMediaFileUri = value; }
        }

        // Check to see if RedactedMediaFileUri property is set
        internal bool IsSetRedactedMediaFileUri()
        {
            return this._redactedMediaFileUri != null;
        }

    }
}