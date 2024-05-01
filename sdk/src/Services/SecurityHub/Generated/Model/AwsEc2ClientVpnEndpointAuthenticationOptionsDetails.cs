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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the authentication method used by the Client VPN endpoint.
    /// </summary>
    public partial class AwsEc2ClientVpnEndpointAuthenticationOptionsDetails
    {
        private AwsEc2ClientVpnEndpointAuthenticationOptionsActiveDirectoryDetails _activeDirectory;
        private AwsEc2ClientVpnEndpointAuthenticationOptionsFederatedAuthenticationDetails _federatedAuthentication;
        private AwsEc2ClientVpnEndpointAuthenticationOptionsMutualAuthenticationDetails _mutualAuthentication;
        private string _type;

        /// <summary>
        /// Gets and sets the property ActiveDirectory. 
        /// <para>
        ///  Information about the Active Directory, if applicable. With Active Directory authentication,
        /// clients are authenticated against existing Active Directory groups. 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointAuthenticationOptionsActiveDirectoryDetails ActiveDirectory
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
        ///  Information about the IAM SAML identity provider, if applicable.
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointAuthenticationOptionsFederatedAuthenticationDetails FederatedAuthentication
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
        ///  Information about the authentication certificates, if applicable.
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointAuthenticationOptionsMutualAuthenticationDetails MutualAuthentication
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
        ///  The authentication type used. 
        /// </para>
        /// </summary>
        public string Type
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