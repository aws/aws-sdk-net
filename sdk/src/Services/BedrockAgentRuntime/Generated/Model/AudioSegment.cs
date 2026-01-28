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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about an audio segment retrieved from a knowledge base, including
    /// its location and transcription.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Retrieve.html#API_agent-runtime_Retrieve_ResponseSyntax">Retrieve
    /// response</a> – in the <c>audio</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AudioSegment
    {
        private string _s3Uri;
        private string _transcription;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The S3 URI where this specific audio segment is stored in the multimodal storage destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property Transcription. 
        /// <para>
        /// The text transcription of the audio segment content.
        /// </para>
        /// </summary>
        public string Transcription
        {
            get { return this._transcription; }
            set { this._transcription = value; }
        }

        // Check to see if Transcription property is set
        internal bool IsSetTranscription()
        {
            return this._transcription != null;
        }

    }
}