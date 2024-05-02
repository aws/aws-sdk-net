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
    /// Information about the source streaming video.
    /// </summary>
    public partial class StreamProcessorInput
    {
        private KinesisVideoStream _kinesisVideoStream;

        /// <summary>
        /// Gets and sets the property KinesisVideoStream. 
        /// <para>
        /// The Kinesis video stream input stream for the source streaming video.
        /// </para>
        /// </summary>
        public KinesisVideoStream KinesisVideoStream
        {
            get { return this._kinesisVideoStream; }
            set { this._kinesisVideoStream = value; }
        }

        // Check to see if KinesisVideoStream property is set
        internal bool IsSetKinesisVideoStream()
        {
            return this._kinesisVideoStream != null;
        }

    }
}