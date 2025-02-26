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
    /// This is the response object from the GetImageSetMetadata operation.
    /// </summary>
    public partial class GetImageSetMetadataResponse : AmazonWebServiceResponse, IDisposable
    {
        private string _contentEncoding;
        private string _contentType;
        private Stream _imageSetMetadataBlob;

        /// <summary>
        /// Gets and sets the property ContentEncoding. 
        /// <para>
        /// The compression format in which image set metadata attributes are returned.
        /// </para>
        /// </summary>
        public string ContentEncoding
        {
            get { return this._contentEncoding; }
            set { this._contentEncoding = value; }
        }

        // Check to see if ContentEncoding property is set
        internal bool IsSetContentEncoding()
        {
            return this._contentEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The format in which the study metadata is returned to the customer. Default is <c>text/plain</c>.
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
        /// Gets and sets the property ImageSetMetadataBlob. 
        /// <para>
        /// The blob containing the aggregated metadata information for the image set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stream ImageSetMetadataBlob
        {
            get { return this._imageSetMetadataBlob; }
            set { this._imageSetMetadataBlob = value; }
        }

        // Check to see if ImageSetMetadataBlob property is set
        internal bool IsSetImageSetMetadataBlob()
        {
            return this._imageSetMetadataBlob != null;
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
                this._imageSetMetadataBlob?.Dispose();
                this._imageSetMetadataBlob = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}