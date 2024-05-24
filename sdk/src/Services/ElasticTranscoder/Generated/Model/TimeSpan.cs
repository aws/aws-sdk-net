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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Settings that determine when a clip begins and how long it lasts.
    /// </summary>
    public partial class TimeSpan
    {
        private string _duration;
        private string _startTime;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the clip. The format can be either HH:mm:ss.SSS (maximum value: 23:59:59.999;
        /// SSS is thousandths of a second) or sssss.SSS (maximum value: 86399.999). If you don't
        /// specify a value, Elastic Transcoder creates an output file from StartTime to the end
        /// of the file.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value longer than the duration of the input file, Elastic Transcoder
        /// transcodes the file and returns a warning message.
        /// </para>
        /// </summary>
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The place in the input file where you want a clip to start. The format can be either
        /// HH:mm:ss.SSS (maximum value: 23:59:59.999; SSS is thousandths of a second) or sssss.SSS
        /// (maximum value: 86399.999). If you don't specify a value, Elastic Transcoder starts
        /// at the beginning of the input file.
        /// </para>
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}