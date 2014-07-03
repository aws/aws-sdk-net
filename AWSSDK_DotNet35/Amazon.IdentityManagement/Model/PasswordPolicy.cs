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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// The PasswordPolicy data type contains information about the account password policy.
    /// 
    ///         
    /// <para>
    ///  This data type is used as a response element in the action <a>GetAccountPasswordPolicy</a>.        
    /// </para>
    /// </summary>
    public partial class PasswordPolicy
    {
        private bool? _allowUsersToChangePassword;
        private int? _minimumPasswordLength;
        private bool? _requireLowercaseCharacters;
        private bool? _requireNumbers;
        private bool? _requireSymbols;
        private bool? _requireUppercaseCharacters;


        /// <summary>
        /// Gets and sets the property AllowUsersToChangePassword. 
        /// <para>
        /// Specifies whether to allow IAM users to change their own password.
        /// </para>
        /// </summary>
        public bool AllowUsersToChangePassword
        {
            get { return this._allowUsersToChangePassword.GetValueOrDefault(); }
            set { this._allowUsersToChangePassword = value; }
        }

        // Check to see if AllowUsersToChangePassword property is set
        internal bool IsSetAllowUsersToChangePassword()
        {
            return this._allowUsersToChangePassword.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MinimumPasswordLength. 
        /// <para>
        /// Minimum length to require for IAM user passwords.
        /// </para>
        /// </summary>
        public int MinimumPasswordLength
        {
            get { return this._minimumPasswordLength.GetValueOrDefault(); }
            set { this._minimumPasswordLength = value; }
        }

        // Check to see if MinimumPasswordLength property is set
        internal bool IsSetMinimumPasswordLength()
        {
            return this._minimumPasswordLength.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RequireLowercaseCharacters. 
        /// <para>
        /// Specifies whether to require lowercase characters for IAM user passwords.
        /// </para>
        /// </summary>
        public bool RequireLowercaseCharacters
        {
            get { return this._requireLowercaseCharacters.GetValueOrDefault(); }
            set { this._requireLowercaseCharacters = value; }
        }

        // Check to see if RequireLowercaseCharacters property is set
        internal bool IsSetRequireLowercaseCharacters()
        {
            return this._requireLowercaseCharacters.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RequireNumbers. 
        /// <para>
        /// Specifies whether to require numbers for IAM user passwords.
        /// </para>
        /// </summary>
        public bool RequireNumbers
        {
            get { return this._requireNumbers.GetValueOrDefault(); }
            set { this._requireNumbers = value; }
        }

        // Check to see if RequireNumbers property is set
        internal bool IsSetRequireNumbers()
        {
            return this._requireNumbers.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RequireSymbols. 
        /// <para>
        /// Specifies whether to require symbols for IAM user passwords.
        /// </para>
        /// </summary>
        public bool RequireSymbols
        {
            get { return this._requireSymbols.GetValueOrDefault(); }
            set { this._requireSymbols = value; }
        }

        // Check to see if RequireSymbols property is set
        internal bool IsSetRequireSymbols()
        {
            return this._requireSymbols.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RequireUppercaseCharacters. 
        /// <para>
        /// Specifies whether to require uppercase characters for IAM user passwords.
        /// </para>
        /// </summary>
        public bool RequireUppercaseCharacters
        {
            get { return this._requireUppercaseCharacters.GetValueOrDefault(); }
            set { this._requireUppercaseCharacters = value; }
        }

        // Check to see if RequireUppercaseCharacters property is set
        internal bool IsSetRequireUppercaseCharacters()
        {
            return this._requireUppercaseCharacters.HasValue; 
        }

    }
}