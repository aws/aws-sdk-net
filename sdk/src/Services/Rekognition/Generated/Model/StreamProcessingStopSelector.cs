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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Specifies when to stop processing the stream. You can specify a maximum amount of
    /// time to process the video.
    /// </summary>
    public partial class StreamProcessingStopSelector
    {
        private long? _maxDurationInSeconds;

        /// <summary>
        /// Gets and sets the property MaxDurationInSeconds. 
        /// <para>
        ///  Specifies the maximum amount of time in seconds that you want the stream to be processed.
        /// The largest amount of time is 2 minutes. The default is 10 seconds. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public long? MaxDurationInSeconds
        {
            get { return this._maxDurationInSeconds; }
            set { this._maxDurationInSeconds = value; }
        }

        // Check to see if MaxDurationInSeconds property is set
        internal bool IsSetMaxDurationInSeconds()
        {
            return this._maxDurationInSeconds.HasValue; 
        }

    }
}