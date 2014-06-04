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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Contains the result of a successful call to the <a>AssumeRoleWithWebIdentity</a> action,
    ///      including temporary AWS credentials that can be used to make AWS requests.
    /// </summary>
    public partial class AssumeRoleWithWebIdentityResult
    {
        private AssumedRoleUser _assumedRoleUser;
        private string _audience;
        private Credentials _credentials;
        private int? _packedPolicySize;
        private string _provider;
        private string _subjectFromWebIdentityToken;


        /// <summary>
        /// Gets and sets the property AssumedRoleUser. 
        /// <para>
        /// The Amazon Resource Name (ARN) and the assumed role ID, which are identifiers that
        /// you can      use to refer to the resulting temporary security credentials. For example,
        /// you can reference      these credentials as a principal in a resource-based policy
        /// by using the ARN or assumed role      ID. The ARN and ID include the <code>RoleSessionName</code>
        /// that you specified when you called        <code>AssumeRole</code>. 
        /// </para>
        /// </summary>
        public AssumedRoleUser AssumedRoleUser
        {
            get { return this._assumedRoleUser; }
            set { this._assumedRoleUser = value; }
        }


        /// <summary>
        /// Sets the AssumedRoleUser property
        /// </summary>
        /// <param name="assumedRoleUser">The value to set for the AssumedRoleUser property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithWebIdentityResult WithAssumedRoleUser(AssumedRoleUser assumedRoleUser)
        {
            this._assumedRoleUser = assumedRoleUser;
            return this;
        }

        // Check to see if AssumedRoleUser property is set
        internal bool IsSetAssumedRoleUser()
        {
            return this._assumedRoleUser != null;
        }


        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        ///  The intended audience of the web identity token. This is traditionally the      
        ///    client identifier issued to the application that requested the web identity token.
        /// </para>
        /// </summary>
        public string Audience
        {
            get { return this._audience; }
            set { this._audience = value; }
        }


        /// <summary>
        /// Sets the Audience property
        /// </summary>
        /// <param name="audience">The value to set for the Audience property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithWebIdentityResult WithAudience(string audience)
        {
            this._audience = audience;
            return this;
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
        /// key, and      a security token.
        /// </para>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }


        /// <summary>
        /// Sets the Credentials property
        /// </summary>
        /// <param name="credentials">The value to set for the Credentials property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithWebIdentityResult WithCredentials(Credentials credentials)
        {
            this._credentials = credentials;
            return this;
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }


        /// <summary>
        /// Gets and sets the property PackedPolicySize. 
        /// <para>
        /// A percentage value that indicates the size of the policy in packed form. The service
        /// rejects      any policy with a packed size greater than 100 percent, which means the
        /// policy exceeded the      allowed space. 
        /// </para>
        /// </summary>
        public int PackedPolicySize
        {
            get { return this._packedPolicySize.GetValueOrDefault(); }
            set { this._packedPolicySize = value; }
        }


        /// <summary>
        /// Sets the PackedPolicySize property
        /// </summary>
        /// <param name="packedPolicySize">The value to set for the PackedPolicySize property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithWebIdentityResult WithPackedPolicySize(int packedPolicySize)
        {
            this._packedPolicySize = packedPolicySize;
            return this;
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
        /// Tokens this contains          the value of the <code>iss</code> field. For OAuth 2.0
        /// Access Tokens, this contains the value of the          <code>ProviderId</code> parameter
        /// that was passed in the <code>AssumeRoleWithWebIdentity</code> request.
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }


        /// <summary>
        /// Sets the Provider property
        /// </summary>
        /// <param name="provider">The value to set for the Provider property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithWebIdentityResult WithProvider(string provider)
        {
            this._provider = provider;
            return this;
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }


        /// <summary>
        /// Gets and sets the property SubjectFromWebIdentityToken. 
        /// <para>
        /// The unique user identifier that is returned by the identity provider. This identifier
        /// is      associated with the <code>WebIdentityToken</code> that was submitted with
        /// the        <code>AssumeRoleWithWebIdentity</code> call. The identifier is typically
        /// unique to the user      and the application that acquired the <code>WebIdentityToken</code>
        /// (pairwise identifier). If      an OpenID Connect ID token was submitted in the <code>WebIdentityToken</code>,
        /// this value is      returned by the identity provider as the token's <code>sub</code>
        /// (Subject) claim. 
        /// </para>
        /// </summary>
        public string SubjectFromWebIdentityToken
        {
            get { return this._subjectFromWebIdentityToken; }
            set { this._subjectFromWebIdentityToken = value; }
        }


        /// <summary>
        /// Sets the SubjectFromWebIdentityToken property
        /// </summary>
        /// <param name="subjectFromWebIdentityToken">The value to set for the SubjectFromWebIdentityToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleWithWebIdentityResult WithSubjectFromWebIdentityToken(string subjectFromWebIdentityToken)
        {
            this._subjectFromWebIdentityToken = subjectFromWebIdentityToken;
            return this;
        }

        // Check to see if SubjectFromWebIdentityToken property is set
        internal bool IsSetSubjectFromWebIdentityToken()
        {
            return this._subjectFromWebIdentityToken != null;
        }

    }
}