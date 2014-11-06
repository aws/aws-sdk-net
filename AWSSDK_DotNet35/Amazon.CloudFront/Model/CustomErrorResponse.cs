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
 * Do not modify this file. This file is generated from the cloudfront-2014-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that describes how you'd prefer CloudFront to respond to requests that
    /// result in either a 4xx or 5xx response. You can control whether a custom error page
    /// should be displayed, what the desired response code should be for this error page
    /// and how long should the error response be cached by CloudFront. If you don't want
    /// to specify any custom error responses, include only an empty CustomErrorResponses
    /// element. To delete all custom error responses in an existing distribution, update
    /// the distribution configuration and include only an empty CustomErrorResponses element.
    /// To add, change, or remove one or more custom error responses, update the distribution
    /// configuration and specify all of the custom error responses that you want to include
    /// in the updated distribution.
    /// </summary>
    public partial class CustomErrorResponse
    {
        private long? _errorCachingMinTTL;
        private int? _errorCode;
        private string _responseCode;
        private string _responsePagePath;

        /// <summary>
        /// Gets and sets the property ErrorCachingMinTTL. The minimum amount of time you want
        /// HTTP error codes to stay in CloudFront caches before CloudFront queries your origin
        /// to see whether the object has been updated. You can specify a value from 0 to 31,536,000.
        /// </summary>
        public long ErrorCachingMinTTL
        {
            get { return this._errorCachingMinTTL.GetValueOrDefault(); }
            set { this._errorCachingMinTTL = value; }
        }

        // Check to see if ErrorCachingMinTTL property is set
        internal bool IsSetErrorCachingMinTTL()
        {
            return this._errorCachingMinTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. The 4xx or 5xx HTTP status code that you want
        /// to customize. For a list of HTTP status codes that you can customize, see CloudFront
        /// documentation.
        /// </summary>
        public int ErrorCode
        {
            get { return this._errorCode.GetValueOrDefault(); }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseCode. The HTTP status code that you want CloudFront
        /// to return with the custom error page to the viewer. For a list of HTTP status codes
        /// that you can replace, see CloudFront Documentation.
        /// </summary>
        public string ResponseCode
        {
            get { return this._responseCode; }
            set { this._responseCode = value; }
        }

        // Check to see if ResponseCode property is set
        internal bool IsSetResponseCode()
        {
            return this._responseCode != null;
        }

        /// <summary>
        /// Gets and sets the property ResponsePagePath. The path of the custom error page (for
        /// example, /custom_404.html). The path is relative to the distribution and must begin
        /// with a slash (/). If the path includes any non-ASCII characters or unsafe characters
        /// as defined in RFC 1783 (http://www.ietf.org/rfc/rfc1738.txt), URL encode those characters.
        /// Do not URL encode any other characters in the path, or CloudFront will not return
        /// the custom error page to the viewer.
        /// </summary>
        public string ResponsePagePath
        {
            get { return this._responsePagePath; }
            set { this._responsePagePath = value; }
        }

        // Check to see if ResponsePagePath property is set
        internal bool IsSetResponsePagePath()
        {
            return this._responsePagePath != null;
        }

    }
}