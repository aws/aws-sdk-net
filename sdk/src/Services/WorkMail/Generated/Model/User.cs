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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// The representation of an WorkMail user.
    /// </summary>
    public partial class User
    {
        private DateTime? _disabledDate;
        private string _displayName;
        private string _email;
        private DateTime? _enabledDate;
        private string _id;
        private string _identityProviderIdentityStoreId;
        private string _identityProviderUserId;
        private string _name;
        private EntityState _state;
        private UserRole _userRole;

        /// <summary>
        /// Gets and sets the property DisabledDate. 
        /// <para>
        /// The date indicating when the user was disabled from WorkMail use.
        /// </para>
        /// </summary>
        public DateTime? DisabledDate
        {
            get { return this._disabledDate; }
            set { this._disabledDate = value; }
        }

        // Check to see if DisabledDate property is set
        internal bool IsSetDisabledDate()
        {
            return this._disabledDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledDate. 
        /// <para>
        /// The date indicating when the user was enabled for WorkMail use.
        /// </para>
        /// </summary>
        public DateTime? EnabledDate
        {
            get { return this._enabledDate; }
            set { this._enabledDate = value; }
        }

        // Check to see if EnabledDate property is set
        internal bool IsSetEnabledDate()
        {
            return this._enabledDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderIdentityStoreId. 
        /// <para>
        /// Identity store ID from the IAM Identity Center. If this parameter is empty it will
        /// be updated automatically when the user logs in for the first time to the mailbox associated
        /// with WorkMail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string IdentityProviderIdentityStoreId
        {
            get { return this._identityProviderIdentityStoreId; }
            set { this._identityProviderIdentityStoreId = value; }
        }

        // Check to see if IdentityProviderIdentityStoreId property is set
        internal bool IsSetIdentityProviderIdentityStoreId()
        {
            return this._identityProviderIdentityStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderUserId. 
        /// <para>
        /// User ID from the IAM Identity Center. If this parameter is empty it will be updated
        /// automatically when the user logs in for the first time to the mailbox associated with
        /// WorkMail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=47)]
        public string IdentityProviderUserId
        {
            get { return this._identityProviderUserId; }
            set { this._identityProviderUserId = value; }
        }

        // Check to see if IdentityProviderUserId property is set
        internal bool IsSetIdentityProviderUserId()
        {
            return this._identityProviderUserId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the user, which can be ENABLED, DISABLED, or DELETED.
        /// </para>
        /// </summary>
        public EntityState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UserRole. 
        /// <para>
        /// The role of the user.
        /// </para>
        /// </summary>
        public UserRole UserRole
        {
            get { return this._userRole; }
            set { this._userRole = value; }
        }

        // Check to see if UserRole property is set
        internal bool IsSetUserRole()
        {
            return this._userRole != null;
        }

    }
}