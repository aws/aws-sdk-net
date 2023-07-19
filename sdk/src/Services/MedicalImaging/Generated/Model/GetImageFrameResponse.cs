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
        /// is <code>application/octet-stream</code>.
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