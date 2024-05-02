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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that controls:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Whether CloudFront replaces HTTP status codes in the 4xx and 5xx range with custom
    /// error messages before returning the response to the viewer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How long CloudFront caches HTTP status codes in the 4xx and 5xx range.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about custom error pages, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html">Customizing
    /// Error Responses</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CustomErrorResponse
    {
        private long? _errorCachingMinTTL;
        private int? _errorCode;
        private string _responseCode;
        private string _responsePagePath;

        /// <summary>
        /// Gets and sets the property ErrorCachingMinTTL. 
        /// <para>
        /// The minimum amount of time, in seconds, that you want CloudFront to cache the HTTP
        /// status code specified in <c>ErrorCode</c>. When this time period has elapsed, CloudFront
        /// queries your origin to see whether the problem that caused the error has been resolved
        /// and the requested object is now available.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html">Customizing
        /// Error Responses</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public long? ErrorCachingMinTTL
        {
            get { return this._errorCachingMinTTL; }
            set { this._errorCachingMinTTL = value; }
        }

        // Check to see if ErrorCachingMinTTL property is set
        internal bool IsSetErrorCachingMinTTL()
        {
            return this._errorCachingMinTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The HTTP status code for which you want to specify a custom error page and/or a caching
        /// duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// The HTTP status code that you want CloudFront to return to the viewer along with the
        /// custom error page. There are a variety of reasons that you might want CloudFront to
        /// return a status code different from the status code that your origin returned to CloudFront,
        /// for example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Some Internet devices (some firewalls and corporate proxies, for example) intercept
        /// HTTP 4xx and 5xx and prevent the response from being returned to the viewer. If you
        /// substitute <c>200</c>, the response typically won't be intercepted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't care about distinguishing among different client errors or server errors,
        /// you can specify <c>400</c> or <c>500</c> as the <c>ResponseCode</c> for all 4xx or
        /// 5xx errors.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You might want to return a <c>200</c> status code (OK) and static website so your
        /// customers don't know that your website is down.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify a value for <c>ResponseCode</c>, you must also specify a value for
        /// <c>ResponsePagePath</c>.
        /// </para>
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
        /// Gets and sets the property ResponsePagePath. 
        /// <para>
        /// The path to the custom error page that you want CloudFront to return to a viewer when
        /// your origin returns the HTTP status code specified by <c>ErrorCode</c>, for example,
        /// <c>/4xx-errors/403-forbidden.html</c>. If you want to store your objects and your
        /// custom error pages in different locations, your distribution must include a cache
        /// behavior for which the following is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <c>PathPattern</c> matches the path to your custom error messages. For
        /// example, suppose you saved custom error pages for 4xx errors in an Amazon S3 bucket
        /// in a directory named <c>/4xx-errors</c>. Your distribution must include a cache behavior
        /// for which the path pattern routes requests for your custom error pages to that location,
        /// for example, <c>/4xx-errors/*</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>TargetOriginId</c> specifies the value of the <c>ID</c> element for
        /// the origin that contains your custom error pages.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify a value for <c>ResponsePagePath</c>, you must also specify a value
        /// for <c>ResponseCode</c>.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you store custom error pages in an Amazon S3 bucket. If you store
        /// custom error pages on an HTTP server and the server starts to return 5xx errors, CloudFront
        /// can't get the files that you want to return to viewers because the origin server is
        /// unavailable.
        /// </para>
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