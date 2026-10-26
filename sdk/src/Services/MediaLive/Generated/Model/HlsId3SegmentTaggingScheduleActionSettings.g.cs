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
    /// Settings for the action to insert ID3 metadata in every segment, in HLS output groups.
    /// </summary>
    public partial class HlsId3SegmentTaggingScheduleActionSettings
    {
        /// <summary>
        /// Gets and sets the property Id3. Complete this parameter if you want to specify the
        /// entire ID3 metadata. Enter a base64 string that contains one or more fully formed
        /// ID3 tags, according to the ID3 specification: http://id3.org/id3v2.4.0-structure
        /// </summary>
        public string Id3 { get; set; }

        /// <summary>
        /// Checks to see if the Id3 property is set.
        /// </summary>
        internal bool IsSetId3() => this.Id3 != null;

        /// <summary>
        /// Gets and sets the property Tag. Complete this parameter if you want to specify only
        /// the metadata, not the entire frame. MediaLive will insert the metadata in a TXXX frame.
        /// Enter the value as plain text. You can include standard MediaLive variable data such
        /// as the current segment number.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Checks to see if the Tag property is set.
        /// </summary>
        internal bool IsSetTag() => this.Tag != null;
    }
}
