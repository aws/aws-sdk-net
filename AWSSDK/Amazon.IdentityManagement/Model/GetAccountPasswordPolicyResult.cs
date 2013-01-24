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
    /// <summary>Get Account Password Policy Result
    /// </summary>
    public class GetAccountPasswordPolicyResult  
    {
        
        private PasswordPolicy passwordPolicy;
        public PasswordPolicy PasswordPolicy
        {
            get { return this.passwordPolicy; }
            set { this.passwordPolicy = value; }
        }

        /// <summary>
        /// Sets the PasswordPolicy property
        /// </summary>
        /// <param name="passwordPolicy">The value to set for the PasswordPolicy property </param>
        /// <returns>this instance</returns>
        public GetAccountPasswordPolicyResult WithPasswordPolicy(PasswordPolicy passwordPolicy)
        {
            this.passwordPolicy = passwordPolicy;
            return this;
        }
            

        // Check to see if PasswordPolicy property is set
        internal bool IsSetPasswordPolicy()
        {
            return this.passwordPolicy != null;       
        }
    }
}
