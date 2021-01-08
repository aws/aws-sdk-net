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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Runtime details of a pipeline when a channel is running.
    /// </summary>
    public partial class PipelineDetail
    {
        private string _activeInputAttachmentName;
        private string _activeInputSwitchActionName;
        private string _pipelineId;

        /// <summary>
        /// Gets and sets the property ActiveInputAttachmentName. The name of the active input
        /// attachment currently being ingested by this pipeline.
        /// </summary>
        public string ActiveInputAttachmentName
        {
            get { return this._activeInputAttachmentName; }
            set { this._activeInputAttachmentName = value; }
        }

        // Check to see if ActiveInputAttachmentName property is set
        internal bool IsSetActiveInputAttachmentName()
        {
            return this._activeInputAttachmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ActiveInputSwitchActionName. The name of the input switch
        /// schedule action that occurred most recently and that resulted in the switch to the
        /// current input attachment for this pipeline.
        /// </summary>
        public string ActiveInputSwitchActionName
        {
            get { return this._activeInputSwitchActionName; }
            set { this._activeInputSwitchActionName = value; }
        }

        // Check to see if ActiveInputSwitchActionName property is set
        internal bool IsSetActiveInputSwitchActionName()
        {
            return this._activeInputSwitchActionName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineId. Pipeline ID
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