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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountPasswordPolicy operation.
    /// <para>Updates the password policy settings for the account. For more information about using a password policy, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html" >Managing an IAM Password Policy</a> .</para>
    /// </summary>
    public partial class UpdateAccountPasswordPolicyRequest : AmazonIdentityManagementServiceRequest
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

        // Check to see if AllowUsersToChangePassword property is set
        internal bool IsSetAllowUsersToChangePassword()
        {
            return this.allowUsersToChangePassword.HasValue;
        }

    }
}
    
