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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOpenIDConnectProviderThumbprint operation.
    /// Replaces the existing list of server certificate thumbprints associated with an OpenID
    /// Connect (OIDC) provider resource object with a new list of thumbprints.
    /// 
    ///  
    /// <para>
    /// The list that you pass with this operation completely replaces the existing list of
    /// thumbprints. (The lists are not merged.)
    /// </para>
    ///  
    /// <para>
    /// Typically, you need to update a thumbprint only when the identity provider certificate
    /// changes, which occurs rarely. However, if the provider's certificate <i>does</i> change,
    /// any attempt to assume an IAM role that specifies the OIDC provider as a principal
    /// fails until the certificate thumbprint is updated.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Web Services secures communication with some OIDC identity providers (IdPs)
    /// through our library of trusted certificate authorities (CAs) instead of using a certificate
    /// thumbprint to verify your IdP server certificate. These OIDC IdPs include Google,
    /// Auth0, and those that use an Amazon S3 bucket to host a JSON Web Key Set (JWKS) endpoint.
    /// In these cases, your legacy thumbprint remains in your configuration, but is no longer
    /// used for validation.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Trust for the OIDC provider is derived from the provider certificate and is validated
    /// by the thumbprint. Therefore, it is best to limit access to the <code>UpdateOpenIDConnectProviderThumbprint</code>
    /// operation to highly privileged users.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateOpenIDConnectProviderThumbprintRequest : AmazonIdentityManagementServiceRequest
    {
        private string _openIDConnectProviderArn;
        private List<string> _thumbprintList = new List<string>();

        /// <summary>
        /// Gets and sets the property OpenIDConnectProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM OIDC provider resource object for which
        /// you want to update the thumbprint. You can get a list of OIDC provider ARNs by using
        /// the <a>ListOpenIDConnectProviders</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string OpenIDConnectProviderArn
        {
            get { return this._openIDConnectProviderArn; }
            set { this._openIDConnectProviderArn = value; }
        }

        // Check to see if OpenIDConnectProviderArn property is set
        internal bool IsSetOpenIDConnectProviderArn()
        {
            return this._openIDConnectProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbprintList. 
        /// <para>
        /// A list of certificate thumbprints that are associated with the specified IAM OpenID
        /// Connect provider. For more information, see <a>CreateOpenIDConnectProvider</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}