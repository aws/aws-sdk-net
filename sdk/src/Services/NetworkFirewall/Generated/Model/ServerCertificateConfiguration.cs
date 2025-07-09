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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Configures the Certificate Manager certificates and scope that Network Firewall uses
    /// to decrypt and re-encrypt traffic using a <a>TLSInspectionConfiguration</a>. You can
    /// configure <c>ServerCertificates</c> for inbound SSL/TLS inspection, a <c>CertificateAuthorityArn</c>
    /// for outbound SSL/TLS inspection, or both. For information about working with certificates
    /// for TLS inspection, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection-certificate-requirements.html">
    /// Using SSL/TLS server certficiates with TLS inspection configurations</a> in the <i>Network
    /// Firewall Developer Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// If a server certificate that's associated with your <a>TLSInspectionConfiguration</a>
    /// is revoked, deleted, or expired it can result in client-side TLS errors.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ServerCertificateConfiguration
    {
        private string _certificateAuthorityArn;
        private CheckCertificateRevocationStatusActions _checkCertificateRevocationStatus;
        private List<ServerCertificateScope> _scopes = AWSConfigs.InitializeCollections ? new List<ServerCertificateScope>() : null;
        private List<ServerCertificate> _serverCertificates = AWSConfigs.InitializeCollections ? new List<ServerCertificate>() : null;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the imported certificate authority (CA) certificate
        /// within Certificate Manager (ACM) to use for outbound SSL/TLS inspection.
        /// </para>
        ///  
        /// <para>
        /// The following limitations apply:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use CA certificates that you imported into ACM, but you can't generate CA
        /// certificates with ACM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't use certificates issued by Private Certificate Authority.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about configuring certificates for outbound inspection, see <a
        /// href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection-certificate-requirements.html">Using
        /// SSL/TLS certificates with TLS inspection configurations</a> in the <i>Network Firewall
        /// Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For information about working with certificates in ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// certificates</a> in the <i>Certificate Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property CheckCertificateRevocationStatus. 
        /// <para>
        /// When enabled, Network Firewall checks if the server certificate presented by the server
        /// in the SSL/TLS connection has a revoked or unkown status. If the certificate has an
        /// unknown or revoked status, you must specify the actions that Network Firewall takes
        /// on outbound traffic. To check the certificate revocation status, you must also specify
        /// a <c>CertificateAuthorityArn</c> in <a>ServerCertificateConfiguration</a>.
        /// </para>
        /// </summary>
        public CheckCertificateRevocationStatusActions CheckCertificateRevocationStatus
        {
            get { return this._checkCertificateRevocationStatus; }
            set { this._checkCertificateRevocationStatus = value; }
        }

        // Check to see if CheckCertificateRevocationStatus property is set
        internal bool IsSetCheckCertificateRevocationStatus()
        {
            return this._checkCertificateRevocationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// A list of scopes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerCertificateScope> Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null && (this._scopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerCertificates. 
        /// <para>
        /// The list of server certificates to use for inbound SSL/TLS inspection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerCertificate> ServerCertificates
        {
            get { return this._serverCertificates; }
            set { this._serverCertificates = value; }
        }

        // Check to see if ServerCertificates property is set
        internal bool IsSetServerCertificates()
        {
            return this._serverCertificates != null && (this._serverCertificates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}