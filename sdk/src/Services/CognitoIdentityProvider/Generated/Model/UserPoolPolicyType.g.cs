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
    /// A list of user pool policies. Contains the policy that sets password-complexity requirements.
    /// </summary>
    public partial class UserPoolPolicyType
    {
        /// <summary>
        /// Gets and sets the property PasswordPolicy. 
        /// <para>
        /// The password policy settings for a user pool, including complexity, history, and length
        /// requirements.
        /// </para>
        /// </summary>
        public PasswordPolicyType PasswordPolicy { get; set; }

        /// <summary>
        /// Checks to see if the PasswordPolicy property is set.
        /// </summary>
        internal bool IsSetPasswordPolicy() => this.PasswordPolicy != null;

        /// <summary>
        /// Gets and sets the property SignInPolicy. 
        /// <para>
        /// The policy for allowed types of authentication in a user pool.
        /// </para>
        /// </summary>
        public SignInPolicyType SignInPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SignInPolicy property is set.
        /// </summary>
        internal bool IsSetSignInPolicy() => this.SignInPolicy != null;
    }
}
