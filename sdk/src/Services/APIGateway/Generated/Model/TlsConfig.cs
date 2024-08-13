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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Specifies the TLS configuration for an integration.
    /// </summary>
    public partial class TlsConfig
    {
        private bool? _insecureSkipVerification;

        /// <summary>
        /// Gets and sets the property InsecureSkipVerification. 
        /// <para>
        /// Specifies whether or not API Gateway skips verification that the certificate for an
        /// integration endpoint is issued by a supported certificate authority. This isn’t recommended,
        /// but it enables you to use certificates that are signed by private certificate authorities,
        /// or certificates that are self-signed. If enabled, API Gateway still performs basic
        /// certificate validation, which includes checking the certificate's expiration date,
        /// hostname, and presence of a root certificate authority. Supported only for <c>HTTP</c>
        /// and <c>HTTP_PROXY</c> integrations.
        /// </para>
        ///  <important> 
        /// <para>
        /// Enabling <c>insecureSkipVerification</c> isn't recommended, especially for integrations
        /// with public HTTPS endpoints. If you enable <c>insecureSkipVerification</c>, you increase
        /// the risk of man-in-the-middle attacks.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? InsecureSkipVerification
        {
            get { return this._insecureSkipVerification; }
            set { this._insecureSkipVerification = value; }
        }

        // Check to see if InsecureSkipVerification property is set
        internal bool IsSetInsecureSkipVerification()
        {
            return this._insecureSkipVerification.HasValue; 
        }

    }
}