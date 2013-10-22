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

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomain operation.
    /// <para> The <c>CreateDomain</c> operation creates a new domain. The domain name should be unique among the domains associated with the Access
    /// Key ID provided in the request. The <c>CreateDomain</c> operation may take 10 or more seconds to complete. </para> <para><b>NOTE:</b>
    /// CreateDomain is an idempotent operation; running it multiple times using the same domain name will not result in an error response. </para>
    /// <para> The client can create up to 100 domains per account. </para> <para> If the client requires additional domains, go to <a
    /// href="http://aws.amazon.com/contact-us/simpledb-limit-request/" > http://aws.amazon.com/contact-us/simpledb-limit-request/</a> .
    /// </para>
    /// </summary>
    public partial class CreateDomainRequest : AmazonWebServiceRequest
    {
        private string domainName;

        /// <summary>
        /// The name of the domain to create. The name can range between 3 and 255 characters and can contain the following characters: a-z, A-Z, 0-9,
        /// '_', '-', and '.'.
        ///  
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

    }
}
    
