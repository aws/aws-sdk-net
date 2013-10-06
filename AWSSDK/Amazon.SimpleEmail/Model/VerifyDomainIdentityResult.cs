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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents a token used for domain ownership verification.</para>
    /// </summary>
    public class VerifyDomainIdentityResult  
    {
        
        private string verificationToken;

        /// <summary>
        /// A TXT record that must be placed in the DNS settings for the domain, in order to complete domain verification.
        ///  
        /// </summary>
        public string VerificationToken
        {
            get { return this.verificationToken; }
            set { this.verificationToken = value; }
        }

        /// <summary>
        /// Sets the VerificationToken property
        /// </summary>
        /// <param name="verificationToken">The value to set for the VerificationToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VerifyDomainIdentityResult WithVerificationToken(string verificationToken)
        {
            this.verificationToken = verificationToken;
            return this;
        }
            

        // Check to see if VerificationToken property is set
        internal bool IsSetVerificationToken()
        {
            return this.verificationToken != null;       
        }
    }
}
