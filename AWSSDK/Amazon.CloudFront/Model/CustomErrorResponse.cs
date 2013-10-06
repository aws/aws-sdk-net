/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> A complex type that describes how you'd prefer CloudFront to respond to requests that result in either a 4xx or 5xx response. You can
    /// control whether a custom error page should be displayed, what the desired response code should be for this error page and how long should
    /// the error response be cached by CloudFront. If you don't want to specify any custom error responses, include only an empty
    /// CustomErrorResponses element. To delete all custom error responses in an existing distribution, update the distribution configuration and
    /// include only an empty CustomErrorResponses element. To add, change, or remove one or more custom error responses, update the distribution
    /// configuration and specify all of the custom error responses that you want to include in the updated distribution. </para>
    /// </summary>
    public class CustomErrorResponse
    {
        
        private int? errorCode;
        private string responsePagePath;
        private string responseCode;
        private long? errorCachingMinTTL;

        /// <summary>
        /// The 4xx or 5xx HTTP status code that you want to customize. For a list of HTTP status codes that you can customize, see CloudFront
        /// documentation.
        ///  
        /// </summary>
        public int ErrorCode
        {
            get { return this.errorCode ?? default(int); }
            set { this.errorCode = value; }
        }

        /// <summary>
        /// Sets the ErrorCode property
        /// </summary>
        /// <param name="errorCode">The value to set for the ErrorCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CustomErrorResponse WithErrorCode(int errorCode)
        {
            this.errorCode = errorCode;
            return this;
        }
            

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this.errorCode.HasValue;
        }

        /// <summary>
        /// The path of the custom error page (for example, /custom_404.html). The path is relative to the distribution and must begin with a slash (/).
        /// If the path includes any non-ASCII characters or unsafe characters as defined in RFC 1783 (http://www.ietf.org/rfc/rfc1738.txt), URL encode
        /// those characters. Do not URL encode any other characters in the path, or CloudFront will not return the custom error page to the viewer.
        ///  
        /// </summary>
        public string ResponsePagePath
        {
            get { return this.responsePagePath; }
            set { this.responsePagePath = value; }
        }

        /// <summary>
        /// Sets the ResponsePagePath property
        /// </summary>
        /// <param name="responsePagePath">The value to set for the ResponsePagePath property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CustomErrorResponse WithResponsePagePath(string responsePagePath)
        {
            this.responsePagePath = responsePagePath;
            return this;
        }
            

        // Check to see if ResponsePagePath property is set
        internal bool IsSetResponsePagePath()
        {
            return this.responsePagePath != null;
        }

        /// <summary>
        /// The HTTP status code that you want CloudFront to return with the custom error page to the viewer. For a list of HTTP status codes that you
        /// can replace, see CloudFront Documentation.
        ///  
        /// </summary>
        public string ResponseCode
        {
            get { return this.responseCode; }
            set { this.responseCode = value; }
        }

        /// <summary>
        /// Sets the ResponseCode property
        /// </summary>
        /// <param name="responseCode">The value to set for the ResponseCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CustomErrorResponse WithResponseCode(string responseCode)
        {
            this.responseCode = responseCode;
            return this;
        }
            

        // Check to see if ResponseCode property is set
        internal bool IsSetResponseCode()
        {
            return this.responseCode != null;
        }

        /// <summary>
        /// The minimum amount of time you want HTTP error codes to stay in CloudFront caches before CloudFront queries your origin to see whether the
        /// object has been updated. You can specify a value from 0 to 31,536,000.
        ///  
        /// </summary>
        public long ErrorCachingMinTTL
        {
            get { return this.errorCachingMinTTL ?? default(long); }
            set { this.errorCachingMinTTL = value; }
        }

        /// <summary>
        /// Sets the ErrorCachingMinTTL property
        /// </summary>
        /// <param name="errorCachingMinTTL">The value to set for the ErrorCachingMinTTL property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CustomErrorResponse WithErrorCachingMinTTL(long errorCachingMinTTL)
        {
            this.errorCachingMinTTL = errorCachingMinTTL;
            return this;
        }
            

        // Check to see if ErrorCachingMinTTL property is set
        internal bool IsSetErrorCachingMinTTL()
        {
            return this.errorCachingMinTTL.HasValue;
        }
    }
}
