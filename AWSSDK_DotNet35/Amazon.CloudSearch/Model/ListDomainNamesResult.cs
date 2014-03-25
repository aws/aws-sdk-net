/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The result of a <c>ListDomainNames</c> request. Contains a list of the domains owned by an account.</para>
    /// </summary>
    public partial class ListDomainNamesResult : AmazonWebServiceResponse
    {
        
        private Dictionary<string,string> domainNames = new Dictionary<string,string>();


        /// <summary>
        /// The names of the search domains owned by an account.
        ///  
        /// </summary>
        public Dictionary<string,string> DomainNames
        {
            get { return this.domainNames; }
            set { this.domainNames = value; }
        }

        // Check to see if DomainNames property is set
        internal bool IsSetDomainNames()
        {
            return this.domainNames != null;
        }
    }
}
