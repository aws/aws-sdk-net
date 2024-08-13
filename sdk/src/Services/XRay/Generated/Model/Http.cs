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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
        private string _clientIp;
        private string _httpMethod;
        private int? _httpStatus;
        private string _httpURL;
        private string _userAgent;

        /// <summary>
        /// Gets and sets the property ClientIp. 
        /// <para>
        /// The IP address of the requestor.
        /// </para>
        /// </summary>
        public string ClientIp
        {
            get { return this._clientIp; }
            set { this._clientIp = value; }
        }

        // Check to see if ClientIp property is set
        internal bool IsSetClientIp()
        {
            return this._clientIp != null;
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The request method.
        /// </para>
        /// </summary>
        public string HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property HttpStatus. 
        /// <para>
        /// The response status.
        /// </para>
        /// </summary>
        public int? HttpStatus
        {
            get { return this._httpStatus; }
            set { this._httpStatus = value; }
        }

        // Check to see if HttpStatus property is set
        internal bool IsSetHttpStatus()
        {
            return this._httpStatus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpURL. 
        /// <para>
        /// The request URL.
        /// </para>
        /// </summary>
        public string HttpURL
        {
            get { return this._httpURL; }
            set { this._httpURL = value; }
        }

        // Check to see if HttpURL property is set
        internal bool IsSetHttpURL()
        {
            return this._httpURL != null;
        }

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The request's user agent string.
        /// </para>
        /// </summary>
        public string UserAgent
        {
            get { return this._userAgent; }
            set { this._userAgent = value; }
        }

        // Check to see if UserAgent property is set
        internal bool IsSetUserAgent()
        {
            return this._userAgent != null;
        }

    }
}