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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property MaxCll. Maximum Content Light Level An integer metadata
        /// value defining the maximum light level, in nits, of any single pixel within an encoded
        /// HDR video stream or file.
        /// </summary>
        public int? MaxCll { get; set; }

        /// <summary>
        /// Checks to see if the MaxCll property is set.
        /// </summary>
        internal bool IsSetMaxCll() => this.MaxCll.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFall. Maximum Frame Average Light Level An integer metadata
        /// value defining the maximum average light level, in nits, for any single frame within
        /// an encoded HDR video stream or file.
        /// </summary>
        public int? MaxFall { get; set; }

        /// <summary>
        /// Checks to see if the MaxFall property is set.
        /// </summary>
        internal bool IsSetMaxFall() => this.MaxFall.HasValue;
    }
}
