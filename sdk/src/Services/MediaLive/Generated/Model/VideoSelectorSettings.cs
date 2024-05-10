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
    /// Video Selector Settings
    /// </summary>
    public partial class VideoSelectorSettings
    {
        private VideoSelectorPid _videoSelectorPid;
        private VideoSelectorProgramId _videoSelectorProgramId;

        /// <summary>
        /// Gets and sets the property VideoSelectorPid.
        /// </summary>
        public VideoSelectorPid VideoSelectorPid
        {
            get { return this._videoSelectorPid; }
            set { this._videoSelectorPid = value; }
        }

        // Check to see if VideoSelectorPid property is set
        internal bool IsSetVideoSelectorPid()
        {
            return this._videoSelectorPid != null;
        }

        /// <summary>
        /// Gets and sets the property VideoSelectorProgramId.
        /// </summary>
        public VideoSelectorProgramId VideoSelectorProgramId
        {
            get { return this._videoSelectorProgramId; }
            set { this._videoSelectorProgramId = value; }
        }

        // Check to see if VideoSelectorProgramId property is set
        internal bool IsSetVideoSelectorProgramId()
        {
            return this._videoSelectorProgramId != null;
        }

    }
}