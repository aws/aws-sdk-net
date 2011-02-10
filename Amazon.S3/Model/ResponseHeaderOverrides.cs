/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This class contains the values of the response headers that will be set on the 
    /// response from a GetObject request.  These values override any headers that were set
    /// when the object was uploaded to S3.
    /// </summary>
    public class ResponseHeaderOverrides
    {
        internal const string RESPONSE_CONTENT_TYPE = "response-content-type";
        internal const string RESPONSE_CONTENT_LANGUAGE = "response-content-language";
        internal const string RESPONSE_EXPIRES = "response-expires";
        internal const string RESPONSE_CACHE_CONTROL = "response-cache-control";
        internal const string RESPONSE_CONTENT_DISPOSITION = "response-content-disposition";
        internal const string RESPONSE_CONTENT_ENCODING = "response-content-encoding";

        string _contentType;
        string _contentLanguage;
        string _expires;
        string _cacheControl;
        string _contentDisposition;
        string _contentEncoding;


        /// <summary>
        /// Gets or sets the ContentType.
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        /// <summary>
        /// Sets the ContentType property and returns back this instance for method chaining.
        /// </summary>
        /// <param name="contentType">The content type for the returned object.</param>
        /// <returns>this instance</returns>
        public ResponseHeaderOverrides WithContentType(string contentType)
        {
            this.ContentType = contentType;
            return this;
        }

        /// <summary>
        /// Gets or sets the ContentLanguage.
        /// </summary>
        public string ContentLanguage
        {
            get { return this._contentLanguage; }
            set { this._contentLanguage = value; }
        }

        /// <summary>
        /// Sets the ContentLanguage property and returns back this instance for method chaining.
        /// </summary>
        /// <param name="contentLanguage">The content language for the returned object.</param>
        /// <returns>this instance</returns>
        public ResponseHeaderOverrides WithContentLanguage(string contentLanguage)
        {
            this.ContentLanguage = contentLanguage;
            return this;
        }

        /// <summary>
        /// Gets or sets the Expires.
        /// </summary>
        public string Expires
        {
            get { return this._expires; }
            set { this._expires = value; }
        }

        /// <summary>
        /// Sets the Expires property and returns back this instance for method chaining.
        /// </summary>
        /// <param name="expires">The expires for the returned object.</param>
        /// <returns>this instance</returns>
        public ResponseHeaderOverrides WithExpires(string expires)
        {
            this.Expires = expires;
            return this;
        }

        /// <summary>
        /// Gets or sets the CacheControl.
        /// </summary>
        public string CacheControl
        {
            get { return this._cacheControl; }
            set { this._cacheControl = value; }
        }

        /// <summary>
        /// Sets the CacheControl property and returns back this instance for method chaining.
        /// </summary>
        /// <param name="cacheControl">The cache control for the returned object.</param>
        /// <returns>this instance</returns>
        public ResponseHeaderOverrides WithCacheControl(string cacheControl)
        {
            this.CacheControl = cacheControl;
            return this;
        }

        /// <summary>
        /// Gets or sets the ContentDisposition.
        /// </summary>
        public string ContentDisposition
        {
            get { return this._contentDisposition; }
            set { this._contentDisposition = value; }
        }

        /// <summary>
        /// Sets the ContentDisposition property and returns back this instance for method chaining.
        /// </summary>
        /// <param name="contentDisposition">The content disposition for the returned object.</param>
        /// <returns>this instance</returns>
        public ResponseHeaderOverrides WithContentDisposition(string contentDisposition)
        {
            this.ContentDisposition = contentDisposition;
            return this;
        }

        /// <summary>
        /// Gets or sets the ContentEncoding.
        /// </summary>
        public string ContentEncoding
        {
            get { return this._contentEncoding; }
            set { this._contentEncoding = value; }
        }

        /// <summary>
        /// Sets the ContentEncoding property and returns back this instance for method chaining.
        /// </summary>
        /// <param name="contentEncoding">The content encoding for the returned object.</param>
        /// <returns>this instance</returns>
        public ResponseHeaderOverrides WithContentEncoding(string contentEncoding)
        {
            this.ContentEncoding = contentEncoding;
            return this;
        }
    }
}
