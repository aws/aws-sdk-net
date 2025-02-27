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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains the Amazon S3 Glacier response to your request.
    /// </summary>
    public partial class GetJobOutputResponse : AmazonWebServiceResponse, IDisposable
    {
        private string _acceptRanges;
        private string _archiveDescription;
        private Stream _body;
        private string _checksum;
        private string _contentRange;
        private string _contentType;
        private int? _status;

        /// <summary>
        /// Gets and sets the property AcceptRanges. 
        /// <para>
        /// Indicates the range units accepted. For more information, see <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html">RFC2616</a>.
        /// 
        /// </para>
        /// </summary>
        public string AcceptRanges
        {
            get { return this._acceptRanges; }
            set { this._acceptRanges = value; }
        }

        // Check to see if AcceptRanges property is set
        internal bool IsSetAcceptRanges()
        {
            return this._acceptRanges != null;
        }

        /// <summary>
        /// Gets and sets the property ArchiveDescription. 
        /// <para>
        /// The description of an archive.
        /// </para>
        /// </summary>
        public string ArchiveDescription
        {
            get { return this._archiveDescription; }
            set { this._archiveDescription = value; }
        }

        // Check to see if ArchiveDescription property is set
        internal bool IsSetArchiveDescription()
        {
            return this._archiveDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The job data, either archive data or inventory data.
        /// </para>
        /// </summary>
        public Stream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum of the data in the response. This header is returned only when retrieving
        /// the output for an archive retrieval job. Furthermore, this header appears only under
        /// the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You get the entire range of the archive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You request a range to return of the archive that starts and ends on a multiple of
        /// 1 MB. For example, if you have an 3.1 MB archive and you specify a range to return
        /// that starts at 1 MB and ends at 2 MB, then the x-amz-sha256-tree-hash is returned
        /// as a response header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You request a range of the archive to return that starts on a multiple of 1 MB and
        /// goes to the end of the archive. For example, if you have a 3.1 MB archive and you
        /// specify a range that starts at 2 MB and ends at 3.1 MB (the end of the archive), then
        /// the x-amz-sha256-tree-hash is returned as a response header.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property ContentRange. 
        /// <para>
        /// The range of bytes returned by Amazon S3 Glacier. If only partial output is downloaded,
        /// the response provides the range of bytes Amazon S3 Glacier returned. For example,
        /// bytes 0-1048575/8388608 returns the first 1 MB from 8 MB.
        /// </para>
        /// </summary>
        public string ContentRange
        {
            get { return this._contentRange; }
            set { this._contentRange = value; }
        }

        // Check to see if ContentRange property is set
        internal bool IsSetContentRange()
        {
            return this._contentRange != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The Content-Type depends on whether the job output is an archive or a vault inventory.
        /// For archive data, the Content-Type is application/octet-stream. For vault inventory,
        /// if you requested CSV format when you initiated the job, the Content-Type is text/csv.
        /// Otherwise, by default, vault inventory is returned as JSON, and the Content-Type is
        /// application/json.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP response code for a job output request. The value depends on whether a range
        /// was specified in the request.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
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
                this._body?.Dispose();
                this._body = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}