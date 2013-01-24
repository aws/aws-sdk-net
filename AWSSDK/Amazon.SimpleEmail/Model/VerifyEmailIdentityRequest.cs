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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the VerifyEmailIdentity operation.
    /// <para>Verifies an email address. This action causes a confirmation email message to be sent to the specified address.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyEmailIdentity"/>
    public class VerifyEmailIdentityRequest : AmazonWebServiceRequest
    {
        private string emailAddress;

        /// <summary>
        /// The email address to be verified.
        ///  
        /// </summary>
        public string EmailAddress
        {
            get { return this.emailAddress; }
            set { this.emailAddress = value; }
        }

        /// <summary>
        /// Sets the EmailAddress property
        /// </summary>
        /// <param name="emailAddress">The value to set for the EmailAddress property </param>
        /// <returns>this instance</returns>
        public VerifyEmailIdentityRequest WithEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
            return this;
        }
            

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this.emailAddress != null;       
        }
    }
}
    
