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
    /// The configuration object of the Amazon Chime SDK meeting for a specified media pipeline.
    /// <code>SourceType</code> must be <code>ChimeSdkMeeting</code>.
    /// </summary>
    public partial class ChimeSdkMeetingConfiguration
    {
        private ArtifactsConfiguration _artifactsConfiguration;
        private SourceConfiguration _sourceConfiguration;

        /// <summary>
        /// Gets and sets the property ArtifactsConfiguration. 
        /// <para>
        /// The configuration for the artifacts in an Amazon Chime SDK meeting.
        /// </para>
        /// </summary>
        public ArtifactsConfiguration ArtifactsConfiguration
        {
            get { return this._artifactsConfiguration; }
            set { this._artifactsConfiguration = value; }
        }

        // Check to see if ArtifactsConfiguration property is set
        internal bool IsSetArtifactsConfiguration()
        {
            return this._artifactsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source configuration for a specified media pipeline.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
        }

    }
}