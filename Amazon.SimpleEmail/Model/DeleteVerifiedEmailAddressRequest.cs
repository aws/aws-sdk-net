/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DeleteVerifiedEmailAddress operation.
    /// <para>Deletes the specified email address from the list of verified
    /// addresses.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.DeleteVerifiedEmailAddress"/>
    public class DeleteVerifiedEmailAddressRequest : AmazonWebServiceRequest
    {
        private string emailAddress;

        /// <summary>
        /// An email address to be removed from the list of verified addreses.
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
        public DeleteVerifiedEmailAddressRequest WithEmailAddress(string emailAddress)
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
    
