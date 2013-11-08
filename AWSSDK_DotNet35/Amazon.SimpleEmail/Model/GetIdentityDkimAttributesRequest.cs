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
    /// Container for the parameters to the GetIdentityDkimAttributes operation.
    /// <para>Returns the current status of Easy DKIM signing for an entity. For domain name identities, this action also returns the DKIM tokens
    /// that are required for Easy DKIM signing, and whether Amazon SES has successfully verified that these tokens have been published.</para>
    /// <para>This action takes a list of identities as input and returns the following information for each:</para>
    /// <ul>
    /// <li>Whether Easy DKIM signing is enabled or disabled.</li>
    /// <li>A set of DKIM tokens that represent the identity. If the identity is an email address, the tokens represent the domain of that
    /// address.</li>
    /// <li>Whether Amazon SES has successfully verified the DKIM tokens published in the domain's DNS. This information is only returned for
    /// domain name identities, not for email addresses.</li>
    /// 
    /// </ul>
    /// <para>This action is throttled at one request per second.</para> <para>For more information about creating DNS records using DKIM tokens,
    /// go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html" >Amazon SES Developer Guide</a> .</para>
    /// </summary>
    public partial class GetIdentityDkimAttributesRequest : AmazonWebServiceRequest
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

        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this.identities.Count > 0;
        }

    }
}
    
