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
    /// A user pool group. Contains details about the group and the way that it contributes
    /// to IAM role decisions with identity pools. Identity pools can make decisions about
    /// the IAM role to assign based on groups: users get credentials for the role associated
    /// with their highest-priority group.
    /// </summary>
    public partial class GroupType
    {
        private DateTime? _creationDate;
        private string _description;
        private string _groupName;
        private DateTime? _lastModifiedDate;
        private int? _precedence;
        private string _roleArn;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A friendly description of the group.
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
        /// The name of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Precedence. 
        /// <para>
        /// A non-negative integer value that specifies the precedence of this group relative
        /// to the other groups that a user can belong to in the user pool. Zero is the highest
        /// precedence value. Groups with lower <c>Precedence</c> values take precedence over
        /// groups with higher ornull <c>Precedence</c> values. If a user belongs to two or more
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
        /// The default <c>Precedence</c> value is <c>null</c>.
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
        /// The ARN of the IAM role associated with the group. If a group has the highest priority
        /// of a user's groups, users who authenticate with an identity pool get credentials for
        /// the <c>RoleArn</c> that's associated with the group.
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
        /// The ID of the user pool that contains the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
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