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
    /// Hdr10 Settings
    /// </summary>
    public partial class Hdr10Settings
    {
        private int? _maxCll;
        private int? _maxFall;

        /// <summary>
        /// Gets and sets the property MaxCll. Maximum Content Light LevelAn integer metadata
        /// value defining the maximum light level, in nits,of any single pixel within an encoded
        /// HDR video stream or file.
        /// </summary>
        [AWSProperty(Min=0, Max=32768)]
        public int? MaxCll
        {
            get { return this._maxCll; }
            set { this._maxCll = value; }
        }

        // Check to see if MaxCll property is set
        internal bool IsSetMaxCll()
        {
            return this._maxCll.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFall. Maximum Frame Average Light LevelAn integer metadata
        /// value defining the maximum average light level, in nits,for any single frame within
        /// an encoded HDR video stream or file.
        /// </summary>
        [AWSProperty(Min=0, Max=32768)]
        public int? MaxFall
        {
            get { return this._maxFall; }
            set { this._maxFall = value; }
        }

        // Check to see if MaxFall property is set
        internal bool IsSetMaxFall()
        {
            return this._maxFall.HasValue; 
        }

    }
}