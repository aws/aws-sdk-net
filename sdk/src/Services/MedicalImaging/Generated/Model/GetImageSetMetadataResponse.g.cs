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

namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// This is the response object from the GetImageSetMetadata operation.
    /// </summary>
    public partial class GetImageSetMetadataResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property ContentEncoding. 
        /// <para>
        /// The compression format in which image set metadata attributes are returned.
        /// </para>
        /// </summary>
        public string ContentEncoding { get; set; }

        /// <summary>
        /// Checks to see if the ContentEncoding property is set.
        /// </summary>
        internal bool IsSetContentEncoding() => this.ContentEncoding != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The format in which the study metadata is returned to the customer. Default is <c>text/plain</c>.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property ImageSetMetadataBlob. 
        /// <para>
        /// The blob containing the aggregated metadata information for the image set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Stream ImageSetMetadataBlob { get; set; }

        /// <summary>
        /// Checks to see if the ImageSetMetadataBlob property is set.
        /// </summary>
        internal bool IsSetImageSetMetadataBlob() => this.ImageSetMetadataBlob != null;

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
            {
                return;
            }

            if (disposing)
            {
                this.ImageSetMetadataBlob?.Dispose();
                this.ImageSetMetadataBlob = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
