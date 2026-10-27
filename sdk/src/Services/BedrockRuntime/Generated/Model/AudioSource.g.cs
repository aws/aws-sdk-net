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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The source of audio data, which can be provided either as raw bytes or a reference
    /// to an S3 location.
    /// </summary>
    public partial class AudioSource
    {
        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// Audio data encoded in base64.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public MemoryStream Bytes { get; set; }

        /// <summary>
        /// Checks to see if the Bytes property is set.
        /// </summary>
        internal bool IsSetBytes() => this.Bytes != null;

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// A reference to audio data stored in an Amazon S3 bucket. To see which models support
        /// S3 uploads, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/conversation-inference-supported-models-features.html">Supported
        /// models and features for Converse</a>.
        /// </para>
        /// </summary>
        public S3Location S3Location { get; set; }

        /// <summary>
        /// Checks to see if the S3Location property is set.
        /// </summary>
        internal bool IsSetS3Location() => this.S3Location != null;
    }
}
