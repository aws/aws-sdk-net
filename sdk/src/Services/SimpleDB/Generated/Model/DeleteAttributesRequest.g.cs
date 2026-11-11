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
    /// Container for the parameters to the DeleteAttributes operation. Deletes one or more
    /// attributes associated with an item. If all attributes of the item are deleted, the
    /// item is deleted. <para> <c>DeleteAttributes</c> is an idempotent operation; running
    /// it multiple times on the same item or attribute does not result in an error response.
    /// </para> <para> Because Amazon SimpleDB makes multiple copies of item data and uses
    /// an eventual consistency update model, performing a <a>GetAttributes</a> or <a>Select</a>
    /// operation (read) immediately after a <c>DeleteAttributes</c> or <a>PutAttributes</a>
    /// operation (write) might not return updated item data. </para>
    /// </summary>
    public partial class DeleteAttributesRequest : AmazonSimpleDBRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DeleteAttributesRequest() { }

        /// <summary>
        /// Instantiates DeleteAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <param name="itemName">The name of the item. Similar to rows on a spreadsheet, items represent individual objects that contain one or more value-attribute pairs.</param>
        public DeleteAttributesRequest(string domainName, string itemName)
        {
            this.DomainName = domainName;
            this.ItemName = itemName;
        }

        /// <summary>
        /// Instantiates DeleteAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <param name="itemName">The name of the item. Similar to rows on a spreadsheet, items represent individual objects that contain one or more value-attribute pairs.</param>
        /// <param name="attributes">A list of Attributes. Similar to columns on a spreadsheet, attributes represent categories of data that can be assigned to items.</param>
        public DeleteAttributesRequest(string domainName, string itemName, List<Attribute> attributes)
        {
            this.DomainName = domainName;
            this.ItemName = itemName;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Instantiates DeleteAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <param name="itemName">The name of the item. Similar to rows on a spreadsheet, items represent individual objects that contain one or more value-attribute pairs.</param>
        /// <param name="attributes">A list of Attributes. Similar to columns on a spreadsheet, attributes represent categories of data that can be assigned to items.</param>
        /// <param name="expected">The update condition which, if specified, determines whether the specified attributes will be deleted or not. The update condition must be satisfied in order for this request to be processed and the attributes to be deleted.</param>
        public DeleteAttributesRequest(string domainName, string itemName, List<Attribute> attributes, UpdateCondition expected)
        {
            this.DomainName = domainName;
            this.ItemName = itemName;
            this.Attributes = attributes;
            this.Expected = expected;
        }

        /// <summary>
        /// Gets and sets the property Attributes. A list of Attributes. Similar to columns on
        /// a spreadsheet, attributes represent categories of data that can be assigned to items.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain in which to perform
        /// the operation.
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Expected. The update condition which, if specified, determines
        /// whether the specified attributes will be deleted or not. The update condition must
        /// be satisfied in order for this request to be processed and the attributes to be deleted.
        /// </summary>
        public UpdateCondition Expected { get; set; }

        /// <summary>
        /// Checks to see if the Expected property is set.
        /// </summary>
        internal bool IsSetExpected() => this.Expected != null;

        /// <summary>
        /// Gets and sets the property ItemName. The name of the item. Similar to rows on a spreadsheet,
        /// items represent individual objects that contain one or more value-attribute pairs.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ItemName { get; set; }

        /// <summary>
        /// Checks to see if the ItemName property is set.
        /// </summary>
        internal bool IsSetItemName() => this.ItemName != null;
    }
}
