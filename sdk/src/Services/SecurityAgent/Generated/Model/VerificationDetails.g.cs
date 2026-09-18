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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Contains the verification details for a target domain, including the verification
    /// method and provider-specific details.
    /// </summary>
    public partial class VerificationDetails
    {
        /// <summary>
        /// Gets and sets the property DnsTxt. 
        /// <para>
        /// The DNS TXT verification details.
        /// </para>
        /// </summary>
        public DnsVerification DnsTxt { get; set; }

        /// <summary>
        /// Checks to see if the DnsTxt property is set.
        /// </summary>
        internal bool IsSetDnsTxt() => this.DnsTxt != null;

        /// <summary>
        /// Gets and sets the property HttpRoute. 
        /// <para>
        /// The HTTP route verification details.
        /// </para>
        /// </summary>
        public HttpVerification HttpRoute { get; set; }

        /// <summary>
        /// Checks to see if the HttpRoute property is set.
        /// </summary>
        internal bool IsSetHttpRoute() => this.HttpRoute != null;

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The verification method used for the target domain.
        /// </para>
        /// </summary>
        public DomainVerificationMethod Method { get; set; }

        /// <summary>
        /// Checks to see if the Method property is set.
        /// </summary>
        internal bool IsSetMethod() => this.Method != null;
    }
}
