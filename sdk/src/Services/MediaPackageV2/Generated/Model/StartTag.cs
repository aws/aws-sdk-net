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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// To insert an EXT-X-START tag in your HLS playlist, specify a StartTag configuration
    /// object with a valid TimeOffset. When you do, you can also optionally specify whether
    /// to include a PRECISE value in the EXT-X-START tag.
    /// </summary>
    public partial class StartTag
    {
        private bool? _precise;
        private float? _timeOffset;

        /// <summary>
        /// Gets and sets the property Precise. 
        /// <para>
        /// Specify the value for PRECISE within your EXT-X-START tag. Leave blank, or choose
        /// false, to use the default value NO. Choose yes to use the value YES.
        /// </para>
        /// </summary>
        public bool? Precise
        {
            get { return this._precise; }
            set { this._precise = value; }
        }

        // Check to see if Precise property is set
        internal bool IsSetPrecise()
        {
            return this._precise.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOffset. 
        /// <para>
        /// Specify the value for TIME-OFFSET within your EXT-X-START tag. Enter a signed floating
        /// point value which, if positive, must be less than the configured manifest duration
        /// minus three times the configured segment target duration. If negative, the absolute
        /// value must be larger than three times the configured segment target duration, and
        /// the absolute value must be smaller than the configured manifest duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float? TimeOffset
        {
            get { return this._timeOffset; }
            set { this._timeOffset = value; }
        }

        // Check to see if TimeOffset property is set
        internal bool IsSetTimeOffset()
        {
            return this._timeOffset.HasValue; 
        }

    }
}