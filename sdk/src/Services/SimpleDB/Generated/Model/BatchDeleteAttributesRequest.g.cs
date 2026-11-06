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
    /// Container for the parameters to the BatchDeleteAttributes operation. Performs multiple
    /// DeleteAttributes operations in a single call, which reduces round trips and latencies.
    /// This enables Amazon SimpleDB to optimize requests, which generally yields better throughput.
    /// <para> The following limitations are enforced for this operation: <ul> <li>1 MB request
    /// size</li> <li>25 item limit per BatchDeleteAttributes operation</li> </ul> </para>
    /// </summary>
    public partial class BatchDeleteAttributesRequest : AmazonSimpleDBRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public BatchDeleteAttributesRequest() { }

        /// <summary>
        /// Instantiates BatchDeleteAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which the attributes are being deleted.</param>
        /// <param name="items">A list of items on which to perform the operation.</param>
        public BatchDeleteAttributesRequest(string domainName, List<DeletableItem> items)
        {
            this.DomainName = domainName;
            this.Items = items;
        }

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain in which the attributes
        /// are being deleted.
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Items. A list of items on which to perform the operation.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DeletableItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<DeletableItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
