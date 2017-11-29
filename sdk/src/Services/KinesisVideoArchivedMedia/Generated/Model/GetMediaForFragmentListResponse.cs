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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// This is the response object from the GetMediaForFragmentList operation.
    /// </summary>
    public partial class GetMediaForFragmentListResponse : AmazonWebServiceResponse
    {
        private string _contentType;
        private Stream _payload;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the requested media.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload that Kinesis Video Streams returns is a sequence of chunks from the specified
        /// stream. For information about the chunks, see <a href="docs.aws.amazon.com/acuity/latest/dg/API_dataplane_PutMedia.html">PutMedia</a>.
        /// The chunks that Kinesis Video Streams returns in the <code>GetMediaForFragmentList</code>
        /// call also include the following additional Matroska (MKV) tags: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_FRAGMENT_NUMBER - Fragment number returned in the chunk.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_SERVER_SIDE_TIMESTAMP - Server-side time stamp of the fragment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_PRODUCER_SIDE_TIMESTAMP - Producer-side time stamp of the fragment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following tags will be included if an exception occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_FRAGMENT_NUMBER - The number of the fragment that threw the exception
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_EXCEPTION_ERROR_CODE - The integer code of the exception
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_EXCEPTION_MESSAGE - A text description of the exception
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Stream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

    }
}