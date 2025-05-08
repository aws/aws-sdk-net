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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the PutApplicationGrant operation.
    /// Creates a configuration for an application to use grants. Conceptually grants are
    /// authorization to request actions related to tokens. This configuration will be used
    /// when parties are requesting and receiving tokens during the trusted identity propagation
    /// process. For more information on the IAM Identity Center supported grant workflows,
    /// see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/customermanagedapps-saml2-oauth2.html">SAML
    /// 2.0 and OAuth 2.0</a>.
    /// 
    ///  
    /// <para>
    /// A grant is created between your applications and Identity Center instance which enables
    /// an application to use specified mechanisms to obtain tokens. These tokens are used
    /// by your applications to gain access to Amazon Web Services resources on behalf of
    /// users. The following elements are within these exchanges:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Requester</b> - The application requesting access to Amazon Web Services resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Subject</b> - Typically the user that is requesting access to Amazon Web Services
    /// resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Grant</b> - Conceptually, a grant is authorization to access Amazon Web Services
    /// resources. These grants authorize token generation for authenticating access to the
    /// requester and for the request to make requests on behalf of the subjects. There are
    /// four types of grants:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>AuthorizationCode</b> - Allows an application to request authorization through
    /// a series of user-agent redirects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>JWT bearer </b> - Authorizes an application to exchange a JSON Web Token that
    /// came from an external identity provider. To learn more, see <a href="https://datatracker.ietf.org/doc/html/rfc6749">RFC
    /// 6479</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Refresh token</b> - Enables application to request new access tokens to replace
    /// expiring or expired access tokens.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Exchange token</b> - A grant that requests tokens from the authorization server
    /// by providing a ‘subject’ token with access scope authorizing trusted identity propagation
    /// to this application. To learn more, see <a href="https://datatracker.ietf.org/doc/html/rfc8693">RFC
    /// 8693</a>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Authorization server</b> - IAM Identity Center requests tokens.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// User credentials are never shared directly within these exchanges. Instead, applications
    /// use grants to request access tokens from IAM Identity Center. For more information,
    /// see <a href="https://datatracker.ietf.org/doc/html/rfc6749">RFC 6479</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Use cases</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Connecting to custom applications.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configuring an Amazon Web Services service to make calls to another Amazon Web Services
    /// services using JWT tokens.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutApplicationGrantRequest : AmazonSSOAdminRequest
    {
        private string _applicationArn;
        private Grant _grant;
        private GrantType _grantType;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// Specifies the ARN of the application to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Grant. 
        /// <para>
        /// Specifies a structure that describes the grant to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Grant Grant
        {
            get { return this._grant; }
            set { this._grant = value; }
        }

        // Check to see if Grant property is set
        internal bool IsSetGrant()
        {
            return this._grant != null;
        }

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// Specifies the type of grant to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GrantType GrantType
        {
            get { return this._grantType; }
            set { this._grantType = value; }
        }

        // Check to see if GrantType property is set
        internal bool IsSetGrantType()
        {
            return this._grantType != null;
        }

    }
}