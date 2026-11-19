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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// The audio source of a recording. In a <c>CreateVoice</c> request, specify exactly
    /// one of <c>S3Url</c> and <c>Bytes</c>. In a response, a recording that Amazon Polly
    /// read from Amazon S3 includes its <c>S3Url</c>. A recording that you passed as <c>Bytes</c>
    /// includes neither field, because Amazon Polly doesn't return the audio.
    /// </summary>
    public partial class RecordingData
    {
        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The audio data, passed directly in the request. The data must be in the format that
        /// <c>Format</c> specifies and can be up to 5 MB. Amazon Polly doesn't store the audio
        /// after it creates the voice, and doesn't return this field in responses.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 5242880)]
        public MemoryStream Bytes { get; set; }

        /// <summary>
        /// Checks to see if the Bytes property is set.
        /// </summary>
        internal bool IsSetBytes() => this.Bytes != null;

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// The Amazon S3 URL of the audio object, in the form <c>s3://bucket/key</c>. You need
        /// <c>s3:GetObject</c> permission on the object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3Url { get; set; }

        /// <summary>
        /// Checks to see if the S3Url property is set.
        /// </summary>
        internal bool IsSetS3Url() => this.S3Url != null;
    }
}
