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
    /// Container for the parameters to the GetAttributes operation.
    /// <para> Returns all of the attributes associated with the specified item. Optionally, the attributes returned can be limited to one or more
    /// attributes by specifying an attribute name parameter. </para> <para> If the item does not exist on the replica that was accessed for this
    /// operation, an empty set is returned. The system does not return an error as it cannot guarantee the item does not exist on other replicas.
    /// </para> <para><b>NOTE:</b> If GetAttributes is called without being passed any attribute names, all the attributes for the item are
    /// returned. </para>
    /// </summary>
    public partial class GetAttributesRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private string itemName;
        private List<string> attributeNames = new List<string>();
        private bool? consistentRead;

        /// <summary>
        /// The name of the domain in which to perform the operation.
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
        /// The name of the item.
        ///  
        /// </summary>
        public string ItemName
        {
            get { return this.itemName; }
            set { this.itemName = value; }
        }

        // Check to see if ItemName property is set
        internal bool IsSetItemName()
        {
            return this.itemName != null;
        }

        /// <summary>
        /// The names of the attributes.
        ///  
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this.attributeNames; }
            set { this.attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this.attributeNames.Count > 0;
        }

        /// <summary>
        /// Determines whether or not strong consistency should be enforced when data is read from SimpleDB. If <c>true</c>, any data previously written
        /// to SimpleDB will be returned. Otherwise, results will be consistent eventually, and the client may not see data that was written immediately
        /// before your read.
        ///  
        /// </summary>
        public bool ConsistentRead
        {
            get { return this.consistentRead ?? default(bool); }
            set { this.consistentRead = value; }
        }

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this.consistentRead.HasValue;
        }

    }
}
    
