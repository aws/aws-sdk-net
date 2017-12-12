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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the DescribeUser operation.
    /// </summary>
    public partial class DescribeUserResponse : AmazonWebServiceResponse
    {
        private DateTime? _disabledDate;
        private string _displayName;
        private string _email;
        private DateTime? _enabledDate;
        private string _name;
        private EntityState _state;
        private string _userId;
        private UserRole _userRole;

        /// <summary>
        /// Gets and sets the property DisabledDate. 
        /// <para>
        /// The date and time at which the user was disabled for Amazon WorkMail usage, in UNIX
        /// epoch time format.
        /// </para>
        /// </summary>
        public DateTime DisabledDate
        {
            get { return this._disabledDate.GetValueOrDefault(); }
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
        /// The date and time at which the user was enabled for Amazon WorkMail usage, in UNIX
        /// epoch time format.
        /// </para>
        /// </summary>
        public DateTime EnabledDate
        {
            get { return this._enabledDate.GetValueOrDefault(); }
            set { this._enabledDate = value; }
        }

        // Check to see if EnabledDate property is set
        internal bool IsSetEnabledDate()
        {
            return this._enabledDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the user.
        /// </para>
        /// </summary>
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
        /// The state of a user: enabled (registered to Amazon WorkMail) or disabled (deregistered
        /// or never registered to Amazon WorkMail).
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
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier for the described user.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property UserRole. 
        /// <para>
        /// In certain cases other entities are modeled as users. If interoperability is enabled,
        /// resources are imported into Amazon WorkMail as users. Because different Amazon WorkMail
        /// organizations rely on different directory types, administrators can distinguish between
        /// a user that is not registered to Amazon WorkMail (is disabled and has a user role)
        /// and the administrative users of the directory. The values are USER, RESOURCE, and
        /// SYSTEM_USER.
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