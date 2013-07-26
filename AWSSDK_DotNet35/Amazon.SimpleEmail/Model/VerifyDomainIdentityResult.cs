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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents a token used for domain ownership verification.</para>
    /// </summary>
    public partial class VerifyDomainIdentityResult : AmazonWebServiceResponse
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

        // Check to see if VerificationToken property is set
        internal bool IsSetVerificationToken()
        {
            return this.verificationToken != null;
        }
    }
}
