/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings for the action to set pause state of a channel.
    /// </summary>
    public partial class PauseStateScheduleActionSettings
    {
        private List<PipelinePauseStateSettings> _pipelines = new List<PipelinePauseStateSettings>();

        /// <summary>
        /// Gets and sets the property Pipelines.
        /// </summary>
        public List<PipelinePauseStateSettings> Pipelines
        {
            get { return this._pipelines; }
            set { this._pipelines = value; }
        }

        // Check to see if Pipelines property is set
        internal bool IsSetPipelines()
        {
            return this._pipelines != null && this._pipelines.Count > 0; 
        }

    }
}