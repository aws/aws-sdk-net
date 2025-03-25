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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGroup operation.
    /// Creates a new group in the specified user pool. For more information about user pool
    /// groups, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-user-groups.html">Adding
    /// groups to a user pool</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateGroupRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _description;
        private string _groupName;
        private int? _precedence;
        private string _roleArn;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the group that you're creating.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// A name for the group. This name must be unique in your user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Precedence. 
        /// <para>
        /// A non-negative integer value that specifies the precedence of this group relative
        /// to the other groups that a user can belong to in the user pool. Zero is the highest
        /// precedence value. Groups with lower <c>Precedence</c> values take precedence over
        /// groups with higher or null <c>Precedence</c> values. If a user belongs to two or more
        /// groups, it is the group with the lowest precedence value whose role ARN is given in
        /// the user's tokens for the <c>cognito:roles</c> and <c>cognito:preferred_role</c> claims.
        /// </para>
        ///  
        /// <para>
        /// Two groups can have the same <c>Precedence</c> value. If this happens, neither group
        /// takes precedence over the other. If two groups with the same <c>Precedence</c> have
        /// the same role ARN, that role is used in the <c>cognito:preferred_role</c> claim in
        /// tokens for users in each group. If the two groups have different role ARNs, the <c>cognito:preferred_role</c>
        /// claim isn't set in users' tokens.
        /// </para>
        ///  
        /// <para>
        /// The default <c>Precedence</c> value is null. The maximum <c>Precedence</c> value is
        /// <c>2^31-1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Precedence
        {
            get { return this._precedence; }
            set { this._precedence = value; }
        }

        // Check to see if Precedence property is set
        internal bool IsSetPrecedence()
        {
            return this._precedence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role that you want to associate with the
        /// group. A group role primarily declares a preferred role for the credentials that you
        /// get from an identity pool. Amazon Cognito ID tokens have a <c>cognito:preferred_role</c>
        /// claim that presents the highest-precedence group that a user belongs to. Both ID and
        /// access tokens also contain a <c>cognito:groups</c> claim that list all the groups
        /// that a user is a member of.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to create a user group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}