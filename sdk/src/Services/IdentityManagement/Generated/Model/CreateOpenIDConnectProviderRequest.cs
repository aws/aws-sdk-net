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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOpenIDConnectProvider operation.
    /// Creates an IAM entity to describe an identity provider (IdP) that supports <a href="http://openid.net/connect/">OpenID
    /// Connect (OIDC)</a>.
    /// 
    ///  
    /// <para>
    /// The OIDC provider that you create with this operation can be used as a principal in
    /// a role's trust policy. Such a policy establishes a trust relationship between AWS
    /// and the OIDC provider.
    /// </para>
    ///  
    /// <para>
    /// When you create the IAM OIDC provider, you specify the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The URL of the OIDC identity provider (IdP) to trust
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A list of client IDs (also known as audiences) that identify the application or applications
    /// that are allowed to authenticate using the OIDC provider
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A list of thumbprints of the server certificate(s) that the IdP uses.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You get all of this information from the OIDC IdP that you want to use to access AWS.
    /// </para>
    ///  <note> 
    /// <para>
    /// Because trust for the OIDC provider is derived from the IAM provider that this operation
    /// creates, it is best to limit access to the <a>CreateOpenIDConnectProvider</a> operation
    /// to highly privileged users.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateOpenIDConnectProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private List<string> _clientIDList = new List<string>();
        private List<string> _thumbprintList = new List<string>();
        private string _url;

        /// <summary>
        /// Gets and sets the property ClientIDList. 
        /// <para>
        /// A list of client IDs (also known as audiences). When a mobile or web app registers
        /// with an OpenID Connect provider, they establish a value that identifies the application.
        /// (This is the value that's sent as the <code>client_id</code> parameter on OAuth requests.)
        /// </para>
        ///  
        /// <para>
        /// You can register multiple client IDs with the same provider. For example, you might
        /// have multiple applications that use the same OIDC provider. You cannot register more
        /// than 100 client IDs with a single IAM OIDC provider.
        /// </para>
        ///  
        /// <para>
        /// There is no defined format for a client ID. The <code>CreateOpenIDConnectProviderRequest</code>
        /// operation accepts client IDs up to 255 characters long.
        /// </para>
        /// </summary>
        public List<string> ClientIDList
        {
            get { return this._clientIDList; }
            set { this._clientIDList = value; }
        }

        // Check to see if ClientIDList property is set
        internal bool IsSetClientIDList()
        {
            return this._clientIDList != null && this._clientIDList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThumbprintList. 
        /// <para>
        /// A list of server certificate thumbprints for the OpenID Connect (OIDC) identity provider's
        /// server certificates. Typically this list includes only one entry. However, IAM lets
        /// you have up to five thumbprints for an OIDC provider. This lets you maintain multiple
        /// thumbprints if the identity provider is rotating certificates.
        /// </para>
        ///  
        /// <para>
        /// The server certificate thumbprint is the hex-encoded SHA-1 hash value of the X.509
        /// certificate used by the domain where the OpenID Connect provider makes its keys available.
        /// It is always a 40-character string.
        /// </para>
        ///  
        /// <para>
        /// You must provide at least one thumbprint when creating an IAM OIDC provider. For example,
        /// assume that the OIDC provider is <code>server.example.com</code> and the provider
        /// stores its keys at https://keys.server.example.com/openid-connect. In that case, the
        /// thumbprint string would be the hex-encoded SHA-1 hash value of the certificate used
        /// by https://keys.server.example.com.
        /// </para>
        ///  
        /// <para>
        /// For more information about obtaining the OIDC provider's thumbprint, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/identity-providers-oidc-obtain-thumbprint.html">Obtaining
        /// the Thumbprint for an OpenID Connect Provider</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> ThumbprintList
        {
            get { return this._thumbprintList; }
            set { this._thumbprintList = value; }
        }

        // Check to see if ThumbprintList property is set
        internal bool IsSetThumbprintList()
        {
            return this._thumbprintList != null && this._thumbprintList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the identity provider. The URL must begin with <code>https://</code> and
        /// should correspond to the <code>iss</code> claim in the provider's OpenID Connect ID
        /// tokens. Per the OIDC standard, path components are allowed but query parameters are
        /// not. Typically the URL consists of only a hostname, like <code>https://server.example.org</code>
        /// or <code>https://example.com</code>.
        /// </para>
        ///  
        /// <para>
        /// You cannot register the same provider multiple times in a single AWS account. If you
        /// try to submit a URL that has already been used for an OpenID Connect provider in the
        /// AWS account, you will get an error.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}