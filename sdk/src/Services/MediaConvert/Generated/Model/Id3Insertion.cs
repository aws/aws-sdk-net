/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// To insert ID3 tags in your output, specify two values. Use ID3 tag (Id3) to specify
    /// the base 64 encoded string and use Timecode (TimeCode) to specify the time when the
    /// tag should be inserted. To insert multiple ID3 tags in your output, create multiple
    /// instances of ID3 insertion (Id3Insertion).
    /// </summary>
    public partial class Id3Insertion
    {
        private string _id3;
        private string _timecode;

        /// <summary>
        /// Gets and sets the property Id3. Use ID3 tag (Id3) to provide a tag value in base64-encode
        /// format.
        /// </summary>
        public string Id3
        {
            get { return this._id3; }
            set { this._id3 = value; }
        }

        // Check to see if Id3 property is set
        internal bool IsSetId3()
        {
            return this._id3 != null;
        }

        /// <summary>
        /// Gets and sets the property Timecode. Provide a Timecode (TimeCode) in HH:MM:SS:FF
        /// or HH:MM:SS;FF format.
        /// </summary>
        public string Timecode
        {
            get { return this._timecode; }
            set { this._timecode = value; }
        }

        // Check to see if Timecode property is set
        internal bool IsSetTimecode()
        {
            return this._timecode != null;
        }

    }
}