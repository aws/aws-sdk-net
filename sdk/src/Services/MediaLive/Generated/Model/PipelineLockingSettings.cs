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
    /// Pipeline Locking Settings
    /// </summary>
    public partial class PipelineLockingSettings
    {
        private string _customEpoch;
        private PipelineLockingMethod _pipelineLockingMethod;

        /// <summary>
        /// Gets and sets the property CustomEpoch. Optional. Only applies to CMAF Ingest Output
        /// Group and MediaPackage V2 Output Group Only. Enter a value here to use a custom epoch,
        /// instead of the standard epoch (which started at 1970-01-01T00:00:00 UTC). Specify
        /// the start time of the custom epoch, in YYYY-MM-DDTHH:MM:SS in UTC. The time must be
        /// 2000-01-01T00:00:00 or later. Always set the MM:SS portion to 00:00.
        /// </summary>
        public string CustomEpoch
        {
            get { return this._customEpoch; }
            set { this._customEpoch = value; }
        }

        // Check to see if CustomEpoch property is set
        internal bool IsSetCustomEpoch()
        {
            return this._customEpoch != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineLockingMethod. The method to use to lock the video
        /// frames in the pipelines. sourceTimecode (default): Use the timecode in the source.
        /// videoAlignment: Lock frames that the encoder identifies as having matching content.
        /// If videoAlignment is selected, existing timecodes will not be used for any locking
        /// decisions.
        /// </summary>
        public PipelineLockingMethod PipelineLockingMethod
        {
            get { return this._pipelineLockingMethod; }
            set { this._pipelineLockingMethod = value; }
        }

        // Check to see if PipelineLockingMethod property is set
        internal bool IsSetPipelineLockingMethod()
        {
            return this._pipelineLockingMethod != null;
        }

    }
}