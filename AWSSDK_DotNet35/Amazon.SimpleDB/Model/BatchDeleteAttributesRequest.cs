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
    /// Container for the parameters to the BatchDeleteAttributes operation.
    /// <para> Performs multiple DeleteAttributes operations in a single call, which reduces round trips and latencies. This enables Amazon SimpleDB
    /// to optimize requests, which generally yields better throughput. </para> <para><b>NOTE:</b> If you specify BatchDeleteAttributes without
    /// attributes or values, all the attributes for the item are deleted. BatchDeleteAttributes is an idempotent operation; running it multiple
    /// times on the same item or attribute doesn't result in an error. The BatchDeleteAttributes operation succeeds or fails in its entirety. There
    /// are no partial deletes. You can execute multiple BatchDeleteAttributes operations and other operations in parallel. However, large numbers
    /// of concurrent BatchDeleteAttributes calls can result in Service Unavailable (503) responses. This operation is vulnerable to exceeding the
    /// maximum URL size when making a REST request using the HTTP GET method. This operation does not support conditions using Expected.X.Name,
    /// Expected.X.Value, or Expected.X.Exists. </para> <para> The following limitations are enforced for this operation:
    /// <ul>
    /// <li>1 MB request size</li>
    /// <li>25 item limit per BatchDeleteAttributes operation</li>
    /// 
    /// </ul>
    /// </para>
    /// </summary>
    public partial class BatchDeleteAttributesRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private List<DeletableItem> items = new List<DeletableItem>();

        /// <summary>
        /// The name of the domain in which the attributes are being deleted.
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

        /// <summary>
        /// A list of items on which to perform the operation.
        ///  
        /// </summary>
        public List<DeletableItem> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this.items.Count > 0;
        }

    }
}
    
