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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specify the XAVC profile settings for MXF outputs when you set your MXF profile to
    /// XAVC.
    /// </summary>
    public partial class MxfXavcProfileSettings
    {
        private MxfXavcDurationMode _durationMode;
        private int? _maxAncDataSize;

        /// <summary>
        /// Gets and sets the property DurationMode. To create an output that complies with the
        /// XAVC file format guidelines for interoperability, keep the default value, Drop frames
        /// for compliance. To include all frames from your input in this output, keep the default
        /// setting, Allow any duration. The number of frames that MediaConvert excludes when
        /// you set this to Drop frames for compliance depends on the output frame rate and duration.
        /// </summary>
        public MxfXavcDurationMode DurationMode
        {
            get { return this._durationMode; }
            set { this._durationMode = value; }
        }

        // Check to see if DurationMode property is set
        internal bool IsSetDurationMode()
        {
            return this._durationMode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxAncDataSize. Specify a value for this setting only for
        /// outputs that you set up with one of these two XAVC profiles: XAVC HD Intra CBG or
        /// XAVC 4K Intra CBG. Specify the amount of space in each frame that the service reserves
        /// for ancillary data, such as teletext captions. The default value for this setting
        /// is 1492 bytes per frame. This should be sufficient to prevent overflow unless you
        /// have multiple pages of teletext captions data. If you have a large amount of teletext
        /// data, specify a larger number.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxAncDataSize
        {
            get { return this._maxAncDataSize; }
            set { this._maxAncDataSize = value; }
        }

        // Check to see if MaxAncDataSize property is set
        internal bool IsSetMaxAncDataSize()
        {
            return this._maxAncDataSize.HasValue; 
        }

    }
}