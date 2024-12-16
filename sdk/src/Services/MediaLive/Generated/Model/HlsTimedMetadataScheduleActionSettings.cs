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
    /// Settings for the action to insert ID3 metadata (as a one-time action) in HLS output
    /// groups.
    /// </summary>
    public partial class HlsTimedMetadataScheduleActionSettings
    {
        private string _id3;

        /// <summary>
        /// Gets and sets the property Id3. Enter a base64 string that contains one or more fully
        /// formed ID3 tags.See the ID3 specification: http://id3.org/id3v2.4.0-structure
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}