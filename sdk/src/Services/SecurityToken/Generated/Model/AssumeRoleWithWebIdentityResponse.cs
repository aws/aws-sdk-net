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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Contains the response to a successful <a>AssumeRoleWithWebIdentity</a> request, including
    /// temporary Amazon Web Services credentials that can be used to make Amazon Web Services
    /// requests.
    /// </summary>
    public partial class AssumeRoleWithWebIdentityResponse : AmazonWebServiceResponse
    {
        private AssumedRoleUser _assumedRoleUser;
        private string _audience;
        private Credentials _credentials;
        private int? _packedPolicySize;
        private string _provider;
        private string _sourceIdentity;
        private string _subjectFromWebIdentityToken;

        /// <summary>
        /// Gets and sets the property AssumedRoleUser. 
        /// <para>
        /// The Amazon Resource Name (ARN) and the assumed role ID, which are identifiers that
        /// you can use to refer to the resulting temporary security credentials. For example,
        /// you can reference these credentials as a principal in a resource-based policy by using
        /// the ARN or assumed role ID. The ARN and ID include the <c>RoleSessionName</c> that
        /// you specified when you called <c>AssumeRole</c>. 
        /// </para>
        /// </summary>
        public AssumedRoleUser AssumedRoleUser
        {
            get { return this._assumedRoleUser; }
            set { this._assumedRoleUser = value; }
        }

        // Check to see if AssumedRoleUser property is set
        internal bool IsSetAssumedRoleUser()
        {
            return this._assumedRoleUser != null;
        }

        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        /// The intended audience (also known as client ID) of the web identity token. This is
        /// traditionally the client identifier issued to the application that requested the web
        /// identity token.
        /// </para>
        /// </summary>
        public string Audience
        {
            get { return this._audience; }
            set { this._audience = value; }
        }

        // Check to see if Audience property is set
        internal bool IsSetAudience()
        {
            return this._audience != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary security credentials, which include an access key ID, a secret access
        /// key, and a security token.
        /// </para>
        ///  <note> 
        /// <para>
        /// The size of the security token that STS API operations return is not fixed. We strongly
        /// recommend that you make no assumptions about the maximum size.
        /// </para>
        ///  </note>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property PackedPolicySize. 
        /// <para>
        /// A percentage value that indicates the packed size of the session policies and session
        /// tags combined passed in the request. The request fails if the packed size is greater
        /// than 100 percent, which means the policies and tags exceeded the allowed space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PackedPolicySize
        {
            get { return this._packedPolicySize; }
            set { this._packedPolicySize = value; }
        }

        // Check to see if PackedPolicySize property is set
        internal bool IsSetPackedPolicySize()
        {
            return this._packedPolicySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        ///  The issuing authority of the web identity token presented. For OpenID Connect ID
        /// tokens, this contains the value of the <c>iss</c> field. For OAuth 2.0 access tokens,
        /// this contains the value of the <c>ProviderId</c> parameter that was passed in the
        /// <c>AssumeRoleWithWebIdentity</c> request.
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIdentity. 
        /// <para>
        /// The value of the source identity that is returned in the JSON web token (JWT) from
        /// the identity provider.
        /// </para>
        ///  
        /// <para>
        /// You can require users to set a source identity value when they assume a role. You
        /// do this by using the <c>sts:SourceIdentity</c> condition key in a role trust policy.
        /// That way, actions that are taken with the role are associated with that user. After
        /// the source identity is set, the value cannot be changed. It is present in the request
        /// for all actions that are taken by the role and persists across <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html#id_roles_terms-and-concepts">chained
        /// role</a> sessions. You can configure your identity provider to use an attribute associated
        /// with your users, like user name or email, as the source identity when calling <c>AssumeRoleWithWebIdentity</c>.
        /// You do this by adding a claim to the JSON web token. To learn more about OIDC tokens
        /// and claims, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-using-tokens-with-identity-providers.html">Using
        /// Tokens with User Pools</a> in the <i>Amazon Cognito Developer Guide</i>. For more
        /// information about using source identity, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_monitor.html">Monitor
        /// and control actions taken with assumed roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string SourceIdentity
        {
            get { return this._sourceIdentity; }
            set { this._sourceIdentity = value; }
        }

        // Check to see if SourceIdentity property is set
        internal bool IsSetSourceIdentity()
        {
            return this._sourceIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectFromWebIdentityToken. 
        /// <para>
        /// The unique user identifier that is returned by the identity provider. This identifier
        /// is associated with the <c>WebIdentityToken</c> that was submitted with the <c>AssumeRoleWithWebIdentity</c>
        /// call. The identifier is typically unique to the user and the application that acquired
        /// the <c>WebIdentityToken</c> (pairwise identifier). For OpenID Connect ID tokens, this
        /// field contains the value returned by the identity provider as the token's <c>sub</c>
        /// (Subject) claim. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=255)]
        public string SubjectFromWebIdentityToken
        {
            get { return this._subjectFromWebIdentityToken; }
            set { this._subjectFromWebIdentityToken = value; }
        }

        // Check to see if SubjectFromWebIdentityToken property is set
        internal bool IsSetSubjectFromWebIdentityToken()
        {
            return this._subjectFromWebIdentityToken != null;
        }

    }
}