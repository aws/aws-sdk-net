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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A friendly description of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

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
        [AWSProperty(Min = 0)]
        public int? Precedence { get; set; }

        /// <summary>
        /// Checks to see if the Precedence property is set.
        /// </summary>
        internal bool IsSetPrecedence() => this.Precedence.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role associated with the group. If a group has the highest priority
        /// of a user's groups, users who authenticate with an identity pool get credentials for
        /// the <c>RoleArn</c> that's associated with the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
