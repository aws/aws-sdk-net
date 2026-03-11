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
    /// Configuration settings for processing video content in multimodal knowledge bases.
    /// </summary>
    public partial class VideoConfiguration
    {
        private VideoSegmentationConfiguration _segmentationConfiguration;

        /// <summary>
        /// Gets and sets the property SegmentationConfiguration. 
        /// <para>
        /// Configuration for segmenting video content during processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VideoSegmentationConfiguration SegmentationConfiguration
        {
            get { return this._segmentationConfiguration; }
            set { this._segmentationConfiguration = value; }
        }

        // Check to see if SegmentationConfiguration property is set
        internal bool IsSetSegmentationConfiguration()
        {
            return this._segmentationConfiguration != null;
        }

    }
}