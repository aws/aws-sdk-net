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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// This is the response object from the GetMediaForFragmentList operation.
    /// </summary>
    public partial class GetMediaForFragmentListResponse : AmazonWebServiceResponse, IDisposable
    {
        private string _contentType;
        private Stream _payload;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the requested media.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// stream. For information about the chunks, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_dataplane_PutMedia.html">PutMedia</a>.
        /// The chunks that Kinesis Video Streams returns in the <c>GetMediaForFragmentList</c>
        /// call also include the following additional Matroska (MKV) tags: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_FRAGMENT_NUMBER - Fragment number returned in the chunk.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_SERVER_SIDE_TIMESTAMP - Server-side timestamp of the fragment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_PRODUCER_SIDE_TIMESTAMP - Producer-side timestamp of the fragment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following tags will be included if an exception occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_FRAGMENT_NUMBER - The number of the fragment that threw the exception
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_EXCEPTION_ERROR_CODE - The integer code of the 
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

        #region Dispose Pattern

        private bool _disposed;

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                this._payload?.Dispose();
                this._payload = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}