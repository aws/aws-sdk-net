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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configuration for segmenting audio content during multimodal knowledge base ingestion.
    /// Determines how audio files are divided into chunks for processing.
    /// </summary>
    public partial class AudioSegmentationConfiguration
    {
        private int? _fixedLengthDuration;

        /// <summary>
        /// Gets and sets the property FixedLengthDuration. 
        /// <para>
        /// The duration in seconds for each audio segment. Audio files will be divided into chunks
        /// of this length for processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public int? FixedLengthDuration
        {
            get { return this._fixedLengthDuration; }
            set { this._fixedLengthDuration = value; }
        }

        // Check to see if FixedLengthDuration property is set
        internal bool IsSetFixedLengthDuration()
        {
            return this._fixedLengthDuration.HasValue; 
        }

    }
}