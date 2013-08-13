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
    /// Container for the parameters to the VerifyDomainDkim operation.
    /// <para>Returns a set of DNS records, or <i>tokens</i> , that must be published in the domain name's DNS to complete the DKIM verification
    /// process. These tokens are DNS <c>CNAME</c> records that point to DKIM public keys hosted by Amazon SES. To complete the DKIM verification
    /// process, these tokens must be published in the domain's DNS. The tokens must remain published in order for Easy DKIM signing to function
    /// correctly.</para> <para>After the tokens are added to the domain's DNS, Amazon SES will be able to DKIM-sign email originating from that
    /// domain. To enable or disable Easy DKIM signing for a domain, use the <c>SetIdentityDkimEnabled</c> action.</para> <para>For more information
    /// about Easy DKIM, go to the Amazon SES Developer Guide.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyDomainDkim"/>
    public class VerifyDomainDkimRequest : AmazonWebServiceRequest
    {
        private string domain;

        /// <summary>
        /// The name of the domain to be verified for Easy DKIM signing.
        ///  
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VerifyDomainDkimRequest WithDomain(string domain)
        {
            this.domain = domain;
            return this;
        }
            

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;       
        }
    }
}
    
