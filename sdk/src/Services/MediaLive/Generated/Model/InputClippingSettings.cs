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
    /// Settings to let you create a clip of the file input, in order to set up the input
    /// to ingest only a portion of the file.
    /// </summary>
    public partial class InputClippingSettings
    {
        private InputTimecodeSource _inputTimecodeSource;
        private StartTimecode _startTimecode;
        private StopTimecode _stopTimecode;

        /// <summary>
        /// Gets and sets the property InputTimecodeSource. The source of the timecodes in the
        /// source being clipped.
        /// </summary>
        [AWSProperty(Required=true)]
        public InputTimecodeSource InputTimecodeSource
        {
            get { return this._inputTimecodeSource; }
            set { this._inputTimecodeSource = value; }
        }

        // Check to see if InputTimecodeSource property is set
        internal bool IsSetInputTimecodeSource()
        {
            return this._inputTimecodeSource != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimecode. Settings to identify the start of the clip.
        /// </summary>
        public StartTimecode StartTimecode
        {
            get { return this._startTimecode; }
            set { this._startTimecode = value; }
        }

        // Check to see if StartTimecode property is set
        internal bool IsSetStartTimecode()
        {
            return this._startTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property StopTimecode. Settings to identify the end of the clip.
        /// </summary>
        public StopTimecode StopTimecode
        {
            get { return this._stopTimecode; }
            set { this._stopTimecode = value; }
        }

        // Check to see if StopTimecode property is set
        internal bool IsSetStopTimecode()
        {
            return this._stopTimecode != null;
        }

    }
}