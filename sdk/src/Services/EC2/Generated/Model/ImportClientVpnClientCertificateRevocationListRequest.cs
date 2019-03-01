/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportClientVpnClientCertificateRevocationList operation.
    /// Uploads a client certificate revocation list to the specified Client VPN endpoint.
    /// Uploading a client certificate revocation list overwrites the existing client certificate
    /// revocation list.
    /// 
    ///  
    /// <para>
    /// Uploading a client certificate revocation list resets existing client connections.
    /// </para>
    /// </summary>
    public partial class ImportClientVpnClientCertificateRevocationListRequest : AmazonEC2Request
    {
        private string _certificateRevocationList;
        private string _clientVpnEndpointId;

        /// <summary>
        /// Gets and sets the property CertificateRevocationList. 
        /// <para>
        /// The client certificate revocation list file. For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/clientvpn-admin/cvpn-working-certificates.html#cvpn-working-certificates-generate">Generate
        /// a Client Certificate Revocation List</a> in the <i>AWS Client VPN Administrator Guide</i>.
        /// </para>
        /// </summary>
        public string CertificateRevocationList
        {
            get { return this._certificateRevocationList; }
            set { this._certificateRevocationList = value; }
        }

        // Check to see if CertificateRevocationList property is set
        internal bool IsSetCertificateRevocationList()
        {
            return this._certificateRevocationList != null;
        }

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint to which the client certificate revocation list
        /// applies.
        /// </para>
        /// </summary>
        public string ClientVpnEndpointId
        {
            get { return this._clientVpnEndpointId; }
            set { this._clientVpnEndpointId = value; }
        }

        // Check to see if ClientVpnEndpointId property is set
        internal bool IsSetClientVpnEndpointId()
        {
            return this._clientVpnEndpointId != null;
        }

    }
}