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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
    /// The source for an image.
    /// </summary>
    public partial class ImageSource
    {
        private MemoryStream _bytes;
        private S3Location _s3Location;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The raw image bytes for the image. If you use an AWS SDK, you don't need to encode
        /// the image bytes in base64.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public MemoryStream Bytes
        {
            get { return this._bytes; }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes != null;
        }

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The location of an image object in an Amazon S3 bucket. To see which models support
        /// S3 uploads, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/conversation-inference-supported-models-features.html">Supported
        /// models and features for Converse</a>.
        /// </para>
        /// </summary>
        public S3Location S3Location
        {
            get { return this._s3Location; }
            set { this._s3Location = value; }
        }

        // Check to see if S3Location property is set
        internal bool IsSetS3Location()
        {
            return this._s3Location != null;
        }

    }
}