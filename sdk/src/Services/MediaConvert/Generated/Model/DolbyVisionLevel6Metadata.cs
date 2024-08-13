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
    /// Use these settings when you set DolbyVisionLevel6Mode to SPECIFY to override the MaxCLL
    /// and MaxFALL values in your input with new values.
    /// </summary>
    public partial class DolbyVisionLevel6Metadata
    {
        private int? _maxCll;
        private int? _maxFall;

        /// <summary>
        /// Gets and sets the property MaxCll. Maximum Content Light Level. Static HDR metadata
        /// that corresponds to the brightest pixel in the entire stream. Measured in nits.
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
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
        /// Gets and sets the property MaxFall. Maximum Frame-Average Light Level. Static HDR
        /// metadata that corresponds to the highest frame-average brightness in the entire stream.
        /// Measured in nits.
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
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