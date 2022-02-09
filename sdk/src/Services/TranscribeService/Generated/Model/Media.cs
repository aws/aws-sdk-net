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
    /// Describes the input media file in a transcription request.
    /// </summary>
    public partial class Media
    {
        private string _mediaFileUri;
        private string _redactedMediaFileUri;

        /// <summary>
        /// Gets and sets the property MediaFileUri. 
        /// <para>
        /// The S3 object location of the input media file. The URI must be in the same region
        /// as the API endpoint that you are calling. The general form is:
        /// </para>
        ///  
        /// <para>
        ///  <code> s3://&lt;AWSDOC-EXAMPLE-BUCKET&gt;/&lt;keyprefix&gt;/&lt;objectkey&gt;</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>s3://AWSDOC-EXAMPLE-BUCKET/example.mp4</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>s3://AWSDOC-EXAMPLE-BUCKET/mediadocs/example.mp4</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information about S3 object names, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMetadata.html#object-keys">Object
        /// Keys</a> in the <i>Amazon S3 Developer Guide</i>.
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
        /// The S3 object location for your redacted output media file. This is only supported
        /// for call analytics jobs.
        /// </para>
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