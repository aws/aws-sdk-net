/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the DomainMetadata operation.
    /// Returns information about the domain, including when the domain was created, the
    /// number of items and attributes in the domain, and the size of the attribute names
    /// and values.
    /// </summary>
    public partial class DomainMetadataRequest : AmazonSimpleDBRequest
    {
        private string _domainName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DomainMetadataRequest() { }

        /// <summary>
        /// Instantiates DomainMetadataRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain for which to display the metadata of.</param>
        public DomainMetadataRequest(string domainName)
        {
            _domainName = domainName;
        }

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain for which to display
        /// the metadata of.
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

    }
}