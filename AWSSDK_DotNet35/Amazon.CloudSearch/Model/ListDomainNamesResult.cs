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

/*
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The result of a <code>ListDomainNames</code> request. Contains a list of the domains
    /// owned by an account.
    /// </summary>
    public partial class ListDomainNamesResult : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _domainNames = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DomainNames. 
        /// <para>
        /// The names of the search domains owned by an account.
        /// </para>
        /// </summary>
        public Dictionary<string, string> DomainNames
        {
            get { return this._domainNames; }
            set { this._domainNames = value; }
        }

        // Check to see if DomainNames property is set
        internal bool IsSetDomainNames()
        {
            return this._domainNames != null && this._domainNames.Count > 0; 
        }

    }
}