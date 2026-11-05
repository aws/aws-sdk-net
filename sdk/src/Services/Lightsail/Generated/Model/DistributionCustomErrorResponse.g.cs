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
        /// <summary>
        /// Gets and sets the property ErrorCachingMinTTL. 
        /// <para>
        /// The minimum time, in seconds, that the distribution caches the custom error response
        /// before requesting the object again from the origin. If you don't specify a value,
        /// the default is <c>10</c> seconds.
        /// </para>
        /// </summary>
        public long? ErrorCachingMinTTL { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCachingMinTTL property is set.
        /// </summary>
        internal bool IsSetErrorCachingMinTTL() => this.ErrorCachingMinTTL.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The HTTP error code from the origin that triggers the custom error response (for example,
        /// <c>403</c> or <c>404</c>).
        /// </para>
        /// </summary>
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// The HTTP status code that the distribution returns to the viewer for the custom error
        /// response.
        /// </para>
        /// </summary>
        public string ResponseCode { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCode property is set.
        /// </summary>
        internal bool IsSetResponseCode() => this.ResponseCode != null;

        /// <summary>
        /// Gets and sets the property ResponsePagePath. 
        /// <para>
        /// The path to the custom error page that the distribution returns to the viewer (for
        /// example, <c>/404.html</c>). The path must begin with a forward slash (<c>/</c>) and
        /// reference an object that is available from the origin.
        /// </para>
        /// </summary>
        public string ResponsePagePath { get; set; }

        /// <summary>
        /// Checks to see if the ResponsePagePath property is set.
        /// </summary>
        internal bool IsSetResponsePagePath() => this.ResponsePagePath != null;
    }
}
