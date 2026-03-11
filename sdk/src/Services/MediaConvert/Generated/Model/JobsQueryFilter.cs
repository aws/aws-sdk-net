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
    /// Provide one or more JobsQueryFilter objects, each containing a Key with an associated
    /// Values array. Note that MediaConvert queries jobs using OR logic.
    /// </summary>
    public partial class JobsQueryFilter
    {
        private JobsQueryFilterKey _key;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. Specify job details to filter for while performing
        /// a jobs query. You specify these filters as part of a key-value pair within the JobsQueryFilter
        /// array. The following list describes which keys are available and their possible values:
        /// * queue - Your Queue's name or ARN. * status - Your job's status. (SUBMITTED | PROGRESSING
        /// | COMPLETE | CANCELED | ERROR) * fileInput - Your input file URL, or partial input
        /// file name. * jobEngineVersionRequested - The Job engine version that you requested
        /// for your job. Valid versions are in a YYYY-MM-DD format. * jobEngineVersionUsed -
        /// The Job engine version that your job used. This may differ from the version that you
        /// requested. Valid versions are in a YYYY-MM-DD format. * audioCodec - Your output's
        /// audio codec. (AAC | MP2 | MP3 | WAV | AIFF | AC3| EAC3 | EAC3_ATMOS | VORBIS | OPUS
        /// | PASSTHROUGH | FLAC) * videoCodec - Your output's video codec. (AV1 | AVC_INTRA |
        /// FRAME_CAPTURE | H_264 | H_265 | MPEG2 | PASSTHROUGH | PRORES | UNCOMPRESSED | VC3
        /// | VP8 | VP9 | XAVC)
        /// </summary>
        public JobsQueryFilterKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. A list of values associated with a JobsQueryFilterKey.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}