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

namespace Amazon.SimpleDB.Model
{
    /// <summary>List Domains Result
    /// </summary>
    public partial class ListDomainsResult : AmazonWebServiceResponse
    {
        
        private List<string> domainNames = new List<string>();
        private string nextToken;

        /// <summary>
        /// A list of domain names that match the expression.
        ///  
        /// </summary>
        public List<string> DomainNames
        {
            get { return this.domainNames; }
            set { this.domainNames = value; }
        }

        // Check to see if DomainNames property is set
        internal bool IsSetDomainNames()
        {
            return this.domainNames.Count > 0;
        }

        /// <summary>
        /// An opaque token indicating that there are more domains than the specified <c>MaxNumberOfDomains</c> still available.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
