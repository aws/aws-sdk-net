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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a custom error response for a Lightsail distribution. A custom error response
    /// specifies the page that the distribution returns to the viewer. It also specifies
    /// the HTTP status code that the distribution sends when the origin responds with a given
    /// HTTP error code.
    /// </summary>
    public partial class DistributionCustomErrorResponse
    {
        private long? _errorCachingMinTTL;
        private int? _errorCode;
        private string _responseCode;
        private string _responsePagePath;

        /// <summary>
        /// Gets and sets the property ErrorCachingMinTTL. 
        /// <para>
        /// The minimum time, in seconds, that the distribution caches the custom error response
        /// before requesting the object again from the origin. If you don't specify a value,
        /// the default is <c>10</c> seconds.
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
        /// The HTTP error code from the origin that triggers the custom error response (for example,
        /// <c>403</c> or <c>404</c>).
        /// </para>
        /// </summary>
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
        /// The HTTP status code that the distribution returns to the viewer for the custom error
        /// response.
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
        /// The path to the custom error page that the distribution returns to the viewer (for
        /// example, <c>/404.html</c>). The path must begin with a forward slash (<c>/</c>) and
        /// reference an object that is available from the origin.
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