/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>The PasswordPolicy data type contains information about the account password policy.</para> <para> This data type is used as a
    /// response element in the action GetAccountPasswordPolicy. </para>
    /// </summary>
    public class PasswordPolicy
    {
        
        private int? minimumPasswordLength;
        private bool? requireSymbols;
        private bool? requireNumbers;
        private bool? requireUppercaseCharacters;
        private bool? requireLowercaseCharacters;
        private bool? allowUsersToChangePassword;
        private bool? expirePasswords;
        private int? maxPasswordAge;


        /// <summary>
        /// Minimum length to require for IAM user passwords.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>6 - 128</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MinimumPasswordLength
        {
            get { return this.minimumPasswordLength ?? default(int); }
            set { this.minimumPasswordLength = value; }
        }

        // Check to see if MinimumPasswordLength property is set
        internal bool IsSetMinimumPasswordLength()
        {
            return this.minimumPasswordLength.HasValue;
        }

        /// <summary>
        /// Specifies whether to require symbols for IAM user passwords.
        ///  
        /// </summary>
        public bool RequireSymbols
        {
            get { return this.requireSymbols ?? default(bool); }
            set { this.requireSymbols = value; }
        }

        // Check to see if RequireSymbols property is set
        internal bool IsSetRequireSymbols()
        {
            return this.requireSymbols.HasValue;
        }

        /// <summary>
        /// Specifies whether to require numbers for IAM user passwords.
        ///  
        /// </summary>
        public bool RequireNumbers
        {
            get { return this.requireNumbers ?? default(bool); }
            set { this.requireNumbers = value; }
        }

        // Check to see if RequireNumbers property is set
        internal bool IsSetRequireNumbers()
        {
            return this.requireNumbers.HasValue;
        }

        /// <summary>
        /// Specifies whether to require uppercase characters for IAM user passwords.
        ///  
        /// </summary>
        public bool RequireUppercaseCharacters
        {
            get { return this.requireUppercaseCharacters ?? default(bool); }
            set { this.requireUppercaseCharacters = value; }
        }

        // Check to see if RequireUppercaseCharacters property is set
        internal bool IsSetRequireUppercaseCharacters()
        {
            return this.requireUppercaseCharacters.HasValue;
        }

        /// <summary>
        /// Specifies whether to require lowercase characters for IAM user passwords.
        ///  
        /// </summary>
        public bool RequireLowercaseCharacters
        {
            get { return this.requireLowercaseCharacters ?? default(bool); }
            set { this.requireLowercaseCharacters = value; }
        }

        // Check to see if RequireLowercaseCharacters property is set
        internal bool IsSetRequireLowercaseCharacters()
        {
            return this.requireLowercaseCharacters.HasValue;
        }

        /// <summary>
        /// Specifies whether to allow IAM users to change their own password.
        ///  
        /// </summary>
        public bool AllowUsersToChangePassword
        {
            get { return this.allowUsersToChangePassword ?? default(bool); }
            set { this.allowUsersToChangePassword = value; }
        }

        // Check to see if AllowUsersToChangePassword property is set
        internal bool IsSetAllowUsersToChangePassword()
        {
            return this.allowUsersToChangePassword.HasValue;
        }
        public bool ExpirePasswords
        {
            get { return this.expirePasswords ?? default(bool); }
            set { this.expirePasswords = value; }
        }

        // Check to see if ExpirePasswords property is set
        internal bool IsSetExpirePasswords()
        {
            return this.expirePasswords.HasValue;
        }
        public int MaxPasswordAge
        {
            get { return this.maxPasswordAge ?? default(int); }
            set { this.maxPasswordAge = value; }
        }

        // Check to see if MaxPasswordAge property is set
        internal bool IsSetMaxPasswordAge()
        {
            return this.maxPasswordAge.HasValue;
        }
    }
}
