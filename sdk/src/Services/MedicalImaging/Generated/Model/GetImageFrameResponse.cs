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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// This is the response object from the GetImageFrame operation.
    /// </summary>
    public partial class GetImageFrameResponse : AmazonWebServiceResponse, IDisposable
    {
        private string _contentType;
        private Stream _imageFrameBlob;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The format in which the image frame information is returned to the customer. Default
        /// is <c>application/octet-stream</c>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// If the stored transfer syntax is <c>1.2.840.10008.1.2.1</c>, the returned <c>contentType</c>
        /// is <c>application/octet-stream</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// If the stored transfer syntax is <c>1.2.840.10008.1.2.4.50</c>, the returned <c>contentType</c>
        /// is <c>image/jpeg</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// If the stored transfer syntax is <c>1.2.840.10008.1.2.4.91</c>, the returned <c>contentType</c>
        /// is <c>image/j2c</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// If the stored transfer syntax is MPEG2, <c>1.2.840.10008.1.2.4.100</c>, <c>1.2.840.10008.1.2.4.100.1</c>,
        /// <c>1.2.840.10008.1.2.4.101</c>, or <c>1.2.840.10008.1.2.4.101.1</c>, the returned
        /// <c>contentType</c> is <c>video/mpeg</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// If the stored transfer syntax is MPEG-4 AVC/H.264, UID <c>1.2.840.10008.1.2.4.102</c>,
        /// <c>1.2.840.10008.1.2.4.102.1</c>, <c>1.2.840.10008.1.2.4.103</c>, <c>1.2.840.10008.1.2.4.103.1</c>,
        /// <c>1.2.840.10008.1.2.4.104</c>, <c>1.2.840.10008.1.2.4.104.1</c>, <c>1.2.840.10008.1.2.4.105</c>,
        /// <c>1.2.840.10008.1.2.4.105.1</c>, <c>1.2.840.10008.1.2.4.106</c>, or <c>1.2.840.10008.1.2.4.106.1</c>,
        /// the returned <c>contentType</c> is <c>video/mp4</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// If the stored transfer syntax is HEVC/H.265, UID <c>1.2.840.10008.1.2.4.107</c> or
        /// <c>1.2.840.10008.1.2.4.108</c>, the returned <c>contentType</c> is <c>video/H256</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// If the stored transfer syntax is <c>1.2.840.10008.1.2.4.202</c> or if the stored transfer
        /// syntax is <i>missing</i>, the returned <c>contentType</c> is <c>image/jph</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// If the stored transfer syntax is <c>1.2.840.10008.1.2.4.203</c>, the returned contentType
        /// is <c>image/jphc</c>.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Gets and sets the property ImageFrameBlob. 
        /// <para>
        /// The blob containing the aggregated image frame information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stream ImageFrameBlob
        {
            get { return this._imageFrameBlob; }
            set { this._imageFrameBlob = value; }
        }

        // Check to see if ImageFrameBlob property is set
        internal bool IsSetImageFrameBlob()
        {
            return this._imageFrameBlob != null;
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
                this._imageFrameBlob?.Dispose();
                this._imageFrameBlob = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}