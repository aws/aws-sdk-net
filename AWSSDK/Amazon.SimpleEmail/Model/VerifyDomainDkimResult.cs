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
    /// <para>Represents the DNS records that must be published in the domain name's DNS to complete DKIM setup.</para>
    /// </summary>
    public class VerifyDomainDkimResult  
    {
        
        private List<string> dkimTokens = new List<string>();

        /// <summary>
        /// A set of DNS records (tokens) that must be published in the domain name's DNS for DKIM verification to complete, and which must remain
        /// published in order for DKIM signing to succeed. The tokens are CNAME DNS records pointing to DKIM public keys hosted by Amazon SES.
        ///  
        /// </summary>
        public List<string> DkimTokens
        {
            get { return this.dkimTokens; }
            set { this.dkimTokens = value; }
        }
        /// <summary>
        /// Adds elements to the DkimTokens collection
        /// </summary>
        /// <param name="dkimTokens">The values to add to the DkimTokens collection </param>
        /// <returns>this instance</returns>
        public VerifyDomainDkimResult WithDkimTokens(params string[] dkimTokens)
        {
            foreach (string element in dkimTokens)
            {
                this.dkimTokens.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the DkimTokens collection
        /// </summary>
        /// <param name="dkimTokens">The values to add to the DkimTokens collection </param>
        /// <returns>this instance</returns>
        public VerifyDomainDkimResult WithDkimTokens(IEnumerable<string> dkimTokens)
        {
            foreach (string element in dkimTokens)
            {
                this.dkimTokens.Add(element);
            }

            return this;
        }

        // Check to see if DkimTokens property is set
        internal bool IsSetDkimTokens()
        {
            return this.dkimTokens.Count > 0;       
        }
    }
}
