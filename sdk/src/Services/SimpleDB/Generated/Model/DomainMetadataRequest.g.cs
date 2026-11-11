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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the DomainMetadata operation. Returns information
    /// about the domain, including when the domain was created, the number of items and attributes
    /// in the domain, and the size of the attribute names and values.
    /// </summary>
    public partial class DomainMetadataRequest : AmazonSimpleDBRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DomainMetadataRequest() { }

        /// <summary>
        /// Instantiates DomainMetadataRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain for which to display the metadata of.</param>
        public DomainMetadataRequest(string domainName)
        {
            this.DomainName = domainName;
        }

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain for which to display
        /// the metadata of.
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;
    }
}
