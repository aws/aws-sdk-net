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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Verification details to verify registered target domain
    /// </summary>
    public partial class VerificationDetails
    {
        private DnsVerification _dnsTxt;
        private HttpVerification _httpRoute;
        private DomainVerificationMethod _method;

        /// <summary>
        /// Gets and sets the property DnsTxt. 
        /// <para>
        /// Represents dns txt verification details
        /// </para>
        /// </summary>
        public DnsVerification DnsTxt
        {
            get { return this._dnsTxt; }
            set { this._dnsTxt = value; }
        }

        // Check to see if DnsTxt property is set
        internal bool IsSetDnsTxt()
        {
            return this._dnsTxt != null;
        }

        /// <summary>
        /// Gets and sets the property HttpRoute. 
        /// <para>
        /// Represents http route verification details
        /// </para>
        /// </summary>
        public HttpVerification HttpRoute
        {
            get { return this._httpRoute; }
            set { this._httpRoute = value; }
        }

        // Check to see if HttpRoute property is set
        internal bool IsSetHttpRoute()
        {
            return this._httpRoute != null;
        }

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// Type of domain ownership verification method
        /// </para>
        /// </summary>
        public DomainVerificationMethod Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

    }
}