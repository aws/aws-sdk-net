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
    /// Settings to identify the end of the clip.
    /// </summary>
    public partial class StopTimecode
    {
        private LastFrameClippingBehavior _lastFrameClippingBehavior;
        private string _timecode;

        /// <summary>
        /// Gets and sets the property LastFrameClippingBehavior. If you specify a StopTimecode
        /// in an input (in order to clip the file), you can specify if you want the clip to exclude
        /// (the default) or include the frame specified by the timecode.
        /// </summary>
        public LastFrameClippingBehavior LastFrameClippingBehavior
        {
            get { return this._lastFrameClippingBehavior; }
            set { this._lastFrameClippingBehavior = value; }
        }

        // Check to see if LastFrameClippingBehavior property is set
        internal bool IsSetLastFrameClippingBehavior()
        {
            return this._lastFrameClippingBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Timecode. The timecode for the frame where you want to
        /// stop the clip. Optional; if not specified, the clip continues to the end of the file.
        /// Enter the timecode as HH:MM:SS:FF or HH:MM:SS;FF.
        /// </summary>
        public string Timecode
        {
            get { return this._timecode; }
            set { this._timecode = value; }
        }

        // Check to see if Timecode property is set
        internal bool IsSetTimecode()
        {
            return this._timecode != null;
        }

    }
}