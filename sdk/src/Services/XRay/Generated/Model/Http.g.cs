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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Information about an HTTP request.
    /// </summary>
    public partial class Http
    {
        /// <summary>
        /// Gets and sets the property ClientIp. 
        /// <para>
        /// The IP address of the requestor.
        /// </para>
        /// </summary>
        public string ClientIp { get; set; }

        /// <summary>
        /// Checks to see if the ClientIp property is set.
        /// </summary>
        internal bool IsSetClientIp() => this.ClientIp != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The request method.
        /// </para>
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property HttpStatus. 
        /// <para>
        /// The response status.
        /// </para>
        /// </summary>
        public int? HttpStatus { get; set; }

        /// <summary>
        /// Checks to see if the HttpStatus property is set.
        /// </summary>
        internal bool IsSetHttpStatus() => this.HttpStatus.HasValue;

        /// <summary>
        /// Gets and sets the property HttpURL. 
        /// <para>
        /// The request URL.
        /// </para>
        /// </summary>
        public string HttpURL { get; set; }

        /// <summary>
        /// Checks to see if the HttpURL property is set.
        /// </summary>
        internal bool IsSetHttpURL() => this.HttpURL != null;

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The request's user agent string.
        /// </para>
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;
    }
}
