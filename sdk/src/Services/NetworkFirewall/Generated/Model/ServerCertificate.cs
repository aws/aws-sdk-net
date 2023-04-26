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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Any Certificate Manager Secure Sockets Layer/Transport Layer Security (SSL/TLS) server
    /// certificate that's associated with a <a>ServerCertificateConfiguration</a> used in
    /// a <a>TLSInspectionConfiguration</a>. You must request or import a SSL/TLS certificate
    /// into ACM for each domain Network Firewall needs to decrypt and inspect. Network Firewall
    /// uses the SSL/TLS certificates to decrypt specified inbound SSL/TLS traffic going to
    /// your firewall. For information about working with certificates in Certificate Manager,
    /// see <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-request-public.html">Request
    /// a public certificate </a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
    /// certificates</a> in the <i>Certificate Manager User Guide</i>.
    /// </summary>
    public partial class ServerCertificate
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Certificate Manager SSL/TLS server certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}