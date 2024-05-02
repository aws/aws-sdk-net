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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Source configuration for a specified media pipeline.
    /// </summary>
    public partial class SourceConfiguration
    {
        private SelectedVideoStreams _selectedVideoStreams;

        /// <summary>
        /// Gets and sets the property SelectedVideoStreams. 
        /// <para>
        /// The selected video streams for a specified media pipeline. The number of video streams
        /// can't exceed 25.
        /// </para>
        /// </summary>
        public SelectedVideoStreams SelectedVideoStreams
        {
            get { return this._selectedVideoStreams; }
            set { this._selectedVideoStreams = value; }
        }

        // Check to see if SelectedVideoStreams property is set
        internal bool IsSetSelectedVideoStreams()
        {
            return this._selectedVideoStreams != null;
        }

    }
}