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
    /// Container for the parameters to the StopSpeakerSearchTask operation.
    /// Stops a speaker search task.
    /// </summary>
    public partial class StopSpeakerSearchTaskRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        private string _identifier;
        private string _speakerSearchTaskId;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the resource to be updated. Valid values include the ID and
        /// ARN of the media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property SpeakerSearchTaskId. 
        /// <para>
        /// The speaker search task ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SpeakerSearchTaskId
        {
            get { return this._speakerSearchTaskId; }
            set { this._speakerSearchTaskId = value; }
        }

        // Check to see if SpeakerSearchTaskId property is set
        internal bool IsSetSpeakerSearchTaskId()
        {
            return this._speakerSearchTaskId != null;
        }

    }
}