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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the user name and password create date for a user.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a>CreateLoginProfile</a> and
    /// <a>GetLoginProfile</a> operations. 
    /// </para>
    /// </summary>
    public partial class LoginProfile
    {
        private DateTime? _createDate;
        private bool? _passwordResetRequired;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public LoginProfile() { }

        /// <summary>
        /// Instantiates LoginProfile with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user, which can be used for signing in to the AWS Management Console.</param>
        /// <param name="createDate">The date when the password for the user was created.</param>
        public LoginProfile(string userName, DateTime createDate)
        {
            _userName = userName;
            _createDate = createDate;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the password for the user was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasswordResetRequired. 
        /// <para>
        /// Specifies whether the user is required to set a new password on next sign-in.
        /// </para>
        /// </summary>
        public bool PasswordResetRequired
        {
            get { return this._passwordResetRequired.GetValueOrDefault(); }
            set { this._passwordResetRequired = value; }
        }

        // Check to see if PasswordResetRequired property is set
        internal bool IsSetPasswordResetRequired()
        {
            return this._passwordResetRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user, which can be used for signing in to the AWS Management Console.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}