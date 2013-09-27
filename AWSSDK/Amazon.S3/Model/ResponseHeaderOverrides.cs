/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for values of the response headers that will be set on a response from a GetObject request. 
    /// These values override any headers that were set when the object was uploaded to S3.
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
        /// A standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// </remarks>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        /// <summary>
        /// Sets a standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// </remarks>
        /// <param name="contentType">The content type for the returned object.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResponseHeaderOverrides WithContentType(string contentType)
        {
            this.ContentType = contentType;
            return this;
        }

        /// <summary>
        /// ContentLanguage header value.
        /// </summary>
        public string ContentLanguage
        {
            get { return this._contentLanguage; }
            set { this._contentLanguage = value; }
        }

        /// <summary>
        /// Sets the ContentLanguage header value.
        /// </summary>
        /// <param name="contentLanguage">The content language for the returned object.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResponseHeaderOverrides WithContentLanguage(string contentLanguage)
        {
            this.ContentLanguage = contentLanguage;
            return this;
        }

        /// <summary>
        /// Expiry header value.
        /// </summary>
        public string Expires
        {
            get { return this._expires; }
            set { this._expires = value; }
        }

        /// <summary>
        /// Sets the Expires header value.
        /// </summary>
        /// <param name="expires">The expires for the returned object.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResponseHeaderOverrides WithExpires(string expires)
        {
            this.Expires = expires;
            return this;
        }

        /// <summary>
        /// CacheControl header value.
        /// </summary>
        public string CacheControl
        {
            get { return this._cacheControl; }
            set { this._cacheControl = value; }
        }

        /// <summary>
        /// Sets the CacheControl header value.
        /// </summary>
        /// <param name="cacheControl">The cache control for the returned object.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResponseHeaderOverrides WithCacheControl(string cacheControl)
        {
            this.CacheControl = cacheControl;
            return this;
        }

        /// <summary>
        /// The ContentDisposition header value.
        /// </summary>
        public string ContentDisposition
        {
            get { return this._contentDisposition; }
            set { this._contentDisposition = value; }
        }

        /// <summary>
        /// Sets the ContentDisposition header value.
        /// </summary>
        /// <param name="contentDisposition">The content disposition for the returned object.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResponseHeaderOverrides WithContentDisposition(string contentDisposition)
        {
            this.ContentDisposition = contentDisposition;
            return this;
        }

        /// <summary>
        /// The ContentEncoding header value.
        /// </summary>
        public string ContentEncoding
        {
            get { return this._contentEncoding; }
            set { this._contentEncoding = value; }
        }

        /// <summary>
        /// Sets the ContentEncoding header value.
        /// </summary>
        /// <param name="contentEncoding">The content encoding for the returned object.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResponseHeaderOverrides WithContentEncoding(string contentEncoding)
        {
            this.ContentEncoding = contentEncoding;
            return this;
        }
    }
}
