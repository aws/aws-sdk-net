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
    /// The summary data of a media capture pipeline.
    /// </summary>
    public partial class MediaCapturePipelineSummary
    {
        private string _mediaPipelineArn;
        private string _mediaPipelineId;

        /// <summary>
        /// Gets and sets the property MediaPipelineArn. 
        /// <para>
        /// The ARN of the media pipeline in the summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string MediaPipelineArn
        {
            get { return this._mediaPipelineArn; }
            set { this._mediaPipelineArn = value; }
        }

        // Check to see if MediaPipelineArn property is set
        internal bool IsSetMediaPipelineArn()
        {
            return this._mediaPipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaPipelineId. 
        /// <para>
        /// The ID of the media pipeline in the summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MediaPipelineId
        {
            get { return this._mediaPipelineId; }
            set { this._mediaPipelineId = value; }
        }

        // Check to see if MediaPipelineId property is set
        internal bool IsSetMediaPipelineId()
        {
            return this._mediaPipelineId != null;
        }

    }
}