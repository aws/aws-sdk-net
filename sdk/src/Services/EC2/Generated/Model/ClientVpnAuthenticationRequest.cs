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
    /// Describes the authentication method to be used by a Client VPN endpoint. For more
    /// information, see <a href="https://docs.aws.amazon.com/vpn/latest/clientvpn-admin/authentication-authrization.html#client-authentication">Authentication</a>
    /// in the <i>Client VPN Administrator Guide</i>.
    /// </summary>
    public partial class ClientVpnAuthenticationRequest
    {
        private DirectoryServiceAuthenticationRequest _activeDirectory;
        private FederatedAuthenticationRequest _federatedAuthentication;
        private CertificateAuthenticationRequest _mutualAuthentication;
        private ClientVpnAuthenticationType _type;

        /// <summary>
        /// Gets and sets the property ActiveDirectory. 
        /// <para>
        /// Information about the Active Directory to be used, if applicable. You must provide
        /// this information if <b>Type</b> is <c>directory-service-authentication</c>.
        /// </para>
        /// </summary>
        public DirectoryServiceAuthenticationRequest ActiveDirectory
        {
            get { return this._activeDirectory; }
            set { this._activeDirectory = value; }
        }

        // Check to see if ActiveDirectory property is set
        internal bool IsSetActiveDirectory()
        {
            return this._activeDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property FederatedAuthentication. 
        /// <para>
        /// Information about the IAM SAML identity provider to be used, if applicable. You must
        /// provide this information if <b>Type</b> is <c>federated-authentication</c>.
        /// </para>
        /// </summary>
        public FederatedAuthenticationRequest FederatedAuthentication
        {
            get { return this._federatedAuthentication; }
            set { this._federatedAuthentication = value; }
        }

        // Check to see if FederatedAuthentication property is set
        internal bool IsSetFederatedAuthentication()
        {
            return this._federatedAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property MutualAuthentication. 
        /// <para>
        /// Information about the authentication certificates to be used, if applicable. You must
        /// provide this information if <b>Type</b> is <c>certificate-authentication</c>.
        /// </para>
        /// </summary>
        public CertificateAuthenticationRequest MutualAuthentication
        {
            get { return this._mutualAuthentication; }
            set { this._mutualAuthentication = value; }
        }

        // Check to see if MutualAuthentication property is set
        internal bool IsSetMutualAuthentication()
        {
            return this._mutualAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of client authentication to be used.
        /// </para>
        /// </summary>
        public ClientVpnAuthenticationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}