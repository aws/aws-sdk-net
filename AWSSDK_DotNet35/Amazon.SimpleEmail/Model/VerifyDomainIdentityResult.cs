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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents a token used for domain ownership verification.
    /// </summary>
    public partial class VerifyDomainIdentityResult : AmazonWebServiceResponse
    {
        private string _verificationToken;

        /// <summary>
        /// Gets and sets the property VerificationToken. 
        /// <para>
        /// A TXT record that must be placed in the DNS settings for the domain, in order to complete
        /// domain verification.
        /// </para>
        /// </summary>
        public string VerificationToken
        {
            get { return this._verificationToken; }
            set { this._verificationToken = value; }
        }

        // Check to see if VerificationToken property is set
        internal bool IsSetVerificationToken()
        {
            return this._verificationToken != null;
        }

    }
}