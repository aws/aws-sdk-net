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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// The current source for one of the pipelines in the multiplex.
    /// </summary>
    public partial class MultiplexProgramPipelineDetail
    {
        private string _activeChannelPipeline;
        private string _pipelineId;

        /// <summary>
        /// Gets and sets the property ActiveChannelPipeline. Identifies the channel pipeline
        /// that is currently active for the pipeline (identified by PipelineId) in the multiplex.
        /// </summary>
        public string ActiveChannelPipeline
        {
            get { return this._activeChannelPipeline; }
            set { this._activeChannelPipeline = value; }
        }

        // Check to see if ActiveChannelPipeline property is set
        internal bool IsSetActiveChannelPipeline()
        {
            return this._activeChannelPipeline != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineId. Identifies a specific pipeline in the multiplex.
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

    }
}