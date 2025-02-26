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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideoMedia.Model
{
    /// <summary>
    /// This is the response object from the GetMedia operation.
    /// </summary>
    public partial class GetMediaResponse : AmazonWebServiceResponse, IDisposable
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
        ///  The payload Kinesis Video Streams returns is a sequence of chunks from the specified
        /// stream. For information about the chunks, see . The chunks that Kinesis Video Streams
        /// returns in the <c>GetMedia</c> call also include the following additional Matroska
        /// (MKV) tags: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_CONTINUATION_TOKEN (UTF-8 string) - In the event your <c>GetMedia</c>
        /// call terminates, you can use this continuation token in your next request to get the
        /// next chunk where the last request terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_MILLIS_BEHIND_NOW (UTF-8 string) - Client applications can use this
        /// tag value to determine how far behind the chunk returned in the response is from the
        /// latest chunk on the stream. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_FRAGMENT_NUMBER - Fragment number returned in the chunk.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_SERVER_TIMESTAMP - Server timestamp of the fragment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_PRODUCER_TIMESTAMP - Producer timestamp of the fragment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following tags will be present if an error occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_ERROR_CODE - String description of an error that caused GetMedia
        /// to stop.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS_KINESISVIDEO_ERROR_ID: Integer code of the error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The error codes are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 3002 - Error writing to the stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4000 - Requested fragment is not found
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4500 - Access denied for the stream's KMS key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4501 - Stream's KMS key is disabled
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4502 - Validation error on the stream's KMS key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4503 - KMS key specified in the stream is unavailable
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4504 - Invalid usage of the KMS key specified in the stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4505 - Invalid state of the KMS key specified in the stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4506 - Unable to find the KMS key specified in the stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 5000 - Internal error
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