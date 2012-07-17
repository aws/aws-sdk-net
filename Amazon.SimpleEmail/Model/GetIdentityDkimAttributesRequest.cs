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
    /// Container for the parameters to the GetIdentityDkimAttributes operation.
    /// <para>Returns the DNS records, or <i>tokens</i> , that must be present in order for Easy DKIM to sign outgoing email messages.</para>
    /// <para>This action takes a list of verified identities as input. It then returns the following information for each identity:</para>
    /// <ul>
    /// <li>Whether Easy DKIM signing is enabled or disabled.</li>
    /// <li>The set of tokens that are required for Easy DKIM signing. These tokens must be published in the domain name's DNS records in order
    /// for DKIM verification to complete, and must remain published in order for Easy DKIM signing to operate correctly. (This information is only
    /// returned for domain name identities, not for email addresses.)</li>
    /// <li>Whether Amazon SES has successfully verified the DKIM tokens published in the domain name's DNS. (This information is only returned for
    /// domain name identities, not for email addresses.)</li>
    /// 
    /// </ul>
    /// <para>For more information about Easy DKIM signing, go to the Amazon SES Developer Guide.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetIdentityDkimAttributes"/>
    public class GetIdentityDkimAttributesRequest : AmazonWebServiceRequest
    {
        private List<string> identities = new List<string>();

        /// <summary>
        /// A list of one or more verified identities - email addresses, domains, or both.
        ///  
        /// </summary>
        public List<string> Identities
        {
            get { return this.identities; }
            set { this.identities = value; }
        }
        /// <summary>
        /// Adds elements to the Identities collection
        /// </summary>
        /// <param name="identities">The values to add to the Identities collection </param>
        /// <returns>this instance</returns>
        public GetIdentityDkimAttributesRequest WithIdentities(params string[] identities)
        {
            foreach (string element in identities)
            {
                this.identities.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Identities collection
        /// </summary>
        /// <param name="identities">The values to add to the Identities collection </param>
        /// <returns>this instance</returns>
        public GetIdentityDkimAttributesRequest WithIdentities(IEnumerable<string> identities)
        {
            foreach (string element in identities)
            {
                this.identities.Add(element);
            }

            return this;
        }

        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this.identities.Count > 0;       
        }
    }
}
    
