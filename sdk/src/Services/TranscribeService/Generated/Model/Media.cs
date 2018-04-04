/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

        /// <summary>
        /// Gets and sets the property MediaFileUri. 
        /// <para>
        /// The S3 location of the input media file. The URI must be in the same region as the
        /// API endpoint that you are calling. The general form is:
        /// </para>
        ///  
        /// <para>
        ///  <code> https://&lt;aws-region&gt;.amazonaws.com/&lt;bucket-name&gt;/&lt;keyprefix&gt;/&lt;objectkey&gt;
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>https://s3-us-east-1.amazonaws.com/examplebucket/example.mp4</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>https://s3-us-east-1.amazonaws.com/examplebucket/mediadocs/example.mp4</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about S3 object names, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMetadata.html#object-keys">Object
        /// Keys</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </para>
        /// </summary>
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

    }
}