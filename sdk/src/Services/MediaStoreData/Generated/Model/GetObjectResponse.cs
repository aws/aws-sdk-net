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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// This is the response object from the GetObject operation.
    /// </summary>
    public partial class GetObjectResponse : AmazonWebServiceResponse
    {
        private Stream _body;
        private string _cacheControl;
        private long? _contentLength;
        private string _contentRange;
        private string _contentType;
        private string _eTag;
        private DateTime? _lastModified;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The path to the file outside of the container. The file name can include or omit an
        /// extension. 
        /// </para>
        ///  
        /// <para>
        /// Example 1: If the file is stored on a remote server that has been mounted to the workstation
        /// on which the REST API command is being run, the path could be the absolute path <code>
        /// \mount\assets\mlaw.avi</code> or the relative path <code>..\..\mount\assets\movies\premium\mlaw.avi</code>.
        /// </para>
        ///  
        /// <para>
        /// Example 2: If the file is stored on a remote server that is not mounted, the path
        /// could be <code>https:\\192.0.2.15\movies\premium\mlaw.avi</code>.
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
        /// Gets and sets the property CacheControl. 
        /// <para>
        /// An optional <code>CacheControl</code> header that allows the caller to control the
        /// object's cache behavior. Headers can be passed in as specified in the HTTP spec at
        /// <a href="https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9">https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9</a>.
        /// </para>
        ///  
        /// <para>
        /// Headers with a custom user-defined value are also accepted.
        /// </para>
        /// </summary>
        public string CacheControl
        {
            get { return this._cacheControl; }
            set { this._cacheControl = value; }
        }

        // Check to see if CacheControl property is set
        internal bool IsSetCacheControl()
        {
            return this._cacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        /// The length of the object in bytes.
        /// </para>
        /// </summary>
        public long ContentLength
        {
            get { return this._contentLength.GetValueOrDefault(); }
            set { this._contentLength = value; }
        }

        // Check to see if ContentLength property is set
        internal bool IsSetContentLength()
        {
            return this._contentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentRange. 
        /// <para>
        /// The range of bytes to retrieve.
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
        /// The content type of the object.
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// The ETag that represents a unique instance of the object.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the object was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModified
        {
            get { return this._lastModified.GetValueOrDefault(); }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTML status code of the request. Status codes ranging from 200 to 299 indicate
        /// success. All other status codes indicate the type of error that occurred.
        /// </para>
        /// </summary>
        public int StatusCode
        {
            get { return this._statusCode.GetValueOrDefault(); }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}