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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportClientVpnClientCertificateRevocationList
    /// operation. Uploads a client certificate revocation list to the specified Client VPN
    /// endpoint. Uploading a client certificate revocation list overwrites the existing client
    /// certificate revocation list. <para> Uploading a client certificate revocation list
    /// resets existing client connections. </para>
    /// </summary>
    public partial class ImportClientVpnClientCertificateRevocationListRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CertificateRevocationList. 
        /// <para>
        /// The client certificate revocation list file. For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/clientvpn-admin/cvpn-working-certificates.html#cvpn-working-certificates-generate">Generate
        /// a Client Certificate Revocation List</a> in the <i>Client VPN Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CertificateRevocationList { get; set; }

        /// <summary>
        /// Checks to see if the CertificateRevocationList property is set.
        /// </summary>
        internal bool IsSetCertificateRevocationList() => this.CertificateRevocationList != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint to which the client certificate revocation list
        /// applies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;
    }
}
