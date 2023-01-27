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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specify YUV limits and RGB tolerances when you set Sample range conversion to Limited
    /// range clip.
    /// </summary>
    public partial class ClipLimits
    {
        private int? _maximumRGBTolerance;
        private int? _maximumYUV;
        private int? _minimumRGBTolerance;
        private int? _minimumYUV;

        /// <summary>
        /// Gets and sets the property MaximumRGBTolerance. Specify the Maximum RGB color sample
        /// range tolerance for your output. MediaConvert corrects any YUV values that, when converted
        /// to RGB, would be outside the upper tolerance that you specify. Enter an integer from
        /// 90 to 105 as an offset percentage to the maximum possible value. Leave blank to use
        /// the default value 100. When you specify a value for Maximum RGB tolerance, you must
        /// set Sample range conversion to Limited range clip.
        /// </summary>
        [AWSProperty(Min=90, Max=105)]
        public int MaximumRGBTolerance
        {
            get { return this._maximumRGBTolerance.GetValueOrDefault(); }
            set { this._maximumRGBTolerance = value; }
        }

        // Check to see if MaximumRGBTolerance property is set
        internal bool IsSetMaximumRGBTolerance()
        {
            return this._maximumRGBTolerance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumYUV. Specify the Maximum YUV color sample limit.
        /// MediaConvert conforms any pixels in your input above the value that you specify to
        /// typical limited range bounds. Enter an integer from 920 to 1023. Leave blank to use
        /// the default value 940. The value that you enter applies to 10-bit ranges. For 8-bit
        /// ranges, MediaConvert automatically scales this value down. When you specify a value
        /// for Maximum YUV, you must set Sample range conversion to Limited range clip.
        /// </summary>
        [AWSProperty(Min=920, Max=1023)]
        public int MaximumYUV
        {
            get { return this._maximumYUV.GetValueOrDefault(); }
            set { this._maximumYUV = value; }
        }

        // Check to see if MaximumYUV property is set
        internal bool IsSetMaximumYUV()
        {
            return this._maximumYUV.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumRGBTolerance. Specify the Minimum RGB color sample
        /// range tolerance for your output. MediaConvert corrects any YUV values that, when converted
        /// to RGB, would be outside the lower tolerance that you specify. Enter an integer from
        /// -5 to 10 as an offset percentage to the minimum possible value. Leave blank to use
        /// the default value 0. When you specify a value for Minimum RGB tolerance, you must
        /// set Sample range conversion to Limited range clip.
        /// </summary>
        [AWSProperty(Min=-5, Max=10)]
        public int MinimumRGBTolerance
        {
            get { return this._minimumRGBTolerance.GetValueOrDefault(); }
            set { this._minimumRGBTolerance = value; }
        }

        // Check to see if MinimumRGBTolerance property is set
        internal bool IsSetMinimumRGBTolerance()
        {
            return this._minimumRGBTolerance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumYUV. Specify the Minimum YUV color sample limit.
        /// MediaConvert conforms any pixels in your input below the value that you specify to
        /// typical limited range bounds. Enter an integer from 0 to 128. Leave blank to use the
        /// default value 64. The value that you enter applies to 10-bit ranges. For 8-bit ranges,
        /// MediaConvert automatically scales this value down. When you specify a value for Minumum
        /// YUV, you must set Sample range conversion to Limited range clip.
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int MinimumYUV
        {
            get { return this._minimumYUV.GetValueOrDefault(); }
            set { this._minimumYUV = value; }
        }

        // Check to see if MinimumYUV property is set
        internal bool IsSetMinimumYUV()
        {
            return this._minimumYUV.HasValue; 
        }

    }
}