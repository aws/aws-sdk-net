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
    /// Container for the parameters to the DeleteAttributes operation.
    /// <para> Deletes one or more attributes associated with an item. If all attributes of the item are deleted, the item is deleted. </para>
    /// <para><b>NOTE:</b> If DeleteAttributes is called without being passed any attributes or values specified, all the attributes for the item
    /// are deleted. </para> <para> <c>DeleteAttributes</c> is an idempotent operation; running it multiple times on the same item or attribute does
    /// not result in an error response. </para> <para> Because Amazon SimpleDB makes multiple copies of item data and uses an eventual consistency
    /// update model, performing a GetAttributes or Select operation (read) immediately after a <c>DeleteAttributes</c> or PutAttributes operation
    /// (write) might not return updated item data. </para>
    /// </summary>
    public partial class DeleteAttributesRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private string itemName;
        private List<Attribute> attributes = new List<Attribute>();
        private UpdateCondition expected;

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
        /// The name of the item. Similar to rows on a spreadsheet, items represent individual objects that contain one or more value-attribute pairs.
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
        /// A list of Attributes. Similar to columns on a spreadsheet, attributes represent categories of data that can be assigned to items.
        ///  
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes.Count > 0;
        }

        /// <summary>
        /// The update condition which, if specified, determines whether the specified attributes will be deleted or not. The update condition must be
        /// satisfied in order for this request to be processed and the attributes to be deleted.
        ///  
        /// </summary>
        public UpdateCondition Expected
        {
            get { return this.expected; }
            set { this.expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this.expected != null;
        }

    }
}
    
