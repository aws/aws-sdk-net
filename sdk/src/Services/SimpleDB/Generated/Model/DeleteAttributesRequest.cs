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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAttributes operation.
    /// Deletes one or more attributes associated with an item. If all attributes of the
    /// item are deleted, the item is deleted. 
    /// 
    ///  
    /// <para>
    ///  <c>DeleteAttributes</c> is an idempotent operation; running it multiple times on
    /// the same item or attribute does not result in an error response. 
    /// </para>
    ///  
    /// <para>
    ///  Because Amazon SimpleDB makes multiple copies of item data and uses an eventual consistency
    /// update model, performing a <a>GetAttributes</a> or <a>Select</a> operation (read)
    /// immediately after a <c>DeleteAttributes</c> or <a>PutAttributes</a> operation (write)
    /// might not return updated item data. 
    /// </para>
    /// </summary>
    public partial class DeleteAttributesRequest : AmazonSimpleDBRequest
    {
        private List<Attribute> _attributes = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;
        private string _domainName;
        private UpdateCondition _expected;
        private string _itemName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteAttributesRequest() { }

        /// <summary>
        /// Instantiates DeleteAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <param name="itemName">The name of the item. Similar to rows on a spreadsheet, items represent individual objects that contain one or more value-attribute pairs.</param>
        public DeleteAttributesRequest(string domainName, string itemName)
        {
            _domainName = domainName;
            _itemName = itemName;
        }

        /// <summary>
        /// Instantiates DeleteAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="domainName">The name of the domain in which to perform the operation.</param>
        /// <param name="itemName">The name of the item. Similar to rows on a spreadsheet, items represent individual objects that contain one or more value-attribute pairs.</param>
        /// <param name="attributes">A list of Attributes. Similar to columns on a spreadsheet, attributes represent categories of data that can be assigned to items.</param>
        public DeleteAttributesRequest(string domainName, string itemName, List<Attribute> attributes)
        {
            _domainName = domainName;
            _itemName = itemName;
            _attributes = attributes;
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
            _domainName = domainName;
            _itemName = itemName;
            _attributes = attributes;
            _expected = expected;
        }

        /// <summary>
        /// Gets and sets the property Attributes. A list of Attributes. Similar to columns on
        /// a spreadsheet, attributes represent categories of data that can be assigned to items.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain in which to perform
        /// the operation.
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

        /// <summary>
        /// Gets and sets the property Expected. The update condition which, if specified, determines
        /// whether the specified attributes will be deleted or not. The update condition must
        /// be satisfied in order for this request to be processed and the attributes to be deleted.
        /// </summary>
        public UpdateCondition Expected
        {
            get { return this._expected; }
            set { this._expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this._expected != null;
        }

        /// <summary>
        /// Gets and sets the property ItemName. The name of the item. Similar to rows on a spreadsheet,
        /// items represent individual objects that contain one or more value-attribute pairs.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
        }

        // Check to see if ItemName property is set
        internal bool IsSetItemName()
        {
            return this._itemName != null;
        }

    }
}