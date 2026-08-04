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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the reason for an application status check result.
    /// </summary>
    public partial class ApplicationStatusReason
    {
        private string _code;
        private string _protocol;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The reason code for the application status check result. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ResponseCodeMatched</c> – The HTTP status code returned by the health check matched
        /// the configured <c>StatusCodeMatcher</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResponseCodeMismatch</c> – The HTTP status code returned by the health check did
        /// not match the configured <c>StatusCodeMatcher</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConnectionTimeout</c> – The connection to the target timed out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResponseTimeout</c> – The health check timed out while waiting for a response
        /// from the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConnectionRefused</c> – The target refused the health check connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConnectionReset</c> – The target reset the health check connection before returning
        /// a response.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Current health check results use the values in the preceding list. Legacy results
        /// that do not contain structured reason metadata can instead contain a producer error
        /// type, such as <c>Http Status Code</c> or <c>HttpConnectTimeoutException</c>.
        /// </para>
        ///  
        /// <para>
        /// For <c>ResponseCodeMatched</c> and <c>ResponseCodeMismatch</c>, the <c>statusCode</c>
        /// field contains the returned HTTP status code. The <c>protocol</c> field contains the
        /// protocol used for the health check.
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for the health check. Possible values: <c>HTTP</c> and <c>HTTPS</c>.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code returned by the health check.
        /// </para>
        /// </summary>
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}