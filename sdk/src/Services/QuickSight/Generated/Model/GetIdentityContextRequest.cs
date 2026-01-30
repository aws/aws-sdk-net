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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the GetIdentityContext operation.
    /// Retrieves the identity context for a Quick Sight user in a specified namespace, allowing
    /// you to obtain identity tokens that can be used with identity-enhanced IAM role sessions
    /// to call identity-aware APIs.
    /// 
    ///  
    /// <para>
    /// Currently, you can call the following APIs with identity-enhanced Credentials
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_StartDashboardSnapshotJob.html">StartDashboardSnapshotJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeDashboardSnapshotJob.html">DescribeDashboardSnapshotJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeDashboardSnapshotJobResult.html">DescribeDashboardSnapshotJobResult</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Supported Authentication Methods</b> 
    /// </para>
    ///  
    /// <para>
    /// This API supports Quick Sight native users, IAM federated users, and Active Directory
    /// users. For Quick Sight users authenticated by Amazon Web Services Identity Center,
    /// see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-identity-enhanced-iam-role-sessions.html">Identity
    /// Center documentation on identity-enhanced IAM role sessions</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Supported Regions</b> 
    /// </para>
    ///  
    /// <para>
    /// The GetIdentityContext API works only in regions that support at least one of these
    /// identity types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Quick Sight native identity
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IAM federated identity
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Active Directory
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To use this API successfully, call it in the same region where your user's identity
    /// resides. For example, if your user's identity is in us-east-1, make the API call in
    /// us-east-1. For more information about managing identities in Amazon Quick Sight, see
    /// <a href="https://docs.aws.amazon.com/quicksight/latest/userguide/identity.html">Identity
    /// and access management in Amazon Quick Sight</a> in the Amazon Quick Sight User Guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>Getting Identity-Enhanced Credentials</b> 
    /// </para>
    ///  
    /// <para>
    /// To obtain identity-enhanced credentials, follow these steps:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Call the GetIdentityContext API to retrieve an identity token for the specified user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the identity token with the <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRole.html">STS
    /// AssumeRole API</a> to obtain identity-enhanced IAM role session credentials.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Usage with STS AssumeRole</b> 
    /// </para>
    ///  
    /// <para>
    /// The identity token returned by this API should be used with the STS AssumeRole API
    /// to obtain credentials for an identity-enhanced IAM role session. When calling AssumeRole,
    /// include the identity token in the <c>ProvidedContexts</c> parameter with <c>ProviderArn</c>
    /// set to <c>arn:aws:iam::aws:contextProvider/QuickSight</c> and <c>ContextAssertion</c>
    /// set to the identity token received from this API.
    /// </para>
    ///  
    /// <para>
    /// The assumed role must allow the <c>sts:SetContext</c> action in addition to <c>sts:AssumeRole</c>
    /// in its trust relationship policy. The trust policy should include both actions for
    /// the principal that will be assuming the role.
    /// </para>
    /// </summary>
    public partial class GetIdentityContextRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _awsNamespace;
        private DateTime? _sessionExpiresAt;
        private UserIdentifier _userIdentifier;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that the user whose identity context you
        /// want to retrieve is in. Currently, you use the ID for the Amazon Web Services account
        /// that contains your Quick Sight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the user that you want to get identity context for. This parameter
        /// is required when the UserIdentifier is specified using Email or UserName.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property SessionExpiresAt. 
        /// <para>
        /// The timestamp at which the session will expire.
        /// </para>
        /// </summary>
        public DateTime SessionExpiresAt
        {
            get { return this._sessionExpiresAt.GetValueOrDefault(); }
            set { this._sessionExpiresAt = value; }
        }

        // Check to see if SessionExpiresAt property is set
        internal bool IsSetSessionExpiresAt()
        {
            return this._sessionExpiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserIdentifier. 
        /// <para>
        /// The identifier for the user whose identity context you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserIdentifier UserIdentifier
        {
            get { return this._userIdentifier; }
            set { this._userIdentifier = value; }
        }

        // Check to see if UserIdentifier property is set
        internal bool IsSetUserIdentifier()
        {
            return this._userIdentifier != null;
        }

    }
}