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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The source configuration object of a media capture pipeline.
    /// </summary>
    public partial class MediaCapturePipelineSourceConfiguration
    {
        private ChimeSdkMeetingConcatenationConfiguration _chimeSdkMeetingConfiguration;
        private string _mediaPipelineArn;

        /// <summary>
        /// Gets and sets the property ChimeSdkMeetingConfiguration. 
        /// <para>
        /// The meeting configuration settings in a media capture pipeline configuration object.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChimeSdkMeetingConcatenationConfiguration ChimeSdkMeetingConfiguration
        {
            get { return this._chimeSdkMeetingConfiguration; }
            set { this._chimeSdkMeetingConfiguration = value; }
        }

        // Check to see if ChimeSdkMeetingConfiguration property is set
        internal bool IsSetChimeSdkMeetingConfiguration()
        {
            return this._chimeSdkMeetingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MediaPipelineArn. 
        /// <para>
        /// The media pipeline ARN in the configuration object of a media capture pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
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

    }
}