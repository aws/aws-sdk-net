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
    /// <para>Represents a list of all the email addresses verified for the current user.</para>
    /// </summary>
    public class ListVerifiedEmailAddressesResult  
    {
        
        private List<string> verifiedEmailAddresses = new List<string>();

        /// <summary>
        /// A list of email addresses that have been verified.
        ///  
        /// </summary>
        public List<string> VerifiedEmailAddresses
        {
            get { return this.verifiedEmailAddresses; }
            set { this.verifiedEmailAddresses = value; }
        }
        /// <summary>
        /// Adds elements to the VerifiedEmailAddresses collection
        /// </summary>
        /// <param name="verifiedEmailAddresses">The values to add to the VerifiedEmailAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVerifiedEmailAddressesResult WithVerifiedEmailAddresses(params string[] verifiedEmailAddresses)
        {
            foreach (string element in verifiedEmailAddresses)
            {
                this.verifiedEmailAddresses.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the VerifiedEmailAddresses collection
        /// </summary>
        /// <param name="verifiedEmailAddresses">The values to add to the VerifiedEmailAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVerifiedEmailAddressesResult WithVerifiedEmailAddresses(IEnumerable<string> verifiedEmailAddresses)
        {
            foreach (string element in verifiedEmailAddresses)
            {
                this.verifiedEmailAddresses.Add(element);
            }

            return this;
        }

        // Check to see if VerifiedEmailAddresses property is set
        internal bool IsSetVerifiedEmailAddresses()
        {
            return this.verifiedEmailAddresses.Count > 0;       
        }
    }
}
