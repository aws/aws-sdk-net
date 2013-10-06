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
    /// <summary>Password Policy
    /// </summary>
    public class PasswordPolicy  
    {
        
        private int? minimumPasswordLength;
        private bool? requireSymbols;
        private bool? requireNumbers;
        private bool? requireUppercaseCharacters;
        private bool? requireLowercaseCharacters;
        private bool? allowUsersToChangePassword;
        public int MinimumPasswordLength
        {
            get { return this.minimumPasswordLength ?? default(int); }
            set { this.minimumPasswordLength = value; }
        }

        /// <summary>
        /// Sets the MinimumPasswordLength property
        /// </summary>
        /// <param name="minimumPasswordLength">The value to set for the MinimumPasswordLength property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordPolicy WithMinimumPasswordLength(int minimumPasswordLength)
        {
            this.minimumPasswordLength = minimumPasswordLength;
            return this;
        }
            

        // Check to see if MinimumPasswordLength property is set
        internal bool IsSetMinimumPasswordLength()
        {
            return this.minimumPasswordLength.HasValue;       
        }
        public bool RequireSymbols
        {
            get { return this.requireSymbols ?? default(bool); }
            set { this.requireSymbols = value; }
        }

        /// <summary>
        /// Sets the RequireSymbols property
        /// </summary>
        /// <param name="requireSymbols">The value to set for the RequireSymbols property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordPolicy WithRequireSymbols(bool requireSymbols)
        {
            this.requireSymbols = requireSymbols;
            return this;
        }
            

        // Check to see if RequireSymbols property is set
        internal bool IsSetRequireSymbols()
        {
            return this.requireSymbols.HasValue;       
        }
        public bool RequireNumbers
        {
            get { return this.requireNumbers ?? default(bool); }
            set { this.requireNumbers = value; }
        }

        /// <summary>
        /// Sets the RequireNumbers property
        /// </summary>
        /// <param name="requireNumbers">The value to set for the RequireNumbers property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordPolicy WithRequireNumbers(bool requireNumbers)
        {
            this.requireNumbers = requireNumbers;
            return this;
        }
            

        // Check to see if RequireNumbers property is set
        internal bool IsSetRequireNumbers()
        {
            return this.requireNumbers.HasValue;       
        }
        public bool RequireUppercaseCharacters
        {
            get { return this.requireUppercaseCharacters ?? default(bool); }
            set { this.requireUppercaseCharacters = value; }
        }

        /// <summary>
        /// Sets the RequireUppercaseCharacters property
        /// </summary>
        /// <param name="requireUppercaseCharacters">The value to set for the RequireUppercaseCharacters property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordPolicy WithRequireUppercaseCharacters(bool requireUppercaseCharacters)
        {
            this.requireUppercaseCharacters = requireUppercaseCharacters;
            return this;
        }
            

        // Check to see if RequireUppercaseCharacters property is set
        internal bool IsSetRequireUppercaseCharacters()
        {
            return this.requireUppercaseCharacters.HasValue;       
        }
        public bool RequireLowercaseCharacters
        {
            get { return this.requireLowercaseCharacters ?? default(bool); }
            set { this.requireLowercaseCharacters = value; }
        }

        /// <summary>
        /// Sets the RequireLowercaseCharacters property
        /// </summary>
        /// <param name="requireLowercaseCharacters">The value to set for the RequireLowercaseCharacters property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordPolicy WithRequireLowercaseCharacters(bool requireLowercaseCharacters)
        {
            this.requireLowercaseCharacters = requireLowercaseCharacters;
            return this;
        }
            

        // Check to see if RequireLowercaseCharacters property is set
        internal bool IsSetRequireLowercaseCharacters()
        {
            return this.requireLowercaseCharacters.HasValue;       
        }
        public bool AllowUsersToChangePassword
        {
            get { return this.allowUsersToChangePassword ?? default(bool); }
            set { this.allowUsersToChangePassword = value; }
        }

        /// <summary>
        /// Sets the AllowUsersToChangePassword property
        /// </summary>
        /// <param name="allowUsersToChangePassword">The value to set for the AllowUsersToChangePassword property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordPolicy WithAllowUsersToChangePassword(bool allowUsersToChangePassword)
        {
            this.allowUsersToChangePassword = allowUsersToChangePassword;
            return this;
        }
            

        // Check to see if AllowUsersToChangePassword property is set
        internal bool IsSetAllowUsersToChangePassword()
        {
            return this.allowUsersToChangePassword.HasValue;       
        }
    }
}
