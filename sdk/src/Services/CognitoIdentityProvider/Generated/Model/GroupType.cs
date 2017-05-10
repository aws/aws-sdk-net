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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The group type.
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
        /// The date the group was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
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
        /// A string containing the description of the group.
        /// </para>
        /// </summary>
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
        /// The date the group was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
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
        /// A nonnegative integer value that specifies the precedence of this group relative to
        /// the other groups that a user can belong to in the user pool. If a user belongs to
        /// two or more groups, it is the group with the highest precedence whose role ARN will
        /// be used in the <code>cognito:roles</code> and <code>cognito:preferred_role</code>
        /// claims in the user's tokens. Groups with higher <code>Precedence</code> values take
        /// precedence over groups with lower <code>Precedence</code> values or with null <code>Precedence</code>
        /// values.
        /// </para>
        ///  
        /// <para>
        /// Two groups can have the same <code>Precedence</code> value. If this happens, neither
        /// group takes precedence over the other. If two groups with the same <code>Precedence</code>
        /// have the same role ARN, that role is used in the <code>cognito:preferred_role</code>
        /// claim in tokens for users in each group. If the two groups have different role ARNs,
        /// the <code>cognito:preferred_role</code> claim is not set in users' tokens.
        /// </para>
        ///  
        /// <para>
        /// The default <code>Precedence</code> value is null.
        /// </para>
        /// </summary>
        public int Precedence
        {
            get { return this._precedence.GetValueOrDefault(); }
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
        /// The role ARN for the group.
        /// </para>
        /// </summary>
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
        /// The user pool ID for the user pool.
        /// </para>
        /// </summary>
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