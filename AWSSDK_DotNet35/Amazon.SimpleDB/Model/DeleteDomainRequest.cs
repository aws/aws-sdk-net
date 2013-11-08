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
    /// Container for the parameters to the DeleteDomain operation.
    /// <para> The <c>DeleteDomain</c> operation deletes a domain. Any items (and their attributes) in the domain are deleted as well. The
    /// <c>DeleteDomain</c> operation might take 10 or more seconds to complete. </para> <para><b>NOTE:</b> Running DeleteDomain on a domain that
    /// does not exist or running the function multiple times using the same domain name will not result in an error response. </para>
    /// </summary>
    public partial class DeleteDomainRequest : AmazonWebServiceRequest
    {
        private string domainName;

        /// <summary>
        /// The name of the domain to delete.
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
    
