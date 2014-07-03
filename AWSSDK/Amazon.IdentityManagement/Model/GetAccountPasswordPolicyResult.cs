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
    /// Contains the result of a successful invocation of the <a>GetAccountPasswordPolicy</a>            action.
    /// </summary>
    public partial class GetAccountPasswordPolicyResult
    {
        private PasswordPolicy _passwordPolicy;


        /// <summary>
        /// Gets and sets the property PasswordPolicy.
        /// </summary>
        public PasswordPolicy PasswordPolicy
        {
            get { return this._passwordPolicy; }
            set { this._passwordPolicy = value; }
        }


        /// <summary>
        /// Sets the PasswordPolicy property
        /// </summary>
        /// <param name="passwordPolicy">The value to set for the PasswordPolicy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetAccountPasswordPolicyResult WithPasswordPolicy(PasswordPolicy passwordPolicy)
        {
            this._passwordPolicy = passwordPolicy;
            return this;
        }

        // Check to see if PasswordPolicy property is set
        internal bool IsSetPasswordPolicy()
        {
            return this._passwordPolicy != null;
        }

    }
}