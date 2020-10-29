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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the GetAuthorizationToken operation.
    /// Generates a temporary authorization token for accessing repositories in the domain.
    /// This API requires the <code>codeartifact:GetAuthorizationToken</code> and <code>sts:GetServiceBearerToken</code>
    /// permissions. For more information about authorization tokens, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/tokens-authentication.html">AWS
    /// CodeArtifact authentication and tokens</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// CodeArtifact authorization tokens are valid for a period of 12 hours when created
    /// with the <code>login</code> command. You can call <code>login</code> periodically
    /// to refresh the token. When you create an authorization token with the <code>GetAuthorizationToken</code>
    /// API, you can set a custom authorization period, up to a maximum of 12 hours, with
    /// the <code>durationSeconds</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// The authorization period begins after <code>login</code> or <code>GetAuthorizationToken</code>
    /// is called. If <code>login</code> or <code>GetAuthorizationToken</code> is called while
    /// assuming a role, the token lifetime is independent of the maximum session duration
    /// of the role. For example, if you call <code>sts assume-role</code> and specify a session
    /// duration of 15 minutes, then generate a CodeArtifact authorization token, the token
    /// will be valid for the full authorization period even though this is longer than the
    /// 15-minute session duration.
    /// </para>
    ///  
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
    /// IAM Roles</a> for more information on controlling session duration. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetAuthorizationTokenRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private long? _durationSeconds;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that is in scope for the generated authorization token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the AWS account that owns the domain. It does not
        /// include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainOwner
        {
            get { return this._domainOwner; }
            set { this._domainOwner = value; }
        }

        // Check to see if DomainOwner property is set
        internal bool IsSetDomainOwner()
        {
            return this._domainOwner != null;
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The time, in seconds, that the generated authorization token is valid. Valid values
        /// are <code>0</code> and any number between <code>900</code> (15 minutes) and <code>43200</code>
        /// (12 hours). A value of <code>0</code> will set the expiration of the authorization
        /// token to the same expiration of the user's role's temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=43200)]
        public long DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

    }
}