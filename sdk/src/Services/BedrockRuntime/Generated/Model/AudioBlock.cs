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
    /// An audio content block that contains audio data in various supported formats.
    /// </summary>
    public partial class AudioBlock
    {
        private ErrorBlock _error;
        private AudioFormat _format;
        private AudioSource _source;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error information if the audio block could not be processed or contains invalid data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ErrorBlock Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the audio data, such as MP3, WAV, FLAC, or other supported audio formats.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AudioFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the audio data, which can be provided as raw bytes or an S3 location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public AudioSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}