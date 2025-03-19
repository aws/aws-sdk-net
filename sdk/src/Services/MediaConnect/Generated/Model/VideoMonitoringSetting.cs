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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Specifies the configuration for video stream metrics monitoring.
    /// </summary>
    public partial class VideoMonitoringSetting
    {
        private BlackFrames _blackFrames;
        private FrozenFrames _frozenFrames;

        /// <summary>
        /// Gets and sets the property BlackFrames. 
        /// <para>
        /// Detects video frames that are black. 
        /// </para>
        /// </summary>
        public BlackFrames BlackFrames
        {
            get { return this._blackFrames; }
            set { this._blackFrames = value; }
        }

        // Check to see if BlackFrames property is set
        internal bool IsSetBlackFrames()
        {
            return this._blackFrames != null;
        }

        /// <summary>
        /// Gets and sets the property FrozenFrames. 
        /// <para>
        /// Detects video frames that have not changed. 
        /// </para>
        /// </summary>
        public FrozenFrames FrozenFrames
        {
            get { return this._frozenFrames; }
            set { this._frozenFrames = value; }
        }

        // Check to see if FrozenFrames property is set
        internal bool IsSetFrozenFrames()
        {
            return this._frozenFrames != null;
        }

    }
}